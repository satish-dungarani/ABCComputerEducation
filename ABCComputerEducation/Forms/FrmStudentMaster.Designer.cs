namespace ABCComputerEducation.Forms
{
    partial class FrmStudentMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudentMaster));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.TLPMasterValuesList = new System.Windows.Forms.TableLayoutPanel();
            this.GCStudentMaster = new DevExpress.XtraGrid.GridControl();
            this.GVStudentMaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GCOLStudentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLStudentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLPincode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLContactNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLPersonalNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLFatherContactNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLRecidantialNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLEmailId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLLasteEducation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GCOLEditAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIBEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.GCOLDeleteAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIBDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
            this.TLPMasterValuesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCStudentMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVStudentMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBDelete)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPMasterValuesList
            // 
            this.TLPMasterValuesList.ColumnCount = 1;
            this.TLPMasterValuesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPMasterValuesList.Controls.Add(this.GCStudentMaster, 0, 1);
            this.TLPMasterValuesList.Controls.Add(this.panel1, 0, 0);
            this.TLPMasterValuesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMasterValuesList.Location = new System.Drawing.Point(0, 0);
            this.TLPMasterValuesList.Name = "TLPMasterValuesList";
            this.TLPMasterValuesList.RowCount = 2;
            this.TLPMasterValuesList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLPMasterValuesList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValuesList.Size = new System.Drawing.Size(844, 581);
            this.TLPMasterValuesList.TabIndex = 3;
            // 
            // GCStudentMaster
            // 
            this.GCStudentMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCStudentMaster.Location = new System.Drawing.Point(3, 43);
            this.GCStudentMaster.MainView = this.GVStudentMaster;
            this.GCStudentMaster.Name = "GCStudentMaster";
            this.GCStudentMaster.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RIBEdit,
            this.RIBDelete});
            this.GCStudentMaster.Size = new System.Drawing.Size(838, 535);
            this.GCStudentMaster.TabIndex = 1;
            this.GCStudentMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVStudentMaster});
            // 
            // GVStudentMaster
            // 
            this.GVStudentMaster.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GCOLStudentId,
            this.GCOLStudentName,
            this.GCOLGender,
            this.GCOLAddress,
            this.GCOLCity,
            this.GCOLState,
            this.GCOLPincode,
            this.GCOLContactNo,
            this.GCOLPersonalNo,
            this.GCOLFatherContactNo,
            this.GCOLRecidantialNo,
            this.GCOLEmailId,
            this.GCOLLasteEducation,
            this.GCOLEditAction,
            this.GCOLDeleteAction});
            this.GVStudentMaster.GridControl = this.GCStudentMaster;
            this.GVStudentMaster.Name = "GVStudentMaster";
            this.GVStudentMaster.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.GVStudentMaster.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.GVStudentMaster.OptionsCustomization.AllowQuickHideColumns = false;
            this.GVStudentMaster.OptionsFind.AlwaysVisible = true;
            // 
            // GCOLStudentId
            // 
            this.GCOLStudentId.Caption = "Student Id";
            this.GCOLStudentId.FieldName = "StudentId";
            this.GCOLStudentId.Name = "GCOLStudentId";
            // 
            // GCOLStudentName
            // 
            this.GCOLStudentName.Caption = "Student Name";
            this.GCOLStudentName.FieldName = "StudentName";
            this.GCOLStudentName.Name = "GCOLStudentName";
            this.GCOLStudentName.OptionsColumn.AllowEdit = false;
            this.GCOLStudentName.OptionsColumn.AllowFocus = false;
            this.GCOLStudentName.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Like;
            this.GCOLStudentName.Visible = true;
            this.GCOLStudentName.VisibleIndex = 0;
            // 
            // GCOLGender
            // 
            this.GCOLGender.Caption = "Gender";
            this.GCOLGender.FieldName = "Gender";
            this.GCOLGender.Name = "GCOLGender";
            this.GCOLGender.OptionsColumn.AllowEdit = false;
            this.GCOLGender.OptionsColumn.AllowFocus = false;
            // 
            // GCOLAddress
            // 
            this.GCOLAddress.Caption = "Address";
            this.GCOLAddress.FieldName = "Address";
            this.GCOLAddress.Name = "GCOLAddress";
            this.GCOLAddress.OptionsColumn.AllowEdit = false;
            this.GCOLAddress.OptionsColumn.AllowFocus = false;
            this.GCOLAddress.Visible = true;
            this.GCOLAddress.VisibleIndex = 1;
            // 
            // GCOLCity
            // 
            this.GCOLCity.Caption = "City";
            this.GCOLCity.FieldName = "City";
            this.GCOLCity.Name = "GCOLCity";
            this.GCOLCity.OptionsColumn.AllowEdit = false;
            this.GCOLCity.OptionsColumn.AllowFocus = false;
            // 
            // GCOLState
            // 
            this.GCOLState.Caption = "State";
            this.GCOLState.FieldName = "State";
            this.GCOLState.Name = "GCOLState";
            this.GCOLState.OptionsColumn.AllowEdit = false;
            this.GCOLState.OptionsColumn.AllowFocus = false;
            // 
            // GCOLPincode
            // 
            this.GCOLPincode.Caption = "Pincode";
            this.GCOLPincode.FieldName = "Pincode";
            this.GCOLPincode.Name = "GCOLPincode";
            this.GCOLPincode.OptionsColumn.AllowEdit = false;
            this.GCOLPincode.OptionsColumn.AllowFocus = false;
            // 
            // GCOLContactNo
            // 
            this.GCOLContactNo.Caption = "Contact No";
            this.GCOLContactNo.FieldName = "ContactNo";
            this.GCOLContactNo.Name = "GCOLContactNo";
            this.GCOLContactNo.Visible = true;
            this.GCOLContactNo.VisibleIndex = 2;
            // 
            // GCOLPersonalNo
            // 
            this.GCOLPersonalNo.Caption = "Personal No";
            this.GCOLPersonalNo.FieldName = "PersonalNo";
            this.GCOLPersonalNo.Name = "GCOLPersonalNo";
            this.GCOLPersonalNo.Visible = true;
            this.GCOLPersonalNo.VisibleIndex = 3;
            // 
            // GCOLFatherContactNo
            // 
            this.GCOLFatherContactNo.Caption = "Father Contact No";
            this.GCOLFatherContactNo.FieldName = "FatherContactNo";
            this.GCOLFatherContactNo.Name = "GCOLFatherContactNo";
            this.GCOLFatherContactNo.Visible = true;
            this.GCOLFatherContactNo.VisibleIndex = 4;
            // 
            // GCOLRecidantialNo
            // 
            this.GCOLRecidantialNo.Caption = "Recidentail No";
            this.GCOLRecidantialNo.FieldName = "RecidentialNo";
            this.GCOLRecidantialNo.Name = "GCOLRecidantialNo";
            // 
            // GCOLEmailId
            // 
            this.GCOLEmailId.Caption = "Email Id";
            this.GCOLEmailId.FieldName = "EmailId";
            this.GCOLEmailId.Name = "GCOLEmailId";
            this.GCOLEmailId.Visible = true;
            this.GCOLEmailId.VisibleIndex = 5;
            // 
            // GCOLLasteEducation
            // 
            this.GCOLLasteEducation.Caption = "Last Education";
            this.GCOLLasteEducation.FieldName = "LastEducation";
            this.GCOLLasteEducation.Name = "GCOLLasteEducation";
            // 
            // GCOLEditAction
            // 
            this.GCOLEditAction.ColumnEdit = this.RIBEdit;
            this.GCOLEditAction.Name = "GCOLEditAction";
            this.GCOLEditAction.Visible = true;
            this.GCOLEditAction.VisibleIndex = 6;
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
            this.GCOLDeleteAction.VisibleIndex = 7;
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
            this.panel1.Size = new System.Drawing.Size(838, 34);
            this.panel1.TabIndex = 2;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Appearance.Options.UseFont = true;
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.Location = new System.Drawing.Point(718, 0);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(120, 34);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // FrmStudentMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 581);
            this.Controls.Add(this.TLPMasterValuesList);
            this.Name = "FrmStudentMaster";
            this.Text = "Student Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStudentMaster_Load);
            this.TLPMasterValuesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCStudentMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVStudentMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIBDelete)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPMasterValuesList;
        public DevExpress.XtraGrid.GridControl GCStudentMaster;
        public DevExpress.XtraGrid.Views.Grid.GridView GVStudentMaster;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLStudentId;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLStudentName;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLGender;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLAddress;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLCity;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLState;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLPincode;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLEditAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBEdit;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLDeleteAction;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIBDelete;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnAddNew;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLContactNo;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLPersonalNo;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLFatherContactNo;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLRecidantialNo;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLEmailId;
        private DevExpress.XtraGrid.Columns.GridColumn GCOLLasteEducation;
    }
}