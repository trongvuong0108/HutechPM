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
            projectName = new DevExpress.XtraGrid.Columns.GridColumn();
            owner = new DevExpress.XtraGrid.Columns.GridColumn();
            description = new DevExpress.XtraGrid.Columns.GridColumn();
            datestart = new DevExpress.XtraGrid.Columns.GridColumn();
            quantityTask = new DevExpress.XtraGrid.Columns.GridColumn();
            isActive = new DevExpress.XtraGrid.Columns.GridColumn();
            update = new DevExpress.XtraGrid.Columns.GridColumn();
            buttonUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            delete = new DevExpress.XtraGrid.Columns.GridColumn();
            buttonDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            projectDetailBindingSource = new System.Windows.Forms.BindingSource(components);
            projectTaskBindingSource = new System.Windows.Forms.BindingSource(components);
            buttonUpdatee = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            buttonCreate = new System.Windows.Forms.Button();
            buttonSelectDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlProjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projectBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewProjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projectDetailBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projectTaskBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonUpdatee).BeginInit();
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
            gridControlProjects.Location = new System.Drawing.Point(-3, 169);
            gridControlProjects.MainView = gridViewProjects;
            gridControlProjects.Name = "gridControlProjects";
            gridControlProjects.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { buttonUpdate, buttonDelete });
            gridControlProjects.Size = new System.Drawing.Size(1364, 793);
            gridControlProjects.TabIndex = 0;
            gridControlProjects.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewProjects });
            gridControlProjects.Click += gridControlProjects_Click;
            // 
            // projectBindingSource
            // 
            projectBindingSource.DataSource = typeof(Data.Entities.Project);
            // 
            // gridViewProjects
            // 
            gridViewProjects.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { projectName, owner, description, datestart, quantityTask, isActive, update, delete });
            gridViewProjects.GridControl = gridControlProjects;
            gridViewProjects.Name = "gridViewProjects";
            gridViewProjects.OptionsSelection.MultiSelect = true;
            gridViewProjects.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            gridViewProjects.InitNewRow += gridViewProjects_InitNewRow;
            // 
            // projectName
            // 
            projectName.Caption = "ProjectName";
            projectName.FieldName = "projectName";
            projectName.MinWidth = 30;
            projectName.Name = "projectName";
            projectName.Visible = true;
            projectName.VisibleIndex = 1;
            projectName.Width = 112;
            // 
            // owner
            // 
            owner.Caption = "Owner";
            owner.FieldName = "owner";
            owner.MinWidth = 30;
            owner.Name = "owner";
            owner.Visible = true;
            owner.VisibleIndex = 2;
            owner.Width = 112;
            // 
            // description
            // 
            description.Caption = "Description";
            description.FieldName = "description";
            description.MinWidth = 30;
            description.Name = "description";
            description.Visible = true;
            description.VisibleIndex = 3;
            description.Width = 112;
            // 
            // datestart
            // 
            datestart.Caption = "Start Date";
            datestart.FieldName = "dateStart";
            datestart.MinWidth = 30;
            datestart.Name = "datestart";
            datestart.Visible = true;
            datestart.VisibleIndex = 4;
            datestart.Width = 112;
            // 
            // quantityTask
            // 
            quantityTask.Caption = "Quantity Task";
            quantityTask.FieldName = "quantityTask";
            quantityTask.MinWidth = 30;
            quantityTask.Name = "quantityTask";
            quantityTask.Visible = true;
            quantityTask.VisibleIndex = 5;
            quantityTask.Width = 112;
            // 
            // isActive
            // 
            isActive.Caption = "is Active";
            isActive.FieldName = "isActive";
            isActive.MinWidth = 30;
            isActive.Name = "isActive";
            isActive.Visible = true;
            isActive.VisibleIndex = 6;
            isActive.Width = 112;
            // 
            // update
            // 
            update.ColumnEdit = buttonUpdate;
            update.MaxWidth = 50;
            update.MinWidth = 30;
            update.Name = "update";
            update.Visible = true;
            update.VisibleIndex = 7;
            update.Width = 50;
            // 
            // buttonUpdate
            // 
            buttonUpdate.AutoHeight = false;
            editorButtonImageOptions1.Image = (System.Drawing.Image)resources.GetObject("editorButtonImageOptions1.Image");
            buttonUpdate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // delete
            // 
            delete.ColumnEdit = buttonDelete;
            delete.MaxWidth = 50;
            delete.MinWidth = 30;
            delete.Name = "delete";
            delete.Visible = true;
            delete.VisibleIndex = 8;
            delete.Width = 50;
            // 
            // buttonDelete
            // 
            buttonDelete.AutoHeight = false;
            editorButtonImageOptions2.Image = (System.Drawing.Image)resources.GetObject("editorButtonImageOptions2.Image");
            buttonDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            buttonDelete.Name = "buttonDelete";
            buttonDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // projectDetailBindingSource
            // 
            projectDetailBindingSource.DataSource = typeof(Data.Entities.ProjectDetail);
            // 
            // projectTaskBindingSource
            // 
            projectTaskBindingSource.DataSource = typeof(Data.Entities.ProjectTask);
            // 
            // buttonUpdatee
            // 
            buttonUpdatee.AutoHeight = false;
            buttonUpdatee.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            buttonUpdatee.Name = "buttonUpdatee";
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonCreate.Location = new System.Drawing.Point(1039, 81);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new System.Drawing.Size(109, 45);
            buttonCreate.TabIndex = 1;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonSelectDelete
            // 
            buttonSelectDelete.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonSelectDelete.Location = new System.Drawing.Point(1201, 81);
            buttonSelectDelete.Name = "buttonSelectDelete";
            buttonSelectDelete.Size = new System.Drawing.Size(110, 45);
            buttonSelectDelete.TabIndex = 2;
            buttonSelectDelete.Text = "Delete";
            buttonSelectDelete.UseVisualStyleBackColor = true;
            // 
            // uc_ListProject
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            AutoSize = true;
            Controls.Add(buttonSelectDelete);
            Controls.Add(buttonCreate);
            Controls.Add(gridControlProjects);
            Name = "uc_ListProject";
            Size = new System.Drawing.Size(1361, 965);
            Load += uc_ListProject_Load;
            ((System.ComponentModel.ISupportInitialize)xtraTabbedMdiManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlProjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)projectBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewProjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)projectDetailBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)projectTaskBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonUpdatee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraGrid.GridControl gridControlProjects;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProjects;
        private System.Windows.Forms.BindingSource projectTaskBindingSource;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource projectDetailBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn projectName;
        private DevExpress.XtraGrid.Columns.GridColumn owner;
        private DevExpress.XtraGrid.Columns.GridColumn description;
        private DevExpress.XtraGrid.Columns.GridColumn datestart;
        private DevExpress.XtraGrid.Columns.GridColumn quantityTask;
        private DevExpress.XtraGrid.Columns.GridColumn isActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit buttonUpdatee;
        private DevExpress.XtraGrid.Columns.GridColumn update;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit buttonUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit buttonDelete;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSelectDelete;
    }
}
