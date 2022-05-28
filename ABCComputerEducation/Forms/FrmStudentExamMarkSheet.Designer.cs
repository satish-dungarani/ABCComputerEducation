namespace ABCComputerEducation.Forms
{
    partial class FrmStudentExamMarkSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentExamMarkSheet));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.RIBDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCOLDeleteAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIBEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCOLEditAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLExamResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLExamDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLRefAdmissionMaster_AdmissionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLMarkSheetNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLMarkSheetId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GVStudentExamMarkSheet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCOLStudentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCStudentExamMarkSheet = new DevExpress.XtraGrid.GridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TLPMasterValuesList = new System.Windows.Forms.TableLayoutPanel();
            this.GCOLContactNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RIBDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVStudentExamMarkSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCStudentExamMarkSheet)).BeginInit();
            this.panel1.SuspendLayout();
            this.TLPMasterValuesList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Appearance.Options.UseFont = true;
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(767, 0);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(120, 34);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // RIBDelete
            // 
            this.RIBDelete.AutoHeight = false;
            this.RIBDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("RIBDelete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.RIBDelete.Name = "RIBDelete";
            this.RIBDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.RIBDelete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RIBDelete_ButtonClick);
            // 
            // GCOLDeleteAction
            // 
            this.GCOLDeleteAction.ColumnEdit = this.RIBDelete;
            this.GCOLDeleteAction.Name = "GCOLDeleteAction";
            this.GCOLDeleteAction.Visible = true;
            this.GCOLDeleteAction.VisibleIndex = 5;
            // 
            // RIBEdit
            // 
            this.RIBEdit.AutoHeight = false;
            this.RIBEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("RIBEdit.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.RIBEdit.Name = "RIBEdit";
            this.RIBEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // GCOLEditAction
            // 
            this.GCOLEditAction.ColumnEdit = this.RIBEdit;
            this.GCOLEditAction.Name = "GCOLEditAction";
            // 
            // GCOLExamResult
            // 
            this.GCOLExamResult.Caption = "Exam Result";
            this.GCOLExamResult.FieldName = "ExamResult";
            this.GCOLExamResult.Name = "GCOLExamResult";
            this.GCOLExamResult.OptionsColumn.AllowEdit = false;
            this.GCOLExamResult.OptionsColumn.AllowFocus = false;
            this.GCOLExamResult.Visible = true;
            this.GCOLExamResult.VisibleIndex = 4;
            // 
            // GCOLExamDate
            // 
            this.GCOLExamDate.Caption = "Exam Date";
            this.GCOLExamDate.FieldName = "ExamDate";
            this.GCOLExamDate.Name = "GCOLExamDate";
            this.GCOLExamDate.OptionsColumn.AllowEdit = false;
            this.GCOLExamDate.OptionsColumn.AllowFocus = false;
            this.GCOLExamDate.Visible = true;
            this.GCOLExamDate.VisibleIndex = 3;
            // 
            // GCOLRefAdmissionMaster_AdmissionId
            // 
            this.GCOLRefAdmissionMaster_AdmissionId.Caption = "Admission Id";
            this.GCOLRefAdmissionMaster_AdmissionId.FieldName = "RefAdmissionMaster_AdmissionId";
            this.GCOLRefAdmissionMaster_AdmissionId.Name = "GCOLRefAdmissionMaster_AdmissionId";
            this.GCOLRefAdmissionMaster_AdmissionId.OptionsColumn.AllowEdit = false;
            this.GCOLRefAdmissionMaster_AdmissionId.OptionsColumn.AllowFocus = false;
            // 
            // GCOLMarkSheetNo
            // 
            this.GCOLMarkSheetNo.Caption = "Mark Sheet No";
            this.GCOLMarkSheetNo.FieldName = "MarkSheetNo";
            this.GCOLMarkSheetNo.Name = "GCOLMarkSheetNo";
            this.GCOLMarkSheetNo.OptionsColumn.AllowEdit = false;
            this.GCOLMarkSheetNo.OptionsColumn.AllowFocus = false;
            this.GCOLMarkSheetNo.Visible = true;
            this.GCOLMarkSheetNo.VisibleIndex = 0;
            // 
            // GCOLMarkSheetId
            // 
            this.GCOLMarkSheetId.Caption = "MarkSheet Id";
            this.GCOLMarkSheetId.FieldName = "MarkSheetId";
            this.GCOLMarkSheetId.Name = "GCOLMarkSheetId";
            this.GCOLMarkSheetId.OptionsColumn.AllowEdit = false;
            this.GCOLMarkSheetId.OptionsColumn.AllowFocus = false;
            // 
            // GVStudentExamMarkSheet
            // 
            this.GVStudentExamMarkSheet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCOLMarkSheetId,
            this.GCOLMarkSheetNo,
            this.GCOLRefAdmissionMaster_AdmissionId,
            this.GCOLStudentName,
            this.GCOLContactNo,
            this.GCOLExamDate,
            this.GCOLExamResult,
            this.GCOLEditAction,
            this.GCOLDeleteAction});
            this.GVStudentExamMarkSheet.GridControl = this.GCStudentExamMarkSheet;
            this.GVStudentExamMarkSheet.Name = "GVStudentExamMarkSheet";
            this.GVStudentExamMarkSheet.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GVStudentExamMarkSheet.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GVStudentExamMarkSheet.OptionsCustomization.AllowQuickHideColumns = false;
            this.GVStudentExamMarkSheet.OptionsFind.AlwaysVisible = true;
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
            // GCStudentExamMarkSheet
            // 
            this.GCStudentExamMarkSheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCStudentExamMarkSheet.Location = new System.Drawing.Point(3, 43);
            this.GCStudentExamMarkSheet.MainView = this.GVStudentExamMarkSheet;
            this.GCStudentExamMarkSheet.Name = "GCStudentExamMarkSheet";
            this.GCStudentExamMarkSheet.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RIBEdit,
            this.RIBDelete});
            this.GCStudentExamMarkSheet.Size = new System.Drawing.Size(887, 545);
            this.GCStudentExamMarkSheet.TabIndex = 1;
            this.GCStudentExamMarkSheet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVStudentExamMarkSheet});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 34);
            this.panel1.TabIndex = 2;
            // 
            // TLPMasterValuesList
            // 
            this.TLPMasterValuesList.ColumnCount = 1;
            this.TLPMasterValuesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPMasterValuesList.Controls.Add(this.GCStudentExamMarkSheet, 0, 1);
            this.TLPMasterValuesList.Controls.Add(this.panel1, 0, 0);
            this.TLPMasterValuesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMasterValuesList.Location = new System.Drawing.Point(0, 0);
            this.TLPMasterValuesList.Name = "TLPMasterValuesList";
            this.TLPMasterValuesList.RowCount = 2;
            this.TLPMasterValuesList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLPMasterValuesList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValuesList.Size = new System.Drawing.Size(893, 591);
            this.TLPMasterValuesList.TabIndex = 4;
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
            // FrmStudentExamMarkSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 591);
            this.Controls.Add(this.TLPMasterValuesList);
            this.Name = "FrmStudentExamMarkSheet";
            this.Text = "Student Exam Mark Sheet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStudentExamMarkSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RIBDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVStudentExamMarkSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GCStudentExamMarkSheet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.TLPMasterValuesList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBDelete;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLDeleteAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBEdit;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLEditAction;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLExamResult;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLExamDate;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLRefAdmissionMaster_AdmissionId;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLMarkSheetNo;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLMarkSheetId;
        public DevExpress.XtraGrid.Views.Grid.GridView GVStudentExamMarkSheet;
        public DevExpress.XtraGrid.GridControl GCStudentExamMarkSheet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel TLPMasterValuesList;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLStudentName;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLContactNo;
    }
}