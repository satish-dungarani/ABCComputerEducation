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
using System.Windows;

namespace ABCComputerEducation.Forms
{
    public partial class FrmAdmissionDetail : DevExpress.XtraEditors.XtraForm
    {
        public bool IsDropOut = false;
        public bool IsPassedOut = false;
        FrmMainPage _ObjFrmMain;
        AdmissionDetailBLL _ObjAdmissionDetailBLL;
        FrmAdmissionDetailEntry _ObjAdmissionDetailEntry;
        StudentMasterBLL _ObjStudentMasterBLL;
        MasterValuesBLL _ObjMasterValuesBLL;
        EnquiryMasterBLL _ObjEnquiryMasterBLL;
        public FrmAdmissionDetail()
        {
            InitializeComponent();
            _ObjFrmMain = new FrmMainPage();
            _ObjAdmissionDetailBLL = new AdmissionDetailBLL();
            _ObjStudentMasterBLL = new StudentMasterBLL();
        }

        private void RIBEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                _ObjAdmissionDetailEntry = new FrmAdmissionDetailEntry();
                //Function For Bind Data In Combobox
                BindComponent(_ObjAdmissionDetailEntry);
                _ObjAdmissionDetailEntry.lblTitle.Text = "Edit Admission Detail";

                int AdmissionId = Convert.ToInt32(this.GVAdmissionDetail.GetFocusedRowCellValue("AdmissionId"));
                DataTable _DTAdmissionData = new DataTable();
                _DTAdmissionData = _ObjAdmissionDetailBLL.GetAdmissionDetail(AdmissionId);

                //Fill Admission List In Combo
                DataTable _DTAdmissionList = new DataTable();
                _DTAdmissionList = _ObjAdmissionDetailBLL.GetAdmissionDetail(null, true);
                _ObjAdmissionDetailEntry.ddlRefAdmissionId.Properties.DataSource = _DTAdmissionList;
                _ObjAdmissionDetailEntry.ddlRefAdmissionId.Properties.ValueMember = "AdmissionId";
                _ObjAdmissionDetailEntry.ddlRefAdmissionId.Properties.DisplayMember = "AdmissionCode";

                //Set Visible False In Edit Mode
                _ObjAdmissionDetailEntry.lblEnquiry.Visible = false;
                _ObjAdmissionDetailEntry.lblReAdmission.Visible = false;
                _ObjAdmissionDetailEntry.ddlRefAdmissionId.Visible = false;
                _ObjAdmissionDetailEntry.chkContinueAdmission.Visible = false;
                _ObjAdmissionDetailEntry.ddlEnquiry.Visible = false;
                _ObjAdmissionDetailEntry.btnAddEnquiry.Visible = false;

                _ObjAdmissionDetailEntry.txtAdmissionId.Text = _DTAdmissionData.Rows[0]["AdmissionId"].ToString();
                _ObjAdmissionDetailEntry.txtAdmissionCode.Text = _DTAdmissionData.Rows[0]["AdmissionCode"].ToString();
                //_ObjAdmissionDetailEntry.ddlEnquiry.EditValue = Convert.ToInt32(_DTAdmissionData.Rows[0]["RefEnquiryMaster_EnquiryId"].ToString());
                _ObjAdmissionDetailEntry.txtStudentName.Text = _DTAdmissionData.Rows[0]["StudentName"].ToString();
                _ObjAdmissionDetailEntry.radGender.EditValue = _DTAdmissionData.Rows[0]["Gender"].ToString().Trim();
                _ObjAdmissionDetailEntry.txtEmailId.Text = _DTAdmissionData.Rows[0]["EmailId"].ToString();
                _ObjAdmissionDetailEntry.txtNo.Text = _DTAdmissionData.Rows[0]["No"].ToString();
                _ObjAdmissionDetailEntry.txtAddress.Text = _DTAdmissionData.Rows[0]["Address"].ToString();
                _ObjAdmissionDetailEntry.txtCity.Text = _DTAdmissionData.Rows[0]["City"].ToString();
                _ObjAdmissionDetailEntry.txtState.Text = _DTAdmissionData.Rows[0]["State"].ToString();
                _ObjAdmissionDetailEntry.txtPincode.Text = _DTAdmissionData.Rows[0]["Pincode"].ToString();
                _ObjAdmissionDetailEntry.txtContactNo.Text = _DTAdmissionData.Rows[0]["ContactNo"].ToString();
                _ObjAdmissionDetailEntry.txtFatherContactNo.Text = _DTAdmissionData.Rows[0]["FatherContactNo"].ToString();
                _ObjAdmissionDetailEntry.txtRecidentialNo.Text = _DTAdmissionData.Rows[0]["RecidentialNo"].ToString();
                _ObjAdmissionDetailEntry.ddlCourse.EditValue = _DTAdmissionData.Rows[0]["RefMasterValues_CourseId"].ToString();
                _ObjAdmissionDetailEntry.cmbCourseType.Text = _DTAdmissionData.Rows[0]["CourseType"].ToString();
                _ObjAdmissionDetailEntry.timeFromtime.Text = _DTAdmissionData.Rows[0]["FromTime"].ToString();
                _ObjAdmissionDetailEntry.timeTotime.Text = _DTAdmissionData.Rows[0]["ToTime"].ToString();
                _ObjAdmissionDetailEntry.txtCourseFee.Text = _DTAdmissionData.Rows[0]["CouseFee"].ToString();
                _ObjAdmissionDetailEntry.timeCourseTimePeriod.Text = _DTAdmissionData.Rows[0]["CouserTimePeriod"].ToString();
                _ObjAdmissionDetailEntry.txtNoofInstallment.Text = _DTAdmissionData.Rows[0]["NoOfInstallments"].ToString();
                _ObjAdmissionDetailEntry.dtpAdmissionDate.EditValue = Convert.ToDateTime(_DTAdmissionData.Rows[0]["AdmissionDate"].ToString());
                _ObjAdmissionDetailEntry.txtLab.Text = _DTAdmissionData.Rows[0]["Lab"].ToString();
                if (!string.IsNullOrEmpty(_DTAdmissionData.Rows[0]["RefAdmissionId"].ToString()))
                    _ObjAdmissionDetailEntry.ddlRefAdmissionId.EditValue = _DTAdmissionData.Rows[0]["RefAdmissionId"].ToString();
                _ObjAdmissionDetailEntry.IsDropOut = this.IsDropOut;

                if (_ObjAdmissionDetailEntry.ShowDialog() == DialogResult.OK)
                {
                    _ObjAdmissionDetailEntry.Close();
                    //Binding Data With Grid
                    //Binding Data With Grid
                    string vLabName = null;
                    if (this.ddlLabs.EditValue != null && this.ddlLabs.EditValue.ToString().ToLower().Trim() != "--select lab--")
                    {
                        vLabName = this.ddlLabs.EditValue.ToString();
                    }

                    if (this.ddlFromToTimeList.EditValue == null || this.ddlFromToTimeList.EditValue.ToString().ToLower().Trim() == "--select time--")
                    {
                        this.GCAdmissionDetail.DataSource = _ObjAdmissionDetailBLL.GetAdmissionDetail(null, this.IsDropOut, this.IsPassedOut, null, null, vLabName);
                    }
                    else
                    {
                        this.GCAdmissionDetail.DataSource = _ObjAdmissionDetailBLL.GetAdmissionDetail(null, this.IsDropOut, this.IsPassedOut, this.ddlFromToTimeList.EditValue.ToString().Split('-')[0].Trim(), this.ddlFromToTimeList.EditValue.ToString().Split('-')[1].Trim(), vLabName);
                    }
                    //this.GCAdmissionDetail.DataSource = _ObjAdmissionDetailBLL.GetAdmissionDetail();
                    this.GVAdmissionDetail.BestFitColumns(true);
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void RIBDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (HelperCls.MsgBox("Are you sure to delete Admission?", HelperCls.MessageType.Question) == DialogResult.Yes)
                {
                    int AdmissionId = Convert.ToInt32(this.GVAdmissionDetail.GetFocusedRowCellValue("AdmissionId"));
                    if (_ObjAdmissionDetailBLL.DeleteRecord(AdmissionId, "AdmissionDetail") > 0)
                    {
                        HelperCls.MsgBox("Admission successfully deleted!", HelperCls.MessageType.Success);
                        //Binding Data With Grid
                        this.GCAdmissionDetail.DataSource = _ObjAdmissionDetailBLL.GetAdmissionDetail();
                        this.GVAdmissionDetail.BestFitColumns(true);
                    }
                    else
                        HelperCls.MsgBox("Somthing want wrong! Admission Record delete fail!", HelperCls.MessageType.Warning);
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                using (_ObjAdmissionDetailEntry = new FrmAdmissionDetailEntry())
                {
                    _ObjAdmissionDetailEntry.lblTitle.Text = "New Admission";
                    //Function For Bind Data In Combobox
                    BindComponent(_ObjAdmissionDetailEntry);
                    //_ObjAdmissionDetailEntry.Parent = this;

                    //Fill Admission Combo
                    DataTable _DTAdmissionList = new DataTable();
                    _DTAdmissionList = _ObjAdmissionDetailBLL.GetAdmissionDetail(null, true);
                    _ObjAdmissionDetailEntry.ddlRefAdmissionId.Properties.DataSource = _DTAdmissionList;
                    _ObjAdmissionDetailEntry.ddlRefAdmissionId.Properties.ValueMember = "AdmissionId";
                    _ObjAdmissionDetailEntry.ddlRefAdmissionId.Properties.DisplayMember = "AdmissionCode";

                    _ObjAdmissionDetailEntry.txtAdmissionCode.Text = _ObjStudentMasterBLL.GetSequanceNo("Admission").ToString();
                    _ObjAdmissionDetailEntry.IsDropOut = this.IsDropOut;

                    if (_ObjAdmissionDetailEntry.ShowDialog() == DialogResult.OK)
                    {
                        //_ObjAdmissionDetailEntry.Close();
                        //Binding Data With Grid
                        string vLabName = null;
                        if (this.ddlLabs.EditValue != null && this.ddlLabs.EditValue.ToString().ToLower().Trim() != "--select lab--")
                        {
                            vLabName = this.ddlLabs.EditValue.ToString();
                        }

                        if (this.ddlFromToTimeList.EditValue == null || this.ddlFromToTimeList.EditValue.ToString().ToLower().Trim() == "--select time--")
                        {
                            this.GCAdmissionDetail.DataSource = _ObjAdmissionDetailBLL.GetAdmissionDetail(null, this.IsDropOut, this.IsPassedOut, null, null, vLabName);
                        }
                        else
                        {
                            this.GCAdmissionDetail.DataSource = _ObjAdmissionDetailBLL.GetAdmissionDetail(null, this.IsDropOut, this.IsPassedOut, this.ddlFromToTimeList.EditValue.ToString().Split('-')[0].Trim(), this.ddlFromToTimeList.EditValue.ToString().Split('-')[1].Trim(), vLabName);
                        }
                        //this.GCAdmissionDetail.DataSource = _ObjAdmissionDetailBLL.GetAdmissionDetail();
                        this.GVAdmissionDetail.BestFitColumns(true);
                    }

                }

            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void FrmAdmissionDetail_Load(object sender, EventArgs e)
        {
            try
            {

                
                if (this.IsDropOut)
                {
                    this.btnAddNew.Visible = false;
                    this.GCOLDropOut.Visible = false;
                    this.GCOLEditAction.Visible = false;
                    this.GCOLDeleteAction.Visible = false;
                    this.GCOLPendingFees.Visible = false;
                }
                else if (this.IsPassedOut)
                {
                    this.btnAddNew.Visible = false;
                    this.GCOLCouseFee.Visible = false;
                    this.GCOLCouserTimePeriod.Visible = false;
                    this.GCOLNoOfInstallments.Visible = false;
                    this.GCOLDropOut.Visible = false;
                    this.GCOLEditAction.Visible = false;
                    this.GCOLDeleteAction.Visible = false;
                    this.GCOLReAdmission.Visible = false;
                    this.GCOLPendingFees.Visible = false;
                }
                else
                {
                    DataSet _DS = new DataSet();
                    _DS =  _ObjAdmissionDetailBLL.GetTimeAndLabList();
                    ddlFromToTimeList.Properties.DataSource = _DS.Tables[0];
                    ddlFromToTimeList.Properties.DisplayMember = "FromToTime";
                    ddlFromToTimeList.Properties.ValueMember = "FromToTime";

                    ddlLabs.Properties.DataSource = _DS.Tables[1];
                    ddlLabs.Properties.DisplayMember = "Lab";
                    ddlLabs.Properties.ValueMember = "Lab";

                    this.GCOLReAdmission.Visible = false;
                    this.btnAddNew.Visible = true;
                }

                if (HelperCls.UserName.ToLower().Trim() == "user")
                {
                    this.GCOLDeleteAction.Visible = false;
                    this.GCOLCouseFee.Visible = false;
                }

                //Binding Data With Grid
                this.GCAdmissionDetail.DataSource = _ObjAdmissionDetailBLL.GetAdmissionDetail(null, this.IsDropOut,this.IsPassedOut);
                this.GVAdmissionDetail.BestFitColumns(true);
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        public void BindComponent(FrmAdmissionDetailEntry _Obj)
        {
            try
            {
                #region "Dropdown List Binding"
                //Get Enquiry List
                _ObjEnquiryMasterBLL = new EnquiryMasterBLL();
                DataTable _DTEnquiry = new DataTable();
                _DTEnquiry = _ObjEnquiryMasterBLL.GetEnquiryMaster();

                //Enquiry List Binding
                _Obj.ddlEnquiry.Properties.DataSource = _DTEnquiry;
                _Obj.ddlEnquiry.Properties.DisplayMember = "EnquiryId";
                _Obj.ddlEnquiry.Properties.ValueMember = "EnquiryId";

                //Get Course List
                _ObjMasterValuesBLL = new MasterValuesBLL();
                DataTable _DTCourse = new DataTable();
                _DTCourse = _ObjMasterValuesBLL.GetMasterValues(null, (int)HelperCls.MasterSetup.Course);

                //Student List Binding
                _Obj.ddlCourse.Properties.DataSource = _DTCourse;
                _Obj.ddlCourse.Properties.DisplayMember = "MasterValue";
                _Obj.ddlCourse.Properties.ValueMember = "MasterValId";
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void RIBDropOut_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                if (HelperCls.MsgBox("Are you sure to drop out Admission?", HelperCls.MessageType.Question) == DialogResult.Yes)
                {
                    int AdmissionId = Convert.ToInt32(this.GVAdmissionDetail.GetFocusedRowCellValue("AdmissionId"));
                    if (_ObjAdmissionDetailBLL.SetDropOutStatus(AdmissionId, true))
                    {
                        HelperCls.MsgBox("Admission successfully drop out!", HelperCls.MessageType.Success);
                        //Binding Data With Grid
                        this.GCAdmissionDetail.DataSource = _ObjAdmissionDetailBLL.GetAdmissionDetail(null, this.IsDropOut);
                        this.GVAdmissionDetail.BestFitColumns(true);
                    }
                    else
                        HelperCls.MsgBox("Somthing want wrong! Admission Record drop out fail!", HelperCls.MessageType.Warning);
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void RIBRestore_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

                if (HelperCls.MsgBox("Are you sure to restore admission from drop out?", HelperCls.MessageType.Question) == DialogResult.Yes)
                {
                    int AdmissionId = Convert.ToInt32(this.GVAdmissionDetail.GetFocusedRowCellValue("AdmissionId"));
                    if (_ObjAdmissionDetailBLL.SetDropOutStatus(AdmissionId, false))
                    {
                        HelperCls.MsgBox("Admission successfully restore!", HelperCls.MessageType.Success);
                        //Binding Data With Grid
                        this.GCAdmissionDetail.DataSource = _ObjAdmissionDetailBLL.GetAdmissionDetail(null, this.IsDropOut);
                        this.GVAdmissionDetail.BestFitColumns(true);
                    }
                    else
                        HelperCls.MsgBox("Somthing want wrong! Admission restore fail!", HelperCls.MessageType.Warning);
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void RIBExamStatus_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void ddlFromToTimeList_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                //Binding Data With Grid
                string vLabName = null;
                if (this.ddlLabs.EditValue != null && this.ddlLabs.EditValue.ToString().ToLower().Trim() != "--select lab--")
                {
                    vLabName = this.ddlLabs.EditValue.ToString();
                }

                if (this.ddlFromToTimeList.EditValue == null || this.ddlFromToTimeList.EditValue.ToString().ToLower().Trim() == "--select time--")
                {
                    this.GCAdmissionDetail.DataSource = _ObjAdmissionDetailBLL.GetAdmissionDetail(null, this.IsDropOut, this.IsPassedOut, null, null, vLabName);
                }
                else
                {
                    this.GCAdmissionDetail.DataSource = _ObjAdmissionDetailBLL.GetAdmissionDetail(null, this.IsDropOut, this.IsPassedOut, this.ddlFromToTimeList.EditValue.ToString().Split('-')[0].Trim(), this.ddlFromToTimeList.EditValue.ToString().Split('-')[1].Trim(), vLabName);
                }
                this.GVAdmissionDetail.BestFitColumns(true);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}