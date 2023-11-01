namespace HutechPM.UI.Frm
{
    partial class FrmProject
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
            System.Windows.Forms.Button buttonSave;
            System.Windows.Forms.Button buttonCancel;
            label1 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            buttonExit = new System.Windows.Forms.Button();
            radioButtonFalse = new System.Windows.Forms.RadioButton();
            radioButtonTrue = new System.Windows.Forms.RadioButton();
            label3 = new System.Windows.Forms.Label();
            dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            label6 = new System.Windows.Forms.Label();
            dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            label7 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            comboBoxOwner = new System.Windows.Forms.ComboBox();
            textBoxDescription = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBoxProjectName = new System.Windows.Forms.TextBox();
            buttonSave = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSave.ForeColor = System.Drawing.Color.Transparent;
            buttonSave.Location = new System.Drawing.Point(488, 634);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(112, 50);
            buttonSave.TabIndex = 34;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = System.Drawing.Color.White;
            buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonCancel.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            buttonCancel.Location = new System.Drawing.Point(337, 636);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(110, 48);
            buttonCancel.TabIndex = 47;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(658, 59);
            label1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(66, 12);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(105, 38);
            label8.TabIndex = 22;
            label8.Text = "Project";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconmenu1;
            pictureBox1.Location = new System.Drawing.Point(12, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(36, 47);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonExit.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonExit.ForeColor = System.Drawing.Color.White;
            buttonExit.Location = new System.Drawing.Point(607, 5);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new System.Drawing.Size(50, 50);
            buttonExit.TabIndex = 24;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // radioButtonFalse
            // 
            radioButtonFalse.AutoSize = true;
            radioButtonFalse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButtonFalse.ForeColor = System.Drawing.Color.Black;
            radioButtonFalse.Location = new System.Drawing.Point(337, 562);
            radioButtonFalse.Name = "radioButtonFalse";
            radioButtonFalse.Size = new System.Drawing.Size(85, 34);
            radioButtonFalse.TabIndex = 18;
            radioButtonFalse.TabStop = true;
            radioButtonFalse.Text = "False";
            radioButtonFalse.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrue
            // 
            radioButtonTrue.AutoSize = true;
            radioButtonTrue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            radioButtonTrue.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButtonTrue.ForeColor = System.Drawing.Color.Black;
            radioButtonTrue.Location = new System.Drawing.Point(200, 562);
            radioButtonTrue.Name = "radioButtonTrue";
            radioButtonTrue.Size = new System.Drawing.Size(91, 35);
            radioButtonTrue.TabIndex = 17;
            radioButtonTrue.TabStop = true;
            radioButtonTrue.Text = "True";
            radioButtonTrue.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label3.Location = new System.Drawing.Point(37, 560);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(106, 30);
            label3.TabIndex = 16;
            label3.Text = "Is Active*";
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTimePickerEndDate.Location = new System.Drawing.Point(200, 480);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new System.Drawing.Size(400, 37);
            dateTimePickerEndDate.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label6.Location = new System.Drawing.Point(37, 480);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(110, 30);
            label6.TabIndex = 19;
            label6.Text = "End date*";
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Enabled = false;
            dateTimePickerStartDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTimePickerStartDate.Location = new System.Drawing.Point(200, 390);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new System.Drawing.Size(400, 37);
            dateTimePickerStartDate.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label7.Location = new System.Drawing.Point(37, 391);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(120, 30);
            label7.TabIndex = 12;
            label7.Text = "Start date*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label4.Location = new System.Drawing.Point(37, 309);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(90, 30);
            label4.TabIndex = 3;
            label4.Text = "Owner*";
            // 
            // comboBoxOwner
            // 
            comboBoxOwner.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxOwner.FormattingEnabled = true;
            comboBoxOwner.Location = new System.Drawing.Point(200, 306);
            comboBoxOwner.Name = "comboBoxOwner";
            comboBoxOwner.Size = new System.Drawing.Size(400, 38);
            comboBoxOwner.TabIndex = 6;
            // 
            // textBoxDescription
            // 
            textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxDescription.Location = new System.Drawing.Point(200, 182);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new System.Drawing.Size(400, 80);
            textBoxDescription.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label5.Location = new System.Drawing.Point(37, 192);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(137, 30);
            label5.TabIndex = 8;
            label5.Text = "Description*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label2.Location = new System.Drawing.Point(37, 104);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(154, 30);
            label2.TabIndex = 1;
            label2.Text = "Project name*";
            // 
            // textBoxProjectName
            // 
            textBoxProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxProjectName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxProjectName.Location = new System.Drawing.Point(200, 105);
            textBoxProjectName.Name = "textBoxProjectName";
            textBoxProjectName.Size = new System.Drawing.Size(400, 37);
            textBoxProjectName.TabIndex = 4;
            // 
            // FrmProject
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(658, 723);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(buttonExit);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(dateTimePickerEndDate);
            Controls.Add(label6);
            Controls.Add(radioButtonFalse);
            Controls.Add(radioButtonTrue);
            Controls.Add(label3);
            Controls.Add(dateTimePickerStartDate);
            Controls.Add(label7);
            Controls.Add(textBoxDescription);
            Controls.Add(label5);
            Controls.Add(comboBoxOwner);
            Controls.Add(textBoxProjectName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmProject";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Project";
            Load += FrmProject_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.RadioButton radioButtonFalse;
        private System.Windows.Forms.RadioButton radioButtonTrue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxOwner;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProjectName;
    }
}