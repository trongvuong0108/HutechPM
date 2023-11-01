namespace HutechPM.UI.Components
{
    partial class uc_ListProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_ListProject));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(components);
            gridControlProjects = new DevExpress.XtraGrid.GridControl();
            projectBindingSource = new System.Windows.Forms.BindingSource(components);
            gridViewProjects = new DevExpress.XtraGrid.Views.Grid.GridView();
            projectId = new DevExpress.XtraGrid.Columns.GridColumn();
            projectName = new DevExpress.XtraGrid.Columns.GridColumn();
            datestart = new DevExpress.XtraGrid.Columns.GridColumn();
            owner = new DevExpress.XtraGrid.Columns.GridColumn();
            description = new DevExpress.XtraGrid.Columns.GridColumn();
            quantityTask = new DevExpress.XtraGrid.Columns.GridColumn();
            endDate = new DevExpress.XtraGrid.Columns.GridColumn();
            update = new DevExpress.XtraGrid.Columns.GridColumn();
            ItemButtonUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            delete = new DevExpress.XtraGrid.Columns.GridColumn();
            ItemButtonDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            projectDetailBindingSource = new System.Windows.Forms.BindingSource(components);
            projectTaskBindingSource = new System.Windows.Forms.BindingSource(components);
            buttonCreate = new System.Windows.Forms.Button();
            buttonSelectDelete = new System.Windows.Forms.Button();
            buttonUpdate = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlProjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projectBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewProjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemButtonUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemButtonDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projectDetailBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projectTaskBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // xtraTabbedMdiManager1
            // 
            xtraTabbedMdiManager1.MdiParent = null;
            // 
            // gridControlProjects
            // 
            gridControlProjects.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gridControlProjects.DataSource = projectBindingSource;
            gridControlProjects.Location = new System.Drawing.Point(0, 168);
            gridControlProjects.MainView = gridViewProjects;
            gridControlProjects.Name = "gridControlProjects";
            gridControlProjects.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { ItemButtonDelete });
            gridControlProjects.Size = new System.Drawing.Size(1350, 352);
            gridControlProjects.TabIndex = 0;
            gridControlProjects.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewProjects });
            // 
            // projectBindingSource
            // 
            projectBindingSource.DataSource = typeof(Data.Entities.Project);
            // 
            // gridViewProjects
            // 
            gridViewProjects.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { projectId, projectName, datestart, owner, description, quantityTask, endDate, update, delete });
            gridViewProjects.CustomizationFormBounds = new System.Drawing.Rectangle(1032, 512, 389, 279);
            gridViewProjects.GridControl = gridControlProjects;
            gridViewProjects.Name = "gridViewProjects";
            gridViewProjects.OptionsFind.AlwaysVisible = true;
            gridViewProjects.OptionsSelection.MultiSelect = true;
            gridViewProjects.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            gridViewProjects.FocusedRowChanged += gridViewProjects_FocusedRowChanged;
            // 
            // projectId
            // 
            projectId.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            projectId.AppearanceHeader.Options.UseFont = true;
            projectId.Caption = "ProjectId";
            projectId.FieldName = "projectId";
            projectId.MinWidth = 30;
            projectId.Name = "projectId";
            projectId.Width = 112;
            // 
            // projectName
            // 
            projectName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            projectName.AppearanceHeader.Options.UseFont = true;
            projectName.Caption = "Project Name";
            projectName.FieldName = "projectName";
            projectName.MinWidth = 30;
            projectName.Name = "projectName";
            projectName.OptionsColumn.AllowSize = false;
            projectName.Visible = true;
            projectName.VisibleIndex = 1;
            projectName.Width = 147;
            // 
            // datestart
            // 
            datestart.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            datestart.AppearanceHeader.Options.UseFont = true;
            datestart.Caption = "Start Date";
            datestart.FieldName = "dateStart";
            datestart.MinWidth = 30;
            datestart.Name = "datestart";
            datestart.Visible = true;
            datestart.VisibleIndex = 4;
            datestart.Width = 175;
            // 
            // owner
            // 
            owner.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            owner.AppearanceHeader.Options.UseFont = true;
            owner.Caption = "Owner";
            owner.FieldName = "owner";
            owner.MinWidth = 30;
            owner.Name = "owner";
            owner.Visible = true;
            owner.VisibleIndex = 2;
            owner.Width = 166;
            // 
            // description
            // 
            description.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            description.AppearanceHeader.Options.UseFont = true;
            description.Caption = "Description";
            description.FieldName = "description";
            description.MinWidth = 30;
            description.Name = "description";
            description.Visible = true;
            description.VisibleIndex = 3;
            description.Width = 191;
            // 
            // quantityTask
            // 
            quantityTask.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            quantityTask.AppearanceHeader.Options.UseFont = true;
            quantityTask.Caption = "Quantity Tasks";
            quantityTask.FieldName = "quantityTask";
            quantityTask.MinWidth = 30;
            quantityTask.Name = "quantityTask";
            quantityTask.Visible = true;
            quantityTask.VisibleIndex = 6;
            quantityTask.Width = 292;
            // 
            // endDate
            // 
            endDate.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            endDate.AppearanceHeader.Options.UseFont = true;
            endDate.Caption = "End Date";
            endDate.FieldName = "dateEnd";
            endDate.MinWidth = 30;
            endDate.Name = "endDate";
            endDate.Visible = true;
            endDate.VisibleIndex = 5;
            endDate.Width = 166;
            // 
            // update
            // 
            update.ColumnEdit = ItemButtonUpdate;
            update.MaxWidth = 50;
            update.MinWidth = 30;
            update.Name = "update";
            update.Visible = true;
            update.VisibleIndex = 7;
            update.Width = 50;
            // 
            // ItemButtonUpdate
            // 
            ItemButtonUpdate.AutoHeight = false;
            editorButtonImageOptions1.Image = (System.Drawing.Image)resources.GetObject("editorButtonImageOptions1.Image");
            ItemButtonUpdate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            ItemButtonUpdate.Name = "ItemButtonUpdate";
            ItemButtonUpdate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // delete
            // 
            delete.ColumnEdit = ItemButtonDelete;
            delete.MaxWidth = 50;
            delete.MinWidth = 30;
            delete.Name = "delete";
            delete.Visible = true;
            delete.VisibleIndex = 8;
            delete.Width = 50;
            // 
            // ItemButtonDelete
            // 
            ItemButtonDelete.AutoHeight = false;
            editorButtonImageOptions2.Image = (System.Drawing.Image)resources.GetObject("editorButtonImageOptions2.Image");
            ItemButtonDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            ItemButtonDelete.Name = "ItemButtonDelete";
            ItemButtonDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // projectDetailBindingSource
            // 
            projectDetailBindingSource.DataSource = typeof(Data.Entities.ProjectDetail);
            // 
            // projectTaskBindingSource
            // 
            projectTaskBindingSource.DataSource = typeof(Data.Entities.ProjectTask);
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonCreate.BackColor = System.Drawing.Color.White;
            buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonCreate.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            buttonCreate.Location = new System.Drawing.Point(783, 98);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new System.Drawing.Size(140, 50);
            buttonCreate.TabIndex = 1;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonSelectDelete
            // 
            buttonSelectDelete.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonSelectDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonSelectDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSelectDelete.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            buttonSelectDelete.Location = new System.Drawing.Point(1177, 98);
            buttonSelectDelete.Name = "buttonSelectDelete";
            buttonSelectDelete.Size = new System.Drawing.Size(140, 50);
            buttonSelectDelete.TabIndex = 2;
            buttonSelectDelete.Text = "Delete";
            buttonSelectDelete.UseVisualStyleBackColor = true;
            buttonSelectDelete.Click += buttonSelectDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonUpdate.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            buttonUpdate.Location = new System.Drawing.Point(981, 98);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(140, 50);
            buttonUpdate.TabIndex = 3;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.BackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(0, 520);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1350, 56);
            label1.TabIndex = 5;
            label1.Text = "Project";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Workflow2;
            pictureBox1.Location = new System.Drawing.Point(8, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(80, 80);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 52;
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
            label7.TabIndex = 51;
            label7.Text = "Workflow";
            // 
            // uc_ListProject
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonSelectDelete);
            Controls.Add(buttonCreate);
            Controls.Add(gridControlProjects);
            Name = "uc_ListProject";
            Size = new System.Drawing.Size(1350, 576);
            Load += uc_ListProject_Load;
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlProjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)projectBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewProjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemButtonUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemButtonDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)projectDetailBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)projectTaskBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraGrid.GridControl gridControlProjects;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProjects;
        private System.Windows.Forms.BindingSource projectTaskBindingSource;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource projectDetailBindingSource;


        private DevExpress.XtraGrid.Columns.GridColumn datestart;
        private DevExpress.XtraGrid.Columns.GridColumn quantityTask;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSelectDelete;

        private DevExpress.XtraGrid.Columns.GridColumn projectId;
        private DevExpress.XtraGrid.Columns.GridColumn projectName;
        private DevExpress.XtraGrid.Columns.GridColumn owner;
        private DevExpress.XtraGrid.Columns.GridColumn endDate;
        private DevExpress.XtraGrid.Columns.GridColumn description;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.Columns.GridColumn update;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonDelete;
    }
}
