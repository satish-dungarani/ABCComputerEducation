namespace ABCComputerEducation.Forms
{
    partial class FrmCertyRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCertyRegistration));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.TLPMasterValuesList = new System.Windows.Forms.TableLayoutPanel();
            this.GCCertyRegistration = new DevExpress.XtraGrid.GridControl();
            this.GVCertyRegistration = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCOLCertyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLRegNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLSrNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLRefStudentExamMarksheet_MarkSheetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLRefStudentMaster_StudentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLStudentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLContactNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLRegDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLCertyType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLCertyRequestDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLCertyReceiveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLCertIssueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLEditAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIBEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCOLDeleteAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIBDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.TLPMasterValuesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCCertyRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVCertyRegistration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBDelete)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPMasterValuesList
            // 
            this.TLPMasterValuesList.ColumnCount = 1;
            this.TLPMasterValuesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPMasterValuesList.Controls.Add(this.GCCertyRegistration, 0, 1);
            this.TLPMasterValuesList.Controls.Add(this.panel1, 0, 0);
            this.TLPMasterValuesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMasterValuesList.Location = new System.Drawing.Point(0, 0);
            this.TLPMasterValuesList.Name = "TLPMasterValuesList";
            this.TLPMasterValuesList.RowCount = 2;
            this.TLPMasterValuesList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLPMasterValuesList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValuesList.Size = new System.Drawing.Size(680, 571);
            this.TLPMasterValuesList.TabIndex = 5;
            // 
            // GCCertyRegistration
            // 
            this.GCCertyRegistration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCCertyRegistration.Location = new System.Drawing.Point(3, 43);
            this.GCCertyRegistration.MainView = this.GVCertyRegistration;
            this.GCCertyRegistration.Name = "GCCertyRegistration";
            this.GCCertyRegistration.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RIBEdit,
            this.RIBDelete});
            this.GCCertyRegistration.Size = new System.Drawing.Size(674, 545);
            this.GCCertyRegistration.TabIndex = 1;
            this.GCCertyRegistration.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVCertyRegistration});
            // 
            // GVCertyRegistration
            // 
            this.GVCertyRegistration.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCOLCertyId,
            this.GCOLRegNo,
            this.GCOLSrNo,
            this.GCOLRefStudentExamMarksheet_MarkSheetId,
            this.GCOLRefStudentMaster_StudentId,
            this.GCOLStudentName,
            this.GCOLContactNo,
            this.GCOLRegDate,
            this.GCOLCertyType,
            this.GCOLCertyRequestDate,
            this.GCOLCertyReceiveDate,
            this.GCOLCertIssueDate,
            this.GCOLEditAction,
            this.GCOLDeleteAction});
            this.GVCertyRegistration.GridControl = this.GCCertyRegistration;
            this.GVCertyRegistration.Name = "GVCertyRegistration";
            this.GVCertyRegistration.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GVCertyRegistration.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GVCertyRegistration.OptionsCustomization.AllowQuickHideColumns = false;
            this.GVCertyRegistration.OptionsFind.AlwaysVisible = true;
            this.GVCertyRegistration.OptionsView.ShowFooter = true;
            // 
            // GCOLCertyId
            // 
            this.GCOLCertyId.Caption = "Certy Id";
            this.GCOLCertyId.FieldName = "CertyId";
            this.GCOLCertyId.Name = "GCOLCertyId";
            this.GCOLCertyId.OptionsColumn.AllowEdit = false;
            this.GCOLCertyId.OptionsColumn.AllowFocus = false;
            // 
            // GCOLRegNo
            // 
            this.GCOLRegNo.Caption = "Registration No";
            this.GCOLRegNo.FieldName = "RegNo";
            this.GCOLRegNo.Name = "GCOLRegNo";
            this.GCOLRegNo.OptionsColumn.AllowEdit = false;
            this.GCOLRegNo.OptionsColumn.AllowFocus = false;
            this.GCOLRegNo.Visible = true;
            this.GCOLRegNo.VisibleIndex = 1;
            this.GCOLRegNo.Width = 59;
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
            this.GCOLSrNo.Width = 59;
            // 
            // GCOLRefStudentExamMarksheet_MarkSheetId
            // 
            this.GCOLRefStudentExamMarksheet_MarkSheetId.Caption = "MarkSheet Id";
            this.GCOLRefStudentExamMarksheet_MarkSheetId.FieldName = "RefStudentExamMarkSheet_MarksheetId";
            this.GCOLRefStudentExamMarksheet_MarkSheetId.Name = "GCOLRefStudentExamMarksheet_MarkSheetId";
            this.GCOLRefStudentExamMarksheet_MarkSheetId.OptionsColumn.AllowEdit = false;
            this.GCOLRefStudentExamMarksheet_MarkSheetId.OptionsColumn.AllowFocus = false;
            // 
            // GCOLRefStudentMaster_StudentId
            // 
            this.GCOLRefStudentMaster_StudentId.Caption = "Student Id";
            this.GCOLRefStudentMaster_StudentId.FieldName = "RefStudentMaster_StudentId";
            this.GCOLRefStudentMaster_StudentId.Name = "GCOLRefStudentMaster_StudentId";
            this.GCOLRefStudentMaster_StudentId.OptionsColumn.AllowEdit = false;
            this.GCOLRefStudentMaster_StudentId.OptionsColumn.AllowFocus = false;
            // 
            // GCOLStudentName
            // 
            this.GCOLStudentName.Caption = "Student Name";
            this.GCOLStudentName.FieldName = "StudentName";
            this.GCOLStudentName.Name = "GCOLStudentName";
            this.GCOLStudentName.OptionsColumn.AllowEdit = false;
            this.GCOLStudentName.OptionsColumn.AllowFocus = false;
            this.GCOLStudentName.Visible = true;
            this.GCOLStudentName.VisibleIndex = 2;
            this.GCOLStudentName.Width = 59;
            // 
            // GCOLContactNo
            // 
            this.GCOLContactNo.Caption = "Contact No";
            this.GCOLContactNo.FieldName = "ContactNumber";
            this.GCOLContactNo.Name = "GCOLContactNo";
            this.GCOLContactNo.OptionsColumn.AllowEdit = false;
            this.GCOLContactNo.OptionsColumn.AllowFocus = false;
            this.GCOLContactNo.Visible = true;
            this.GCOLContactNo.VisibleIndex = 3;
            this.GCOLContactNo.Width = 76;
            // 
            // GCOLRegDate
            // 
            this.GCOLRegDate.Caption = "Registration Date";
            this.GCOLRegDate.FieldName = "RegDate";
            this.GCOLRegDate.Name = "GCOLRegDate";
            this.GCOLRegDate.OptionsColumn.AllowEdit = false;
            this.GCOLRegDate.OptionsColumn.AllowFocus = false;
            this.GCOLRegDate.Visible = true;
            this.GCOLRegDate.VisibleIndex = 5;
            this.GCOLRegDate.Width = 56;
            // 
            // GCOLCertyType
            // 
            this.GCOLCertyType.Caption = "Certy Type";
            this.GCOLCertyType.FieldName = "CertyType";
            this.GCOLCertyType.Name = "GCOLCertyType";
            this.GCOLCertyType.OptionsColumn.AllowEdit = false;
            this.GCOLCertyType.OptionsColumn.AllowFocus = false;
            this.GCOLCertyType.Visible = true;
            this.GCOLCertyType.VisibleIndex = 4;
            this.GCOLCertyType.Width = 56;
            // 
            // GCOLCertyRequestDate
            // 
            this.GCOLCertyRequestDate.Caption = "Request Date";
            this.GCOLCertyRequestDate.FieldName = "CertyRequestDate";
            this.GCOLCertyRequestDate.Name = "GCOLCertyRequestDate";
            this.GCOLCertyRequestDate.OptionsColumn.AllowEdit = false;
            this.GCOLCertyRequestDate.OptionsColumn.AllowFocus = false;
            this.GCOLCertyRequestDate.Visible = true;
            this.GCOLCertyRequestDate.VisibleIndex = 6;
            this.GCOLCertyRequestDate.Width = 56;
            // 
            // GCOLCertyReceiveDate
            // 
            this.GCOLCertyReceiveDate.Caption = "Receive Date";
            this.GCOLCertyReceiveDate.FieldName = "CertyReceiveDate";
            this.GCOLCertyReceiveDate.Name = "GCOLCertyReceiveDate";
            this.GCOLCertyReceiveDate.OptionsColumn.AllowEdit = false;
            this.GCOLCertyReceiveDate.OptionsColumn.AllowFocus = false;
            this.GCOLCertyReceiveDate.Visible = true;
            this.GCOLCertyReceiveDate.VisibleIndex = 7;
            this.GCOLCertyReceiveDate.Width = 56;
            // 
            // GCOLCertIssueDate
            // 
            this.GCOLCertIssueDate.Caption = "Issue Date";
            this.GCOLCertIssueDate.FieldName = "CertyIssueDate";
            this.GCOLCertIssueDate.Name = "GCOLCertIssueDate";
            this.GCOLCertIssueDate.OptionsColumn.AllowEdit = false;
            this.GCOLCertIssueDate.OptionsColumn.AllowFocus = false;
            this.GCOLCertIssueDate.Visible = true;
            this.GCOLCertIssueDate.VisibleIndex = 8;
            this.GCOLCertIssueDate.Width = 56;
            // 
            // GCOLEditAction
            // 
            this.GCOLEditAction.ColumnEdit = this.RIBEdit;
            this.GCOLEditAction.Name = "GCOLEditAction";
            this.GCOLEditAction.Visible = true;
            this.GCOLEditAction.VisibleIndex = 9;
            this.GCOLEditAction.Width = 56;
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
            this.GCOLDeleteAction.VisibleIndex = 10;
            this.GCOLDeleteAction.Width = 67;
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
            this.panel1.Size = new System.Drawing.Size(674, 34);
            this.panel1.TabIndex = 2;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Appearance.Options.UseFont = true;
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(554, 0);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(120, 34);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // FrmCertyRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 571);
            this.Controls.Add(this.TLPMasterValuesList);
            this.Name = "FrmCertyRegistration";
            this.Text = "Cert Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCertyRegistration_Load);
            this.TLPMasterValuesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCCertyRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVCertyRegistration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBDelete)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPMasterValuesList;
        public DevExpress.XtraGrid.GridControl GCCertyRegistration;
        public DevExpress.XtraGrid.Views.Grid.GridView GVCertyRegistration;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLCertyId;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLRegNo;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLRefStudentExamMarksheet_MarkSheetId;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLRefStudentMaster_StudentId;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLStudentName;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLRegDate;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLCertyType;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLCertyRequestDate;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLCertyReceiveDate;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLCertIssueDate;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLEditAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBEdit;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLDeleteAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBDelete;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLSrNo;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLContactNo;
    }
}