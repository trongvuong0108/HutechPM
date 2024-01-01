namespace HutechPM.UI.Frm
{
    partial class FrmTask
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label8 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            textBoxDescription = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            comboBoxOwner = new System.Windows.Forms.ComboBox();
            textBoxTaskName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            textBoxEstimate = new System.Windows.Forms.TextBox();
            textBoxRemaining = new System.Windows.Forms.TextBox();
            comboBoxStatus = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            buttonExit = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            comboBoxProjectName = new System.Windows.Forms.ComboBox();
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
            buttonSave.Location = new System.Drawing.Point(478, 694);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(112, 50);
            buttonSave.TabIndex = 33;
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
            buttonCancel.Location = new System.Drawing.Point(316, 696);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(110, 48);
            buttonCancel.TabIndex = 46;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconmenu1;
            pictureBox1.Location = new System.Drawing.Point(13, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(36, 47);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label8.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(55, 9);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(71, 38);
            label8.TabIndex = 40;
            label8.Text = "Task";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label6.Location = new System.Drawing.Point(35, 537);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(129, 30);
            label6.TabIndex = 38;
            label6.Text = "Remaining*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label3.Location = new System.Drawing.Point(35, 622);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 30);
            label3.TabIndex = 35;
            label3.Text = "Status*";
            // 
            // textBoxDescription
            // 
            textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxDescription.Location = new System.Drawing.Point(190, 251);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new System.Drawing.Size(400, 75);
            textBoxDescription.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label5.Location = new System.Drawing.Point(35, 251);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(127, 30);
            label5.TabIndex = 29;
            label5.Text = "Description";
            // 
            // comboBoxOwner
            // 
            comboBoxOwner.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxOwner.FormattingEnabled = true;
            comboBoxOwner.Location = new System.Drawing.Point(190, 356);
            comboBoxOwner.Name = "comboBoxOwner";
            comboBoxOwner.Size = new System.Drawing.Size(400, 38);
            comboBoxOwner.TabIndex = 28;
            // 
            // textBoxTaskName
            // 
            textBoxTaskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxTaskName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxTaskName.Location = new System.Drawing.Point(190, 172);
            textBoxTaskName.Name = "textBoxTaskName";
            textBoxTaskName.Size = new System.Drawing.Size(400, 37);
            textBoxTaskName.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label4.Location = new System.Drawing.Point(35, 359);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(90, 30);
            label4.TabIndex = 26;
            label4.Text = "Owner*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label2.Location = new System.Drawing.Point(35, 179);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(126, 30);
            label2.TabIndex = 25;
            label2.Text = "Task name*";
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(658, 59);
            label1.TabIndex = 24;
            // 
            // textBoxEstimate
            // 
            textBoxEstimate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxEstimate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxEstimate.Location = new System.Drawing.Point(190, 445);
            textBoxEstimate.Name = "textBoxEstimate";
            textBoxEstimate.Size = new System.Drawing.Size(400, 37);
            textBoxEstimate.TabIndex = 42;
            // 
            // textBoxRemaining
            // 
            textBoxRemaining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxRemaining.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxRemaining.Location = new System.Drawing.Point(190, 535);
            textBoxRemaining.Name = "textBoxRemaining";
            textBoxRemaining.Size = new System.Drawing.Size(400, 37);
            textBoxRemaining.TabIndex = 43;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new System.Drawing.Point(190, 619);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new System.Drawing.Size(400, 38);
            comboBoxStatus.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label7.Location = new System.Drawing.Point(35, 447);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(107, 30);
            label7.TabIndex = 45;
            label7.Text = "Estimate*";
            label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonExit.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonExit.ForeColor = System.Drawing.Color.White;
            buttonExit.Location = new System.Drawing.Point(602, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new System.Drawing.Size(56, 59);
            buttonExit.TabIndex = 47;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label9.Location = new System.Drawing.Point(35, 100);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(154, 30);
            label9.TabIndex = 48;
            label9.Text = "Project name*";
            // 
            // comboBoxProjectName
            // 
            comboBoxProjectName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxProjectName.FormattingEnabled = true;
            comboBoxProjectName.Location = new System.Drawing.Point(190, 92);
            comboBoxProjectName.Name = "comboBoxProjectName";
            comboBoxProjectName.Size = new System.Drawing.Size(400, 38);
            comboBoxProjectName.TabIndex = 49;
            comboBoxProjectName.SelectedIndexChanged += comboBoxProjectName_SelectedIndexChanged;
            // 
            // FrmTask
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(658, 775);
            Controls.Add(comboBoxProjectName);
            Controls.Add(label9);
            Controls.Add(buttonExit);
            Controls.Add(buttonCancel);
            Controls.Add(label7);
            Controls.Add(comboBoxStatus);
            Controls.Add(textBoxRemaining);
            Controls.Add(textBoxEstimate);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(buttonSave);
            Controls.Add(textBoxDescription);
            Controls.Add(label5);
            Controls.Add(comboBoxOwner);
            Controls.Add(textBoxTaskName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FrmTask";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmTask";
            Load += FrmTask_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButtonFalse;
        private System.Windows.Forms.RadioButton radioButtonTrue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label estimate;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxOwner;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEstimate;
        private System.Windows.Forms.TextBox textBoxRemaining;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxProjectName;
    }
}