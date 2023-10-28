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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_ListTask));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            gridControlGridTask = new DevExpress.XtraGrid.GridControl();
            gridViewTask = new DevExpress.XtraGrid.Views.Grid.GridView();
            projectTaskBindingSource = new System.Windows.Forms.BindingSource(components);
            projectTaskBindingSource1 = new System.Windows.Forms.BindingSource(components);
            projectName = new DevExpress.XtraGrid.Columns.GridColumn();
            taskName = new DevExpress.XtraGrid.Columns.GridColumn();
            owner = new DevExpress.XtraGrid.Columns.GridColumn();
            description = new DevExpress.XtraGrid.Columns.GridColumn();
            estimate = new DevExpress.XtraGrid.Columns.GridColumn();
            remaining = new DevExpress.XtraGrid.Columns.GridColumn();
            taskStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            update = new DevExpress.XtraGrid.Columns.GridColumn();
            delete = new DevExpress.XtraGrid.Columns.GridColumn();
            uploadFile = new DevExpress.XtraGrid.Columns.GridColumn();
            ItemButtonUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ItemButtonDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ItemButtonuploadFile = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)gridControlGridTask).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewTask).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projectTaskBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)projectTaskBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemButtonUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemButtonDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ItemButtonuploadFile).BeginInit();
            SuspendLayout();
            // 
            // gridControlGridTask
            // 
            gridControlGridTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gridControlGridTask.DataSource = projectTaskBindingSource1;
            gridControlGridTask.Location = new System.Drawing.Point(3, 67);
            gridControlGridTask.MainView = gridViewTask;
            gridControlGridTask.Name = "gridControlGridTask";
            gridControlGridTask.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { ItemButtonUpdate, ItemButtonDelete, ItemButtonuploadFile });
            gridControlGridTask.Size = new System.Drawing.Size(1427, 712);
            gridControlGridTask.TabIndex = 0;
            gridControlGridTask.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewTask });
            // 
            // gridViewTask
            // 
            gridViewTask.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { projectName, taskName, owner, description, estimate, remaining, taskStatus, update, delete, uploadFile });
            gridViewTask.GridControl = gridControlGridTask;
            gridViewTask.Name = "gridViewTask";
            // 
            // projectTaskBindingSource
            // 
            projectTaskBindingSource.DataSource = typeof(Data.Entities.ProjectTask);
            // 
            // projectTaskBindingSource1
            // 
            projectTaskBindingSource1.DataSource = typeof(Data.Entities.ProjectTask);
            // 
            // projectName
            // 
            projectName.AccessibleName = "";
            projectName.Caption = "ProjectName";
            projectName.FieldName = "projectDetail.project.projectName";
            projectName.MinWidth = 30;
            projectName.Name = "projectName";
            projectName.Visible = true;
            projectName.VisibleIndex = 0;
            projectName.Width = 112;
            // 
            // taskName
            // 
            taskName.Caption = "TaskName";
            taskName.FieldName = "name";
            taskName.MinWidth = 30;
            taskName.Name = "taskName";
            taskName.Visible = true;
            taskName.VisibleIndex = 1;
            taskName.Width = 112;
            // 
            // owner
            // 
            owner.Caption = "Owner";
            owner.FieldName = "projectDetail.user.userName";
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
            // estimate
            // 
            estimate.Caption = "Estimate";
            estimate.FieldName = "estimate";
            estimate.MinWidth = 30;
            estimate.Name = "estimate";
            estimate.Visible = true;
            estimate.VisibleIndex = 4;
            estimate.Width = 112;
            // 
            // remaining
            // 
            remaining.Caption = "Remaining";
            remaining.FieldName = "remaining";
            remaining.MinWidth = 30;
            remaining.Name = "remaining";
            remaining.Visible = true;
            remaining.VisibleIndex = 5;
            remaining.Width = 112;
            // 
            // taskStatus
            // 
            taskStatus.Caption = "Status";
            taskStatus.FieldName = "taskStatus";
            taskStatus.MinWidth = 30;
            taskStatus.Name = "taskStatus";
            taskStatus.Visible = true;
            taskStatus.VisibleIndex = 6;
            taskStatus.Width = 50;
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
            // uploadFile
            // 
            uploadFile.ColumnEdit = ItemButtonuploadFile;
            uploadFile.MaxWidth = 50;
            uploadFile.MinWidth = 30;
            uploadFile.Name = "uploadFile";
            uploadFile.Visible = true;
            uploadFile.VisibleIndex = 9;
            uploadFile.Width = 50;
            // 
            // ItemButtonUpdate
            // 
            ItemButtonUpdate.AutoHeight = false;
            editorButtonImageOptions1.Image = (System.Drawing.Image)resources.GetObject("editorButtonImageOptions1.Image");
            ItemButtonUpdate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            ItemButtonUpdate.Name = "ItemButtonUpdate";
            ItemButtonUpdate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // ItemButtonDelete
            // 
            ItemButtonDelete.AutoHeight = false;
            editorButtonImageOptions2.Image = (System.Drawing.Image)resources.GetObject("editorButtonImageOptions2.Image");
            ItemButtonDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            ItemButtonDelete.Name = "ItemButtonDelete";
            ItemButtonDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // ItemButtonuploadFile
            // 
            ItemButtonuploadFile.AutoHeight = false;
            editorButtonImageOptions3.Image = (System.Drawing.Image)resources.GetObject("editorButtonImageOptions3.Image");
            ItemButtonuploadFile.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            ItemButtonuploadFile.Name = "ItemButtonuploadFile";
            ItemButtonuploadFile.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // uc_ListTask
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gridControlGridTask);
            Name = "uc_ListTask";
            Size = new System.Drawing.Size(1430, 779);
            Load += uc_ListTask_Load;
            ((System.ComponentModel.ISupportInitialize)gridControlGridTask).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewTask).EndInit();
            ((System.ComponentModel.ISupportInitialize)projectTaskBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)projectTaskBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemButtonUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemButtonDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)ItemButtonuploadFile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlGridTask;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTask;
        private System.Windows.Forms.BindingSource projectTaskBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn projectName;
        private DevExpress.XtraGrid.Columns.GridColumn taskName;
        private DevExpress.XtraGrid.Columns.GridColumn owner;
        private DevExpress.XtraGrid.Columns.GridColumn description;
        private DevExpress.XtraGrid.Columns.GridColumn estimate;
        private DevExpress.XtraGrid.Columns.GridColumn remaining;
        private DevExpress.XtraGrid.Columns.GridColumn taskStatus;
        private DevExpress.XtraGrid.Columns.GridColumn update;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonUpdate;
        private DevExpress.XtraGrid.Columns.GridColumn delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonDelete;
        private DevExpress.XtraGrid.Columns.GridColumn uploadFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonuploadFile;
        private System.Windows.Forms.BindingSource projectTaskBindingSource;
    }
}
