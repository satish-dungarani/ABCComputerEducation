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
using System.Globalization;

namespace ABCComputerEducation.Forms
{
    public partial class FrmAdmissionDetailEntry : DevExpress.XtraEditors.XtraForm
    {
        public bool IsDropOut = false;
        AdmissionDetailBLL _ObjAdmissionDetailBLL;
        MasterValuesBLL _ObjMasterValuesBLL;

        public FrmAdmissionDetailEntry()
        {
            InitializeComponent();
            _ObjAdmissionDetailBLL = new AdmissionDetailBLL();
            _ObjMasterValuesBLL = new MasterValuesBLL();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                decimal _decout;
                int _intout;
                TimeSpan _tsout;
                DateTime _dtout;
                //Validation
                if ((string.IsNullOrEmpty(this.txtAdmissionId.Text) || this.txtAdmissionId.Text == "0") && string.IsNullOrEmpty(this.ddlEnquiry.Text) && string.IsNullOrEmpty(this.ddlRefAdmissionId.Text))
                {
                    HelperCls.MsgBox("Enquiry can't left blank.", HelperCls.MessageType.Warning);
                    this.ddlEnquiry.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(this.txtStudentName.Text))
                {
                    HelperCls.MsgBox("Student can't left blank.", HelperCls.MessageType.Warning);
                    this.txtStudentName.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(this.ddlCourse.Text))
                {
                    HelperCls.MsgBox("Course Name can't left blank.", HelperCls.MessageType.Warning);
                    this.ddlCourse.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(this.cmbCourseType.Text))
                {
                    HelperCls.MsgBox("Course Type can't left blank.", HelperCls.MessageType.Warning);
                    this.cmbCourseType.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(this.timeFromtime.Text))
                {
                    HelperCls.MsgBox("From Time can't left blank.", HelperCls.MessageType.Warning);
                    this.timeFromtime.Focus();
                    return;
                }
                //else if (!TimeSpan.TryParse(this.timeFromtime.Text, out _tsout))
                //{
                //    HelperCls.MsgBox("From Time must be in time format", HelperCls.MessageType.Warning);
                //    this.timeFromtime.Focus();
                //    return;
                //}
                else if (string.IsNullOrEmpty(this.timeTotime.Text))
                {
                    HelperCls.MsgBox("To Time can't left blank.", HelperCls.MessageType.Warning);
                    this.timeTotime.Focus();
                    return;
                }
                //else if (!TimeSpan.TryParse(this.timeTotime.Text, out _tsout))
                //{
                //    HelperCls.MsgBox("To Time must be in time format!", HelperCls.MessageType.Warning);
                //    this.timeTotime.Focus();
                //    return;
                //}
                else if (string.IsNullOrEmpty(this.txtCourseFee.Text))
                {
                    HelperCls.MsgBox("Course Fee can't left blank.", HelperCls.MessageType.Warning);
                    this.txtCourseFee.Focus();
                    return;
                }
                else if (!Decimal.TryParse(this.txtCourseFee.Text, out _decout))
                {
                    HelperCls.MsgBox("Course Fee must be in decimal format!", HelperCls.MessageType.Warning);
                    this.txtCourseFee.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(this.dtpAdmissionDate.Text))
                {
                    HelperCls.MsgBox("Admission Date can't left blank.", HelperCls.MessageType.Warning);
                    this.dtpAdmissionDate.Focus();
                    return;
                }
                else if (!DateTime.TryParse(this.dtpAdmissionDate.Text, out _dtout))
                {
                    HelperCls.MsgBox("Admission Date must be in date format!", HelperCls.MessageType.Warning);
                    this.dtpAdmissionDate.Focus();
                    return;
                }
                else if (!Int32.TryParse(this.txtNoofInstallment.Text, out _intout))
                {
                    HelperCls.MsgBox("No of Installment must be in number format!", HelperCls.MessageType.Warning);
                    this.txtNoofInstallment.Focus();
                    return;
                }

                //Send Data For Store In DB
                _ObjAdmissionDetailBLL.AdmissionId = Convert.ToInt32(this.txtAdmissionId.Text);
                _ObjAdmissionDetailBLL.AdmissionCode = this.txtAdmissionCode.Text;
                _ObjAdmissionDetailBLL.RefEnquiryMaster_EnquiryId = Convert.ToInt32(this.ddlEnquiry.EditValue);
                _ObjAdmissionDetailBLL.StudentName = this.txtStudentName.Text;
                _ObjAdmissionDetailBLL.Gender = this.radGender.Text;
                _ObjAdmissionDetailBLL.EmailId = this.txtEmailId.Text;
                _ObjAdmissionDetailBLL.No = this.txtNo.Text;
                _ObjAdmissionDetailBLL.Address = this.txtAddress.Text;
                _ObjAdmissionDetailBLL.City = this.txtCity.Text;
                _ObjAdmissionDetailBLL.State = this.txtState.Text;
                if (!string.IsNullOrEmpty(this.txtPincode.Text))
                    _ObjAdmissionDetailBLL.Pincode = Convert.ToDecimal(this.txtPincode.Text);
                _ObjAdmissionDetailBLL.ContactNo = this.txtContactNo.Text;
                if (!string.IsNullOrEmpty(this.txtFatherContactNo.Text))
                _ObjAdmissionDetailBLL.FatherContactNo = Convert.ToDecimal(this.txtFatherContactNo.Text);
                _ObjAdmissionDetailBLL.RecidentialNo = this.txtRecidentialNo.Text;
                _ObjAdmissionDetailBLL.RefMasterValues_CourseId = Convert.ToInt32(this.ddlCourse.EditValue);
                _ObjAdmissionDetailBLL.CourseType = this.cmbCourseType.Text;
                _ObjAdmissionDetailBLL.NoOfInstallments = Convert.ToInt32(this.txtNoofInstallment.Text);
                _ObjAdmissionDetailBLL.CouseFee = Convert.ToDecimal(this.txtCourseFee.Text);
                _ObjAdmissionDetailBLL.CouserTimePeriod = Convert.ToInt32(this.timeCourseTimePeriod.Text);
                _ObjAdmissionDetailBLL.FromTime = this.timeFromtime.Text;
                _ObjAdmissionDetailBLL.ToTime = this.timeTotime.Text;
                _ObjAdmissionDetailBLL.AdmissionDate = Convert.ToDateTime(this.dtpAdmissionDate.EditValue);
                _ObjAdmissionDetailBLL.Lab = txtLab.Text;
                if (string.IsNullOrEmpty(this.ddlRefAdmissionId.Text))
                    _ObjAdmissionDetailBLL.RefAdmissionId = null;
                else
                    _ObjAdmissionDetailBLL.RefAdmissionId = Convert.ToInt32(this.ddlRefAdmissionId.EditValue);
                _ObjAdmissionDetailBLL.User = HelperCls.User;
                _ObjAdmissionDetailBLL.Terminal = HelperCls.Terminal;
                if (_ObjAdmissionDetailBLL.SetAdmissionDetail() > 0)
                {
                    if (this.txtAdmissionId.Text == "0")
                        HelperCls.MsgBox("Admission successfully add in List.", HelperCls.MessageType.Success);
                    else
                        HelperCls.MsgBox("Admission successfully updated.", HelperCls.MessageType.Success);

                    if (_ObjAdmissionDetailBLL.AdmissionId > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        ResetFields();
                    }

                }
                else
                {
                    if (HelperCls.MsgBox("Admission data fail to add or change.", HelperCls.MessageType.Warning) == DialogResult.OK)
                        this.DialogResult = DialogResult.Cancel;

                }
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
                this.txtAdmissionId.Text = "0";
                this.txtAdmissionCode.Text = _ObjStudentMasterBLL.GetSequanceNo("Admission").ToString();
                this.ddlEnquiry.EditValue = -1;
                this.txtStudentName.Text = "";
                this.radGender.EditValue = "Male";
                this.txtEmailId.Text = "";
                this.txtNo.Text = "";
                this.txtAddress.Text = "";
                this.txtCity.Text = "";
                this.txtState.Text = "";
                this.txtPincode.Text = "";
                this.txtContactNo.Text = "";
                this.txtFatherContactNo.Text = "";
                this.txtRecidentialNo.Text = "";
                this.ddlCourse.EditValue = "";
                this.cmbCourseType.Text = "";
                this.txtNoofInstallment.Text = "";
                this.txtCourseFee.Text = "";
                this.timeCourseTimePeriod.Text = "";
                //this.timeFromtime.Text = "";
                //this.timeTotime.Text = "";
                //this.ddlRefAdmissionId.EditValue = -1;


                //Get Enquiry List
                EnquiryMasterBLL _ObjEnquiryMasterBLL = new EnquiryMasterBLL();
                DataTable _DTEnquiry = new DataTable();
                _DTEnquiry = _ObjEnquiryMasterBLL.GetEnquiryMaster();

                //Enquiry List Binding
                this.ddlEnquiry.Properties.DataSource = _DTEnquiry;
                this.ddlEnquiry.Properties.DisplayMember = "EnquiryId";
                this.ddlEnquiry.Properties.ValueMember = "EnquiryId";

                //Fill Admission Combo
                DataTable _DTAdmissionList = new DataTable();
                _DTAdmissionList = _ObjAdmissionDetailBLL.GetAdmissionDetail(null, true);
                this.ddlRefAdmissionId.Properties.DataSource = _DTAdmissionList;
                this.ddlRefAdmissionId.Properties.ValueMember = "AdmissionId";
                this.ddlRefAdmissionId.Properties.DisplayMember = "AdmissionCode";


                this.ddlEnquiry.Focus();
            }
            catch (Exception ex)
            {
                throw ex;
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

        private void FrmAdmissionDetailEntry_Load(object sender, EventArgs e)
        {
            try
            {
                this.dtpAdmissionDate.Properties.MaxValue = System.DateTime.Now.Date;
                //if (this.ddlRefAdmissionId.EditValue != null)
                //{
                //    this.chkContinueAdmission.Checked = true;
                //    this.ddlRefAdmissionId.Visible = true;
                //}
                //else
                //{
                //    this.ddlRefAdmissionId.Visible = false;
                //}
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void chkContinueAdmission_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkContinueAdmission.CheckState == CheckState.Checked)
                {
                    this.btnAddEnquiry.Visible = false;
                    this.lblEnquiry.Visible = false;
                    this.ddlEnquiry.Visible = false;
                    this.lblReAdmission.Visible = true;
                    this.ddlRefAdmissionId.Visible = true;
                }
                else
                {
                    this.btnAddEnquiry.Visible = true;
                    this.lblEnquiry.Visible = true;
                    this.ddlEnquiry.Visible = true;
                    this.lblReAdmission.Visible = false;
                    this.ddlRefAdmissionId.Visible = false;
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnAddEnquiry_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEnquiryMasterEntry _ObjEnquiryMasterEntry = new FrmEnquiryMasterEntry();
                _ObjEnquiryMasterEntry.lblTitle.Text = "Add Enquiry";

                StudentMasterBLL _ObjStudentMasterBLL = new StudentMasterBLL();
                _ObjEnquiryMasterEntry.txtEnquiryNo.Text = _ObjStudentMasterBLL.GetSequanceNo("Enquiry").ToString();
                _ObjEnquiryMasterEntry.txtEnquiryId.Text = "0";
                _ObjEnquiryMasterEntry.txtStudentName.Text = "";
                _ObjEnquiryMasterEntry.txtNo.Text = "";
                _ObjEnquiryMasterEntry.txtAddress.Text = "";
                _ObjEnquiryMasterEntry.txtContactNo.Text = "";
                _ObjEnquiryMasterEntry.txtEmailId.Text = "";
                _ObjEnquiryMasterEntry.ddlRefMasterValues_CourseId.EditValue = -1;
                _ObjEnquiryMasterEntry.txtInstitution.Text = "";
                _ObjEnquiryMasterEntry.txtExmination.Text = "";
                //_ObjEnquiryMasterEntry.dtpEnquiryDate.EditValue = DateTime.Now.Date.ToString();
                _ObjEnquiryMasterEntry.dtpEnquiryDate.Text = DateTime.Now.Date.ToShortDateString();
                if (_ObjEnquiryMasterEntry.ShowDialog() == DialogResult.OK)
                {
                    _ObjEnquiryMasterEntry.Close();

                    //Get Enquiry List
                    EnquiryMasterBLL _ObjEnquiryMasterBLL = new EnquiryMasterBLL();
                    DataTable _DTEnquiry = new DataTable();
                    _DTEnquiry = _ObjEnquiryMasterBLL.GetEnquiryMaster();

                    //Enquiry List Binding
                    this.ddlEnquiry.Properties.DataSource = _DTEnquiry;
                    this.ddlEnquiry.Properties.DisplayMember = "EnquiryId";
                    this.ddlEnquiry.Properties.ValueMember = "EnquiryId";
                    if (_ObjEnquiryMasterEntry._EnquiryId > 0)
                        this.ddlEnquiry.EditValue = _ObjEnquiryMasterEntry._EnquiryId;
                    this.ddlEnquiry.Focus();
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void ddlEnquiry_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtStudentName.Text = this.SLV_Enquiry.GetRowCellValue(this.SLV_Enquiry.FocusedRowHandle, "StudentName").ToString();
                this.txtNo.Text = this.SLV_Enquiry.GetRowCellValue(this.SLV_Enquiry.FocusedRowHandle, "No").ToString();
                this.txtAddress.Text = this.SLV_Enquiry.GetRowCellValue(this.SLV_Enquiry.FocusedRowHandle, "Address").ToString();
                this.radGender.EditValue = this.SLV_Enquiry.GetRowCellValue(this.SLV_Enquiry.FocusedRowHandle, "Gender").ToString().Trim();
                this.txtEmailId.Text = this.SLV_Enquiry.GetRowCellValue(this.SLV_Enquiry.FocusedRowHandle, "EmailId").ToString();
                this.txtContactNo.Text = this.SLV_Enquiry.GetRowCellValue(this.SLV_Enquiry.FocusedRowHandle, "ContactNo").ToString();
                this.txtFatherContactNo.Text = this.SLV_Enquiry.GetRowCellValue(this.SLV_Enquiry.FocusedRowHandle, "FatherContactNo").ToString();
                this.txtRecidentialNo.Text = this.SLV_Enquiry.GetRowCellValue(this.SLV_Enquiry.FocusedRowHandle, "RecidentialNo").ToString();
                this.txtPincode.Text = this.SLV_Enquiry.GetRowCellValue(this.SLV_Enquiry.FocusedRowHandle, "Pincode").ToString();
                this.txtCity.Text = this.SLV_Enquiry.GetRowCellValue(this.SLV_Enquiry.FocusedRowHandle, "City").ToString();
                this.txtState.Text = this.SLV_Enquiry.GetRowCellValue(this.SLV_Enquiry.FocusedRowHandle, "State").ToString();
                this.ddlCourse.EditValue = this.SLV_Enquiry.GetRowCellValue(this.SLV_Enquiry.FocusedRowHandle, "RefMasterValues_CourseId").ToString();
                this.cmbCourseType.EditValue = "ABC";
                this.timeCourseTimePeriod.Text = "";
                this.txtNoofInstallment.Text = "";
                this.txtCourseFee.Text = "";
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void ddlRefAdmissionId_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.txtStudentName.Text = this.SLV_DropOut.GetRowCellValue(this.SLV_DropOut.FocusedRowHandle, "StudentName").ToString();
                this.txtNo.Text = this.SLV_DropOut.GetRowCellValue(this.SLV_DropOut.FocusedRowHandle, "No").ToString();
                this.txtAddress.Text = this.SLV_DropOut.GetRowCellValue(this.SLV_DropOut.FocusedRowHandle, "Address").ToString();
                this.radGender.EditValue = this.SLV_DropOut.GetRowCellValue(this.SLV_DropOut.FocusedRowHandle, "Gender").ToString();
                this.txtEmailId.Text = this.SLV_DropOut.GetRowCellValue(this.SLV_DropOut.FocusedRowHandle, "EmailId").ToString();
                this.txtContactNo.Text = this.SLV_DropOut.GetRowCellValue(this.SLV_DropOut.FocusedRowHandle, "ContactNo").ToString();
                this.txtFatherContactNo.Text = this.SLV_DropOut.GetRowCellValue(this.SLV_DropOut.FocusedRowHandle, "FatherContactNo").ToString();
                this.txtRecidentialNo.Text = this.SLV_DropOut.GetRowCellValue(this.SLV_DropOut.FocusedRowHandle, "RecidentalNo").ToString();
                this.txtPincode.Text = this.SLV_DropOut.GetRowCellValue(this.SLV_DropOut.FocusedRowHandle, "Pincode").ToString();
                this.txtCity.Text = this.SLV_DropOut.GetRowCellValue(this.SLV_DropOut.FocusedRowHandle, "City").ToString();
                this.txtState.Text = this.SLV_DropOut.GetRowCellValue(this.SLV_DropOut.FocusedRowHandle, "State").ToString();
                this.ddlCourse.EditValue = this.SLV_DropOut.GetRowCellValue(this.SLV_DropOut.FocusedRowHandle, "RefMasterValues_CourseId").ToString();
                this.cmbCourseType.EditValue = this.SLV_DropOut.GetRowCellValue(this.SLV_DropOut.FocusedRowHandle, "CourseType").ToString();
                this.timeCourseTimePeriod.Text = this.SLV_DropOut.GetRowCellValue(this.SLV_DropOut.FocusedRowHandle, "CouserTimePeriod").ToString();
                this.txtNoofInstallment.Text = this.SLV_DropOut.GetRowCellValue(this.SLV_DropOut.FocusedRowHandle, "NoOfInstallments").ToString();
                this.txtCourseFee.Text = this.SLV_DropOut.GetRowCellValue(this.SLV_DropOut.FocusedRowHandle, "CouseFee").ToString();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void dtpAdmissionDate_EditValueChanged(object sender, EventArgs e)
        {

        }

    }
}