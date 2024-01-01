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
            buttonCancel.Location = new System.Drawing.Point(321, 583);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(141, 57);
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
            buttonSave.Location = new System.Drawing.Point(490, 583);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(143, 58);
            buttonSave.TabIndex = 65;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            buttonOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonOpenFile.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonOpenFile.ForeColor = System.Drawing.Color.Transparent;
            buttonOpenFile.Location = new System.Drawing.Point(299, 233);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new System.Drawing.Size(249, 47);
            buttonOpenFile.TabIndex = 70;
            buttonOpenFile.Text = "Open File";
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonExit.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonExit.ForeColor = System.Drawing.Color.White;
            buttonExit.Location = new System.Drawing.Point(641, 3);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new System.Drawing.Size(50, 50);
            buttonExit.TabIndex = 64;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconmenu1;
            pictureBox1.Location = new System.Drawing.Point(11, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(36, 47);
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
            label8.Location = new System.Drawing.Point(66, 12);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(209, 38);
            label8.TabIndex = 62;
            label8.Text = "FileAttachment";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label3.Location = new System.Drawing.Point(36, 488);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 30);
            label3.TabIndex = 57;
            label3.Text = "File*";
            // 
            // textBoxFileName
            // 
            textBoxFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxFileName.Enabled = false;
            textBoxFileName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxFileName.Location = new System.Drawing.Point(234, 182);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.Size = new System.Drawing.Size(401, 37);
            textBoxFileName.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label5.Location = new System.Drawing.Point(36, 183);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(117, 30);
            label5.TabIndex = 53;
            label5.Text = "FileName*";
            // 
            // comboBoxTypeFile
            // 
            comboBoxTypeFile.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxTypeFile.FormattingEnabled = true;
            comboBoxTypeFile.Location = new System.Drawing.Point(234, 312);
            comboBoxTypeFile.Name = "comboBoxTypeFile";
            comboBoxTypeFile.Size = new System.Drawing.Size(400, 38);
            comboBoxTypeFile.TabIndex = 52;
            // 
            // textBoxProjectTaskName
            // 
            textBoxProjectTaskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxProjectTaskName.Enabled = false;
            textBoxProjectTaskName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxProjectTaskName.Location = new System.Drawing.Point(234, 103);
            textBoxProjectTaskName.Name = "textBoxProjectTaskName";
            textBoxProjectTaskName.Size = new System.Drawing.Size(401, 37);
            textBoxProjectTaskName.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label4.Location = new System.Drawing.Point(36, 312);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(193, 30);
            label4.TabIndex = 50;
            label4.Text = "Attachment Type*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label2.Location = new System.Drawing.Point(36, 103);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(130, 30);
            label2.TabIndex = 49;
            label2.Text = "Task Name*";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(694, 70);
            label1.TabIndex = 48;
            // 
            // textBoxDescription
            // 
            textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxDescription.Location = new System.Drawing.Point(234, 395);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new System.Drawing.Size(401, 80);
            textBoxDescription.TabIndex = 68;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label7.Location = new System.Drawing.Point(36, 397);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(127, 30);
            label7.TabIndex = 67;
            label7.Text = "Description";
            // 
            // linkLabelChooseFile
            // 
            linkLabelChooseFile.AutoSize = true;
            linkLabelChooseFile.Location = new System.Drawing.Point(234, 495);
            linkLabelChooseFile.Name = "linkLabelChooseFile";
            linkLabelChooseFile.Size = new System.Drawing.Size(103, 25);
            linkLabelChooseFile.TabIndex = 69;
            linkLabelChooseFile.TabStop = true;
            linkLabelChooseFile.Text = "Choose File";
            linkLabelChooseFile.LinkClicked += linkLabelChooseFile_LinkClicked;
            // 
            // FrmAttachment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(694, 658);
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