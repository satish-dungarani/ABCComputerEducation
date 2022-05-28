namespace ABCComputerEducation.Forms
{
    partial class FrmStudentExamMarkSheetEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentExamMarkSheetEntry));
            this.lblMarkSheetNo = new DevExpress.XtraEditors.LabelControl();
            this.lblExamDate = new DevExpress.XtraEditors.LabelControl();
            this.txtMarkSheetNo = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtMarkSheetId = new DevExpress.XtraEditors.TextEdit();
            this.lblStudent = new DevExpress.XtraEditors.LabelControl();
            this.lblAdmissionId = new DevExpress.XtraEditors.LabelControl();
            this.lblExamResult = new DevExpress.XtraEditors.LabelControl();
            this.TLPMasterValues = new System.Windows.Forms.TableLayoutPanel();
            this.dtpExamDate = new DevExpress.XtraEditors.DateEdit();
            this.ddlAdmissionId = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.SLEV_Admission = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.COL_AdmissionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_AdmissionCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_StudentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_CourseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_BatchNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_RefStudentMaster_StudentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.txtStudentName = new DevExpress.XtraEditors.TextEdit();
            this.ddlExamResult = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkSheetNo.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkSheetId.Properties)).BeginInit();
            this.TLPMasterValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExamDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExamDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlAdmissionId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SLEV_Admission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlExamResult.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarkSheetNo
            // 
            this.lblMarkSheetNo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkSheetNo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMarkSheetNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMarkSheetNo.Location = new System.Drawing.Point(45, 91);
            this.lblMarkSheetNo.Name = "lblMarkSheetNo";
            this.lblMarkSheetNo.Size = new System.Drawing.Size(116, 36);
            this.lblMarkSheetNo.TabIndex = 0;
            this.lblMarkSheetNo.Text = "Exam No";
            // 
            // lblExamDate
            // 
            this.lblExamDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblExamDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExamDate.Location = new System.Drawing.Point(45, 217);
            this.lblExamDate.Name = "lblExamDate";
            this.lblExamDate.Size = new System.Drawing.Size(116, 36);
            this.lblExamDate.TabIndex = 2;
            this.lblExamDate.Text = "Exam Date";
            // 
            // txtMarkSheetNo
            // 
            this.TLPMasterValues.SetColumnSpan(this.txtMarkSheetNo, 3);
            this.txtMarkSheetNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMarkSheetNo.EnterMoveNextControl = true;
            this.txtMarkSheetNo.Location = new System.Drawing.Point(167, 91);
            this.txtMarkSheetNo.Name = "txtMarkSheetNo";
            this.txtMarkSheetNo.Properties.AutoHeight = false;
            this.txtMarkSheetNo.Properties.ReadOnly = true;
            this.txtMarkSheetNo.Size = new System.Drawing.Size(530, 36);
            this.txtMarkSheetNo.TabIndex = 0;
            // 
            // panel1
            // 
            this.TLPMasterValues.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtMarkSheetId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(167, 277);
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
            // txtMarkSheetId
            // 
            this.txtMarkSheetId.EditValue = "0";
            this.txtMarkSheetId.Location = new System.Drawing.Point(3, 3);
            this.txtMarkSheetId.Name = "txtMarkSheetId";
            this.txtMarkSheetId.Size = new System.Drawing.Size(10, 20);
            this.txtMarkSheetId.TabIndex = 0;
            this.txtMarkSheetId.Visible = false;
            // 
            // lblStudent
            // 
            this.lblStudent.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStudent.Location = new System.Drawing.Point(45, 175);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(116, 36);
            this.lblStudent.TabIndex = 10;
            this.lblStudent.Text = "Student Name";
            // 
            // lblAdmissionId
            // 
            this.lblAdmissionId.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmissionId.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAdmissionId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAdmissionId.Location = new System.Drawing.Point(45, 133);
            this.lblAdmissionId.Name = "lblAdmissionId";
            this.lblAdmissionId.Size = new System.Drawing.Size(116, 36);
            this.lblAdmissionId.TabIndex = 9;
            this.lblAdmissionId.Text = "Admission";
            // 
            // lblExamResult
            // 
            this.lblExamResult.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamResult.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblExamResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExamResult.Location = new System.Drawing.Point(374, 217);
            this.lblExamResult.Name = "lblExamResult";
            this.lblExamResult.Size = new System.Drawing.Size(116, 36);
            this.lblExamResult.TabIndex = 7;
            this.lblExamResult.Text = "Exam Result";
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
            this.TLPMasterValues.Controls.Add(this.lblMarkSheetNo, 1, 3);
            this.TLPMasterValues.Controls.Add(this.lblExamDate, 1, 6);
            this.TLPMasterValues.Controls.Add(this.txtMarkSheetNo, 2, 3);
            this.TLPMasterValues.Controls.Add(this.panel1, 2, 10);
            this.TLPMasterValues.Controls.Add(this.lblAdmissionId, 1, 4);
            this.TLPMasterValues.Controls.Add(this.lblStudent, 1, 5);
            this.TLPMasterValues.Controls.Add(this.dtpExamDate, 2, 6);
            this.TLPMasterValues.Controls.Add(this.ddlAdmissionId, 2, 4);
            this.TLPMasterValues.Controls.Add(this.lblTitle, 1, 1);
            this.TLPMasterValues.Controls.Add(this.txtStudentName, 2, 5);
            this.TLPMasterValues.Controls.Add(this.ddlExamResult, 4, 6);
            this.TLPMasterValues.Controls.Add(this.lblExamResult, 3, 6);
            this.TLPMasterValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMasterValues.Location = new System.Drawing.Point(0, 0);
            this.TLPMasterValues.Name = "TLPMasterValues";
            this.TLPMasterValues.RowCount = 12;
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.TLPMasterValues.Size = new System.Drawing.Size(737, 350);
            this.TLPMasterValues.TabIndex = 4;
            // 
            // dtpExamDate
            // 
            this.dtpExamDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpExamDate.EditValue = null;
            this.dtpExamDate.EnterMoveNextControl = true;
            this.dtpExamDate.Location = new System.Drawing.Point(167, 217);
            this.dtpExamDate.Name = "dtpExamDate";
            this.dtpExamDate.Properties.AutoHeight = false;
            this.dtpExamDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpExamDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpExamDate.Properties.Mask.IgnoreMaskBlank = false;
            this.dtpExamDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpExamDate.Size = new System.Drawing.Size(201, 36);
            this.dtpExamDate.TabIndex = 3;
            // 
            // ddlAdmissionId
            // 
            this.TLPMasterValues.SetColumnSpan(this.ddlAdmissionId, 3);
            this.ddlAdmissionId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddlAdmissionId.EnterMoveNextControl = true;
            this.ddlAdmissionId.Location = new System.Drawing.Point(167, 133);
            this.ddlAdmissionId.Name = "ddlAdmissionId";
            this.ddlAdmissionId.Properties.AutoHeight = false;
            this.ddlAdmissionId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddlAdmissionId.Properties.NullText = "";
            this.ddlAdmissionId.Properties.View = this.SLEV_Admission;
            this.ddlAdmissionId.Size = new System.Drawing.Size(530, 36);
            this.ddlAdmissionId.TabIndex = 1;
            this.ddlAdmissionId.EditValueChanged += new System.EventHandler(this.ddlAdmissionId_EditValueChanged);
            // 
            // SLEV_Admission
            // 
            this.SLEV_Admission.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.COL_AdmissionId,
            this.COL_AdmissionCode,
            this.COL_StudentName,
            this.COL_CourseName,
            this.COL_BatchNo,
            this.COL_RefStudentMaster_StudentId});
            this.SLEV_Admission.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.SLEV_Admission.Name = "SLEV_Admission";
            this.SLEV_Admission.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.SLEV_Admission.OptionsView.ShowGroupPanel = false;
            // 
            // COL_AdmissionId
            // 
            this.COL_AdmissionId.Caption = "Admission Id";
            this.COL_AdmissionId.FieldName = "AdmissionId";
            this.COL_AdmissionId.Name = "COL_AdmissionId";
            // 
            // COL_AdmissionCode
            // 
            this.COL_AdmissionCode.Caption = "Admission Code";
            this.COL_AdmissionCode.FieldName = "AdmissionCode";
            this.COL_AdmissionCode.Name = "COL_AdmissionCode";
            this.COL_AdmissionCode.OptionsColumn.AllowEdit = false;
            this.COL_AdmissionCode.OptionsColumn.AllowFocus = false;
            this.COL_AdmissionCode.Visible = true;
            this.COL_AdmissionCode.VisibleIndex = 0;
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
            // COL_CourseName
            // 
            this.COL_CourseName.Caption = "Course Name";
            this.COL_CourseName.FieldName = "CourseName";
            this.COL_CourseName.Name = "COL_CourseName";
            this.COL_CourseName.OptionsColumn.AllowEdit = false;
            this.COL_CourseName.OptionsColumn.AllowFocus = false;
            this.COL_CourseName.Visible = true;
            this.COL_CourseName.VisibleIndex = 2;
            // 
            // COL_BatchNo
            // 
            this.COL_BatchNo.Caption = "Batch No";
            this.COL_BatchNo.FieldName = "BatchNo";
            this.COL_BatchNo.Name = "COL_BatchNo";
            this.COL_BatchNo.OptionsColumn.AllowEdit = false;
            this.COL_BatchNo.OptionsColumn.AllowFocus = false;
            this.COL_BatchNo.Visible = true;
            this.COL_BatchNo.VisibleIndex = 3;
            // 
            // COL_RefStudentMaster_StudentId
            // 
            this.COL_RefStudentMaster_StudentId.Caption = "Student Id";
            this.COL_RefStudentMaster_StudentId.FieldName = "RefStudentMaster_StudentId";
            this.COL_RefStudentMaster_StudentId.Name = "COL_RefStudentMaster_StudentId";
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
            this.lblTitle.Size = new System.Drawing.Size(652, 42);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "labelControl1";
            // 
            // txtStudentName
            // 
            this.TLPMasterValues.SetColumnSpan(this.txtStudentName, 3);
            this.txtStudentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStudentName.Location = new System.Drawing.Point(167, 175);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Properties.AutoHeight = false;
            this.txtStudentName.Properties.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(530, 36);
            this.txtStudentName.TabIndex = 2;
            // 
            // ddlExamResult
            // 
            this.ddlExamResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddlExamResult.EnterMoveNextControl = true;
            this.ddlExamResult.Location = new System.Drawing.Point(496, 217);
            this.ddlExamResult.Name = "ddlExamResult";
            this.ddlExamResult.Properties.AutoHeight = false;
            this.ddlExamResult.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ddlExamResult.Properties.Items.AddRange(new object[] {
            "Done"});
            this.ddlExamResult.Properties.ReadOnly = true;
            this.ddlExamResult.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ddlExamResult.Size = new System.Drawing.Size(201, 36);
            this.ddlExamResult.TabIndex = 7;
            // 
            // FrmStudentExamMarkSheetEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 350);
            this.Controls.Add(this.TLPMasterValues);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStudentExamMarkSheetEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Exam Marks";
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkSheetNo.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMarkSheetId.Properties)).EndInit();
            this.TLPMasterValues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpExamDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpExamDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlAdmissionId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SLEV_Admission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlExamResult.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.LabelControl lblMarkSheetNo;
        public DevExpress.XtraEditors.LabelControl lblExamDate;
        public DevExpress.XtraEditors.TextEdit txtMarkSheetNo;
        private System.Windows.Forms.TableLayoutPanel TLPMasterValues;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        public DevExpress.XtraEditors.TextEdit txtMarkSheetId;
        private DevExpress.XtraEditors.LabelControl lblAdmissionId;
        private DevExpress.XtraEditors.LabelControl lblStudent;
        public DevExpress.XtraEditors.LabelControl lblExamResult;
        public DevExpress.XtraEditors.DateEdit dtpExamDate;
        public DevExpress.XtraEditors.ComboBoxEdit ddlExamResult;
        private DevExpress.XtraGrid.Views.Grid.GridView SLEV_Admission;
        public DevExpress.XtraEditors.SearchLookUpEdit ddlAdmissionId;
        private DevExpress.XtraGrid.Columns.GridColumn COL_AdmissionId;
        private DevExpress.XtraGrid.Columns.GridColumn COL_AdmissionCode;
        private DevExpress.XtraGrid.Columns.GridColumn COL_StudentName;
        private DevExpress.XtraGrid.Columns.GridColumn COL_CourseName;
        private DevExpress.XtraGrid.Columns.GridColumn COL_BatchNo;
        private DevExpress.XtraGrid.Columns.GridColumn COL_RefStudentMaster_StudentId;
        public DevExpress.XtraEditors.LabelControl lblTitle;
        public DevExpress.XtraEditors.TextEdit txtStudentName;
    }
}