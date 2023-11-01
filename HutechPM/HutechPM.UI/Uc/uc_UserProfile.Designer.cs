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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_UserProfile));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
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
            update = new DevExpress.XtraGrid.Columns.GridColumn();
            ItemButtonUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlUserProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewUserProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemButtonUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            gridControlUserProfile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gridControlUserProfile.DataSource = userBindingSource2;
            gridControlUserProfile.Location = new System.Drawing.Point(0, 121);
            gridControlUserProfile.MainView = gridViewUserProfile;
            gridControlUserProfile.Name = "gridControlUserProfile";
            gridControlUserProfile.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { ItemButtonUpdate });
            gridControlUserProfile.Size = new System.Drawing.Size(1350, 395);
            gridControlUserProfile.TabIndex = 0;
            gridControlUserProfile.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewUserProfile });
            // 
            // userBindingSource2
            // 
            userBindingSource2.DataSource = typeof(Data.Entities.User);
            // 
            // gridViewUserProfile
            // 
            gridViewUserProfile.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { coluserId, coluserName, colemail, colphone, colpassword, colfullName, coladdress, colgender, colisActive, colavatar, update });
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
            coluserName.VisibleIndex = 1;
            coluserName.Width = 112;
            // 
            // colemail
            // 
            colemail.Caption = "Email";
            colemail.FieldName = "email";
            colemail.MinWidth = 30;
            colemail.Name = "colemail";
            colemail.Visible = true;
            colemail.VisibleIndex = 2;
            colemail.Width = 112;
            // 
            // colphone
            // 
            colphone.Caption = "Phone";
            colphone.FieldName = "phone";
            colphone.MinWidth = 30;
            colphone.Name = "colphone";
            colphone.Visible = true;
            colphone.VisibleIndex = 3;
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
            colfullName.VisibleIndex = 4;
            colfullName.Width = 112;
            // 
            // coladdress
            // 
            coladdress.Caption = "Address";
            coladdress.FieldName = "address";
            coladdress.MinWidth = 30;
            coladdress.Name = "coladdress";
            coladdress.Visible = true;
            coladdress.VisibleIndex = 5;
            coladdress.Width = 112;
            // 
            // colgender
            // 
            colgender.Caption = "Gender";
            colgender.FieldName = "genderDTO";
            colgender.MinWidth = 30;
            colgender.Name = "colgender";
            colgender.Visible = true;
            colgender.VisibleIndex = 6;
            colgender.Width = 112;
            // 
            // colisActive
            // 
            colisActive.Caption = "Is Active";
            colisActive.FieldName = "isActive";
            colisActive.MinWidth = 30;
            colisActive.Name = "colisActive";
            colisActive.Visible = true;
            colisActive.VisibleIndex = 7;
            colisActive.Width = 112;
            // 
            // colavatar
            // 
            colavatar.Caption = "Avatar";
            colavatar.FieldName = "avatar";
            colavatar.MinWidth = 30;
            colavatar.Name = "colavatar";
            colavatar.Width = 112;
            // 
            // update
            // 
            update.ColumnEdit = ItemButtonUpdate;
            update.MinWidth = 30;
            update.Name = "update";
            update.Visible = true;
            update.VisibleIndex = 0;
            update.Width = 112;
            // 
            // ItemButtonUpdate
            // 
            ItemButtonUpdate.AutoHeight = false;
            editorButtonImageOptions1.Image = (System.Drawing.Image)resources.GetObject("editorButtonImageOptions1.Image");
            ItemButtonUpdate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            ItemButtonUpdate.Name = "ItemButtonUpdate";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Workflow2;
            pictureBox1.Location = new System.Drawing.Point(8, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(80, 80);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(0, 513);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1350, 63);
            label1.TabIndex = 57;
            label1.Tag = "Profile ";
            label1.Text = "Profile";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label7.Location = new System.Drawing.Point(94, 21);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(289, 74);
            label7.TabIndex = 58;
            label7.Text = "Workflow";
            // 
            // uc_UserProfile
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(gridControlUserProfile);
            Name = "uc_UserProfile";
            Size = new System.Drawing.Size(1350, 576);
            Load += uc_UserProfile_Load;
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlUserProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewUserProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemButtonUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.Columns.GridColumn update;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonUpdate;
    }
}
