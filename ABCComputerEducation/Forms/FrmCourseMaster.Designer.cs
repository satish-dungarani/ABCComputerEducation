namespace ABCComputerEducation.Forms
{
    partial class FrmCourseMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCourseMaster));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.TLPMasterValuesList = new System.Windows.Forms.TableLayoutPanel();
            this.GCMasterValues = new DevExpress.XtraGrid.GridControl();
            this.GVMasterValues = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCOLMasterValId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLRefMasterSetup_MasterSetupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLMasterValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLShortValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLMasterDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLOtherValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLEditAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIBEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCOLDeleteAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIBDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.TLPMasterValuesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCMasterValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVMasterValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBDelete)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPMasterValuesList
            // 
            this.TLPMasterValuesList.ColumnCount = 1;
            this.TLPMasterValuesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPMasterValuesList.Controls.Add(this.GCMasterValues, 0, 1);
            this.TLPMasterValuesList.Controls.Add(this.panel1, 0, 0);
            this.TLPMasterValuesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMasterValuesList.Location = new System.Drawing.Point(0, 0);
            this.TLPMasterValuesList.Name = "TLPMasterValuesList";
            this.TLPMasterValuesList.RowCount = 2;
            this.TLPMasterValuesList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLPMasterValuesList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValuesList.Size = new System.Drawing.Size(651, 479);
            this.TLPMasterValuesList.TabIndex = 1;
            // 
            // GCMasterValues
            // 
            this.GCMasterValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCMasterValues.Location = new System.Drawing.Point(3, 43);
            this.GCMasterValues.MainView = this.GVMasterValues;
            this.GCMasterValues.Name = "GCMasterValues";
            this.GCMasterValues.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RIBEdit,
            this.RIBDelete});
            this.GCMasterValues.Size = new System.Drawing.Size(645, 433);
            this.GCMasterValues.TabIndex = 1;
            this.GCMasterValues.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVMasterValues});
            // 
            // GVMasterValues
            // 
            this.GVMasterValues.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCOLMasterValId,
            this.GCOLRefMasterSetup_MasterSetupId,
            this.GCOLMasterValue,
            this.GCOLShortValue,
            this.GCOLMasterDesc,
            this.GCOLOtherValue,
            this.GCOLEditAction,
            this.GCOLDeleteAction});
            this.GVMasterValues.GridControl = this.GCMasterValues;
            this.GVMasterValues.Name = "GVMasterValues";
            this.GVMasterValues.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GVMasterValues.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GVMasterValues.OptionsCustomization.AllowQuickHideColumns = false;
            this.GVMasterValues.OptionsFind.AlwaysVisible = true;
            // 
            // GCOLMasterValId
            // 
            this.GCOLMasterValId.Caption = "MasterValId";
            this.GCOLMasterValId.FieldName = "MasterValId";
            this.GCOLMasterValId.Name = "GCOLMasterValId";
            // 
            // GCOLRefMasterSetup_MasterSetupId
            // 
            this.GCOLRefMasterSetup_MasterSetupId.Caption = "MasterSetupId";
            this.GCOLRefMasterSetup_MasterSetupId.FieldName = "RefMasterSetup_MasterSetupId";
            this.GCOLRefMasterSetup_MasterSetupId.Name = "GCOLRefMasterSetup_MasterSetupId";
            // 
            // GCOLMasterValue
            // 
            this.GCOLMasterValue.Caption = "Course Name";
            this.GCOLMasterValue.FieldName = "MasterValue";
            this.GCOLMasterValue.Name = "GCOLMasterValue";
            this.GCOLMasterValue.OptionsColumn.AllowEdit = false;
            this.GCOLMasterValue.OptionsColumn.AllowFocus = false;
            this.GCOLMasterValue.Visible = true;
            this.GCOLMasterValue.VisibleIndex = 0;
            // 
            // GCOLShortValue
            // 
            this.GCOLShortValue.Caption = "Course Short Name";
            this.GCOLShortValue.FieldName = "ShortValue";
            this.GCOLShortValue.Name = "GCOLShortValue";
            this.GCOLShortValue.OptionsColumn.AllowEdit = false;
            this.GCOLShortValue.OptionsColumn.AllowFocus = false;
            this.GCOLShortValue.Visible = true;
            this.GCOLShortValue.VisibleIndex = 1;
            // 
            // GCOLMasterDesc
            // 
            this.GCOLMasterDesc.Caption = "Description";
            this.GCOLMasterDesc.FieldName = "MasterDesc";
            this.GCOLMasterDesc.Name = "GCOLMasterDesc";
            this.GCOLMasterDesc.OptionsColumn.AllowEdit = false;
            this.GCOLMasterDesc.OptionsColumn.AllowFocus = false;
            this.GCOLMasterDesc.Visible = true;
            this.GCOLMasterDesc.VisibleIndex = 2;
            // 
            // GCOLOtherValue
            // 
            this.GCOLOtherValue.Caption = "Fees";
            this.GCOLOtherValue.FieldName = "OtherValue";
            this.GCOLOtherValue.Name = "GCOLOtherValue";
            this.GCOLOtherValue.OptionsColumn.AllowEdit = false;
            this.GCOLOtherValue.OptionsColumn.AllowFocus = false;
            this.GCOLOtherValue.Visible = true;
            this.GCOLOtherValue.VisibleIndex = 3;
            // 
            // GCOLEditAction
            // 
            this.GCOLEditAction.ColumnEdit = this.RIBEdit;
            this.GCOLEditAction.Name = "GCOLEditAction";
            this.GCOLEditAction.Visible = true;
            this.GCOLEditAction.VisibleIndex = 4;
            // 
            // RIBEdit
            // 
            this.RIBEdit.AutoHeight = false;
            this.RIBEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("RIBEdit.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.RIBEdit.Name = "RIBEdit";
            this.RIBEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.RIBEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RIBEdit_ButtonClick);
            // 
            // GCOLDeleteAction
            // 
            this.GCOLDeleteAction.ColumnEdit = this.RIBDelete;
            this.GCOLDeleteAction.Name = "GCOLDeleteAction";
            this.GCOLDeleteAction.Visible = true;
            this.GCOLDeleteAction.VisibleIndex = 5;
            // 
            // RIBDelete
            // 
            this.RIBDelete.AutoHeight = false;
            this.RIBDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("RIBDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.RIBDelete.Name = "RIBDelete";
            this.RIBDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.RIBDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RIBDelete_ButtonClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 34);
            this.panel1.TabIndex = 2;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Appearance.Options.UseFont = true;
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(525, 0);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(120, 34);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // FrmCourseMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 479);
            this.Controls.Add(this.TLPMasterValuesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCourseMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCourseMaster_Load);
            this.TLPMasterValuesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCMasterValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVMasterValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBDelete)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPMasterValuesList;
        private DevExpress.XtraGrid.GridControl GCMasterValues;
        private DevExpress.XtraGrid.Views.Grid.GridView GVMasterValues;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLMasterValId;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLRefMasterSetup_MasterSetupId;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLMasterValue;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLShortValue;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLMasterDesc;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLEditAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBEdit;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLDeleteAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBDelete;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLOtherValue;


    }
}