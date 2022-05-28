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
using System.IO;

namespace ABCComputerEducation.Forms
{
    public partial class FrmEnquiryMaster : DevExpress.XtraEditors.XtraForm
    {
        public bool IsExternalData = false;
        FrmMainPage _ObjFrmMain;
        EnquiryMasterBLL _ObjEnquiryMasterBLL;
        FrmEnquiryMasterEntry _ObjEnquiryMasterEntry;
        public FrmEnquiryMaster()
        {
            InitializeComponent();

            _ObjFrmMain = new FrmMainPage();
            _ObjEnquiryMasterBLL = new EnquiryMasterBLL();

        }

        private void RIBEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                _ObjEnquiryMasterEntry = new FrmEnquiryMasterEntry();
                _ObjEnquiryMasterEntry.lblTitle.Text = "Edit Enquiry";

                int EnquiryId = Convert.ToInt32(this.GVEnquiryMaster.GetFocusedRowCellValue("EnquiryId"));
                DataTable _DTEnquiryData = new DataTable();
                _DTEnquiryData = _ObjEnquiryMasterBLL.GetEnquiryMaster(EnquiryId, this.IsExternalData);
                _ObjEnquiryMasterEntry.txtEnquiryId.Text = _DTEnquiryData.Rows[0]["EnquiryId"].ToString();
                _ObjEnquiryMasterEntry.txtEnquiryNo.Text = _DTEnquiryData.Rows[0]["EnquiryNo"].ToString();
                _ObjEnquiryMasterEntry.txtStudentName.Text = _DTEnquiryData.Rows[0]["StudentName"].ToString();
                _ObjEnquiryMasterEntry.txtNo.Text = _DTEnquiryData.Rows[0]["No"].ToString();
                _ObjEnquiryMasterEntry.txtAddress.Text = _DTEnquiryData.Rows[0]["Address"].ToString();
                _ObjEnquiryMasterEntry.txtPincode.Text = _DTEnquiryData.Rows[0]["Pincode"].ToString();
                _ObjEnquiryMasterEntry.txtContactNo.Text = _DTEnquiryData.Rows[0]["ContactNo"].ToString();
                _ObjEnquiryMasterEntry.txtFatherContactNo.Text = _DTEnquiryData.Rows[0]["FatherContactNo"].ToString();
                _ObjEnquiryMasterEntry.txtRecidentialNo.Text = _DTEnquiryData.Rows[0]["RecidentialNo"].ToString();
                _ObjEnquiryMasterEntry.txtLastEducation.Text = _DTEnquiryData.Rows[0]["LastEducation"].ToString();
                _ObjEnquiryMasterEntry.txtEmailId.Text = _DTEnquiryData.Rows[0]["EmailId"].ToString();
                _ObjEnquiryMasterEntry.ddlRefMasterValues_CourseId.EditValue = _DTEnquiryData.Rows[0]["RefMasterValues_CourseId"].ToString();
                _ObjEnquiryMasterEntry.txtInstitution.Text = _DTEnquiryData.Rows[0]["Institution"].ToString();
                _ObjEnquiryMasterEntry.txtExmination.Text = _DTEnquiryData.Rows[0]["Examination"].ToString();
                _ObjEnquiryMasterEntry.dtpEnquiryDate.DateTime = Convert.ToDateTime(_DTEnquiryData.Rows[0]["EnquiryDate"].ToString());
                _ObjEnquiryMasterEntry.IsExternalData = this.IsExternalData;

                if (_ObjEnquiryMasterEntry.ShowDialog() == DialogResult.OK)
                {
                    _ObjEnquiryMasterEntry.Close();
                    //Binding Data With Grid
                    this.GCEnquiryMaster.DataSource = _ObjEnquiryMasterBLL.GetEnquiryMaster(null, this.IsExternalData);
                    this.GVEnquiryMaster.BestFitColumns(true);
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
                if (HelperCls.MsgBox("Are you sure to delete Enquiry?", HelperCls.MessageType.Question) == DialogResult.Yes)
                {
                    int EnquiryId = Convert.ToInt32(this.GVEnquiryMaster.GetFocusedRowCellValue("EnquiryId"));
                    if (_ObjEnquiryMasterBLL.DeleteRecord(EnquiryId, "EnquiryMaster") > 0)
                    {
                        HelperCls.MsgBox("Enquiry successfully deleted!", HelperCls.MessageType.Success);
                        //Binding Data With Grid
                        this.GCEnquiryMaster.DataSource = _ObjEnquiryMasterBLL.GetEnquiryMaster(null,this.IsExternalData);
                        this.GVEnquiryMaster.BestFitColumns(true);
                    }
                    else
                        HelperCls.MsgBox("Somthing want wrong! Enquiry Record delete fail!", HelperCls.MessageType.Warning);
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void FrmEnquiryMaster_Load(object sender, EventArgs e)
        {
            try
            {
                if (HelperCls.UserName.ToLower().Trim() == "user")
                {
                    this.GCOLDeleteAction.Visible = false;
                }
                //Binding Data With Grid
                this.GCEnquiryMaster.DataSource = _ObjEnquiryMasterBLL.GetEnquiryMaster(null, this.IsExternalData);
                this.GVEnquiryMaster.BestFitColumns(true);
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
                _ObjEnquiryMasterEntry = new FrmEnquiryMasterEntry();
                _ObjEnquiryMasterEntry.lblTitle.Text = "Add Enquiry";

                StudentMasterBLL _ObjStudentMasterBLL = new StudentMasterBLL();
                if (this.IsExternalData)
                    _ObjEnquiryMasterEntry.txtEnquiryNo.Text = _ObjStudentMasterBLL.GetSequanceNo("ExternalData").ToString();
                else
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
                _ObjEnquiryMasterEntry.dtpEnquiryDate.Text = DateTime.Now.Date.ToString();
                _ObjEnquiryMasterEntry.IsExternalData = this.IsExternalData;

                if (_ObjEnquiryMasterEntry.ShowDialog() == DialogResult.OK)
                {
                    _ObjEnquiryMasterEntry.Close();

                    //Binding Data With Grid
                    this.GCEnquiryMaster.DataSource = _ObjEnquiryMasterBLL.GetEnquiryMaster(null, this.IsExternalData);
                    this.GVEnquiryMaster.BestFitColumns(true);
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        public void GridViewDataExport()
        {
            try
            {
                //string _Path = Path.Combine(Application.StartupPath.ToString() + "/ExportFiles/Enquiry.Xlsx");
                //if(this.GVEnquiryMaster != null)
                //    this.GVEnquiryMaster.ExportToXlsx(_Path);
                //_Path = Path.Combine(Application.StartupPath.ToString() + "/ExportFiles/Enquiry123.Pdf");
                //GCEnquiryMaster.ExportToPdf(_Path);

            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

    }
}