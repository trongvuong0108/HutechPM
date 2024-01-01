namespace HutechPM.UI.Components
{
    partial class uc_Home
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
            components = new System.ComponentModel.Container();
            projectTaskBindingSource1 = new System.Windows.Forms.BindingSource(components);
            projectBindingSource = new System.Windows.Forms.BindingSource(components);
            projectTaskBindingSource = new System.Windows.Forms.BindingSource(components);
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label7 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)projectTaskBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projectBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projectTaskBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // projectTaskBindingSource1
            // 
            projectTaskBindingSource1.DataSource = typeof(Data.Entities.ProjectTask);
            // 
            // projectBindingSource
            // 
            projectBindingSource.DataSource = typeof(Data.Entities.Project);
            // 
            // projectTaskBindingSource
            // 
            projectTaskBindingSource.DataSource = typeof(Data.Entities.ProjectTask);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Workflow2;
            pictureBox1.Location = new System.Drawing.Point(598, 292);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(120, 120);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 55;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 58F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label7.Location = new System.Drawing.Point(352, 430);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(602, 153);
            label7.TabIndex = 54;
            label7.Text = "Workflow";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(0, 610);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1302, 56);
            label1.TabIndex = 53;
            label1.Text = "Home";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label2.Location = new System.Drawing.Point(202, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(438, 128);
            label2.TabIndex = 57;
            label2.Text = "HUTECH";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.HutechlogoNoName;
            pictureBox2.Location = new System.Drawing.Point(21, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(200, 200);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 58;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label3.Location = new System.Drawing.Point(230, 138);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(374, 2);
            label3.TabIndex = 59;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Red;
            label4.Location = new System.Drawing.Point(230, 143);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(365, 38);
            label4.TabIndex = 60;
            label4.Text = "Đại học Công Nghệ Tp.HCM";
            // 
            // uc_Home
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label1);
            Name = "uc_Home";
            Size = new System.Drawing.Size(1302, 666);
            Load += uc_Home_Load;
            ((System.ComponentModel.ISupportInitialize)projectTaskBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)projectBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)projectTaskBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.BindingSource projectTaskBindingSource;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource projectTaskBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
