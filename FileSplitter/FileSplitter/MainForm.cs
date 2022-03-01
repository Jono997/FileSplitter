using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace FileSplitter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            tabControl1.SelectTab(1);
            fragmentSizeUnitComboBox.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (splitOpenFileDialog.ShowDialog() == DialogResult.OK)
                splitFileTextBox.Text = splitOpenFileDialog.FileName;
        }

        private void splitFileTextBox_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(splitFileTextBox.Text))
            {
                splitFileTextBox.ForeColor = Color.Black;
                splitButton.Enabled = true;
            }
            else
            {
                splitFileTextBox.ForeColor = Color.Red;
                splitButton.Enabled = false;
            }
        }

        private void splitFileTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void splitFileTextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                splitFileTextBox.Text = files[0];
            }
        }

        private void splitButton_Click(object sender, EventArgs e)
        {
            byte[] file = File.ReadAllBytes(splitFileTextBox.Text);
            long fragment_size = (int)fragmentSizeNumericUpDown.Value;
            for (int i = 3; i > fragmentSizeUnitComboBox.SelectedIndex; i--)
                fragment_size *= 1024;
            Fragment[] series = Fragment.MakeSeries(file, fragment_size);

            for (int i = 0; i < series.Length; i++)
                File.WriteAllBytes($"{splitFileTextBox.Text}_{i}.sff", series[i].Serialise());
            MessageBox.Show("File split complete!");
        }

        private void ScanFile(string path)
        {
            Regex regex = new Regex(@"(.+?)\d+(.*\.sff)$");
            string filename = path.Split('\\').Last();
            Match m = regex.Match(filename);
            if (m.Success)
            {
                foreach (string file in Directory.GetFiles(Path.GetDirectoryName(path)))
                    if (file.Contains(m.Groups[1].Value) && file.EndsWith(m.Groups[2].Value))
                        fragmentListBox.Items.Add(file);
            }
            else
            {
                fragmentListBox.Items.Add(path);
            }
            joinInstructionLabel.Visible = fragmentListBox.Items.Count == 0;
            mergeButton.Enabled = !joinInstructionLabel.Visible && File.Exists(mergeFilePathTextBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mergeOpenFileDialog.ShowDialog() == DialogResult.OK)
                ScanFile(mergeOpenFileDialog.FileName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fragmentListBox.Items.Clear();
            mergeButton.Enabled = false;
            joinInstructionLabel.Visible = true;
        }

        private void fragmentListBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void fragmentListBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                bool first_file = true;
                foreach (string file in files)
                {
                    int starting_count = fragmentListBox.Items.Count;
                    ScanFile(file);
                    if (first_file)
                    {
                        if (starting_count + 1 < fragmentListBox.Items.Count)
                            return;
                        else
                            first_file = false;
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                mergeFilePathTextBox.Text = saveFileDialog1.FileName;
        }

        private void mergeFilePathTextBox_TextChanged(object sender, EventArgs e)
        {
            mergeButton.Enabled = mergeFilePathTextBox.Text.Length > 0 && fragmentListBox.Items.Count > 0;
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            Fragment[] series = new Fragment[fragmentListBox.Items.Count];
            for (int i = 0; i < series.Length; i++)
            {
                byte[] fragment_raw = File.ReadAllBytes((string)fragmentListBox.Items[i]);
                Fragment f = Fragment.Deserialise(fragment_raw);
                series[i] = f;
            }
            byte[] file = Fragment.GetFileFromSeries(series);
            File.WriteAllBytes(mergeFilePathTextBox.Text, file);
            MessageBox.Show("File merge complete");
        }
    }
}
