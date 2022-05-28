namespace ABCComputerEducation.Forms
{
    partial class FrmCertyRegistrationEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCertyRegistrationEntry));
            this.lblRegNo = new DevExpress.XtraEditors.LabelControl();
            this.txtRegNo = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtCertyId = new DevExpress.XtraEditors.TextEdit();
            this.lblMarkSheetId = new DevExpress.XtraEditors.LabelControl();
            this.lblStudent = new DevExpress.XtraEditors.LabelControl();
            this.lblReceiveDate = new DevExpress.XtraEditors.LabelControl();
            this.lblCertyType = new DevExpress.XtraEditors.LabelControl();
            this.lblRequestDate = new DevExpress.XtraEditors.LabelControl();
            this.lblIssueDate = new DevExpress.XtraEditors.LabelControl();
            this.dtpRequestDate = new DevExpress.XtraEditors.DateEdit();
            this.ddlCertyType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TLPMasterValues = new System.Windows.Forms.TableLayoutPanel();
            this.ddlMarkSheetId = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.SLEV_MarkSheet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.COL_MarkSheetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_MarkSheetNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_RefStudentMaster_StudentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_StudentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_EaxmResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.txtStudentName = new DevExpress.XtraEditors.TextEdit();
            this.dtpReceiveDate = new DevExpress.XtraEditors.DateEdit();
            this.dtpIssueDate = new DevExpress.XtraEditors.DateEdit();
            this.COL_CertyType = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegNo.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCertyId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRequestDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRequestDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCertyType.Properties)).BeginInit();
            this.TLPMasterValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlMarkSheetId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SLEV_MarkSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReceiveDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReceiveDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpIssueDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpIssueDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegNo
            // 
            this.lblRegNo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRegNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRegNo.Location = new System.Drawing.Point(45, 101);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(116, 36);
            this.lblRegNo.TabIndex = 0;
            this.lblRegNo.Text = "Registration No";
            // 
            // txtRegNo
            // 
            this.TLPMasterValues.SetColumnSpan(this.txtRegNo, 3);
            this.txtRegNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRegNo.EnterMoveNextControl = true;
            this.txtRegNo.Location = new System.Drawing.Point(167, 101);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Properties.AutoHeight = false;
            this.txtRegNo.Properties.ReadOnly = true;
            this.txtRegNo.Size = new System.Drawing.Size(530, 36);
            this.txtRegNo.TabIndex = 0;
            // 
            // panel1
            // 
            this.TLPMasterValues.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtCertyId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(167, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 45);
            this.panel1.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(302, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 45);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(416, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 45);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCertyId
            // 
            this.txtCertyId.EditValue = "0";
            this.txtCertyId.Location = new System.Drawing.Point(3, 3);
            this.txtCertyId.Name = "txtCertyId";
            this.txtCertyId.Size = new System.Drawing.Size(10, 20);
            this.txtCertyId.TabIndex = 0;
            this.txtCertyId.Visible = false;
            // 
            // lblMarkSheetId
            // 
            this.lblMarkSheetId.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkSheetId.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMarkSheetId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMarkSheetId.Location = new System.Drawing.Point(45, 143);
            this.lblMarkSheetId.Name = "lblMarkSheetId";
            this.lblMarkSheetId.Size = new System.Drawing.Size(116, 36);
            this.lblMarkSheetId.TabIndex = 9;
            this.lblMarkSheetId.Text = "Mark Sheet No";
            // 
            // lblStudent
            // 
            this.lblStudent.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStudent.Location = new System.Drawing.Point(45, 185);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(116, 36);
            this.lblStudent.TabIndex = 10;
            this.lblStudent.Text = "Student Name";
            // 
            // lblReceiveDate
            // 
            this.lblReceiveDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiveDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblReceiveDate.Location = new System.Drawing.Point(45, 269);
            this.lblReceiveDate.Name = "lblReceiveDate";
            this.lblReceiveDate.Size = new System.Drawing.Size(116, 36);
            this.lblReceiveDate.TabIndex = 17;
            this.lblReceiveDate.Text = "Receive Date";
            // 
            // lblCertyType
            // 
            this.lblCertyType.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertyType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCertyType.Location = new System.Drawing.Point(45, 227);
            this.lblCertyType.Name = "lblCertyType";
            this.lblCertyType.Size = new System.Drawing.Size(116, 36);
            this.lblCertyType.TabIndex = 12;
            this.lblCertyType.Text = "Certy Type";
            // 
            // lblRequestDate
            // 
            this.lblRequestDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRequestDate.Location = new System.Drawing.Point(374, 227);
            this.lblRequestDate.Name = "lblRequestDate";
            this.lblRequestDate.Size = new System.Drawing.Size(116, 36);
            this.lblRequestDate.TabIndex = 19;
            this.lblRequestDate.Text = "Request Date";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblIssueDate.Location = new System.Drawing.Point(374, 269);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(116, 36);
            this.lblIssueDate.TabIndex = 20;
            this.lblIssueDate.Text = "Issue Date";
            // 
            // dtpRequestDate
            // 
            this.dtpRequestDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpRequestDate.EditValue = null;
            this.dtpRequestDate.EnterMoveNextControl = true;
            this.dtpRequestDate.Location = new System.Drawing.Point(496, 227);
            this.dtpRequestDate.MaximumSize = new System.Drawing.Size(0, 36);
            this.dtpRequestDate.MinimumSize = new System.Drawing.Size(0, 36);
            this.dtpRequestDate.Name = "dtpRequestDate";
            this.dtpRequestDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpRequestDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpRequestDate.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.dtpRequestDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dtpRequestDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpRequestDate.Size = new System.Drawing.Size(201, 36);
            this.dtpRequestDate.TabIndex = 4;
            // 
            // ddlCertyType
            // 
            this.ddlCertyType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddlCertyType.EnterMoveNextControl = true;
            this.ddlCertyType.Location = new System.Drawing.Point(167, 227);
            this.ddlCertyType.Name = "ddlCertyType";
            this.ddlCertyType.Properties.AutoHeight = false;
            this.ddlCertyType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddlCertyType.Properties.Items.AddRange(new object[] {
            "ABC",
            "RGCSM"});
            this.ddlCertyType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ddlCertyType.Size = new System.Drawing.Size(201, 36);
            this.ddlCertyType.TabIndex = 3;
            // 
            // TLPMasterValues
            // 
            this.TLPMasterValues.ColumnCount = 6;
            this.TLPMasterValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.TLPMasterValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPMasterValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPMasterValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPMasterValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPMasterValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.TLPMasterValues.Controls.Add(this.lblRegNo, 1, 3);
            this.TLPMasterValues.Controls.Add(this.txtRegNo, 2, 3);
            this.TLPMasterValues.Controls.Add(this.panel1, 2, 10);
            this.TLPMasterValues.Controls.Add(this.lblMarkSheetId, 1, 4);
            this.TLPMasterValues.Controls.Add(this.lblStudent, 1, 5);
            this.TLPMasterValues.Controls.Add(this.ddlMarkSheetId, 2, 4);
            this.TLPMasterValues.Controls.Add(this.lblTitle, 1, 1);
            this.TLPMasterValues.Controls.Add(this.txtStudentName, 2, 5);
            this.TLPMasterValues.Controls.Add(this.lblCertyType, 1, 6);
            this.TLPMasterValues.Controls.Add(this.ddlCertyType, 2, 6);
            this.TLPMasterValues.Controls.Add(this.lblRequestDate, 3, 6);
            this.TLPMasterValues.Controls.Add(this.dtpRequestDate, 4, 6);
            this.TLPMasterValues.Controls.Add(this.lblReceiveDate, 1, 7);
            this.TLPMasterValues.Controls.Add(this.lblIssueDate, 3, 7);
            this.TLPMasterValues.Controls.Add(this.dtpReceiveDate, 2, 7);
            this.TLPMasterValues.Controls.Add(this.dtpIssueDate, 4, 7);
            this.TLPMasterValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMasterValues.Location = new System.Drawing.Point(0, 0);
            this.TLPMasterValues.Name = "TLPMasterValues";
            this.TLPMasterValues.RowCount = 12;
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.TLPMasterValues.Size = new System.Drawing.Size(733, 449);
            this.TLPMasterValues.TabIndex = 0;
            // 
            // ddlMarkSheetId
            // 
            this.TLPMasterValues.SetColumnSpan(this.ddlMarkSheetId, 3);
            this.ddlMarkSheetId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddlMarkSheetId.EnterMoveNextControl = true;
            this.ddlMarkSheetId.Location = new System.Drawing.Point(167, 143);
            this.ddlMarkSheetId.Name = "ddlMarkSheetId";
            this.ddlMarkSheetId.Properties.AutoHeight = false;
            this.ddlMarkSheetId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddlMarkSheetId.Properties.NullText = "";
            this.ddlMarkSheetId.Properties.View = this.SLEV_MarkSheet;
            this.ddlMarkSheetId.Size = new System.Drawing.Size(530, 36);
            this.ddlMarkSheetId.TabIndex = 1;
            this.ddlMarkSheetId.EditValueChanged += new System.EventHandler(this.ddlMarkSheetId_EditValueChanged);
            // 
            // SLEV_MarkSheet
            // 
            this.SLEV_MarkSheet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.COL_MarkSheetId,
            this.COL_MarkSheetNo,
            this.COL_RefStudentMaster_StudentId,
            this.COL_StudentName,
            this.COL_EaxmResult,
            this.COL_CertyType});
            this.SLEV_MarkSheet.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.SLEV_MarkSheet.Name = "SLEV_MarkSheet";
            this.SLEV_MarkSheet.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.SLEV_MarkSheet.OptionsView.ShowGroupPanel = false;
            // 
            // COL_MarkSheetId
            // 
            this.COL_MarkSheetId.Caption = "Mark Sheet Id";
            this.COL_MarkSheetId.FieldName = "MarkSheetId";
            this.COL_MarkSheetId.Name = "COL_MarkSheetId";
            // 
            // COL_MarkSheetNo
            // 
            this.COL_MarkSheetNo.Caption = "MarkSheet No";
            this.COL_MarkSheetNo.FieldName = "MarkSheetNo";
            this.COL_MarkSheetNo.Name = "COL_MarkSheetNo";
            this.COL_MarkSheetNo.OptionsColumn.AllowEdit = false;
            this.COL_MarkSheetNo.OptionsColumn.AllowFocus = false;
            this.COL_MarkSheetNo.Visible = true;
            this.COL_MarkSheetNo.VisibleIndex = 0;
            // 
            // COL_RefStudentMaster_StudentId
            // 
            this.COL_RefStudentMaster_StudentId.Caption = "Student Id";
            this.COL_RefStudentMaster_StudentId.FieldName = "RefStudentMaster_StudentId";
            this.COL_RefStudentMaster_StudentId.Name = "COL_RefStudentMaster_StudentId";
            // 
            // COL_StudentName
            // 
            this.COL_StudentName.Caption = "Student Name";
            this.COL_StudentName.FieldName = "StudentName";
            this.COL_StudentName.Name = "COL_StudentName";
            this.COL_StudentName.OptionsColumn.AllowEdit = false;
            this.COL_StudentName.OptionsColumn.AllowFocus = false;
            this.COL_StudentName.Visible = true;
            this.COL_StudentName.VisibleIndex = 1;
            // 
            // COL_EaxmResult
            // 
            this.COL_EaxmResult.Caption = "Exam Result";
            this.COL_EaxmResult.FieldName = "ExamResult";
            this.COL_EaxmResult.Name = "COL_EaxmResult";
            this.COL_EaxmResult.OptionsColumn.AllowEdit = false;
            this.COL_EaxmResult.OptionsColumn.AllowFocus = false;
            this.COL_EaxmResult.Visible = true;
            this.COL_EaxmResult.VisibleIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.TLPMasterValues.SetColumnSpan(this.lblTitle, 4);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Location = new System.Drawing.Point(45, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(652, 45);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "labelControl1";
            // 
            // txtStudentName
            // 
            this.TLPMasterValues.SetColumnSpan(this.txtStudentName, 3);
            this.txtStudentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentName.EnterMoveNextControl = true;
            this.txtStudentName.Location = new System.Drawing.Point(167, 185);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Properties.AutoHeight = false;
            this.txtStudentName.Properties.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(530, 36);
            this.txtStudentName.TabIndex = 2;
            // 
            // dtpReceiveDate
            // 
            this.dtpReceiveDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpReceiveDate.EditValue = null;
            this.dtpReceiveDate.EnterMoveNextControl = true;
            this.dtpReceiveDate.Location = new System.Drawing.Point(167, 269);
            this.dtpReceiveDate.Name = "dtpReceiveDate";
            this.dtpReceiveDate.Properties.AutoHeight = false;
            this.dtpReceiveDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpReceiveDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpReceiveDate.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.dtpReceiveDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dtpReceiveDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpReceiveDate.Size = new System.Drawing.Size(201, 36);
            this.dtpReceiveDate.TabIndex = 5;
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpIssueDate.EditValue = null;
            this.dtpIssueDate.EnterMoveNextControl = true;
            this.dtpIssueDate.Location = new System.Drawing.Point(496, 269);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Properties.AutoHeight = false;
            this.dtpIssueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpIssueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpIssueDate.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Strong;
            this.dtpIssueDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dtpIssueDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpIssueDate.Size = new System.Drawing.Size(201, 36);
            this.dtpIssueDate.TabIndex = 6;
            // 
            // COL_CertyType
            // 
            this.COL_CertyType.Caption = "Certy Type";
            this.COL_CertyType.FieldName = "CourseType";
            this.COL_CertyType.Name = "COL_CertyType";
            // 
            // FrmCertyRegistrationEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 449);
            this.Controls.Add(this.TLPMasterValues);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCertyRegistrationEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Certy Registration Entry";
            this.Load += new System.EventHandler(this.FrmCertyRegistrationEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtRegNo.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCertyId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRequestDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRequestDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCertyType.Properties)).EndInit();
            this.TLPMasterValues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddlMarkSheetId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SLEV_MarkSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReceiveDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReceiveDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpIssueDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpIssueDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl lblRegNo;
        public DevExpress.XtraEditors.TextEdit txtRegNo;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        public DevExpress.XtraEditors.TextEdit txtCertyId;
        private DevExpress.XtraEditors.LabelControl lblMarkSheetId;
        private DevExpress.XtraEditors.LabelControl lblStudent;
        public DevExpress.XtraEditors.LabelControl lblReceiveDate;
        public DevExpress.XtraEditors.LabelControl lblCertyType;
        public DevExpress.XtraEditors.LabelControl lblRequestDate;
        public DevExpress.XtraEditors.LabelControl lblIssueDate;
        public DevExpress.XtraEditors.DateEdit dtpRequestDate;
        public DevExpress.XtraEditors.ComboBoxEdit ddlCertyType;
        public DevExpress.XtraEditors.DateEdit dtpIssueDate;
        public DevExpress.XtraEditors.DateEdit dtpReceiveDate;
        private DevExpress.XtraGrid.Views.Grid.GridView SLEV_MarkSheet;
        public DevExpress.XtraEditors.SearchLookUpEdit ddlMarkSheetId;
        private DevExpress.XtraGrid.Columns.GridColumn COL_MarkSheetId;
        private DevExpress.XtraGrid.Columns.GridColumn COL_MarkSheetNo;
        private DevExpress.XtraGrid.Columns.GridColumn COL_RefStudentMaster_StudentId;
        private DevExpress.XtraGrid.Columns.GridColumn COL_StudentName;
        private DevExpress.XtraGrid.Columns.GridColumn COL_EaxmResult;
        public System.Windows.Forms.TableLayoutPanel TLPMasterValues;
        public DevExpress.XtraEditors.LabelControl lblTitle;
        public DevExpress.XtraEditors.TextEdit txtStudentName;
        private DevExpress.XtraGrid.Columns.GridColumn COL_CertyType;
    }
}