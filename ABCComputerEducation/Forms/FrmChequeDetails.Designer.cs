namespace ABCComputerEducation.Forms
{
    partial class FrmChequeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChequeDetails));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.RIBEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GCOLStudentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLRefAdmissionDetail_AdmissionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLReceiptNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLReceiptId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GVChequeDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCLO_ChequeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLBanoOfCheque = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLDepositedIn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLReceiveDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLDepositedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLClearDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLBounsedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLEditAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCChequeDetails = new DevExpress.XtraGrid.GridControl();
            this.TLPMasterValuesList = new System.Windows.Forms.TableLayoutPanel();
            this.GCOLContactNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RIBEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVChequeDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCChequeDetails)).BeginInit();
            this.TLPMasterValuesList.SuspendLayout();
            this.SuspendLayout();
            // 
            // RIBEdit
            // 
            this.RIBEdit.AutoHeight = false;
            this.RIBEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("RIBEdit.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.RIBEdit.Name = "RIBEdit";
            this.RIBEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.RIBEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RIBEdit_ButtonClick);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 34);
            this.panel1.TabIndex = 2;
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
            // GCOLRefAdmissionDetail_AdmissionId
            // 
            this.GCOLRefAdmissionDetail_AdmissionId.Caption = "Gender";
            this.GCOLRefAdmissionDetail_AdmissionId.CustomizationCaption = "Admission Id";
            this.GCOLRefAdmissionDetail_AdmissionId.FieldName = "RefAdmissionDetail_AdmissionId";
            this.GCOLRefAdmissionDetail_AdmissionId.Name = "GCOLRefAdmissionDetail_AdmissionId";
            this.GCOLRefAdmissionDetail_AdmissionId.OptionsColumn.AllowEdit = false;
            this.GCOLRefAdmissionDetail_AdmissionId.OptionsColumn.AllowFocus = false;
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
            // GCOLReceiptId
            // 
            this.GCOLReceiptId.Caption = "Receipt Id";
            this.GCOLReceiptId.FieldName = "ReceiptId";
            this.GCOLReceiptId.Name = "GCOLReceiptId";
            this.GCOLReceiptId.OptionsColumn.AllowEdit = false;
            this.GCOLReceiptId.OptionsColumn.AllowFocus = false;
            // 
            // GVChequeDetails
            // 
            this.GVChequeDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCOLReceiptId,
            this.GCOLReceiptNo,
            this.GCOLRefAdmissionDetail_AdmissionId,
            this.GCOLStudentName,
            this.GCOLContactNo,
            this.GCLO_ChequeNo,
            this.GCOLBanoOfCheque,
            this.GCOLDepositedIn,
            this.GCOLReceiveDate,
            this.GCOLDepositedDate,
            this.GCOLClearDate,
            this.GCOLBounsedDate,
            this.GCOLEditAction});
            this.GVChequeDetails.GridControl = this.GCChequeDetails;
            this.GVChequeDetails.Name = "GVChequeDetails";
            this.GVChequeDetails.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GVChequeDetails.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GVChequeDetails.OptionsCustomization.AllowQuickHideColumns = false;
            this.GVChequeDetails.OptionsFind.AlwaysVisible = true;
            this.GVChequeDetails.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.GVChequeDetails_RowCellStyle);
            this.GVChequeDetails.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.GVChequeDetails_RowStyle);
            // 
            // GCLO_ChequeNo
            // 
            this.GCLO_ChequeNo.Caption = "Cheque No";
            this.GCLO_ChequeNo.FieldName = "ChequeNo";
            this.GCLO_ChequeNo.Name = "GCLO_ChequeNo";
            this.GCLO_ChequeNo.OptionsColumn.AllowEdit = false;
            this.GCLO_ChequeNo.OptionsColumn.AllowFocus = false;
            this.GCLO_ChequeNo.Visible = true;
            this.GCLO_ChequeNo.VisibleIndex = 3;
            // 
            // GCOLBanoOfCheque
            // 
            this.GCOLBanoOfCheque.Caption = "Bank Of Cheque";
            this.GCOLBanoOfCheque.FieldName = "BankOfCheque";
            this.GCOLBanoOfCheque.Name = "GCOLBanoOfCheque";
            this.GCOLBanoOfCheque.OptionsColumn.AllowEdit = false;
            this.GCOLBanoOfCheque.OptionsColumn.AllowFocus = false;
            this.GCOLBanoOfCheque.Visible = true;
            this.GCOLBanoOfCheque.VisibleIndex = 4;
            // 
            // GCOLDepositedIn
            // 
            this.GCOLDepositedIn.Caption = "Deposited Account Name";
            this.GCOLDepositedIn.FieldName = "DepositedAccountName";
            this.GCOLDepositedIn.Name = "GCOLDepositedIn";
            this.GCOLDepositedIn.OptionsColumn.AllowEdit = false;
            this.GCOLDepositedIn.OptionsColumn.AllowFocus = false;
            this.GCOLDepositedIn.Visible = true;
            this.GCOLDepositedIn.VisibleIndex = 5;
            // 
            // GCOLReceiveDate
            // 
            this.GCOLReceiveDate.Caption = "Receive Date";
            this.GCOLReceiveDate.FieldName = "ChequeReceiveDate";
            this.GCOLReceiveDate.Name = "GCOLReceiveDate";
            this.GCOLReceiveDate.OptionsColumn.AllowEdit = false;
            this.GCOLReceiveDate.OptionsColumn.AllowFocus = false;
            this.GCOLReceiveDate.Visible = true;
            this.GCOLReceiveDate.VisibleIndex = 6;
            // 
            // GCOLDepositedDate
            // 
            this.GCOLDepositedDate.Caption = "Deposited Date";
            this.GCOLDepositedDate.FieldName = "ChequeRequestDate";
            this.GCOLDepositedDate.Name = "GCOLDepositedDate";
            // 
            // GCOLClearDate
            // 
            this.GCOLClearDate.Caption = "Clear Date";
            this.GCOLClearDate.FieldName = "ChequeAcceptDate";
            this.GCOLClearDate.Name = "GCOLClearDate";
            // 
            // GCOLBounsedDate
            // 
            this.GCOLBounsedDate.Caption = "Bounsed Date";
            this.GCOLBounsedDate.FieldName = "ChequeBounsDate";
            this.GCOLBounsedDate.Name = "GCOLBounsedDate";
            // 
            // GCOLEditAction
            // 
            this.GCOLEditAction.ColumnEdit = this.RIBEdit;
            this.GCOLEditAction.Name = "GCOLEditAction";
            this.GCOLEditAction.Visible = true;
            this.GCOLEditAction.VisibleIndex = 7;
            // 
            // GCChequeDetails
            // 
            this.GCChequeDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCChequeDetails.Location = new System.Drawing.Point(3, 43);
            this.GCChequeDetails.MainView = this.GVChequeDetails;
            this.GCChequeDetails.Name = "GCChequeDetails";
            this.GCChequeDetails.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RIBEdit});
            this.GCChequeDetails.Size = new System.Drawing.Size(659, 453);
            this.GCChequeDetails.TabIndex = 1;
            this.GCChequeDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVChequeDetails});
            // 
            // TLPMasterValuesList
            // 
            this.TLPMasterValuesList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLPMasterValuesList.ColumnCount = 1;
            this.TLPMasterValuesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPMasterValuesList.Controls.Add(this.GCChequeDetails, 0, 1);
            this.TLPMasterValuesList.Controls.Add(this.panel1, 0, 0);
            this.TLPMasterValuesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMasterValuesList.Location = new System.Drawing.Point(0, 0);
            this.TLPMasterValuesList.Name = "TLPMasterValuesList";
            this.TLPMasterValuesList.RowCount = 2;
            this.TLPMasterValuesList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLPMasterValuesList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValuesList.Size = new System.Drawing.Size(665, 499);
            this.TLPMasterValuesList.TabIndex = 6;
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
            // FrmChequeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 499);
            this.Controls.Add(this.TLPMasterValuesList);
            this.Name = "FrmChequeDetails";
            this.Text = "FrmChequeDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmChequeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RIBEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVChequeDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCChequeDetails)).EndInit();
            this.TLPMasterValuesList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBEdit;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLStudentName;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLRefAdmissionDetail_AdmissionId;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLReceiptNo;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLReceiptId;
        public DevExpress.XtraGrid.Views.Grid.GridView GVChequeDetails;
        public DevExpress.XtraGrid.GridControl GCChequeDetails;
        private System.Windows.Forms.TableLayoutPanel TLPMasterValuesList;
        private DevExpress.XtraGrid.Columns.GridColumn GCLO_ChequeNo;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLBanoOfCheque;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLDepositedIn;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLReceiveDate;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLEditAction;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLDepositedDate;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLClearDate;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLBounsedDate;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLContactNo;
    }
}