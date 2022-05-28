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
    public partial class FrmStudentMaster : DevExpress.XtraEditors.XtraForm
    {
        StudentMasterBLL _ObjStudentMasterBLL;
        FrmStudentMasterEntry _ObjStudentMasterEntry;
        public FrmStudentMaster()
        {
            InitializeComponent();
            _ObjStudentMasterBLL = new StudentMasterBLL();
        }

        private void RIBEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                _ObjStudentMasterEntry = new FrmStudentMasterEntry();
                _ObjStudentMasterEntry.lblTitle.Text = "Edit Student Detail";

                int StudentId = Convert.ToInt32(this.GVStudentMaster.GetFocusedRowCellValue("StudentId"));
                DataTable _DTStudentData = new DataTable();
                _DTStudentData = _ObjStudentMasterBLL.GetStudentMaster(StudentId);
                _ObjStudentMasterEntry.txtStudentId.Text = _DTStudentData.Rows[0]["StudentId"].ToString();
                _ObjStudentMasterEntry.txtStudentName.Text = _DTStudentData.Rows[0]["StudentName"].ToString();
                _ObjStudentMasterEntry.radGender.SelectedIndex = _DTStudentData.Rows[0]["Gender"].ToString().Trim() == "Male" ? 0 : 1;
                _ObjStudentMasterEntry.txtAddress.Text = _DTStudentData.Rows[0]["Address"].ToString();
                _ObjStudentMasterEntry.txtCity.Text = _DTStudentData.Rows[0]["City"].ToString();
                _ObjStudentMasterEntry.txtState.Text = _DTStudentData.Rows[0]["State"].ToString();
                _ObjStudentMasterEntry.txtPincode.Text = _DTStudentData.Rows[0]["Pincode"].ToString();
                _ObjStudentMasterEntry.txtContactNo.Text = _DTStudentData.Rows[0]["ContactNo"].ToString();
                _ObjStudentMasterEntry.txtPersonalNo.Text = _DTStudentData.Rows[0]["PersonalNo"].ToString();
                _ObjStudentMasterEntry.txtFatherContactNo.Text = _DTStudentData.Rows[0]["FatherContactNo"].ToString();
                _ObjStudentMasterEntry.txtRecidentialNo.Text = _DTStudentData.Rows[0]["RecidentialNo"].ToString();
                _ObjStudentMasterEntry.txtEmailId.Text = _DTStudentData.Rows[0]["EmailId"].ToString();
                _ObjStudentMasterEntry.txtLastEducation.Text = _DTStudentData.Rows[0]["LastEducation"].ToString();

                if (_ObjStudentMasterEntry.ShowDialog() == DialogResult.OK)
                {
                    _ObjStudentMasterEntry.Close();
                    //Binding Data With Grid
                    this.GCStudentMaster.DataSource = _ObjStudentMasterBLL.GetStudentMaster();
                    this.GVStudentMaster.BestFitColumns(true);
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
                if (HelperCls.MsgBox("Are you sure to delete Student Detail?", HelperCls.MessageType.Question) == DialogResult.Yes)
                {
                    int EnquiryId = Convert.ToInt32(this.GVStudentMaster.GetFocusedRowCellValue("StudentId"));
                    if (_ObjStudentMasterBLL.DeleteRecord(EnquiryId, "StudentMaster") > 0)
                    {
                        HelperCls.MsgBox("Student Detail successfully deleted!", HelperCls.MessageType.Success);
                        //Binding Data With Grid
                        this.GCStudentMaster.DataSource = _ObjStudentMasterBLL.GetStudentMaster();
                        this.GVStudentMaster.BestFitColumns(true);
                    }
                    else
                        HelperCls.MsgBox("Somthing want wrong! Student Record delete fail!", HelperCls.MessageType.Warning);
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void FrmStudentMaster_Load(object sender, EventArgs e)
        {
            try
            {
                //Binding Data With Grid
                this.GCStudentMaster.DataSource = _ObjStudentMasterBLL.GetStudentMaster();
                this.GVStudentMaster.BestFitColumns(true);
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
                _ObjStudentMasterEntry = new FrmStudentMasterEntry();
                _ObjStudentMasterEntry.lblTitle.Text = "Add Student Detail";

                _ObjStudentMasterEntry.txtStudentId.Text = "0";
                _ObjStudentMasterEntry.txtStudentName.Text = "";
                _ObjStudentMasterEntry.radGender.SelectedIndex = 0;
                _ObjStudentMasterEntry.txtAddress.Text = "";
                _ObjStudentMasterEntry.txtCity.Text = "";
                _ObjStudentMasterEntry.txtState.Text = "";
                _ObjStudentMasterEntry.txtPincode.Text = "";
                _ObjStudentMasterEntry.txtContactNo.Text= "";
                _ObjStudentMasterEntry.txtPersonalNo.Text= "";
                _ObjStudentMasterEntry.txtFatherContactNo.Text= "";
                _ObjStudentMasterEntry.txtRecidentialNo.Text= "";
                _ObjStudentMasterEntry.txtEmailId.Text = "";
                
                if(_ObjStudentMasterEntry.ShowDialog() == DialogResult.OK)
                {
                    _ObjStudentMasterEntry.Close();
                    this.GCStudentMaster.DataSource = _ObjStudentMasterBLL.GetStudentMaster();
                    this.GVStudentMaster.BestFitColumns(true);
                    this.Focus();
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }
    }
}