namespace HutechPM.UI.Uc
{
    partial class uc_UserProfile
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
            userBindingSource = new System.Windows.Forms.BindingSource(components);
            userBindingSource1 = new System.Windows.Forms.BindingSource(components);
            gridControlUserProfile = new DevExpress.XtraGrid.GridControl();
            userBindingSource2 = new System.Windows.Forms.BindingSource(components);
            gridViewUserProfile = new DevExpress.XtraGrid.Views.Grid.GridView();
            coluserId = new DevExpress.XtraGrid.Columns.GridColumn();
            coluserName = new DevExpress.XtraGrid.Columns.GridColumn();
            colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            colphone = new DevExpress.XtraGrid.Columns.GridColumn();
            colpassword = new DevExpress.XtraGrid.Columns.GridColumn();
            colfullName = new DevExpress.XtraGrid.Columns.GridColumn();
            coladdress = new DevExpress.XtraGrid.Columns.GridColumn();
            colgender = new DevExpress.XtraGrid.Columns.GridColumn();
            colisActive = new DevExpress.XtraGrid.Columns.GridColumn();
            colavatar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlUserProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewUserProfile).BeginInit();
            SuspendLayout();
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Data.Entities.User);
            // 
            // userBindingSource1
            // 
            userBindingSource1.DataSource = typeof(Data.Entities.User);
            // 
            // gridControlUserProfile
            // 
            gridControlUserProfile.DataSource = userBindingSource2;
            gridControlUserProfile.Location = new System.Drawing.Point(0, 65);
            gridControlUserProfile.MainView = gridViewUserProfile;
            gridControlUserProfile.Name = "gridControlUserProfile";
            gridControlUserProfile.Size = new System.Drawing.Size(1258, 505);
            gridControlUserProfile.TabIndex = 0;
            gridControlUserProfile.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewUserProfile });
            // 
            // userBindingSource2
            // 
            userBindingSource2.DataSource = typeof(Data.Entities.User);
            // 
            // gridViewUserProfile
            // 
            gridViewUserProfile.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { coluserId, coluserName, colemail, colphone, colpassword, colfullName, coladdress, colgender, colisActive, colavatar });
            gridViewUserProfile.GridControl = gridControlUserProfile;
            gridViewUserProfile.Name = "gridViewUserProfile";
            // 
            // coluserId
            // 
            coluserId.FieldName = "userId";
            coluserId.MinWidth = 30;
            coluserId.Name = "coluserId";
            coluserId.Width = 112;
            // 
            // coluserName
            // 
            coluserName.Caption = "UserName";
            coluserName.FieldName = "userName";
            coluserName.MinWidth = 30;
            coluserName.Name = "coluserName";
            coluserName.Visible = true;
            coluserName.VisibleIndex = 0;
            coluserName.Width = 112;
            // 
            // colemail
            // 
            colemail.Caption = "Email";
            colemail.FieldName = "email";
            colemail.MinWidth = 30;
            colemail.Name = "colemail";
            colemail.Visible = true;
            colemail.VisibleIndex = 1;
            colemail.Width = 112;
            // 
            // colphone
            // 
            colphone.Caption = "Phone";
            colphone.FieldName = "phone";
            colphone.MinWidth = 30;
            colphone.Name = "colphone";
            colphone.Visible = true;
            colphone.VisibleIndex = 2;
            colphone.Width = 112;
            // 
            // colpassword
            // 
            colpassword.FieldName = "password";
            colpassword.MinWidth = 30;
            colpassword.Name = "colpassword";
            colpassword.Width = 112;
            // 
            // colfullName
            // 
            colfullName.Caption = "Full Name";
            colfullName.FieldName = "fullName";
            colfullName.MinWidth = 30;
            colfullName.Name = "colfullName";
            colfullName.Visible = true;
            colfullName.VisibleIndex = 3;
            colfullName.Width = 112;
            // 
            // coladdress
            // 
            coladdress.Caption = "Address";
            coladdress.FieldName = "address";
            coladdress.MinWidth = 30;
            coladdress.Name = "coladdress";
            coladdress.Visible = true;
            coladdress.VisibleIndex = 4;
            coladdress.Width = 112;
            // 
            // colgender
            // 
            colgender.Caption = "Gender";
            colgender.FieldName = "genderDTO";
            colgender.MinWidth = 30;
            colgender.Name = "colgender";
            colgender.Visible = true;
            colgender.VisibleIndex = 5;
            colgender.Width = 112;
            // 
            // colisActive
            // 
            colisActive.Caption = "Is Active";
            colisActive.FieldName = "isActive";
            colisActive.MinWidth = 30;
            colisActive.Name = "colisActive";
            colisActive.Visible = true;
            colisActive.VisibleIndex = 6;
            colisActive.Width = 112;
            // 
            // colavatar
            // 
            colavatar.Caption = "Avatar";
            colavatar.FieldName = "avatar";
            colavatar.MinWidth = 30;
            colavatar.Name = "colavatar";
            colavatar.Visible = true;
            colavatar.VisibleIndex = 7;
            colavatar.Width = 112;
            // 
            // uc_UserProfile
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gridControlUserProfile);
            Name = "uc_UserProfile";
            Size = new System.Drawing.Size(1258, 647);
            Load += uc_UserProfile_Load;
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlUserProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewUserProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private DevExpress.XtraGrid.GridControl gridControlUserProfile;
        private System.Windows.Forms.BindingSource userBindingSource2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUserProfile;
        private DevExpress.XtraGrid.Columns.GridColumn coluserId;
        private DevExpress.XtraGrid.Columns.GridColumn coluserName;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colphone;
        private DevExpress.XtraGrid.Columns.GridColumn colpassword;
        private DevExpress.XtraGrid.Columns.GridColumn colfullName;
        private DevExpress.XtraGrid.Columns.GridColumn coladdress;
        private DevExpress.XtraGrid.Columns.GridColumn colgender;
        private DevExpress.XtraGrid.Columns.GridColumn colisActive;
        private DevExpress.XtraGrid.Columns.GridColumn colavatar;
    }
}
