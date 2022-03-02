namespace FileSplitter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.splitOutputPathTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fragmentSizeUnitComboBox = new System.Windows.Forms.ComboBox();
            this.fragmentQuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fragmentQuantityLabel = new System.Windows.Forms.Label();
            this.splitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitInputFileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.joinInstructionLabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.mergeFilePathTextBox = new System.Windows.Forms.TextBox();
            this.mergeButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fragmentListBox = new System.Windows.Forms.ListBox();
            this.splitOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mergeOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mergeSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.splitFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitBySizeRadioButton = new System.Windows.Forms.RadioButton();
            this.splitByCountRadioButton = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fragmentQuantityNumericUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 242);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.splitOutputPathTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.fragmentSizeUnitComboBox);
            this.tabPage1.Controls.Add(this.fragmentQuantityNumericUpDown);
            this.tabPage1.Controls.Add(this.fragmentQuantityLabel);
            this.tabPage1.Controls.Add(this.splitButton);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.splitInputFileTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(437, 216);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Split";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(404, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // splitOutputPathTextBox
            // 
            this.splitOutputPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitOutputPathTextBox.Location = new System.Drawing.Point(89, 140);
            this.splitOutputPathTextBox.Name = "splitOutputPathTextBox";
            this.splitOutputPathTextBox.Size = new System.Drawing.Size(309, 20);
            this.splitOutputPathTextBox.TabIndex = 9;
            this.splitOutputPathTextBox.TextChanged += new System.EventHandler(this.splitFileTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Save location:";
            // 
            // fragmentSizeUnitComboBox
            // 
            this.fragmentSizeUnitComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fragmentSizeUnitComboBox.FormattingEnabled = true;
            this.fragmentSizeUnitComboBox.Items.AddRange(new object[] {
            "GB",
            "MB",
            "KB",
            "B"});
            this.fragmentSizeUnitComboBox.Location = new System.Drawing.Point(385, 87);
            this.fragmentSizeUnitComboBox.Name = "fragmentSizeUnitComboBox";
            this.fragmentSizeUnitComboBox.Size = new System.Drawing.Size(44, 21);
            this.fragmentSizeUnitComboBox.TabIndex = 6;
            // 
            // fragmentQuantityNumericUpDown
            // 
            this.fragmentQuantityNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fragmentQuantityNumericUpDown.Location = new System.Drawing.Point(106, 87);
            this.fragmentQuantityNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.fragmentQuantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fragmentQuantityNumericUpDown.Name = "fragmentQuantityNumericUpDown";
            this.fragmentQuantityNumericUpDown.Size = new System.Drawing.Size(273, 20);
            this.fragmentQuantityNumericUpDown.TabIndex = 5;
            this.fragmentQuantityNumericUpDown.ThousandsSeparator = true;
            this.fragmentQuantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fragmentQuantityLabel
            // 
            this.fragmentQuantityLabel.AutoSize = true;
            this.fragmentQuantityLabel.Location = new System.Drawing.Point(8, 89);
            this.fragmentQuantityLabel.Name = "fragmentQuantityLabel";
            this.fragmentQuantityLabel.Size = new System.Drawing.Size(75, 13);
            this.fragmentQuantityLabel.TabIndex = 4;
            this.fragmentQuantityLabel.Text = "Fragment size:";
            // 
            // splitButton
            // 
            this.splitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitButton.Enabled = false;
            this.splitButton.Location = new System.Drawing.Point(11, 166);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(418, 42);
            this.splitButton.TabIndex = 3;
            this.splitButton.Text = "Split file";
            this.splitButton.UseVisualStyleBackColor = true;
            this.splitButton.Click += new System.EventHandler(this.splitButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(404, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitInputFileTextBox
            // 
            this.splitInputFileTextBox.AllowDrop = true;
            this.splitInputFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitInputFileTextBox.Location = new System.Drawing.Point(40, 8);
            this.splitInputFileTextBox.Name = "splitInputFileTextBox";
            this.splitInputFileTextBox.Size = new System.Drawing.Size(358, 20);
            this.splitInputFileTextBox.TabIndex = 1;
            this.splitInputFileTextBox.TextChanged += new System.EventHandler(this.splitFileTextBox_TextChanged);
            this.splitInputFileTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.splitFileTextBox_DragDrop);
            this.splitInputFileTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.splitFileTextBox_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.joinInstructionLabel);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.mergeFilePathTextBox);
            this.tabPage2.Controls.Add(this.mergeButton);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.fragmentListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(437, 216);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Join";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // joinInstructionLabel
            // 
            this.joinInstructionLabel.AutoSize = true;
            this.joinInstructionLabel.Location = new System.Drawing.Point(9, 9);
            this.joinInstructionLabel.Name = "joinInstructionLabel";
            this.joinInstructionLabel.Size = new System.Drawing.Size(195, 13);
            this.joinInstructionLabel.TabIndex = 6;
            this.joinInstructionLabel.Text = "Drag one or all of the file fragments here";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(354, 35);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(403, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // mergeFilePathTextBox
            // 
            this.mergeFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mergeFilePathTextBox.Location = new System.Drawing.Point(6, 188);
            this.mergeFilePathTextBox.Name = "mergeFilePathTextBox";
            this.mergeFilePathTextBox.Size = new System.Drawing.Size(391, 20);
            this.mergeFilePathTextBox.TabIndex = 3;
            this.mergeFilePathTextBox.TextChanged += new System.EventHandler(this.mergeFilePathTextBox_TextChanged);
            // 
            // mergeButton
            // 
            this.mergeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mergeButton.Enabled = false;
            this.mergeButton.Location = new System.Drawing.Point(354, 64);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(75, 23);
            this.mergeButton.TabIndex = 2;
            this.mergeButton.Text = "Merge";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(354, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fragmentListBox
            // 
            this.fragmentListBox.AllowDrop = true;
            this.fragmentListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fragmentListBox.FormattingEnabled = true;
            this.fragmentListBox.Location = new System.Drawing.Point(6, 6);
            this.fragmentListBox.Name = "fragmentListBox";
            this.fragmentListBox.Size = new System.Drawing.Size(342, 173);
            this.fragmentListBox.TabIndex = 0;
            this.fragmentListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.fragmentListBox_DragDrop);
            this.fragmentListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.fragmentListBox_DragEnter);
            // 
            // mergeOpenFileDialog
            // 
            this.mergeOpenFileDialog.DefaultExt = "sff";
            this.mergeOpenFileDialog.Filter = "Split file fragments|*_*.sff|All files|*.*";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.splitByCountRadioButton);
            this.groupBox1.Controls.Add(this.splitBySizeRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(6, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 47);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // splitBySizeRadioButton
            // 
            this.splitBySizeRadioButton.AutoSize = true;
            this.splitBySizeRadioButton.Checked = true;
            this.splitBySizeRadioButton.Location = new System.Drawing.Point(5, 19);
            this.splitBySizeRadioButton.Name = "splitBySizeRadioButton";
            this.splitBySizeRadioButton.Size = new System.Drawing.Size(106, 17);
            this.splitBySizeRadioButton.TabIndex = 0;
            this.splitBySizeRadioButton.TabStop = true;
            this.splitBySizeRadioButton.Text = "Set fragment size";
            this.splitBySizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // splitByCountRadioButton
            // 
            this.splitByCountRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.splitByCountRadioButton.AutoSize = true;
            this.splitByCountRadioButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.splitByCountRadioButton.Location = new System.Drawing.Point(294, 19);
            this.splitByCountRadioButton.Name = "splitByCountRadioButton";
            this.splitByCountRadioButton.Size = new System.Drawing.Size(123, 17);
            this.splitByCountRadioButton.TabIndex = 1;
            this.splitByCountRadioButton.Text = "Set fragment amount";
            this.splitByCountRadioButton.UseVisualStyleBackColor = true;
            this.splitByCountRadioButton.CheckedChanged += new System.EventHandler(this.splitByCountRadioButton_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 242);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "File splitter";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fragmentQuantityNumericUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox splitInputFileTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog splitOpenFileDialog;
        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.ComboBox fragmentSizeUnitComboBox;
        private System.Windows.Forms.NumericUpDown fragmentQuantityNumericUpDown;
        private System.Windows.Forms.Label fragmentQuantityLabel;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox fragmentListBox;
        private System.Windows.Forms.OpenFileDialog mergeOpenFileDialog;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox mergeFilePathTextBox;
        private System.Windows.Forms.SaveFileDialog mergeSaveFileDialog;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label joinInstructionLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox splitOutputPathTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog splitFolderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton splitByCountRadioButton;
        private System.Windows.Forms.RadioButton splitBySizeRadioButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

