namespace HutechPM.UI.FRM
{
    partial class FrmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplashScreen));
            progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            labelCopyright = new DevExpress.XtraEditors.LabelControl();
            labelStatus = new DevExpress.XtraEditors.LabelControl();
            peLogo = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)progressBarControl.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peLogo.Properties).BeginInit();
            SuspendLayout();
            // 
            // progressBarControl
            // 
            progressBarControl.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            progressBarControl.EditValue = 0;
            progressBarControl.Location = new System.Drawing.Point(27, 541);
            progressBarControl.Margin = new System.Windows.Forms.Padding(4);
            progressBarControl.Name = "progressBarControl";
            progressBarControl.Size = new System.Drawing.Size(1444, 38);
            progressBarControl.TabIndex = 5;
            // 
            // labelCopyright
            // 
            labelCopyright.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelCopyright.Appearance.Options.UseFont = true;
            labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            labelCopyright.Location = new System.Drawing.Point(402, 209);
            labelCopyright.Margin = new System.Windows.Forms.Padding(4);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new System.Drawing.Size(695, 48);
            labelCopyright.TabIndex = 6;
            labelCopyright.Text = "Trường Đại học công nghệ TPHCM Hutech";
            // 
            // labelStatus
            // 
            labelStatus.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelStatus.Appearance.Options.UseFont = true;
            labelStatus.Location = new System.Drawing.Point(27, 468);
            labelStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 1);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new System.Drawing.Size(196, 54);
            labelStatus.TabIndex = 7;
            labelStatus.Text = "starting up";
            // 
            // peLogo
            // 
            peLogo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            peLogo.EditValue = resources.GetObject("peLogo.EditValue");
            peLogo.Location = new System.Drawing.Point(123, -29);
            peLogo.Margin = new System.Windows.Forms.Padding(4);
            peLogo.Name = "peLogo";
            peLogo.Properties.AllowFocused = false;
            peLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            peLogo.Properties.Appearance.Options.UseBackColor = true;
            peLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            peLogo.Properties.ShowMenu = false;
            peLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            peLogo.Size = new System.Drawing.Size(1243, 230);
            peLogo.TabIndex = 8;
            // 
            // FrmSplashScreen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1516, 648);
            Controls.Add(peLogo);
            Controls.Add(labelStatus);
            Controls.Add(labelCopyright);
            Controls.Add(progressBarControl);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "FrmSplashScreen";
            Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            Text = "FrmSplashScreen";
            Load += FrmSplashScreen_Load;
            ((System.ComponentModel.ISupportInitialize)progressBarControl.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)peLogo.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
        private DevExpress.XtraEditors.LabelControl labelCopyright;
        private DevExpress.XtraEditors.LabelControl labelStatus;
        private DevExpress.XtraEditors.PictureEdit peLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
