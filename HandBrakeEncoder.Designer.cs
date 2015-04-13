namespace HandBrake_Encoder
{
    partial class handBrakeBatchEncoder
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
			this.encodeButton = new System.Windows.Forms.Button();
			this.encodeLocationButton = new System.Windows.Forms.Button();
			this.folderFileListBox = new System.Windows.Forms.ListBox();
			this.encodeLocationTextBox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.preserveTimeStampCheckBox = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.fileDownButton = new System.Windows.Forms.Button();
			this.fileUpButton = new System.Windows.Forms.Button();
			this.fileRemoveButton = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.encodeQueryLabel = new System.Windows.Forms.Label();
			this.handBrakeCMDTextBox = new System.Windows.Forms.TextBox();
			this.handBrakeCLIButton = new System.Windows.Forms.Button();
			this.handBrakeCLILocationTextBox = new System.Windows.Forms.TextBox();
			this.encodeFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.handBrakeCLIOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.saveNextToOriginalsCheckBox = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// encodeButton
			// 
			this.encodeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.encodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.encodeButton.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.encodeButton.Location = new System.Drawing.Point(252, 132);
			this.encodeButton.Name = "encodeButton";
			this.encodeButton.Size = new System.Drawing.Size(143, 23);
			this.encodeButton.TabIndex = 1;
			this.encodeButton.Text = "Start Batch Encode";
			this.encodeButton.UseVisualStyleBackColor = false;
			this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
			// 
			// encodeLocationButton
			// 
			this.encodeLocationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.encodeLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.encodeLocationButton.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.encodeLocationButton.Location = new System.Drawing.Point(252, 200);
			this.encodeLocationButton.Name = "encodeLocationButton";
			this.encodeLocationButton.Size = new System.Drawing.Size(143, 23);
			this.encodeLocationButton.TabIndex = 2;
			this.encodeLocationButton.Text = "Select encode location";
			this.encodeLocationButton.UseVisualStyleBackColor = false;
			this.encodeLocationButton.Click += new System.EventHandler(this.encodeLocationButton_Click);
			// 
			// folderFileListBox
			// 
			this.folderFileListBox.AllowDrop = true;
			this.folderFileListBox.BackColor = System.Drawing.Color.Gray;
			this.folderFileListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.folderFileListBox.FormattingEnabled = true;
			this.folderFileListBox.Location = new System.Drawing.Point(6, 37);
			this.folderFileListBox.Name = "folderFileListBox";
			this.folderFileListBox.Size = new System.Drawing.Size(240, 130);
			this.folderFileListBox.TabIndex = 4;
			this.folderFileListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.folderFileListBox_DragDrop);
			this.folderFileListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.folderFileListBox_DragEnter);
			// 
			// encodeLocationTextBox
			// 
			this.encodeLocationTextBox.BackColor = System.Drawing.Color.Gray;
			this.encodeLocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.encodeLocationTextBox.Location = new System.Drawing.Point(6, 202);
			this.encodeLocationTextBox.Name = "encodeLocationTextBox";
			this.encodeLocationTextBox.Size = new System.Drawing.Size(240, 13);
			this.encodeLocationTextBox.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.saveNextToOriginalsCheckBox);
			this.groupBox1.Controls.Add(this.preserveTimeStampCheckBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.fileDownButton);
			this.groupBox1.Controls.Add(this.fileUpButton);
			this.groupBox1.Controls.Add(this.fileRemoveButton);
			this.groupBox1.Controls.Add(this.folderFileListBox);
			this.groupBox1.Controls.Add(this.encodeLocationTextBox);
			this.groupBox1.Controls.Add(this.encodeLocationButton);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(450, 236);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Files";
			// 
			// preserveTimeStampCheckBox
			// 
			this.preserveTimeStampCheckBox.AutoSize = true;
			this.preserveTimeStampCheckBox.Checked = true;
			this.preserveTimeStampCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.preserveTimeStampCheckBox.Location = new System.Drawing.Point(252, 137);
			this.preserveTimeStampCheckBox.Name = "preserveTimeStampCheckBox";
			this.preserveTimeStampCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.preserveTimeStampCheckBox.Size = new System.Drawing.Size(131, 17);
			this.preserveTimeStampCheckBox.TabIndex = 13;
			this.preserveTimeStampCheckBox.Text = "Preserve creation time";
			this.preserveTimeStampCheckBox.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Drag in files to be encoded";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 178);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Encode Location (no trailing \\)";
			// 
			// fileDownButton
			// 
			this.fileDownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.fileDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fileDownButton.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.fileDownButton.Location = new System.Drawing.Point(252, 95);
			this.fileDownButton.Name = "fileDownButton";
			this.fileDownButton.Size = new System.Drawing.Size(53, 23);
			this.fileDownButton.TabIndex = 9;
			this.fileDownButton.Text = "DOWN";
			this.fileDownButton.UseVisualStyleBackColor = false;
			this.fileDownButton.Click += new System.EventHandler(this.fileDownButton_Click);
			// 
			// fileUpButton
			// 
			this.fileUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.fileUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fileUpButton.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.fileUpButton.Location = new System.Drawing.Point(252, 66);
			this.fileUpButton.Name = "fileUpButton";
			this.fileUpButton.Size = new System.Drawing.Size(53, 23);
			this.fileUpButton.TabIndex = 8;
			this.fileUpButton.Text = "UP";
			this.fileUpButton.UseVisualStyleBackColor = false;
			this.fileUpButton.Click += new System.EventHandler(this.fileUpButton_Click);
			// 
			// fileRemoveButton
			// 
			this.fileRemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.fileRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fileRemoveButton.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.fileRemoveButton.Location = new System.Drawing.Point(252, 37);
			this.fileRemoveButton.Name = "fileRemoveButton";
			this.fileRemoveButton.Size = new System.Drawing.Size(53, 23);
			this.fileRemoveButton.TabIndex = 7;
			this.fileRemoveButton.Text = "DEL";
			this.fileRemoveButton.UseVisualStyleBackColor = false;
			this.fileRemoveButton.Click += new System.EventHandler(this.fileRemoveButton_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.encodeQueryLabel);
			this.groupBox2.Controls.Add(this.handBrakeCMDTextBox);
			this.groupBox2.Controls.Add(this.handBrakeCLIButton);
			this.groupBox2.Controls.Add(this.encodeButton);
			this.groupBox2.Controls.Add(this.handBrakeCLILocationTextBox);
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.groupBox2.Location = new System.Drawing.Point(12, 254);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(450, 167);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "HandBrake";
			// 
			// encodeQueryLabel
			// 
			this.encodeQueryLabel.AutoSize = true;
			this.encodeQueryLabel.Location = new System.Drawing.Point(6, 56);
			this.encodeQueryLabel.Name = "encodeQueryLabel";
			this.encodeQueryLabel.Size = new System.Drawing.Size(308, 26);
			this.encodeQueryLabel.TabIndex = 3;
			this.encodeQueryLabel.Text = "Paste in the handbrake query generated by the handbrake GUI.\r\nRemove the -i and -" +
    "o sections of the query.";
			// 
			// handBrakeCMDTextBox
			// 
			this.handBrakeCMDTextBox.BackColor = System.Drawing.Color.Gray;
			this.handBrakeCMDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.handBrakeCMDTextBox.Location = new System.Drawing.Point(7, 85);
			this.handBrakeCMDTextBox.Multiline = true;
			this.handBrakeCMDTextBox.Name = "handBrakeCMDTextBox";
			this.handBrakeCMDTextBox.Size = new System.Drawing.Size(239, 70);
			this.handBrakeCMDTextBox.TabIndex = 2;
			// 
			// handBrakeCLIButton
			// 
			this.handBrakeCLIButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.handBrakeCLIButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.handBrakeCLIButton.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.handBrakeCLIButton.Location = new System.Drawing.Point(252, 30);
			this.handBrakeCLIButton.Name = "handBrakeCLIButton";
			this.handBrakeCLIButton.Size = new System.Drawing.Size(143, 23);
			this.handBrakeCLIButton.TabIndex = 1;
			this.handBrakeCLIButton.Text = "Select Hand Brake CLI";
			this.handBrakeCLIButton.UseVisualStyleBackColor = false;
			this.handBrakeCLIButton.Click += new System.EventHandler(this.handBrakeCLIButton_Click);
			// 
			// handBrakeCLILocationTextBox
			// 
			this.handBrakeCLILocationTextBox.BackColor = System.Drawing.Color.Gray;
			this.handBrakeCLILocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.handBrakeCLILocationTextBox.Location = new System.Drawing.Point(7, 32);
			this.handBrakeCLILocationTextBox.Name = "handBrakeCLILocationTextBox";
			this.handBrakeCLILocationTextBox.Size = new System.Drawing.Size(239, 13);
			this.handBrakeCLILocationTextBox.TabIndex = 0;
			// 
			// handBrakeCLIOpenFileDialog
			// 
			this.handBrakeCLIOpenFileDialog.FileName = "HandBrakeCLI.exe";
			// 
			// saveNextToOriginalsCheckBox
			// 
			this.saveNextToOriginalsCheckBox.AutoSize = true;
			this.saveNextToOriginalsCheckBox.Location = new System.Drawing.Point(252, 161);
			this.saveNextToOriginalsCheckBox.Name = "saveNextToOriginalsCheckBox";
			this.saveNextToOriginalsCheckBox.Size = new System.Drawing.Size(127, 17);
			this.saveNextToOriginalsCheckBox.TabIndex = 14;
			this.saveNextToOriginalsCheckBox.Text = "Save next to originals";
			this.saveNextToOriginalsCheckBox.UseVisualStyleBackColor = true;
			this.saveNextToOriginalsCheckBox.CheckedChanged += new System.EventHandler(this.saveNextToOriginalsCheckBox_CheckedChanged);
			// 
			// handBrakeBatchEncoder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(474, 435);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "handBrakeBatchEncoder";
			this.Text = "HandBrake Batch Encoder";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Button encodeButton;
		private System.Windows.Forms.Button encodeLocationButton;
		private System.Windows.Forms.ListBox folderFileListBox;
        private System.Windows.Forms.TextBox encodeLocationTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox handBrakeCMDTextBox;
        private System.Windows.Forms.Button handBrakeCLIButton;
		private System.Windows.Forms.TextBox handBrakeCLILocationTextBox;
        private System.Windows.Forms.FolderBrowserDialog encodeFolderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog handBrakeCLIOpenFileDialog;
        private System.Windows.Forms.Button fileRemoveButton;
        private System.Windows.Forms.Button fileDownButton;
        private System.Windows.Forms.Button fileUpButton;
		private System.Windows.Forms.Label encodeQueryLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox preserveTimeStampCheckBox;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.CheckBox saveNextToOriginalsCheckBox;
    }
}

