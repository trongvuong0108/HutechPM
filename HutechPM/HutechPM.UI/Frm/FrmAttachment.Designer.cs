namespace HutechPM.UI.Frm
{
    partial class FrmAttachment
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
            System.Windows.Forms.Button buttonCancel;
            System.Windows.Forms.Button buttonSave;
            System.Windows.Forms.Button buttonOpenFile;
            buttonExit = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label8 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBoxFileName = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            comboBoxTypeFile = new System.Windows.Forms.ComboBox();
            textBoxProjectTaskName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            textBoxDescription = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            linkLabelChooseFile = new System.Windows.Forms.LinkLabel();
            buttonCancel = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            buttonOpenFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = System.Drawing.Color.White;
            buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonCancel.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            buttonCancel.Location = new System.Drawing.Point(225, 350);
            buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(99, 34);
            buttonCancel.TabIndex = 66;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSave.ForeColor = System.Drawing.Color.Transparent;
            buttonSave.Location = new System.Drawing.Point(343, 350);
            buttonSave.Margin = new System.Windows.Forms.Padding(2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(100, 35);
            buttonSave.TabIndex = 65;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonOpenFile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonOpenFile.ForeColor = System.Drawing.Color.Transparent;
            buttonOpenFile.Location = new System.Drawing.Point(209, 140);
            buttonOpenFile.Margin = new System.Windows.Forms.Padding(2);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new System.Drawing.Size(174, 26);
            buttonOpenFile.TabIndex = 70;
            buttonOpenFile.Text = "Open File";
            buttonOpenFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            buttonOpenFile.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonExit.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonExit.ForeColor = System.Drawing.Color.White;
            buttonExit.Location = new System.Drawing.Point(449, 2);
            buttonExit.Margin = new System.Windows.Forms.Padding(2);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new System.Drawing.Size(35, 30);
            buttonExit.TabIndex = 64;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconmenu1;
            pictureBox1.Location = new System.Drawing.Point(8, 4);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(25, 28);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(46, 7);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(144, 25);
            label8.TabIndex = 62;
            label8.Text = "FileAttachment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label3.Location = new System.Drawing.Point(25, 293);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(40, 20);
            label3.TabIndex = 57;
            label3.Text = "File*";
            // 
            // textBoxFileName
            // 
            textBoxFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxFileName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxFileName.Location = new System.Drawing.Point(164, 109);
            textBoxFileName.Margin = new System.Windows.Forms.Padding(2);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.Size = new System.Drawing.Size(281, 27);
            textBoxFileName.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label5.Location = new System.Drawing.Point(25, 110);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(81, 20);
            label5.TabIndex = 53;
            label5.Text = "FileName*";
            // 
            // comboBoxTypeFile
            // 
            comboBoxTypeFile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxTypeFile.FormattingEnabled = true;
            comboBoxTypeFile.Location = new System.Drawing.Point(164, 187);
            comboBoxTypeFile.Margin = new System.Windows.Forms.Padding(2);
            comboBoxTypeFile.Name = "comboBoxTypeFile";
            comboBoxTypeFile.Size = new System.Drawing.Size(281, 28);
            comboBoxTypeFile.TabIndex = 52;
            // 
            // textBoxProjectTaskName
            // 
            textBoxProjectTaskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxProjectTaskName.Enabled = false;
            textBoxProjectTaskName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxProjectTaskName.Location = new System.Drawing.Point(164, 62);
            textBoxProjectTaskName.Margin = new System.Windows.Forms.Padding(2);
            textBoxProjectTaskName.Name = "textBoxProjectTaskName";
            textBoxProjectTaskName.Size = new System.Drawing.Size(281, 27);
            textBoxProjectTaskName.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label4.Location = new System.Drawing.Point(25, 187);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(131, 20);
            label4.TabIndex = 50;
            label4.Text = "Attachment Type*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label2.Location = new System.Drawing.Point(25, 62);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 20);
            label2.TabIndex = 49;
            label2.Text = "Task Name*";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(486, 42);
            label1.TabIndex = 48;
            // 
            // textBoxDescription
            // 
            textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxDescription.Location = new System.Drawing.Point(164, 237);
            textBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new System.Drawing.Size(281, 49);
            textBoxDescription.TabIndex = 68;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label7.Location = new System.Drawing.Point(25, 238);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(87, 20);
            label7.TabIndex = 67;
            label7.Text = "Description";
            // 
            // linkLabelChooseFile
            // 
            linkLabelChooseFile.AutoSize = true;
            linkLabelChooseFile.Location = new System.Drawing.Point(164, 297);
            linkLabelChooseFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            linkLabelChooseFile.Name = "linkLabelChooseFile";
            linkLabelChooseFile.Size = new System.Drawing.Size(68, 15);
            linkLabelChooseFile.TabIndex = 69;
            linkLabelChooseFile.TabStop = true;
            linkLabelChooseFile.Text = "Choose File";
            linkLabelChooseFile.LinkClicked += linkLabelChooseFile_LinkClicked;
            // 
            // FrmAttachment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(486, 395);
            Controls.Add(buttonOpenFile);
            Controls.Add(linkLabelChooseFile);
            Controls.Add(textBoxDescription);
            Controls.Add(label7);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(buttonExit);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(textBoxFileName);
            Controls.Add(label5);
            Controls.Add(comboBoxTypeFile);
            Controls.Add(textBoxProjectTaskName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(2);
            Name = "FrmAttachment";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmAttachment";
            Load += FrmAttachment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTypeFile;
        private System.Windows.Forms.TextBox textBoxProjectTaskName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabelChooseFile;
    }
}