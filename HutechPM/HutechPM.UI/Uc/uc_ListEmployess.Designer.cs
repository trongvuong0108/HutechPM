namespace HutechPM.UI.Uc
{
    partial class uc_ListEmployess
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
            gridControlEmployess = new DevExpress.XtraGrid.GridControl();
            gridViewEmployess = new DevExpress.XtraGrid.Views.Grid.GridView();
            userName = new DevExpress.XtraGrid.Columns.GridColumn();
            gender = new DevExpress.XtraGrid.Columns.GridColumn();
            email = new DevExpress.XtraGrid.Columns.GridColumn();
            role = new DevExpress.XtraGrid.Columns.GridColumn();
            quantityTask = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            userBindingSource = new System.Windows.Forms.BindingSource(components);
            buttonCreate = new System.Windows.Forms.Button();
            buttonSelectDelete = new System.Windows.Forms.Button();
            projectName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)gridControlEmployess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewEmployess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemImageEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gridControlEmployess
            // 
            gridControlEmployess.Location = new System.Drawing.Point(0, 148);
            gridControlEmployess.MainView = gridViewEmployess;
            gridControlEmployess.Name = "gridControlEmployess";
            gridControlEmployess.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemImageEdit1 });
            gridControlEmployess.Size = new System.Drawing.Size(1335, 574);
            gridControlEmployess.TabIndex = 0;
            gridControlEmployess.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewEmployess });
            // 
            // gridViewEmployess
            // 
            gridViewEmployess.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { userName, gender, email, role, quantityTask, projectName });
            gridViewEmployess.GridControl = gridControlEmployess;
            gridViewEmployess.Name = "gridViewEmployess";
            // 
            // userName
            // 
            userName.Caption = "User Name";
            userName.FieldName = "userName";
            userName.MinWidth = 30;
            userName.Name = "userName";
            userName.Visible = true;
            userName.VisibleIndex = 0;
            userName.Width = 112;
            // 
            // gender
            // 
            gender.Caption = "Gender";
            gender.FieldName = "genderDTO";
            gender.MinWidth = 30;
            gender.Name = "gender";
            gender.Visible = true;
            gender.VisibleIndex = 1;
            gender.Width = 112;
            // 
            // email
            // 
            email.Caption = "Email";
            email.FieldName = "email";
            email.MinWidth = 30;
            email.Name = "email";
            email.Visible = true;
            email.VisibleIndex = 2;
            email.Width = 112;
            // 
            // role
            // 
            role.Caption = "Role";
            role.FieldName = "projectRole";
            role.MinWidth = 30;
            role.Name = "role";
            role.Visible = true;
            role.VisibleIndex = 3;
            role.Width = 112;
            // 
            // quantityTask
            // 
            quantityTask.Caption = "Quantity Task";
            quantityTask.FieldName = "quantityTask";
            quantityTask.MinWidth = 30;
            quantityTask.Name = "quantityTask";
            quantityTask.Visible = true;
            quantityTask.VisibleIndex = 4;
            quantityTask.Width = 112;
            // 
            // repositoryItemImageEdit1
            // 
            repositoryItemImageEdit1.AutoHeight = false;
            repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Data.Entities.User);
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonCreate.AutoSize = true;
            buttonCreate.BackColor = System.Drawing.Color.White;
            buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonCreate.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            buttonCreate.Location = new System.Drawing.Point(39, 62);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new System.Drawing.Size(143, 50);
            buttonCreate.TabIndex = 6;
            buttonCreate.Text = "Add";
            buttonCreate.UseVisualStyleBackColor = false;
            // 
            // buttonSelectDelete
            // 
            buttonSelectDelete.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonSelectDelete.AutoSize = true;
            buttonSelectDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSelectDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSelectDelete.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            buttonSelectDelete.Location = new System.Drawing.Point(255, 62);
            buttonSelectDelete.Name = "buttonSelectDelete";
            buttonSelectDelete.Size = new System.Drawing.Size(140, 50);
            buttonSelectDelete.TabIndex = 5;
            buttonSelectDelete.Text = "Delete";
            buttonSelectDelete.UseVisualStyleBackColor = true;
            // 
            // projectName
            // 
            projectName.Caption = "Project Name";
            projectName.FieldName = "projectName";
            projectName.MinWidth = 30;
            projectName.Name = "projectName";
            projectName.Visible = true;
            projectName.VisibleIndex = 5;
            projectName.Width = 112;
            // 
            // uc_ListEmployess
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(buttonCreate);
            Controls.Add(buttonSelectDelete);
            Controls.Add(gridControlEmployess);
            Name = "uc_ListEmployess";
            Size = new System.Drawing.Size(1335, 722);
            Load += uc_ListEmployess_Load;
            ((System.ComponentModel.ISupportInitialize)gridControlEmployess).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewEmployess).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemImageEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlEmployess;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmployess;
        private DevExpress.XtraGrid.Columns.GridColumn userName;
        private DevExpress.XtraGrid.Columns.GridColumn gender;
        private DevExpress.XtraGrid.Columns.GridColumn email;
        private DevExpress.XtraGrid.Columns.GridColumn role;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSelectDelete;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn quantityTask;
        private DevExpress.XtraGrid.Columns.GridColumn projectName;
    }
}
