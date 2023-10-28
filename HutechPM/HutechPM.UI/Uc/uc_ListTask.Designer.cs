namespace HutechPM.UI.Uc
{
    partial class uc_ListTask
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_ListTask));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            gridViewTask = new DevExpress.XtraGrid.Views.Grid.GridView();
            taskName = new DevExpress.XtraGrid.Columns.GridColumn();
            owner = new DevExpress.XtraGrid.Columns.GridColumn();
            gridControlListProject = new DevExpress.XtraGrid.GridControl();
            projectTaskBindingSource = new System.Windows.Forms.BindingSource(components);
            gridViewProject = new DevExpress.XtraGrid.Views.Grid.GridView();
            ProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            ButtonDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            description = new DevExpress.XtraGrid.Columns.GridColumn();
            estimate = new DevExpress.XtraGrid.Columns.GridColumn();
            remaining = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)gridViewTask).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlListProject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projectTaskBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewProject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ButtonDelete).BeginInit();
            SuspendLayout();
            // 
            // gridViewTask
            // 
            gridViewTask.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { taskName, owner, description, estimate, remaining });
            gridViewTask.GridControl = gridControlListProject;
            gridViewTask.Name = "gridViewTask";
            // 
            // taskName
            // 
            taskName.Caption = "TaskName";
            taskName.FieldName = "name";
            taskName.MinWidth = 30;
            taskName.Name = "taskName";
            taskName.Visible = true;
            taskName.VisibleIndex = 0;
            taskName.Width = 112;
            // 
            // owner
            // 
            owner.Caption = "Owner";
            owner.MinWidth = 30;
            owner.Name = "owner";
            owner.Visible = true;
            owner.VisibleIndex = 1;
            owner.Width = 112;
            // 
            // gridControlListProject
            // 
            gridControlListProject.DataSource = projectTaskBindingSource;
            gridLevelNode1.LevelTemplate = gridViewTask;
            gridLevelNode1.RelationName = "Task";
            gridControlListProject.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] { gridLevelNode1 });
            gridControlListProject.Location = new System.Drawing.Point(3, 15);
            gridControlListProject.MainView = gridViewProject;
            gridControlListProject.Name = "gridControlListProject";
            gridControlListProject.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { ButtonDelete });
            gridControlListProject.Size = new System.Drawing.Size(1382, 854);
            gridControlListProject.TabIndex = 1;
            gridControlListProject.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewProject, gridViewTask });
            gridControlListProject.Click += gridControlListProject_Click;
            // 
            // projectTaskBindingSource
            // 
            projectTaskBindingSource.DataSource = typeof(Data.Entities.ProjectTask);
            // 
            // gridViewProject
            // 
            gridViewProject.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { ProjectName });
            gridViewProject.GridControl = gridControlListProject;
            gridViewProject.Name = "gridViewProject";
            gridViewProject.MasterRowEmpty += gridViewProject_MasterRowEmpty;
            gridViewProject.MasterRowGetChildList += gridViewProject_MasterRowGetChildList;
            gridViewProject.MasterRowGetRelationName += gridViewProject_MasterRowGetRelationName;
            gridViewProject.MasterRowGetRelationCount += gridViewProject_MasterRowGetRelationCount;
            // 
            // ProjectName
            // 
            ProjectName.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ProjectName.AppearanceCell.Options.UseFont = true;
            ProjectName.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ProjectName.AppearanceHeader.Options.UseFont = true;
            ProjectName.Caption = "ProjectName";
            ProjectName.FieldName = "projectName";
            ProjectName.MinWidth = 30;
            ProjectName.Name = "ProjectName";
            ProjectName.OptionsColumn.AllowEdit = false;
            ProjectName.Visible = true;
            ProjectName.VisibleIndex = 0;
            ProjectName.Width = 112;
            // 
            // ButtonDelete
            // 
            ButtonDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = (System.Drawing.Image)resources.GetObject("editorButtonImageOptions1.Image");
            ButtonDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // description
            // 
            description.Caption = "Description";
            description.FieldName = "description";
            description.MinWidth = 30;
            description.Name = "description";
            description.Visible = true;
            description.VisibleIndex = 2;
            description.Width = 112;
            // 
            // estimate
            // 
            estimate.Caption = "Estimate";
            estimate.FieldName = "estimate";
            estimate.MinWidth = 30;
            estimate.Name = "estimate";
            estimate.Visible = true;
            estimate.VisibleIndex = 3;
            estimate.Width = 112;
            // 
            // remaining
            // 
            remaining.Caption = "Remaining";
            remaining.FieldName = "remaining";
            remaining.MinWidth = 30;
            remaining.Name = "remaining";
            remaining.Visible = true;
            remaining.VisibleIndex = 4;
            remaining.Width = 112;
            // 
            // uc_ListTask
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gridControlListProject);
            Name = "uc_ListTask";
            Size = new System.Drawing.Size(1388, 872);
            Load += uc_ListTask_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewTask).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlListProject).EndInit();
            ((System.ComponentModel.ISupportInitialize)projectTaskBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewProject).EndInit();
            ((System.ComponentModel.ISupportInitialize)ButtonDelete).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlListProject;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTask;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProject;
        private DevExpress.XtraGrid.Columns.GridColumn ProjectName;
        private System.Windows.Forms.BindingSource projectTaskBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ButtonDelete;
        private DevExpress.XtraGrid.Columns.GridColumn taskName;
        private DevExpress.XtraGrid.Columns.GridColumn owner;
        private DevExpress.XtraGrid.Columns.GridColumn description;
        private DevExpress.XtraGrid.Columns.GridColumn estimate;
        private DevExpress.XtraGrid.Columns.GridColumn remaining;
    }
}
