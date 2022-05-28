using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ABCComputerEducation.BLL;

namespace ABCComputerEducation.Forms
{
    public partial class FrmEnquiryMasterEntry : DevExpress.XtraEditors.XtraForm
    {
        public int _EnquiryId = 0;
        public bool IsExternalData = false;
        EnquiryMasterBLL _ObjEnquiryMasterBLL;
        MasterValuesBLL _ObjMasterValuesBLL;
        public FrmEnquiryMasterEntry()
        {
            InitializeComponent();
            _ObjEnquiryMasterBLL = new EnquiryMasterBLL();
            _ObjMasterValuesBLL = new MasterValuesBLL();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                decimal _decOut;
                //Validation
                if (string.IsNullOrEmpty(this.txtStudentName.Text))
                {
                    HelperCls.MsgBox("Student Name can't left blank.", HelperCls.MessageType.Warning);
                    this.txtStudentName.Focus();
                    return;
                }
                //if (string.IsNullOrEmpty(this.txtPincode.Text))
                //{
                //    HelperCls.MsgBox("Pincode can't left blank.", HelperCls.MessageType.Warnin5g);
                //    this.txtPincode.Focus();
                //    return;
                //}
                //if (string.IsNullOrEmpty(this.txtFatherContactNo.Text))
                //{
                //    HelperCls.MsgBox("Father contact no can't left blank.", HelperCls.MessageType.Warning);
                //    this.txtFatherContactNo.Focus();
                //    return;
                //}
                if (string.IsNullOrEmpty(this.ddlRefMasterValues_CourseId.Text))
                {
                    HelperCls.MsgBox("Course can't left blank.", HelperCls.MessageType.Warning);
                    this.ddlRefMasterValues_CourseId.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.dtpEnquiryDate.Text))
                {
                    HelperCls.MsgBox("Enquiry Date can't left blank.", HelperCls.MessageType.Warning);
                    this.dtpEnquiryDate.Focus();
                    return;
                }

                //Send Data For Store In DB
                _ObjEnquiryMasterBLL.EnquiryId = Convert.ToInt32(this.txtEnquiryId.Text);
                _ObjEnquiryMasterBLL.EnquiryNo = this.txtEnquiryNo.Text;
                _ObjEnquiryMasterBLL.StudentName = this.txtStudentName.Text;
                _ObjEnquiryMasterBLL.Gender = this.radGender.Text;
                _ObjEnquiryMasterBLL.No = this.txtNo.Text;
                _ObjEnquiryMasterBLL.Address = this.txtAddress.Text;
                _ObjEnquiryMasterBLL.City = this.txtCity.Text;
                _ObjEnquiryMasterBLL.State = this.txtState.Text;
                if (!string.IsNullOrEmpty(this.txtPincode.Text))
                    _ObjEnquiryMasterBLL.Pincode = Convert.ToDecimal(this.txtPincode.Text);
                _ObjEnquiryMasterBLL.ContactNo = this.txtContactNo.Text;
                if (!string.IsNullOrEmpty(this.txtFatherContactNo.Text))
                    _ObjEnquiryMasterBLL.FatherContactNo = Convert.ToDecimal(this.txtFatherContactNo.Text);
                _ObjEnquiryMasterBLL.RecidentialNo = this.txtRecidentialNo.Text;
                _ObjEnquiryMasterBLL.EmailId = this.txtEmailId.Text;
                _ObjEnquiryMasterBLL.RefMasterValues_CourseId = Convert.ToInt32(this.ddlRefMasterValues_CourseId.EditValue);
                _ObjEnquiryMasterBLL.LastEducation = this.txtLastEducation.Text;
                _ObjEnquiryMasterBLL.Institution = this.txtInstitution.Text;
                _ObjEnquiryMasterBLL.Examination = this.txtExmination.Text;
                _ObjEnquiryMasterBLL.EnquiryDate = Convert.ToDateTime(this.dtpEnquiryDate.EditValue);
                _ObjEnquiryMasterBLL.IsExternalData = IsExternalData;
                _ObjEnquiryMasterBLL.User = HelperCls.User;
                _ObjEnquiryMasterBLL.Terminal = HelperCls.Terminal;

                this._EnquiryId = _ObjEnquiryMasterBLL.SetEnquiryMaster();

                if (this._EnquiryId > 0)
                {
                    if (this.txtEnquiryId.Text == "0")
                        HelperCls.MsgBox("Enquiry successfully add in List.", HelperCls.MessageType.Success);
                    else
                        HelperCls.MsgBox("Enquiry successfully updated.", HelperCls.MessageType.Success);

                    if (_ObjEnquiryMasterBLL.EnquiryId > 0)
                    {
                        this.Close();
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        ResetFields();
                    }
                }
                else
                    HelperCls.MsgBox("Enquiry data fail to add or change.", HelperCls.MessageType.Warning);
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void FrmEnquiryMasterEntry_Load(object sender, EventArgs e)
        {
            try
            {
                // Combobox Data Binding
                DataTable _DTCourseLsit = new DataTable();
                _DTCourseLsit = _ObjMasterValuesBLL.GetMasterValues(null, (int)HelperCls.MasterSetup.Course);
                //_DTCourseLsit.Columns.Remove("MasterValId");
                //_DTCourseLsit.Columns.Remove("MasterDesc");
                //_DTCourseLsit.Columns.Remove("RefMasterSetup_MasterSetupId");
                //_DTCourseLsit.Columns.Remove("MasterName");
                //_DTCourseLsit.Columns.Remove("OtherValue");
                ////_DTCourseLsit.Columns.Remove("ShortValue");
                //_DTCourseLsit.Columns.Remove("InsUser");
                //_DTCourseLsit.Columns.Remove("InsDateTime");
                //_DTCourseLsit.Columns.Remove("InsTerminal");
                //_DTCourseLsit.Columns.Remove("UpdUser");
                //_DTCourseLsit.Columns.Remove("UpdDateTime");
                //_DTCourseLsit.Columns.Remove("UpdTerminal");
                this.ddlRefMasterValues_CourseId.Properties.DataSource = _DTCourseLsit;
                this.ddlRefMasterValues_CourseId.Properties.ValueMember = "MasterValId";
                this.ddlRefMasterValues_CourseId.Properties.DisplayMember = "MasterValue";

            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        public void ResetFields()
        {
            try
            {
                StudentMasterBLL _ObjStudentMasterBLL = new StudentMasterBLL();
                if (this.IsExternalData)
                    this.txtEnquiryNo.Text = _ObjStudentMasterBLL.GetSequanceNo("ExternalData").ToString();
                else
                    this.txtEnquiryNo.Text = _ObjStudentMasterBLL.GetSequanceNo("Enquiry").ToString();
                this.txtEnquiryId.Text = "0";
                this.txtStudentName.Text = "";
                this.txtNo.Text = "";
                this.txtAddress.Text = "";
                this.txtPincode.Text = "";
                this.txtContactNo.Text = "";
                this.txtFatherContactNo.Text = "";
                this.txtRecidentialNo.Text = "";
                this.txtEmailId.Text = "";
                this.ddlRefMasterValues_CourseId.EditValue = -1;
                this.txtLastEducation.Text = "";
                this.txtInstitution.Text = "";
                this.txtExmination.Text = "";

                //_ObjEnquiryMasterEntry.dtpEnquiryDate.EditValue = DateTime.Now.Date.ToString();
                //this.dtpEnquiryDate.Text = DateTime.Now.Date.ToShortDateString();
                this.txtStudentName.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}