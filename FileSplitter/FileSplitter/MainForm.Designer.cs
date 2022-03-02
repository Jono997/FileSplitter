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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fragmentSizeUnitComboBox = new System.Windows.Forms.ComboBox();
            this.fragmentSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.splitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitFileTextBox = new System.Windows.Forms.TextBox();
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
            this.label3 = new System.Windows.Forms.Label();
            this.splitFilePathTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.splitFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fragmentSizeNumericUpDown)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.splitFilePathTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.fragmentSizeUnitComboBox);
            this.tabPage1.Controls.Add(this.fragmentSizeNumericUpDown);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.splitButton);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.splitFileTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(437, 216);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Split";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.fragmentSizeUnitComboBox.Location = new System.Drawing.Point(385, 34);
            this.fragmentSizeUnitComboBox.Name = "fragmentSizeUnitComboBox";
            this.fragmentSizeUnitComboBox.Size = new System.Drawing.Size(44, 21);
            this.fragmentSizeUnitComboBox.TabIndex = 6;
            // 
            // fragmentSizeNumericUpDown
            // 
            this.fragmentSizeNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fragmentSizeNumericUpDown.Location = new System.Drawing.Point(89, 34);
            this.fragmentSizeNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.fragmentSizeNumericUpDown.Name = "fragmentSizeNumericUpDown";
            this.fragmentSizeNumericUpDown.Size = new System.Drawing.Size(290, 20);
            this.fragmentSizeNumericUpDown.TabIndex = 5;
            this.fragmentSizeNumericUpDown.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fragment size:";
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
            // splitFileTextBox
            // 
            this.splitFileTextBox.AllowDrop = true;
            this.splitFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitFileTextBox.Location = new System.Drawing.Point(40, 8);
            this.splitFileTextBox.Name = "splitFileTextBox";
            this.splitFileTextBox.Size = new System.Drawing.Size(358, 20);
            this.splitFileTextBox.TabIndex = 1;
            this.splitFileTextBox.TextChanged += new System.EventHandler(this.splitFileTextBox_TextChanged);
            this.splitFileTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.splitFileTextBox_DragDrop);
            this.splitFileTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.splitFileTextBox_DragEnter);
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
            // splitFilePathTextBox
            // 
            this.splitFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitFilePathTextBox.Location = new System.Drawing.Point(89, 140);
            this.splitFilePathTextBox.Name = "splitFilePathTextBox";
            this.splitFilePathTextBox.Size = new System.Drawing.Size(309, 20);
            this.splitFilePathTextBox.TabIndex = 9;
            this.splitFilePathTextBox.TextChanged += new System.EventHandler(this.splitFileTextBox_TextChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.fragmentSizeNumericUpDown)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox splitFileTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog splitOpenFileDialog;
        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.ComboBox fragmentSizeUnitComboBox;
        private System.Windows.Forms.NumericUpDown fragmentSizeNumericUpDown;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.TextBox splitFilePathTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog splitFolderBrowserDialog;
    }
}

