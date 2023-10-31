namespace HutechPM.UI.Frm
{
    partial class FrmChangePassword
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
            panel1 = new System.Windows.Forms.Panel();
            textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            textBoxNewPassword = new System.Windows.Forms.TextBox();
            ChangePassword = new System.Windows.Forms.Button();
            label11 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            checkBoxShowpassword = new System.Windows.Forms.CheckBox();
            buttonExit = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(textBoxPasswordConfirm);
            panel1.Controls.Add(textBoxNewPassword);
            panel1.Controls.Add(ChangePassword);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(checkBoxShowpassword);
            panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            panel1.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            panel1.Location = new System.Drawing.Point(22, 100);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(783, 392);
            panel1.TabIndex = 88;
            // 
            // textBoxPasswordConfirm
            // 
            textBoxPasswordConfirm.BackColor = System.Drawing.SystemColors.Control;
            textBoxPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxPasswordConfirm.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            textBoxPasswordConfirm.Location = new System.Drawing.Point(77, 193);
            textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            textBoxPasswordConfirm.Size = new System.Drawing.Size(617, 32);
            textBoxPasswordConfirm.TabIndex = 96;
            textBoxPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.BackColor = System.Drawing.SystemColors.Control;
            textBoxNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxNewPassword.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            textBoxNewPassword.Location = new System.Drawing.Point(77, 59);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new System.Drawing.Size(616, 32);
            textBoxNewPassword.TabIndex = 95;
            textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // ChangePassword
            // 
            ChangePassword.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            ChangePassword.FlatAppearance.BorderSize = 0;
            ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ChangePassword.ForeColor = System.Drawing.Color.White;
            ChangePassword.Location = new System.Drawing.Point(251, 303);
            ChangePassword.Name = "ChangePassword";
            ChangePassword.Size = new System.Drawing.Size(299, 50);
            ChangePassword.TabIndex = 92;
            ChangePassword.Text = "Change Password";
            ChangePassword.UseVisualStyleBackColor = false;
            ChangePassword.Click += ChangePassword_Click;
            // 
            // label11
            // 
            label11.BackColor = System.Drawing.Color.FromArgb(42, 128, 185);
            label11.ForeColor = System.Drawing.Color.FromArgb(42, 128, 185);
            label11.Location = new System.Drawing.Point(60, 228);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(669, 2);
            label11.TabIndex = 91;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label14.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label14.Location = new System.Drawing.Point(53, 150);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(327, 32);
            label14.TabIndex = 90;
            label14.Text = "New Password Confirm";
            label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.BackColor = System.Drawing.Color.FromArgb(42, 128, 185);
            label7.ForeColor = System.Drawing.Color.FromArgb(42, 128, 185);
            label7.Location = new System.Drawing.Point(59, 102);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(669, 2);
            label7.TabIndex = 89;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label9.Location = new System.Drawing.Point(53, 24);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(213, 32);
            label9.TabIndex = 88;
            label9.Text = "New Password";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxShowpassword
            // 
            checkBoxShowpassword.AutoSize = true;
            checkBoxShowpassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            checkBoxShowpassword.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            checkBoxShowpassword.Location = new System.Drawing.Point(556, 250);
            checkBoxShowpassword.Name = "checkBoxShowpassword";
            checkBoxShowpassword.Size = new System.Drawing.Size(172, 32);
            checkBoxShowpassword.TabIndex = 86;
            checkBoxShowpassword.Text = "Show Password";
            checkBoxShowpassword.UseVisualStyleBackColor = true;
            checkBoxShowpassword.CheckedChanged += checkBoxShowpassword_CheckedChanged;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonExit.FlatAppearance.BorderSize = 0;
            buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonExit.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonExit.ForeColor = System.Drawing.Color.White;
            buttonExit.Location = new System.Drawing.Point(779, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new System.Drawing.Size(56, 59);
            buttonExit.TabIndex = 92;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconmenu1;
            pictureBox1.Location = new System.Drawing.Point(12, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(36, 47);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 91;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(54, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 38);
            label1.TabIndex = 90;
            label1.Text = "Task";
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label2.Location = new System.Drawing.Point(-1, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(862, 59);
            label2.TabIndex = 89;
            // 
            // FrmChangePassword
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(834, 526);
            Controls.Add(buttonExit);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FrmChangePassword";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmChangePassword";
            Load += FrmChangePassword_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChangePassword;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxShowpassword;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxPasswordConfirm;
    }
}