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
using Microsoft.Win32;

namespace FileSplitter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            tabControl1.SelectTab(1);
            fragmentSizeUnitComboBox.SelectedIndex = 1;
            if ((int)Registry.GetValue(Program.REGISTRY_KEY, Program.REGISTRY_SHOW_ASSOCIATION_DIALOG, 1) == 1)
            {
                switch (MessageBox.Show("Associate .sff files with FileSplitter? Doing so will allow you to merge fragment series by double clicking on them", "Associate .sff files?", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        System.Diagnostics.Process proc = new System.Diagnostics.Process()
                        {
                            StartInfo = new System.Diagnostics.ProcessStartInfo("AssociateSFF.exe")
                        };
                        proc.Start();
                        proc.WaitForExit();
                        if ((int)Registry.GetValue(Program.REGISTRY_KEY, AssociateSFF.Program.REGISTRY_ASSOCIATION_SUCCESS, 0) == 1)
                        {
                            Registry.SetValue(Program.REGISTRY_KEY, AssociateSFF.Program.REGISTRY_ASSOCIATION_SUCCESS, 0);
                            Registry.SetValue(Program.REGISTRY_KEY, Program.REGISTRY_SHOW_ASSOCIATION_DIALOG, 0);
                        }
                        else
                            MessageBox.Show("Something went wrong in the process. Please try again later.", "Associate SFF error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case DialogResult.No:
                        Registry.SetValue(Program.REGISTRY_KEY, Program.REGISTRY_SHOW_ASSOCIATION_DIALOG, 0);
                        break;
                }
            }
        }

        public MainForm(string[] series) : this()
        {
            fragmentListBox.Items.AddRange(series);
            joinInstructionLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (splitOpenFileDialog.ShowDialog() == DialogResult.OK)
                splitInputFileTextBox.Text = splitOpenFileDialog.FileName;
        }

        private void splitFileTextBox_TextChanged(object sender, EventArgs e)
        {
            splitButton.Enabled = true;

            if (File.Exists(splitInputFileTextBox.Text))
            {
                splitInputFileTextBox.ForeColor = Color.Black;
                if (splitOutputPathTextBox.Text == "")
                    splitOutputPathTextBox.Text = $"{splitInputFileTextBox.Text}_split";
            }
            else
            {
                splitInputFileTextBox.ForeColor = Color.Red;
                splitButton.Enabled = false;
            }

            if (File.Exists(splitOutputPathTextBox.Text))
            {
                splitOutputPathTextBox.ForeColor = Color.Red;
                splitButton.Enabled = false;
            }
            else
                splitOutputPathTextBox.ForeColor = Color.Black;
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
                splitInputFileTextBox.Text = files[0];
            }
        }

        private void splitButton_Click(object sender, EventArgs e)
        {
            byte[] file = File.ReadAllBytes(splitInputFileTextBox.Text);

            Fragment[] series;
            if (splitBySizeRadioButton.Checked)
            {
                long fragment_size = (int)fragmentQuantityNumericUpDown.Value;
                for (int i = 3; i > fragmentSizeUnitComboBox.SelectedIndex; i--)
                    fragment_size *= 1024;
                series = Fragment.MakeSeries(file, fragment_size);
            }
            else
            {
                long fl_remainder = file.Length % (int)fragmentQuantityNumericUpDown.Value;
                long fragment_size = (file.Length - fl_remainder) / (int)fragmentQuantityNumericUpDown.Value + (fl_remainder > 0 ? 1 : 0) + Fragment.HEADER_SIZE;
                series = Fragment.MakeSeries(file, fragment_size);
            }

            Directory.CreateDirectory(splitOutputPathTextBox.Text);
            string fragment_base_filename = Path.GetFileName(splitInputFileTextBox.Text);
            for (int i = 0; i < series.Length; i++)
                File.WriteAllBytes($"{splitOutputPathTextBox.Text}\\{fragment_base_filename}_{i}.sff", series[i].Serialise());
            MessageBox.Show("File split complete!");
        }

        private void ScanFile(string path)
        {
            fragmentListBox.Items.AddRange(Program.SearchForFragments(path));
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
            if (mergeSaveFileDialog.ShowDialog() == DialogResult.OK)
                mergeFilePathTextBox.Text = mergeSaveFileDialog.FileName;
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (splitFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string folder = splitFolderBrowserDialog.SelectedPath;
                if (Directory.GetFileSystemEntries(folder).Length == 0 || MessageBox.Show("It's reccommended you save a split file to an empty folder, but this folder has contents in it.\nSave to here anyway?", "Not empty folder", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    splitOutputPathTextBox.Text = folder;
            }
        }

        private void splitByCountRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (splitByCountRadioButton.Checked)
            {
                fragmentQuantityLabel.Text = "Fragment amount:";
                fragmentQuantityNumericUpDown.Width += fragmentQuantityNumericUpDown.Margin.Right + fragmentSizeUnitComboBox.Margin.Left + fragmentSizeUnitComboBox.Width;
                fragmentSizeUnitComboBox.Visible = false;
            }
            else
            {
                fragmentQuantityLabel.Text = "Fragment size:";
                fragmentQuantityNumericUpDown.Width -= fragmentQuantityNumericUpDown.Margin.Right + fragmentSizeUnitComboBox.Margin.Left + fragmentSizeUnitComboBox.Width;
                fragmentSizeUnitComboBox.Visible = true;
            }
        }
    }
}
