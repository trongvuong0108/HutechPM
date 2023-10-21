namespace HutechPM.UI.Uc
{
    partial class uc_Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPassword = new System.Windows.Forms.TextBox();
            pictureBoxIconLock = new System.Windows.Forms.PictureBox();
            pictureBoxPasswork = new System.Windows.Forms.PictureBox();
            pictureBoxIconUser = new System.Windows.Forms.PictureBox();
            textBoxUser = new System.Windows.Forms.TextBox();
            pictureBoxUser = new System.Windows.Forms.PictureBox();
            labelForget = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            checkBoxPasswork = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconLock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPasswork).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            textBoxPassword.Location = new System.Drawing.Point(98, 218);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new System.Drawing.Size(611, 30);
            textBoxPassword.TabIndex = 33;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.Click += textBoxPassword_Click;
            // 
            // pictureBoxIconLock
            // 
            pictureBoxIconLock.BackColor = System.Drawing.Color.White;
            pictureBoxIconLock.Image = Properties.Resources.lock2;
            pictureBoxIconLock.Location = new System.Drawing.Point(26, 210);
            pictureBoxIconLock.Name = "pictureBoxIconLock";
            pictureBoxIconLock.Size = new System.Drawing.Size(45, 45);
            pictureBoxIconLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxIconLock.TabIndex = 32;
            pictureBoxIconLock.TabStop = false;
            pictureBoxIconLock.UseWaitCursor = true;
            // 
            // pictureBoxPasswork
            // 
            pictureBoxPasswork.BackColor = System.Drawing.Color.White;
            pictureBoxPasswork.Location = new System.Drawing.Point(8, 193);
            pictureBoxPasswork.Name = "pictureBoxPasswork";
            pictureBoxPasswork.Size = new System.Drawing.Size(723, 78);
            pictureBoxPasswork.TabIndex = 31;
            pictureBoxPasswork.TabStop = false;
            // 
            // pictureBoxIconUser
            // 
            pictureBoxIconUser.BackColor = System.Drawing.Color.White;
            pictureBoxIconUser.Image = Properties.Resources.user1;
            pictureBoxIconUser.Location = new System.Drawing.Point(26, 110);
            pictureBoxIconUser.Name = "pictureBoxIconUser";
            pictureBoxIconUser.Size = new System.Drawing.Size(45, 45);
            pictureBoxIconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBoxIconUser.TabIndex = 30;
            pictureBoxIconUser.TabStop = false;
            // 
            // textBoxUser
            // 
            textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxUser.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            textBoxUser.Location = new System.Drawing.Point(98, 113);
            textBoxUser.Multiline = true;
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new System.Drawing.Size(611, 42);
            textBoxUser.TabIndex = 29;
            textBoxUser.Click += textBoxUser_Click;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.BackColor = System.Drawing.Color.White;
            pictureBoxUser.Location = new System.Drawing.Point(8, 95);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new System.Drawing.Size(723, 78);
            pictureBoxUser.TabIndex = 28;
            pictureBoxUser.TabStop = false;
            // 
            // labelForget
            // 
            labelForget.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelForget.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            labelForget.Location = new System.Drawing.Point(280, 307);
            labelForget.Name = "labelForget";
            labelForget.Size = new System.Drawing.Size(182, 23);
            labelForget.TabIndex = 27;
            labelForget.Text = "Forget PassWord?";
            labelForget.Click += labelForget_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(26, 293);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(186, 50);
            button1.TabIndex = 26;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label6.Location = new System.Drawing.Point(64, 30);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(361, 39);
            label6.TabIndex = 25;
            label6.Text = "Login to your account";
            // 
            // checkBoxPasswork
            // 
            checkBoxPasswork.AutoSize = true;
            checkBoxPasswork.Location = new System.Drawing.Point(547, 301);
            checkBoxPasswork.Name = "checkBoxPasswork";
            checkBoxPasswork.Size = new System.Drawing.Size(162, 29);
            checkBoxPasswork.TabIndex = 67;
            checkBoxPasswork.Text = "Show Password";
            checkBoxPasswork.UseVisualStyleBackColor = true;
            checkBoxPasswork.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // uc_Login
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            Controls.Add(checkBoxPasswork);
            Controls.Add(textBoxPassword);
            Controls.Add(pictureBoxIconLock);
            Controls.Add(pictureBoxPasswork);
            Controls.Add(pictureBoxIconUser);
            Controls.Add(textBoxUser);
            Controls.Add(pictureBoxUser);
            Controls.Add(labelForget);
            Controls.Add(button1);
            Controls.Add(label6);
            Name = "uc_Login";
            Size = new System.Drawing.Size(754, 392);
            Load += uc_Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconLock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPasswork).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIconUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxIconLock;
        private System.Windows.Forms.PictureBox pictureBoxPasswork;
        private System.Windows.Forms.PictureBox pictureBoxIconUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label labelForget;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxPasswork;
    }
}
