namespace ABCComputerEducation.Forms
{
    partial class FrmChequeDetailsEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChequeDetailsEntry));
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.TLPMasterValues = new System.Windows.Forms.TableLayoutPanel();
            this.lblReceiptNo = new DevExpress.XtraEditors.LabelControl();
            this.txtReceiptNo = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtReceiptId = new DevExpress.XtraEditors.TextEdit();
            this.lblStudent = new DevExpress.XtraEditors.LabelControl();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.lblChequeNo = new DevExpress.XtraEditors.LabelControl();
            this.lblBankofCheque = new DevExpress.XtraEditors.LabelControl();
            this.lblDAccName = new DevExpress.XtraEditors.LabelControl();
            this.lblReceiveDate = new DevExpress.XtraEditors.LabelControl();
            this.lblDepositedDate = new DevExpress.XtraEditors.LabelControl();
            this.lblClearDate = new DevExpress.XtraEditors.LabelControl();
            this.lblBouncedDate = new DevExpress.XtraEditors.LabelControl();
            this.dtpReceiveDate = new DevExpress.XtraEditors.DateEdit();
            this.dtpDepositedDate = new DevExpress.XtraEditors.DateEdit();
            this.dtpClearDate = new DevExpress.XtraEditors.DateEdit();
            this.dtpBouncedDate = new DevExpress.XtraEditors.DateEdit();
            this.txtChequeNo = new DevExpress.XtraEditors.TextEdit();
            this.txtBankofCheque = new DevExpress.XtraEditors.TextEdit();
            this.txtDepositedAccName = new DevExpress.XtraEditors.TextEdit();
            this.txtStudentName = new DevExpress.XtraEditors.TextEdit();
            this.TLPMasterValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiptNo.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiptId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReceiveDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReceiveDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDepositedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDepositedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpClearDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpClearDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBouncedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBouncedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChequeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankofCheque.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepositedAccName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(319, 0);
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
            this.btnCancel.Location = new System.Drawing.Point(433, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 45);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TLPMasterValues
            // 
            this.TLPMasterValues.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TLPMasterValues.ColumnCount = 6;
            this.TLPMasterValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TLPMasterValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPMasterValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPMasterValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPMasterValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLPMasterValues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.TLPMasterValues.Controls.Add(this.lblReceiptNo, 1, 3);
            this.TLPMasterValues.Controls.Add(this.txtReceiptNo, 2, 3);
            this.TLPMasterValues.Controls.Add(this.panel1, 2, 15);
            this.TLPMasterValues.Controls.Add(this.lblStudent, 1, 5);
            this.TLPMasterValues.Controls.Add(this.lblTitle, 1, 1);
            this.TLPMasterValues.Controls.Add(this.lblChequeNo, 1, 10);
            this.TLPMasterValues.Controls.Add(this.lblBankofCheque, 3, 10);
            this.TLPMasterValues.Controls.Add(this.lblDAccName, 1, 11);
            this.TLPMasterValues.Controls.Add(this.lblReceiveDate, 1, 12);
            this.TLPMasterValues.Controls.Add(this.lblDepositedDate, 3, 12);
            this.TLPMasterValues.Controls.Add(this.lblClearDate, 1, 13);
            this.TLPMasterValues.Controls.Add(this.lblBouncedDate, 3, 13);
            this.TLPMasterValues.Controls.Add(this.dtpReceiveDate, 2, 12);
            this.TLPMasterValues.Controls.Add(this.dtpDepositedDate, 4, 12);
            this.TLPMasterValues.Controls.Add(this.dtpClearDate, 2, 13);
            this.TLPMasterValues.Controls.Add(this.dtpBouncedDate, 4, 13);
            this.TLPMasterValues.Controls.Add(this.txtChequeNo, 2, 10);
            this.TLPMasterValues.Controls.Add(this.txtBankofCheque, 4, 10);
            this.TLPMasterValues.Controls.Add(this.txtDepositedAccName, 2, 11);
            this.TLPMasterValues.Controls.Add(this.txtStudentName, 2, 5);
            this.TLPMasterValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMasterValues.Location = new System.Drawing.Point(0, 0);
            this.TLPMasterValues.Name = "TLPMasterValues";
            this.TLPMasterValues.RowCount = 17;
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLPMasterValues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.TLPMasterValues.Size = new System.Drawing.Size(769, 472);
            this.TLPMasterValues.TabIndex = 4;
            // 
            // lblReceiptNo
            // 
            this.lblReceiptNo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptNo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblReceiptNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiptNo.Location = new System.Drawing.Point(32, 85);
            this.lblReceiptNo.Name = "lblReceiptNo";
            this.lblReceiptNo.Size = new System.Drawing.Size(154, 36);
            this.lblReceiptNo.TabIndex = 0;
            this.lblReceiptNo.Text = "Receipt No";
            // 
            // txtReceiptNo
            // 
            this.TLPMasterValues.SetColumnSpan(this.txtReceiptNo, 3);
            this.txtReceiptNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceiptNo.EnterMoveNextControl = true;
            this.txtReceiptNo.Location = new System.Drawing.Point(192, 85);
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.Properties.AutoHeight = false;
            this.txtReceiptNo.Properties.ReadOnly = true;
            this.txtReceiptNo.Size = new System.Drawing.Size(547, 36);
            this.txtReceiptNo.TabIndex = 0;
            // 
            // panel1
            // 
            this.TLPMasterValues.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtReceiptId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(192, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 45);
            this.panel1.TabIndex = 17;
            // 
            // txtReceiptId
            // 
            this.txtReceiptId.EditValue = "0";
            this.txtReceiptId.Location = new System.Drawing.Point(3, 3);
            this.txtReceiptId.Name = "txtReceiptId";
            this.txtReceiptId.Size = new System.Drawing.Size(10, 20);
            this.txtReceiptId.TabIndex = 0;
            this.txtReceiptId.Visible = false;
            // 
            // lblStudent
            // 
            this.lblStudent.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStudent.Location = new System.Drawing.Point(32, 127);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(154, 36);
            this.lblStudent.TabIndex = 10;
            this.lblStudent.Text = "Student Name";
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.TLPMasterValues.SetColumnSpan(this.lblTitle, 4);
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Location = new System.Drawing.Point(32, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(707, 39);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "labelControl1";
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChequeNo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblChequeNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChequeNo.Location = new System.Drawing.Point(32, 169);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(154, 36);
            this.lblChequeNo.TabIndex = 24;
            this.lblChequeNo.Text = "Cheque No";
            // 
            // lblBankofCheque
            // 
            this.lblBankofCheque.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBankofCheque.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBankofCheque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBankofCheque.Location = new System.Drawing.Point(391, 169);
            this.lblBankofCheque.Name = "lblBankofCheque";
            this.lblBankofCheque.Size = new System.Drawing.Size(141, 36);
            this.lblBankofCheque.TabIndex = 25;
            this.lblBankofCheque.Text = "Bank Of Cheque";
            // 
            // lblDAccName
            // 
            this.lblDAccName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDAccName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDAccName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDAccName.Location = new System.Drawing.Point(32, 211);
            this.lblDAccName.Name = "lblDAccName";
            this.lblDAccName.Size = new System.Drawing.Size(154, 36);
            this.lblDAccName.TabIndex = 26;
            this.lblDAccName.Text = "Deposited Account Name";
            // 
            // lblReceiveDate
            // 
            this.lblReceiveDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiveDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblReceiveDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiveDate.Location = new System.Drawing.Point(32, 253);
            this.lblReceiveDate.Name = "lblReceiveDate";
            this.lblReceiveDate.Size = new System.Drawing.Size(154, 36);
            this.lblReceiveDate.TabIndex = 27;
            this.lblReceiveDate.Text = "Receive Date";
            // 
            // lblDepositedDate
            // 
            this.lblDepositedDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositedDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDepositedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDepositedDate.Location = new System.Drawing.Point(391, 253);
            this.lblDepositedDate.Name = "lblDepositedDate";
            this.lblDepositedDate.Size = new System.Drawing.Size(141, 36);
            this.lblDepositedDate.TabIndex = 28;
            this.lblDepositedDate.Text = "Deposited Date";
            // 
            // lblClearDate
            // 
            this.lblClearDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClearDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblClearDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClearDate.Location = new System.Drawing.Point(32, 295);
            this.lblClearDate.Name = "lblClearDate";
            this.lblClearDate.Size = new System.Drawing.Size(154, 36);
            this.lblClearDate.TabIndex = 29;
            this.lblClearDate.Text = "Clear Date";
            // 
            // lblBouncedDate
            // 
            this.lblBouncedDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBouncedDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBouncedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBouncedDate.Location = new System.Drawing.Point(391, 295);
            this.lblBouncedDate.Name = "lblBouncedDate";
            this.lblBouncedDate.Size = new System.Drawing.Size(141, 36);
            this.lblBouncedDate.TabIndex = 30;
            this.lblBouncedDate.Text = "Bounced Date";
            // 
            // dtpReceiveDate
            // 
            this.dtpReceiveDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpReceiveDate.EditValue = null;
            this.dtpReceiveDate.EnterMoveNextControl = true;
            this.dtpReceiveDate.Location = new System.Drawing.Point(192, 253);
            this.dtpReceiveDate.MaximumSize = new System.Drawing.Size(0, 36);
            this.dtpReceiveDate.MinimumSize = new System.Drawing.Size(0, 36);
            this.dtpReceiveDate.Name = "dtpReceiveDate";
            this.dtpReceiveDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpReceiveDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpReceiveDate.Properties.ReadOnly = true;
            this.dtpReceiveDate.Size = new System.Drawing.Size(193, 36);
            this.dtpReceiveDate.TabIndex = 13;
            // 
            // dtpDepositedDate
            // 
            this.dtpDepositedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDepositedDate.EditValue = null;
            this.dtpDepositedDate.EnterMoveNextControl = true;
            this.dtpDepositedDate.Location = new System.Drawing.Point(538, 253);
            this.dtpDepositedDate.MaximumSize = new System.Drawing.Size(0, 36);
            this.dtpDepositedDate.MinimumSize = new System.Drawing.Size(0, 36);
            this.dtpDepositedDate.Name = "dtpDepositedDate";
            this.dtpDepositedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDepositedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpDepositedDate.Size = new System.Drawing.Size(201, 36);
            this.dtpDepositedDate.TabIndex = 14;
            // 
            // dtpClearDate
            // 
            this.dtpClearDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpClearDate.EditValue = null;
            this.dtpClearDate.EnterMoveNextControl = true;
            this.dtpClearDate.Location = new System.Drawing.Point(192, 295);
            this.dtpClearDate.MaximumSize = new System.Drawing.Size(0, 36);
            this.dtpClearDate.MinimumSize = new System.Drawing.Size(0, 36);
            this.dtpClearDate.Name = "dtpClearDate";
            this.dtpClearDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpClearDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpClearDate.Size = new System.Drawing.Size(193, 36);
            this.dtpClearDate.TabIndex = 15;
            // 
            // dtpBouncedDate
            // 
            this.dtpBouncedDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpBouncedDate.EditValue = null;
            this.dtpBouncedDate.EnterMoveNextControl = true;
            this.dtpBouncedDate.Location = new System.Drawing.Point(538, 295);
            this.dtpBouncedDate.MaximumSize = new System.Drawing.Size(0, 36);
            this.dtpBouncedDate.MinimumSize = new System.Drawing.Size(0, 36);
            this.dtpBouncedDate.Name = "dtpBouncedDate";
            this.dtpBouncedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBouncedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBouncedDate.Size = new System.Drawing.Size(201, 36);
            this.dtpBouncedDate.TabIndex = 16;
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChequeNo.EnterMoveNextControl = true;
            this.txtChequeNo.Location = new System.Drawing.Point(192, 169);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Properties.AutoHeight = false;
            this.txtChequeNo.Properties.Mask.EditMask = "f0";
            this.txtChequeNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtChequeNo.Properties.ReadOnly = true;
            this.txtChequeNo.Size = new System.Drawing.Size(193, 36);
            this.txtChequeNo.TabIndex = 10;
            // 
            // txtBankofCheque
            // 
            this.txtBankofCheque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBankofCheque.EnterMoveNextControl = true;
            this.txtBankofCheque.Location = new System.Drawing.Point(538, 169);
            this.txtBankofCheque.Name = "txtBankofCheque";
            this.txtBankofCheque.Properties.AutoHeight = false;
            this.txtBankofCheque.Properties.ReadOnly = true;
            this.txtBankofCheque.Size = new System.Drawing.Size(201, 36);
            this.txtBankofCheque.TabIndex = 11;
            // 
            // txtDepositedAccName
            // 
            this.TLPMasterValues.SetColumnSpan(this.txtDepositedAccName, 3);
            this.txtDepositedAccName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDepositedAccName.EnterMoveNextControl = true;
            this.txtDepositedAccName.Location = new System.Drawing.Point(192, 211);
            this.txtDepositedAccName.Name = "txtDepositedAccName";
            this.txtDepositedAccName.Properties.AutoHeight = false;
            this.txtDepositedAccName.Size = new System.Drawing.Size(547, 36);
            this.txtDepositedAccName.TabIndex = 12;
            // 
            // txtStudentName
            // 
            this.TLPMasterValues.SetColumnSpan(this.txtStudentName, 3);
            this.txtStudentName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtStudentName.EnterMoveNextControl = true;
            this.txtStudentName.Location = new System.Drawing.Point(192, 127);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Properties.AutoHeight = false;
            this.txtStudentName.Properties.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(547, 36);
            this.txtStudentName.TabIndex = 2;
            // 
            // FrmChequeDetailsEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 472);
            this.Controls.Add(this.TLPMasterValues);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmChequeDetailsEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmChequeDetailsEntry";
            this.TLPMasterValues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiptNo.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiptId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReceiveDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpReceiveDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDepositedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDepositedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpClearDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpClearDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBouncedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBouncedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChequeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankofCheque.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepositedAccName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.TableLayoutPanel TLPMasterValues;
        public DevExpress.XtraEditors.LabelControl lblReceiptNo;
        public DevExpress.XtraEditors.TextEdit txtReceiptNo;
        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.TextEdit txtReceiptId;
        private DevExpress.XtraEditors.LabelControl lblStudent;
        public DevExpress.XtraEditors.LabelControl lblTitle;
        public DevExpress.XtraEditors.LabelControl lblChequeNo;
        public DevExpress.XtraEditors.LabelControl lblBankofCheque;
        public DevExpress.XtraEditors.LabelControl lblDAccName;
        public DevExpress.XtraEditors.LabelControl lblReceiveDate;
        public DevExpress.XtraEditors.LabelControl lblDepositedDate;
        public DevExpress.XtraEditors.LabelControl lblClearDate;
        public DevExpress.XtraEditors.LabelControl lblBouncedDate;
        public DevExpress.XtraEditors.DateEdit dtpReceiveDate;
        public DevExpress.XtraEditors.DateEdit dtpDepositedDate;
        public DevExpress.XtraEditors.DateEdit dtpClearDate;
        public DevExpress.XtraEditors.DateEdit dtpBouncedDate;
        public DevExpress.XtraEditors.TextEdit txtChequeNo;
        public DevExpress.XtraEditors.TextEdit txtBankofCheque;
        public DevExpress.XtraEditors.TextEdit txtDepositedAccName;
        public DevExpress.XtraEditors.TextEdit txtStudentName;
    }
}