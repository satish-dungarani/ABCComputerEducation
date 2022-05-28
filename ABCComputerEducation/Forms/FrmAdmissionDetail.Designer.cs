namespace ABCComputerEducation.Forms
{
    partial class FrmAdmissionDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmissionDetail));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            this.GCOLExamDone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIBExamStatus = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.RIBDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.RIBEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCOLAdmissionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLNoOfInstallments = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLCouserTimePeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLCouseFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLToTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLFromTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLRefMasterValues_CourseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLStudentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLRefEnquiryMaster_EnquiryId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLAdmissionCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLAdmissionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GVAdmissionDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCOLSrNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLContactNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLCourseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLCourseType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLLab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLPendingFees = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLReAdmission = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIBRestore = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCOLDropOut = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIBDropOut = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCOLEditAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLDeleteAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCAdmissionDetail = new DevExpress.XtraGrid.GridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ddlLabs = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ddlFromToTimeList = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnDeleteAll = new DevExpress.XtraEditors.SimpleButton();
            this.TLPMasterValuesList = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.RIBExamStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVAdmissionDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBDropOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCAdmissionDetail)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlLabs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlFromToTimeList.Properties)).BeginInit();
            this.TLPMasterValuesList.SuspendLayout();
            this.SuspendLayout();
            // 
            // GCOLExamDone
            // 
            this.GCOLExamDone.ColumnEdit = this.RIBExamStatus;
            this.GCOLExamDone.FieldName = "ExamStatus";
            this.GCOLExamDone.Name = "GCOLExamDone";
            this.GCOLExamDone.OptionsColumn.AllowEdit = false;
            this.GCOLExamDone.OptionsColumn.AllowFocus = false;
            // 
            // RIBExamStatus
            // 
            this.RIBExamStatus.AutoHeight = false;
            this.RIBExamStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("RIBExamStatus.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.RIBExamStatus.Name = "RIBExamStatus";
            this.RIBExamStatus.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.RIBExamStatus.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RIBExamStatus_ButtonClick);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Appearance.Options.UseFont = true;
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(917, 0);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(140, 41);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
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
            // RIBEdit
            // 
            this.RIBEdit.AutoHeight = false;
            this.RIBEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("RIBEdit.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.RIBEdit.Name = "RIBEdit";
            this.RIBEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.RIBEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RIBEdit_ButtonClick);
            // 
            // GCOLAdmissionDate
            // 
            this.GCOLAdmissionDate.Caption = "Admission Date";
            this.GCOLAdmissionDate.FieldName = "AdmissionDate";
            this.GCOLAdmissionDate.Name = "GCOLAdmissionDate";
            this.GCOLAdmissionDate.OptionsColumn.AllowEdit = false;
            this.GCOLAdmissionDate.OptionsColumn.AllowFocus = false;
            this.GCOLAdmissionDate.Visible = true;
            this.GCOLAdmissionDate.VisibleIndex = 12;
            this.GCOLAdmissionDate.Width = 50;
            // 
            // GCOLNoOfInstallments
            // 
            this.GCOLNoOfInstallments.Caption = "No Of Installments";
            this.GCOLNoOfInstallments.FieldName = "NoOfInstallments";
            this.GCOLNoOfInstallments.Name = "GCOLNoOfInstallments";
            this.GCOLNoOfInstallments.OptionsColumn.AllowEdit = false;
            this.GCOLNoOfInstallments.OptionsColumn.AllowFocus = false;
            this.GCOLNoOfInstallments.Visible = true;
            this.GCOLNoOfInstallments.VisibleIndex = 6;
            this.GCOLNoOfInstallments.Width = 40;
            // 
            // GCOLCouserTimePeriod
            // 
            this.GCOLCouserTimePeriod.Caption = "Couser Time Period";
            this.GCOLCouserTimePeriod.FieldName = "CouserTimePeriod";
            this.GCOLCouserTimePeriod.Name = "GCOLCouserTimePeriod";
            this.GCOLCouserTimePeriod.OptionsColumn.AllowEdit = false;
            this.GCOLCouserTimePeriod.OptionsColumn.AllowFocus = false;
            this.GCOLCouserTimePeriod.Visible = true;
            this.GCOLCouserTimePeriod.VisibleIndex = 5;
            this.GCOLCouserTimePeriod.Width = 84;
            // 
            // GCOLCouseFee
            // 
            this.GCOLCouseFee.Caption = "Couse Fee";
            this.GCOLCouseFee.FieldName = "CouseFee";
            this.GCOLCouseFee.Name = "GCOLCouseFee";
            this.GCOLCouseFee.OptionsColumn.AllowEdit = false;
            this.GCOLCouseFee.OptionsColumn.AllowFocus = false;
            this.GCOLCouseFee.Visible = true;
            this.GCOLCouseFee.VisibleIndex = 8;
            this.GCOLCouseFee.Width = 40;
            // 
            // GCOLToTime
            // 
            this.GCOLToTime.Caption = "To Time";
            this.GCOLToTime.FieldName = "ToTime";
            this.GCOLToTime.Name = "GCOLToTime";
            this.GCOLToTime.OptionsColumn.AllowEdit = false;
            this.GCOLToTime.OptionsColumn.AllowFocus = false;
            this.GCOLToTime.Visible = true;
            this.GCOLToTime.VisibleIndex = 10;
            this.GCOLToTime.Width = 50;
            // 
            // GCOLFromTime
            // 
            this.GCOLFromTime.Caption = "From Time";
            this.GCOLFromTime.FieldName = "FromTime";
            this.GCOLFromTime.Name = "GCOLFromTime";
            this.GCOLFromTime.OptionsColumn.AllowEdit = false;
            this.GCOLFromTime.OptionsColumn.AllowFocus = false;
            this.GCOLFromTime.Visible = true;
            this.GCOLFromTime.VisibleIndex = 9;
            this.GCOLFromTime.Width = 50;
            // 
            // GCOLRefMasterValues_CourseId
            // 
            this.GCOLRefMasterValues_CourseId.Caption = "Course Id";
            this.GCOLRefMasterValues_CourseId.FieldName = "RefMasterValues_CourseId";
            this.GCOLRefMasterValues_CourseId.Name = "GCOLRefMasterValues_CourseId";
            this.GCOLRefMasterValues_CourseId.OptionsColumn.AllowEdit = false;
            this.GCOLRefMasterValues_CourseId.OptionsColumn.AllowFocus = false;
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
            this.GCOLStudentName.Width = 45;
            // 
            // GCOLRefEnquiryMaster_EnquiryId
            // 
            this.GCOLRefEnquiryMaster_EnquiryId.Caption = "Gender";
            this.GCOLRefEnquiryMaster_EnquiryId.CustomizationCaption = "EnquiryId";
            this.GCOLRefEnquiryMaster_EnquiryId.FieldName = "RefEnquiryMaster_EnquiryId";
            this.GCOLRefEnquiryMaster_EnquiryId.Name = "GCOLRefEnquiryMaster_EnquiryId";
            this.GCOLRefEnquiryMaster_EnquiryId.OptionsColumn.AllowEdit = false;
            this.GCOLRefEnquiryMaster_EnquiryId.OptionsColumn.AllowFocus = false;
            // 
            // GCOLAdmissionCode
            // 
            this.GCOLAdmissionCode.Caption = "Admission No";
            this.GCOLAdmissionCode.FieldName = "AdmissionCode";
            this.GCOLAdmissionCode.Name = "GCOLAdmissionCode";
            this.GCOLAdmissionCode.OptionsColumn.AllowEdit = false;
            this.GCOLAdmissionCode.OptionsColumn.AllowFocus = false;
            this.GCOLAdmissionCode.Width = 62;
            // 
            // GCOLAdmissionId
            // 
            this.GCOLAdmissionId.Caption = "Admission Id";
            this.GCOLAdmissionId.FieldName = "AdmissionId";
            this.GCOLAdmissionId.Name = "GCOLAdmissionId";
            this.GCOLAdmissionId.OptionsColumn.AllowEdit = false;
            this.GCOLAdmissionId.OptionsColumn.AllowFocus = false;
            // 
            // GVAdmissionDetail
            // 
            this.GVAdmissionDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCOLAdmissionId,
            this.GCOLAdmissionCode,
            this.GCOLSrNo,
            this.GCOLRefEnquiryMaster_EnquiryId,
            this.GCOLStudentName,
            this.GCOLContactNo,
            this.GCOLRefMasterValues_CourseId,
            this.GCOLCourseName,
            this.GCOLCourseType,
            this.GCOLFromTime,
            this.GCOLToTime,
            this.GCOLLab,
            this.GCOLCouseFee,
            this.GCOLCouserTimePeriod,
            this.GCOLNoOfInstallments,
            this.GCOLAdmissionDate,
            this.GCOLPendingFees,
            this.GCOLExamDone,
            this.GCOLReAdmission,
            this.GCOLDropOut,
            this.GCOLEditAction,
            this.GCOLDeleteAction});
            gridFormatRule1.Column = this.GCOLExamDone;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            formatConditionRuleValue1.Appearance.Options.UseImage = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue1.Expression = "[CouseFee] == \'Done\'";
            formatConditionRuleValue1.Value1 = "Done";
            gridFormatRule1.Rule = formatConditionRuleValue1;
            this.GVAdmissionDetail.FormatRules.Add(gridFormatRule1);
            this.GVAdmissionDetail.GridControl = this.GCAdmissionDetail;
            this.GVAdmissionDetail.Name = "GVAdmissionDetail";
            this.GVAdmissionDetail.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GVAdmissionDetail.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GVAdmissionDetail.OptionsCustomization.AllowQuickHideColumns = false;
            this.GVAdmissionDetail.OptionsFind.AlwaysVisible = true;
            this.GVAdmissionDetail.OptionsView.ShowFooter = true;
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
            this.GCOLSrNo.Width = 55;
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
            // GCOLCourseName
            // 
            this.GCOLCourseName.Caption = "Course Name";
            this.GCOLCourseName.FieldName = "CourseName";
            this.GCOLCourseName.Name = "GCOLCourseName";
            this.GCOLCourseName.OptionsColumn.AllowEdit = false;
            this.GCOLCourseName.OptionsColumn.AllowFocus = false;
            this.GCOLCourseName.Visible = true;
            this.GCOLCourseName.VisibleIndex = 3;
            // 
            // GCOLCourseType
            // 
            this.GCOLCourseType.Caption = "Course Type";
            this.GCOLCourseType.FieldName = "CourseType";
            this.GCOLCourseType.Name = "GCOLCourseType";
            this.GCOLCourseType.OptionsColumn.AllowEdit = false;
            this.GCOLCourseType.OptionsColumn.AllowFocus = false;
            this.GCOLCourseType.Visible = true;
            this.GCOLCourseType.VisibleIndex = 4;
            this.GCOLCourseType.Width = 62;
            // 
            // GCOLLab
            // 
            this.GCOLLab.Caption = "Lab";
            this.GCOLLab.FieldName = "Lab";
            this.GCOLLab.Name = "GCOLLab";
            this.GCOLLab.OptionsColumn.AllowEdit = false;
            this.GCOLLab.OptionsColumn.AllowFocus = false;
            this.GCOLLab.Visible = true;
            this.GCOLLab.VisibleIndex = 11;
            // 
            // GCOLPendingFees
            // 
            this.GCOLPendingFees.Caption = "Pending Fees";
            this.GCOLPendingFees.FieldName = "PendingFee";
            this.GCOLPendingFees.Name = "GCOLPendingFees";
            this.GCOLPendingFees.OptionsColumn.AllowEdit = false;
            this.GCOLPendingFees.OptionsColumn.AllowFocus = false;
            this.GCOLPendingFees.Visible = true;
            this.GCOLPendingFees.VisibleIndex = 7;
            this.GCOLPendingFees.Width = 37;
            // 
            // GCOLReAdmission
            // 
            this.GCOLReAdmission.ColumnEdit = this.RIBRestore;
            this.GCOLReAdmission.Name = "GCOLReAdmission";
            this.GCOLReAdmission.Visible = true;
            this.GCOLReAdmission.VisibleIndex = 14;
            this.GCOLReAdmission.Width = 34;
            // 
            // RIBRestore
            // 
            this.RIBRestore.AutoHeight = false;
            this.RIBRestore.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("RIBRestore.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.RIBRestore.Name = "RIBRestore";
            this.RIBRestore.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.RIBRestore.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RIBRestore_ButtonClick);
            // 
            // GCOLDropOut
            // 
            this.GCOLDropOut.ColumnEdit = this.RIBDropOut;
            this.GCOLDropOut.Name = "GCOLDropOut";
            this.GCOLDropOut.Visible = true;
            this.GCOLDropOut.VisibleIndex = 13;
            this.GCOLDropOut.Width = 34;
            // 
            // RIBDropOut
            // 
            this.RIBDropOut.AutoHeight = false;
            this.RIBDropOut.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("RIBDropOut.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, "", null, null, true)});
            this.RIBDropOut.Name = "RIBDropOut";
            this.RIBDropOut.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.RIBDropOut.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RIBDropOut_ButtonClick);
            // 
            // GCOLEditAction
            // 
            this.GCOLEditAction.ColumnEdit = this.RIBEdit;
            this.GCOLEditAction.Name = "GCOLEditAction";
            this.GCOLEditAction.Visible = true;
            this.GCOLEditAction.VisibleIndex = 15;
            this.GCOLEditAction.Width = 34;
            // 
            // GCOLDeleteAction
            // 
            this.GCOLDeleteAction.ColumnEdit = this.RIBDelete;
            this.GCOLDeleteAction.Name = "GCOLDeleteAction";
            this.GCOLDeleteAction.Visible = true;
            this.GCOLDeleteAction.VisibleIndex = 16;
            this.GCOLDeleteAction.Width = 67;
            // 
            // GCAdmissionDetail
            // 
            this.GCAdmissionDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCAdmissionDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GCAdmissionDetail.Location = new System.Drawing.Point(3, 53);
            this.GCAdmissionDetail.MainView = this.GVAdmissionDetail;
            this.GCAdmissionDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GCAdmissionDetail.Name = "GCAdmissionDetail";
            this.GCAdmissionDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RIBEdit,
            this.RIBDelete,
            this.RIBDropOut,
            this.RIBRestore,
            this.RIBExamStatus});
            this.GCAdmissionDetail.Size = new System.Drawing.Size(1057, 658);
            this.GCAdmissionDetail.TabIndex = 1;
            this.GCAdmissionDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVAdmissionDetail});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ddlLabs);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.ddlFromToTimeList);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.btnDeleteAll);
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 41);
            this.panel1.TabIndex = 2;
            // 
            // ddlLabs
            // 
            this.ddlLabs.Dock = System.Windows.Forms.DockStyle.Left;
            this.ddlLabs.Location = new System.Drawing.Point(485, 0);
            this.ddlLabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddlLabs.MaximumSize = new System.Drawing.Size(233, 34);
            this.ddlLabs.MinimumSize = new System.Drawing.Size(233, 34);
            this.ddlLabs.Name = "ddlLabs";
            this.ddlLabs.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddlLabs.Properties.NullText = "";
            this.ddlLabs.Size = new System.Drawing.Size(233, 22);
            this.ddlLabs.TabIndex = 6;
            this.ddlLabs.EditValueChanged += new System.EventHandler(this.ddlFromToTimeList_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl2.Location = new System.Drawing.Point(359, 0);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(126, 41);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "       Labs";
            // 
            // ddlFromToTimeList
            // 
            this.ddlFromToTimeList.Dock = System.Windows.Forms.DockStyle.Left;
            this.ddlFromToTimeList.Location = new System.Drawing.Point(126, 0);
            this.ddlFromToTimeList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ddlFromToTimeList.MaximumSize = new System.Drawing.Size(233, 34);
            this.ddlFromToTimeList.MinimumSize = new System.Drawing.Size(233, 34);
            this.ddlFromToTimeList.Name = "ddlFromToTimeList";
            this.ddlFromToTimeList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddlFromToTimeList.Properties.NullText = "";
            this.ddlFromToTimeList.Size = new System.Drawing.Size(233, 22);
            this.ddlFromToTimeList.TabIndex = 4;
            this.ddlFromToTimeList.EditValueChanged += new System.EventHandler(this.ddlFromToTimeList_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 41);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Batch Time Filter";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.Appearance.Options.UseFont = true;
            this.btnDeleteAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Image")));
            this.btnDeleteAll.Location = new System.Drawing.Point(777, 0);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(140, 41);
            this.btnDeleteAll.TabIndex = 1;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.Visible = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // TLPMasterValuesList
            // 
            this.TLPMasterValuesList.ColumnCount = 1;
            this.TLPMasterValuesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPMasterValuesList.Controls.Add(this.GCAdmissionDetail, 0, 1);
            this.TLPMasterValuesList.Controls.Add(this.panel1, 0, 0);
            this.TLPMasterValuesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMasterValuesList.Location = new System.Drawing.Point(0, 0);
            this.TLPMasterValuesList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TLPMasterValuesList.Name = "TLPMasterValuesList";
            this.TLPMasterValuesList.RowCount = 2;
            this.TLPMasterValuesList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.TLPMasterValuesList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValuesList.Size = new System.Drawing.Size(1063, 709);
            this.TLPMasterValuesList.TabIndex = 4;
            // 
            // FrmAdmissionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 709);
            this.Controls.Add(this.TLPMasterValuesList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAdmissionDetail";
            this.Text = "Admission Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdmissionDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RIBExamStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVAdmissionDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBDropOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCAdmissionDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddlLabs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlFromToTimeList.Properties)).EndInit();
            this.TLPMasterValuesList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBEdit;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLAdmissionDate;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLNoOfInstallments;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLCouserTimePeriod;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLCouseFee;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLToTime;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLFromTime;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLRefMasterValues_CourseId;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLStudentName;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLRefEnquiryMaster_EnquiryId;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLAdmissionCode;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLAdmissionId;
        public DevExpress.XtraGrid.Views.Grid.GridView GVAdmissionDetail;
        public DevExpress.XtraGrid.GridControl GCAdmissionDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel TLPMasterValuesList;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLCourseType;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLEditAction;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLDeleteAction;
        private DevExpress.XtraEditors.SimpleButton btnDeleteAll;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLDropOut;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBDropOut;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLReAdmission;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBRestore;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLExamDone;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBExamStatus;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLPendingFees;
        private DevExpress.XtraEditors.LookUpEdit ddlFromToTimeList;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLSrNo;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLCourseName;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLLab;
        private DevExpress.XtraEditors.LookUpEdit ddlLabs;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLContactNo;
    }
}