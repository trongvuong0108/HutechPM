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
            userId = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            userBindingSource = new System.Windows.Forms.BindingSource(components);
            buttonAddMenber = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label7 = new System.Windows.Forms.Label();
            labelProject = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)gridControlEmployess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewEmployess).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemImageEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gridControlEmployess
            // 
            gridControlEmployess.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gridControlEmployess.Location = new System.Drawing.Point(0, 168);
            gridControlEmployess.MainView = gridViewEmployess;
            gridControlEmployess.Name = "gridControlEmployess";
            gridControlEmployess.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemImageEdit1 });
            gridControlEmployess.Size = new System.Drawing.Size(1350, 355);
            gridControlEmployess.TabIndex = 0;
            gridControlEmployess.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewEmployess });
            // 
            // gridViewEmployess
            // 
            gridViewEmployess.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { userName, gender, email, role, quantityTask, userId });
            gridViewEmployess.GridControl = gridControlEmployess;
            gridViewEmployess.Name = "gridViewEmployess";
            gridViewEmployess.OptionsSelection.MultiSelect = true;
            gridViewEmployess.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            // 
            // userName
            // 
            userName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            userName.AppearanceHeader.Options.UseFont = true;
            userName.Caption = "User Name";
            userName.FieldName = "userName";
            userName.MinWidth = 30;
            userName.Name = "userName";
            userName.Visible = true;
            userName.VisibleIndex = 1;
            userName.Width = 112;
            // 
            // gender
            // 
            gender.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gender.AppearanceHeader.Options.UseFont = true;
            gender.Caption = "Gender";
            gender.FieldName = "genderDTO";
            gender.MinWidth = 30;
            gender.Name = "gender";
            gender.Visible = true;
            gender.VisibleIndex = 2;
            gender.Width = 112;
            // 
            // email
            // 
            email.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            email.AppearanceHeader.Options.UseFont = true;
            email.Caption = "Email";
            email.FieldName = "email";
            email.MinWidth = 30;
            email.Name = "email";
            email.Visible = true;
            email.VisibleIndex = 3;
            email.Width = 112;
            // 
            // role
            // 
            role.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            role.AppearanceHeader.Options.UseFont = true;
            role.Caption = "Role";
            role.FieldName = "projectRole";
            role.MinWidth = 30;
            role.Name = "role";
            role.Visible = true;
            role.VisibleIndex = 4;
            role.Width = 112;
            // 
            // quantityTask
            // 
            quantityTask.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            quantityTask.AppearanceHeader.Options.UseFont = true;
            quantityTask.Caption = "Quantity Task";
            quantityTask.FieldName = "quantityTask";
            quantityTask.MinWidth = 30;
            quantityTask.Name = "quantityTask";
            quantityTask.Visible = true;
            quantityTask.VisibleIndex = 5;
            quantityTask.Width = 112;
            // 
            // userId
            // 
            userId.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            userId.AppearanceHeader.Options.UseFont = true;
            userId.Caption = "userId";
            userId.FieldName = "userId";
            userId.MinWidth = 30;
            userId.Name = "userId";
            userId.Width = 112;
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
            // buttonAddMenber
            // 
            buttonAddMenber.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonAddMenber.AutoSize = true;
            buttonAddMenber.BackColor = System.Drawing.Color.White;
            buttonAddMenber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAddMenber.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonAddMenber.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            buttonAddMenber.Location = new System.Drawing.Point(981, 98);
            buttonAddMenber.Name = "buttonAddMenber";
            buttonAddMenber.Size = new System.Drawing.Size(143, 50);
            buttonAddMenber.TabIndex = 6;
            buttonAddMenber.Text = "Add";
            buttonAddMenber.UseVisualStyleBackColor = false;
            buttonAddMenber.Click += buttonAddMenber_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonDelete.AutoSize = true;
            buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonDelete.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            buttonDelete.Location = new System.Drawing.Point(1177, 98);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(140, 50);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Workflow2;
            pictureBox1.Location = new System.Drawing.Point(8, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(80, 80);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label7.Location = new System.Drawing.Point(94, 6);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(289, 74);
            label7.TabIndex = 57;
            label7.Text = "Workflow";
            // 
            // labelProject
            // 
            labelProject.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelProject.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            labelProject.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelProject.ForeColor = System.Drawing.Color.White;
            labelProject.Location = new System.Drawing.Point(0, 521);
            labelProject.Name = "labelProject";
            labelProject.Size = new System.Drawing.Size(1350, 55);
            labelProject.TabIndex = 56;
            labelProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelProject.Click += label1_Click;
            // 
            // uc_ListEmployess
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(labelProject);
            Controls.Add(buttonAddMenber);
            Controls.Add(buttonDelete);
            Controls.Add(gridControlEmployess);
            Name = "uc_ListEmployess";
            Size = new System.Drawing.Size(1350, 576);
            Load += uc_ListEmployess_Load;
            ((System.ComponentModel.ISupportInitialize)gridControlEmployess).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewEmployess).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemImageEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private System.Windows.Forms.Button buttonAddMenber;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn quantityTask;
        private DevExpress.XtraGrid.Columns.GridColumn projectName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelProject;
        private DevExpress.XtraGrid.Columns.GridColumn userId;
    }
}
