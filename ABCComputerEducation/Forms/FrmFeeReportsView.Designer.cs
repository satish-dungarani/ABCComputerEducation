namespace ABCComputerEducation.Forms
{
    partial class FrmFeeReportsView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GC_InstallmentDetail = new DevExpress.XtraGrid.GridControl();
            this.GV_InstallmentDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.COL_StudentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLAdmissionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_StudentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLAppNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.COL_ContactNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLEducation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLInstitution = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLCourseName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLCOurseType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLFromTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLToTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLLab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLAdmissionStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLSrNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GC_InstallmentDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_InstallmentDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.GC_InstallmentDetail, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(922, 528);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // GC_InstallmentDetail
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.GC_InstallmentDetail, 7);
            this.GC_InstallmentDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GC_InstallmentDetail.Location = new System.Drawing.Point(3, 3);
            this.GC_InstallmentDetail.MainView = this.GV_InstallmentDetail;
            this.GC_InstallmentDetail.Name = "GC_InstallmentDetail";
            this.GC_InstallmentDetail.Size = new System.Drawing.Size(917, 522);
            this.GC_InstallmentDetail.TabIndex = 0;
            this.GC_InstallmentDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GV_InstallmentDetail});
            // 
            // GV_InstallmentDetail
            // 
            this.GV_InstallmentDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.COL_StudentId,
            this.GCOLSrNo,
            this.GCOLAdmissionDate,
            this.COL_StudentName,
            this.GCOLAppNo,
            this.COL_Address,
            this.COL_ContactNo,
            this.GCOLEducation,
            this.GCOLInstitution,
            this.GCOLCourseName,
            this.GCOLCOurseType,
            this.GCOLFromTime,
            this.GCOLToTime,
            this.GCOLLab,
            this.GCOLAdmissionStatus});
            this.GV_InstallmentDetail.GridControl = this.GC_InstallmentDetail;
            this.GV_InstallmentDetail.Name = "GV_InstallmentDetail";
            this.GV_InstallmentDetail.OptionsCustomization.AllowColumnMoving = false;
            this.GV_InstallmentDetail.OptionsFind.AlwaysVisible = true;
            this.GV_InstallmentDetail.OptionsView.ShowFooter = true;
            // 
            // COL_StudentId
            // 
            this.COL_StudentId.Caption = "Student Id";
            this.COL_StudentId.FieldName = "StudentId";
            this.COL_StudentId.Name = "COL_StudentId";
            // 
            // GCOLAdmissionDate
            // 
            this.GCOLAdmissionDate.Caption = "Admission Date";
            this.GCOLAdmissionDate.FieldName = "AdmissionDate";
            this.GCOLAdmissionDate.Name = "GCOLAdmissionDate";
            this.GCOLAdmissionDate.OptionsColumn.AllowEdit = false;
            this.GCOLAdmissionDate.OptionsColumn.AllowFocus = false;
            this.GCOLAdmissionDate.Visible = true;
            this.GCOLAdmissionDate.VisibleIndex = 2;
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
            // GCOLAppNo
            // 
            this.GCOLAppNo.Caption = "App/ No.";
            this.GCOLAppNo.FieldName = "No";
            this.GCOLAppNo.Name = "GCOLAppNo";
            this.GCOLAppNo.OptionsColumn.AllowEdit = false;
            this.GCOLAppNo.OptionsColumn.AllowFocus = false;
            this.GCOLAppNo.Visible = true;
            this.GCOLAppNo.VisibleIndex = 4;
            // 
            // COL_Address
            // 
            this.COL_Address.Caption = "Address";
            this.COL_Address.FieldName = "Address";
            this.COL_Address.Name = "COL_Address";
            this.COL_Address.OptionsColumn.AllowEdit = false;
            this.COL_Address.OptionsColumn.AllowFocus = false;
            this.COL_Address.Visible = true;
            this.COL_Address.VisibleIndex = 3;
            // 
            // COL_ContactNo
            // 
            this.COL_ContactNo.Caption = "Contact No";
            this.COL_ContactNo.FieldName = "ContactNumber";
            this.COL_ContactNo.Name = "COL_ContactNo";
            this.COL_ContactNo.OptionsColumn.AllowEdit = false;
            this.COL_ContactNo.OptionsColumn.AllowFocus = false;
            this.COL_ContactNo.Visible = true;
            this.COL_ContactNo.VisibleIndex = 5;
            // 
            // GCOLEducation
            // 
            this.GCOLEducation.Caption = "Education";
            this.GCOLEducation.FieldName = "LastEducation";
            this.GCOLEducation.Name = "GCOLEducation";
            this.GCOLEducation.OptionsColumn.AllowEdit = false;
            this.GCOLEducation.OptionsColumn.AllowFocus = false;
            this.GCOLEducation.Visible = true;
            this.GCOLEducation.VisibleIndex = 6;
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
            this.GCOLCourseName.VisibleIndex = 8;
            // 
            // GCOLCOurseType
            // 
            this.GCOLCOurseType.Caption = "Course Type";
            this.GCOLCOurseType.FieldName = "CourseType";
            this.GCOLCOurseType.Name = "GCOLCOurseType";
            this.GCOLCOurseType.OptionsColumn.AllowEdit = false;
            this.GCOLCOurseType.OptionsColumn.AllowFocus = false;
            this.GCOLCOurseType.Visible = true;
            this.GCOLCOurseType.VisibleIndex = 9;
            // 
            // GCOLFromTime
            // 
            this.GCOLFromTime.Caption = "From Time";
            this.GCOLFromTime.FieldName = "FromTime";
            this.GCOLFromTime.Name = "GCOLFromTime";
            this.GCOLFromTime.OptionsColumn.AllowEdit = false;
            this.GCOLFromTime.OptionsColumn.AllowFocus = false;
            this.GCOLFromTime.Visible = true;
            this.GCOLFromTime.VisibleIndex = 10;
            // 
            // GCOLToTime
            // 
            this.GCOLToTime.Caption = "To Time";
            this.GCOLToTime.FieldName = "ToTime";
            this.GCOLToTime.Name = "GCOLToTime";
            this.GCOLToTime.OptionsColumn.AllowEdit = false;
            this.GCOLToTime.OptionsColumn.AllowFocus = false;
            this.GCOLToTime.Visible = true;
            this.GCOLToTime.VisibleIndex = 11;
            // 
            // GCOLLab
            // 
            this.GCOLLab.Caption = "Lab";
            this.GCOLLab.FieldName = "Lab";
            this.GCOLLab.Name = "GCOLLab";
            this.GCOLLab.OptionsColumn.AllowEdit = false;
            this.GCOLLab.OptionsColumn.AllowFocus = false;
            this.GCOLLab.Visible = true;
            this.GCOLLab.VisibleIndex = 12;
            // 
            // GCOLAdmissionStatus
            // 
            this.GCOLAdmissionStatus.Caption = "Status";
            this.GCOLAdmissionStatus.FieldName = "AdmissionStatus";
            this.GCOLAdmissionStatus.Name = "GCOLAdmissionStatus";
            this.GCOLAdmissionStatus.OptionsColumn.AllowEdit = false;
            this.GCOLAdmissionStatus.OptionsColumn.AllowFocus = false;
            this.GCOLAdmissionStatus.Visible = true;
            this.GCOLAdmissionStatus.VisibleIndex = 13;
            // 
            // GCOLSrNo
            // 
            this.GCOLSrNo.Caption = "Sr No";
            this.GCOLSrNo.FieldName = "SrNo";
            this.GCOLSrNo.Name = "GCOLSrNo";
            this.GCOLSrNo.OptionsColumn.AllowEdit = false;
            this.GCOLSrNo.OptionsColumn.AllowFocus = false;
            this.GCOLSrNo.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "SrNo", "{0}")});
            this.GCOLSrNo.Visible = true;
            this.GCOLSrNo.VisibleIndex = 0;
            // 
            // FrmFeeReportsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 528);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmFeeReportsView";
            this.Text = "Report View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmFeeReportsView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GC_InstallmentDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GV_InstallmentDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl GC_InstallmentDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView GV_InstallmentDetail;
        private DevExpress.XtraGrid.Columns.GridColumn COL_StudentId;
        private DevExpress.XtraGrid.Columns.GridColumn COL_StudentName;
        private DevExpress.XtraGrid.Columns.GridColumn COL_Address;
        private DevExpress.XtraGrid.Columns.GridColumn COL_ContactNo;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLAdmissionDate;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLAppNo;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLEducation;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLInstitution;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLCourseName;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLCOurseType;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLFromTime;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLToTime;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLLab;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLAdmissionStatus;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLSrNo;

    }
}