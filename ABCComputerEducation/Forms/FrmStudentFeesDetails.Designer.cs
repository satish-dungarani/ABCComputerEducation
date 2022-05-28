namespace ABCComputerEducation.Forms
{
    partial class FrmStudentFeesDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentFeesDetails));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            this.TLPMasterValuesList = new System.Windows.Forms.TableLayoutPanel();
            this.GCStudentFeesDetails = new DevExpress.XtraGrid.GridControl();
            this.GVStudentFeesDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCOLReceiptId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLReceiptNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLRefAdmissionDetail_AdmissionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLRefStudentMaster_StudentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLStudentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLInstallmentNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLPaidAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLTotalFees = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLPendingFees = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLPaidDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLEditAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIBEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCOLDeleteAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIBDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCOLReportView = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIBReport = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.GCOLContactNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TLPMasterValuesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCStudentFeesDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVStudentFeesDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPMasterValuesList
            // 
            this.TLPMasterValuesList.ColumnCount = 1;
            this.TLPMasterValuesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPMasterValuesList.Controls.Add(this.GCStudentFeesDetails, 0, 1);
            this.TLPMasterValuesList.Controls.Add(this.panel1, 0, 0);
            this.TLPMasterValuesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMasterValuesList.Location = new System.Drawing.Point(0, 0);
            this.TLPMasterValuesList.Name = "TLPMasterValuesList";
            this.TLPMasterValuesList.RowCount = 2;
            this.TLPMasterValuesList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLPMasterValuesList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValuesList.Size = new System.Drawing.Size(685, 599);
            this.TLPMasterValuesList.TabIndex = 5;
            // 
            // GCStudentFeesDetails
            // 
            this.GCStudentFeesDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCStudentFeesDetails.Location = new System.Drawing.Point(3, 43);
            this.GCStudentFeesDetails.MainView = this.GVStudentFeesDetails;
            this.GCStudentFeesDetails.Name = "GCStudentFeesDetails";
            this.GCStudentFeesDetails.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RIBEdit,
            this.RIBDelete,
            this.RIBReport});
            this.GCStudentFeesDetails.Size = new System.Drawing.Size(679, 553);
            this.GCStudentFeesDetails.TabIndex = 1;
            this.GCStudentFeesDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVStudentFeesDetails});
            // 
            // GVStudentFeesDetails
            // 
            this.GVStudentFeesDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCOLReceiptId,
            this.GCOLReceiptNo,
            this.GCOLRefAdmissionDetail_AdmissionId,
            this.GCOLRefStudentMaster_StudentId,
            this.GCOLStudentName,
            this.GCOLContactNo,
            this.GCOLInstallmentNo,
            this.GCOLPaidAmount,
            this.GCOLTotalFees,
            this.GCOLPendingFees,
            this.GCOLPaidDate,
            this.GCOLEditAction,
            this.GCOLDeleteAction,
            this.GCOLReportView});
            this.GVStudentFeesDetails.GridControl = this.GCStudentFeesDetails;
            this.GVStudentFeesDetails.Name = "GVStudentFeesDetails";
            this.GVStudentFeesDetails.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GVStudentFeesDetails.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GVStudentFeesDetails.OptionsCustomization.AllowQuickHideColumns = false;
            this.GVStudentFeesDetails.OptionsFind.AlwaysVisible = true;
            // 
            // GCOLReceiptId
            // 
            this.GCOLReceiptId.Caption = "Receipt Id";
            this.GCOLReceiptId.FieldName = "ReceiptId";
            this.GCOLReceiptId.Name = "GCOLReceiptId";
            this.GCOLReceiptId.OptionsColumn.AllowEdit = false;
            this.GCOLReceiptId.OptionsColumn.AllowFocus = false;
            // 
            // GCOLReceiptNo
            // 
            this.GCOLReceiptNo.Caption = "Receipt No";
            this.GCOLReceiptNo.FieldName = "ReceiptNo";
            this.GCOLReceiptNo.Name = "GCOLReceiptNo";
            this.GCOLReceiptNo.OptionsColumn.AllowEdit = false;
            this.GCOLReceiptNo.OptionsColumn.AllowFocus = false;
            this.GCOLReceiptNo.Visible = true;
            this.GCOLReceiptNo.VisibleIndex = 0;
            // 
            // GCOLRefAdmissionDetail_AdmissionId
            // 
            this.GCOLRefAdmissionDetail_AdmissionId.Caption = "Gender";
            this.GCOLRefAdmissionDetail_AdmissionId.CustomizationCaption = "Admission Id";
            this.GCOLRefAdmissionDetail_AdmissionId.FieldName = "RefAdmissionDetail_AdmissionId";
            this.GCOLRefAdmissionDetail_AdmissionId.Name = "GCOLRefAdmissionDetail_AdmissionId";
            this.GCOLRefAdmissionDetail_AdmissionId.OptionsColumn.AllowEdit = false;
            this.GCOLRefAdmissionDetail_AdmissionId.OptionsColumn.AllowFocus = false;
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
            this.GCOLStudentName.VisibleIndex = 1;
            // 
            // GCOLInstallmentNo
            // 
            this.GCOLInstallmentNo.Caption = "Installment No";
            this.GCOLInstallmentNo.FieldName = "InstallmanrNo";
            this.GCOLInstallmentNo.Name = "GCOLInstallmentNo";
            this.GCOLInstallmentNo.OptionsColumn.AllowEdit = false;
            this.GCOLInstallmentNo.OptionsColumn.AllowFocus = false;
            this.GCOLInstallmentNo.Visible = true;
            this.GCOLInstallmentNo.VisibleIndex = 3;
            // 
            // GCOLPaidAmount
            // 
            this.GCOLPaidAmount.Caption = "Paid Amount";
            this.GCOLPaidAmount.FieldName = "PaidAmount";
            this.GCOLPaidAmount.Name = "GCOLPaidAmount";
            this.GCOLPaidAmount.OptionsColumn.AllowEdit = false;
            this.GCOLPaidAmount.OptionsColumn.AllowFocus = false;
            this.GCOLPaidAmount.Visible = true;
            this.GCOLPaidAmount.VisibleIndex = 4;
            // 
            // GCOLTotalFees
            // 
            this.GCOLTotalFees.Caption = "Total Fees";
            this.GCOLTotalFees.FieldName = "TotalFees";
            this.GCOLTotalFees.Name = "GCOLTotalFees";
            this.GCOLTotalFees.OptionsColumn.AllowEdit = false;
            this.GCOLTotalFees.OptionsColumn.AllowFocus = false;
            this.GCOLTotalFees.Visible = true;
            this.GCOLTotalFees.VisibleIndex = 5;
            // 
            // GCOLPendingFees
            // 
            this.GCOLPendingFees.Caption = "Pending Fees";
            this.GCOLPendingFees.FieldName = "PendingFees";
            this.GCOLPendingFees.Name = "GCOLPendingFees";
            this.GCOLPendingFees.OptionsColumn.AllowEdit = false;
            this.GCOLPendingFees.OptionsColumn.AllowFocus = false;
            this.GCOLPendingFees.Visible = true;
            this.GCOLPendingFees.VisibleIndex = 6;
            // 
            // GCOLPaidDate
            // 
            this.GCOLPaidDate.Caption = "Paid Date";
            this.GCOLPaidDate.FieldName = "PaidDate";
            this.GCOLPaidDate.Name = "GCOLPaidDate";
            this.GCOLPaidDate.OptionsColumn.AllowEdit = false;
            this.GCOLPaidDate.OptionsColumn.AllowFocus = false;
            this.GCOLPaidDate.Visible = true;
            this.GCOLPaidDate.VisibleIndex = 7;
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("RIBEdit.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
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
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("RIBDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.RIBDelete.Name = "RIBDelete";
            this.RIBDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.RIBDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RIBDelete_ButtonClick);
            // 
            // GCOLReportView
            // 
            this.GCOLReportView.ColumnEdit = this.RIBReport;
            this.GCOLReportView.Name = "GCOLReportView";
            this.GCOLReportView.Visible = true;
            this.GCOLReportView.VisibleIndex = 10;
            // 
            // RIBReport
            // 
            this.RIBReport.AutoHeight = false;
            this.RIBReport.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("RIBReport.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject6, "", null, null, true)});
            this.RIBReport.Name = "RIBReport";
            this.RIBReport.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.RIBReport.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RIBReport_ButtonClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 34);
            this.panel1.TabIndex = 2;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Appearance.Options.UseFont = true;
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(559, 0);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(120, 34);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // GCOLContactNo
            // 
            this.GCOLContactNo.Caption = "Contact No";
            this.GCOLContactNo.FieldName = "ContactNumber";
            this.GCOLContactNo.Name = "GCOLContactNo";
            this.GCOLContactNo.OptionsColumn.AllowEdit = false;
            this.GCOLContactNo.OptionsColumn.AllowFocus = false;
            this.GCOLContactNo.Visible = true;
            this.GCOLContactNo.VisibleIndex = 2;
            // 
            // FrmStudentFeesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 599);
            this.Controls.Add(this.TLPMasterValuesList);
            this.Name = "FrmStudentFeesDetails";
            this.Text = "Student Fees Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStudentFeesDetails_Load);
            this.TLPMasterValuesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCStudentFeesDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVStudentFeesDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPMasterValuesList;
        public DevExpress.XtraGrid.GridControl GCStudentFeesDetails;
        public DevExpress.XtraGrid.Views.Grid.GridView GVStudentFeesDetails;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLReceiptId;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLReceiptNo;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLRefAdmissionDetail_AdmissionId;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLRefStudentMaster_StudentId;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLInstallmentNo;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLPaidAmount;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLTotalFees;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLPendingFees;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLPaidDate;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLEditAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBEdit;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLDeleteAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBDelete;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLStudentName;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLReportView;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBReport;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLContactNo;
    }
}