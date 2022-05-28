namespace ABCComputerEducation.Forms
{
    partial class FrmEnquiryMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnquiryMaster));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.TLPMasterValuesList = new System.Windows.Forms.TableLayoutPanel();
            this.GCEnquiryMaster = new DevExpress.XtraGrid.GridControl();
            this.GVEnquiryMaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCOLEnquiryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLSrNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLStudentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLContactNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLEmailId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLRefMasterValues_CourseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLInstitution = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLCourseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLEnquiryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLEditAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIBEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCOLDeleteAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIBDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.TLPMasterValuesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCEnquiryMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVEnquiryMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBDelete)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPMasterValuesList
            // 
            this.TLPMasterValuesList.ColumnCount = 1;
            this.TLPMasterValuesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPMasterValuesList.Controls.Add(this.GCEnquiryMaster, 0, 1);
            this.TLPMasterValuesList.Controls.Add(this.panel1, 0, 0);
            this.TLPMasterValuesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMasterValuesList.Location = new System.Drawing.Point(0, 0);
            this.TLPMasterValuesList.Name = "TLPMasterValuesList";
            this.TLPMasterValuesList.RowCount = 2;
            this.TLPMasterValuesList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLPMasterValuesList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValuesList.Size = new System.Drawing.Size(737, 532);
            this.TLPMasterValuesList.TabIndex = 2;
            // 
            // GCEnquiryMaster
            // 
            this.GCEnquiryMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCEnquiryMaster.Location = new System.Drawing.Point(3, 43);
            this.GCEnquiryMaster.MainView = this.GVEnquiryMaster;
            this.GCEnquiryMaster.Name = "GCEnquiryMaster";
            this.GCEnquiryMaster.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RIBEdit,
            this.RIBDelete});
            this.GCEnquiryMaster.Size = new System.Drawing.Size(731, 493);
            this.GCEnquiryMaster.TabIndex = 1;
            this.GCEnquiryMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVEnquiryMaster});
            // 
            // GVEnquiryMaster
            // 
            this.GVEnquiryMaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCOLEnquiryId,
            this.GCOLSrNo,
            this.GCOLStudentName,
            this.GCOLNo,
            this.GCOLAddress,
            this.GCOLContactNo,
            this.GCOLEmailId,
            this.GCOLRefMasterValues_CourseId,
            this.GCOLInstitution,
            this.GCOLCourseName,
            this.GCOLEnquiryDate,
            this.GCOLEditAction,
            this.GCOLDeleteAction});
            this.GVEnquiryMaster.GridControl = this.GCEnquiryMaster;
            this.GVEnquiryMaster.Name = "GVEnquiryMaster";
            this.GVEnquiryMaster.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GVEnquiryMaster.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GVEnquiryMaster.OptionsCustomization.AllowQuickHideColumns = false;
            this.GVEnquiryMaster.OptionsFind.AlwaysVisible = true;
            this.GVEnquiryMaster.OptionsView.ShowFooter = true;
            // 
            // GCOLEnquiryId
            // 
            this.GCOLEnquiryId.Caption = "EnquiryId";
            this.GCOLEnquiryId.FieldName = "EnquiryId";
            this.GCOLEnquiryId.Name = "GCOLEnquiryId";
            this.GCOLEnquiryId.OptionsColumn.AllowEdit = false;
            this.GCOLEnquiryId.OptionsColumn.AllowFocus = false;
            // 
            // GCOLSrNo
            // 
            this.GCOLSrNo.Caption = "SrNo";
            this.GCOLSrNo.FieldName = "SrNo";
            this.GCOLSrNo.Name = "GCOLSrNo";
            this.GCOLSrNo.OptionsColumn.AllowEdit = false;
            this.GCOLSrNo.OptionsColumn.AllowFocus = false;
            this.GCOLSrNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SrNo", "{0}")});
            this.GCOLSrNo.Visible = true;
            this.GCOLSrNo.VisibleIndex = 0;
            // 
            // GCOLStudentName
            // 
            this.GCOLStudentName.Caption = "Student Name";
            this.GCOLStudentName.FieldName = "StudentName";
            this.GCOLStudentName.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.GCOLStudentName.Name = "GCOLStudentName";
            this.GCOLStudentName.OptionsColumn.AllowEdit = false;
            this.GCOLStudentName.OptionsColumn.AllowFocus = false;
            this.GCOLStudentName.Visible = true;
            this.GCOLStudentName.VisibleIndex = 1;
            // 
            // GCOLNo
            // 
            this.GCOLNo.Caption = "No/App";
            this.GCOLNo.FieldName = "No";
            this.GCOLNo.Name = "GCOLNo";
            this.GCOLNo.OptionsColumn.AllowEdit = false;
            this.GCOLNo.OptionsColumn.AllowFocus = false;
            this.GCOLNo.Visible = true;
            this.GCOLNo.VisibleIndex = 3;
            // 
            // GCOLAddress
            // 
            this.GCOLAddress.Caption = "Address";
            this.GCOLAddress.FieldName = "Address";
            this.GCOLAddress.Name = "GCOLAddress";
            this.GCOLAddress.OptionsColumn.AllowEdit = false;
            this.GCOLAddress.OptionsColumn.AllowFocus = false;
            this.GCOLAddress.Visible = true;
            this.GCOLAddress.VisibleIndex = 4;
            // 
            // GCOLContactNo
            // 
            this.GCOLContactNo.Caption = "Contact No";
            this.GCOLContactNo.FieldName = "ContactNo";
            this.GCOLContactNo.Name = "GCOLContactNo";
            this.GCOLContactNo.OptionsColumn.AllowEdit = false;
            this.GCOLContactNo.OptionsColumn.AllowFocus = false;
            this.GCOLContactNo.Visible = true;
            this.GCOLContactNo.VisibleIndex = 2;
            // 
            // GCOLEmailId
            // 
            this.GCOLEmailId.Caption = "Email Id";
            this.GCOLEmailId.FieldName = "EmailId";
            this.GCOLEmailId.Name = "GCOLEmailId";
            this.GCOLEmailId.OptionsColumn.AllowEdit = false;
            this.GCOLEmailId.OptionsColumn.AllowFocus = false;
            // 
            // GCOLRefMasterValues_CourseId
            // 
            this.GCOLRefMasterValues_CourseId.Caption = "Course Id";
            this.GCOLRefMasterValues_CourseId.FieldName = "RefMasterValues_CourseId";
            this.GCOLRefMasterValues_CourseId.Name = "GCOLRefMasterValues_CourseId";
            this.GCOLRefMasterValues_CourseId.OptionsColumn.AllowEdit = false;
            this.GCOLRefMasterValues_CourseId.OptionsColumn.AllowFocus = false;
            // 
            // GCOLInstitution
            // 
            this.GCOLInstitution.Caption = "Institution";
            this.GCOLInstitution.FieldName = "Institution";
            this.GCOLInstitution.Name = "GCOLInstitution";
            this.GCOLInstitution.OptionsColumn.AllowEdit = false;
            this.GCOLInstitution.OptionsColumn.AllowFocus = false;
            this.GCOLInstitution.Visible = true;
            this.GCOLInstitution.VisibleIndex = 7;
            // 
            // GCOLCourseName
            // 
            this.GCOLCourseName.Caption = "Course Name";
            this.GCOLCourseName.FieldName = "CourseName";
            this.GCOLCourseName.Name = "GCOLCourseName";
            this.GCOLCourseName.OptionsColumn.AllowEdit = false;
            this.GCOLCourseName.OptionsColumn.AllowFocus = false;
            this.GCOLCourseName.Visible = true;
            this.GCOLCourseName.VisibleIndex = 5;
            // 
            // GCOLEnquiryDate
            // 
            this.GCOLEnquiryDate.Caption = "Enquiry Date";
            this.GCOLEnquiryDate.FieldName = "EnquiryDate";
            this.GCOLEnquiryDate.Name = "GCOLEnquiryDate";
            this.GCOLEnquiryDate.OptionsColumn.AllowEdit = false;
            this.GCOLEnquiryDate.OptionsColumn.AllowFocus = false;
            this.GCOLEnquiryDate.Visible = true;
            this.GCOLEnquiryDate.VisibleIndex = 6;
            // 
            // GCOLEditAction
            // 
            this.GCOLEditAction.ColumnEdit = this.RIBEdit;
            this.GCOLEditAction.Name = "GCOLEditAction";
            this.GCOLEditAction.Visible = true;
            this.GCOLEditAction.VisibleIndex = 8;
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
            this.GCOLDeleteAction.VisibleIndex = 9;
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
            this.panel1.Size = new System.Drawing.Size(731, 34);
            this.panel1.TabIndex = 2;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Appearance.Options.UseFont = true;
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(611, 0);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(120, 34);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // FrmEnquiryMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 532);
            this.Controls.Add(this.TLPMasterValuesList);
            this.Name = "FrmEnquiryMaster";
            this.Text = "Enquiry Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEnquiryMaster_Load);
            this.TLPMasterValuesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCEnquiryMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVEnquiryMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBDelete)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPMasterValuesList;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLEnquiryId;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLStudentName;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLContactNo;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLEmailId;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLRefMasterValues_CourseId;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLEnquiryDate;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLEditAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBEdit;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLDeleteAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBDelete;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLCourseName;
        public DevExpress.XtraGrid.GridControl GCEnquiryMaster;
        public DevExpress.XtraGrid.Views.Grid.GridView GVEnquiryMaster;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLNo;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLAddress;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLInstitution;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLSrNo;
    }
}