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
    public partial class FrmStudentExamMarkSheet : DevExpress.XtraEditors.XtraForm
    {

        StudentExamMarkSheetBLL _ObjStudentExamMarkSheetBLL;
        FrmStudentExamMarkSheetEntry _ObjStudentExamMarkSheetEntry;
        StudentMasterBLL _ObjStudentMasterBLL;
        AdmissionDetailBLL _ObjAdmissionDetailBLL;
        public FrmStudentExamMarkSheet()
        {
            InitializeComponent();
            _ObjStudentExamMarkSheetBLL = new StudentExamMarkSheetBLL();
        }

        private void RIBDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (HelperCls.MsgBox("Are you sure to delete Student Fees Detail?", HelperCls.MessageType.Question) == DialogResult.Yes)
                {
                    int MarkSheetId = Convert.ToInt32(this.GVStudentExamMarkSheet.GetFocusedRowCellValue("MarkSheetId"));
                    if (_ObjStudentExamMarkSheetBLL.DeleteRecord(MarkSheetId, "StudentExamMarkSheet") > 0)
                    {
                        HelperCls.MsgBox("Student Fees Detail successfully deleted!", HelperCls.MessageType.Success);
                        //Binding Data With Grid
                        this.GCStudentExamMarkSheet.DataSource = _ObjStudentExamMarkSheetBLL.GetStudentExamMarkSheet();
                        this.GVStudentExamMarkSheet.BestFitColumns(true);
                    }
                    else
                        HelperCls.MsgBox("Somthing want wrong! Student Fees Record delete fail!", HelperCls.MessageType.Warning);
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
                _ObjStudentExamMarkSheetEntry = new FrmStudentExamMarkSheetEntry();
                BindData(_ObjStudentExamMarkSheetEntry);
                _ObjStudentExamMarkSheetEntry.lblTitle.Text = "Add New MarkSheet Detail";

                StudentMasterBLL _ObjStudentMasterBLL = new StudentMasterBLL();
                
                _ObjStudentExamMarkSheetEntry.txtMarkSheetId.Text = "0";
                _ObjStudentExamMarkSheetEntry.txtMarkSheetNo.Text = _ObjStudentMasterBLL.GetSequanceNo("ExamMarkSheet").ToString(); 
                //_ObjStudentExamMarkSheetEntry.ddlAdmissionId.EditValue =  -1;
                _ObjStudentExamMarkSheetEntry.txtStudentName.Text = "";
                _ObjStudentExamMarkSheetEntry.dtpExamDate.EditValue = DateTime.Now.Date.ToShortDateString();
                _ObjStudentExamMarkSheetEntry.ddlExamResult.EditValue = "Done";
                if (_ObjStudentExamMarkSheetEntry.ShowDialog() == DialogResult.OK)
                {
                    _ObjStudentExamMarkSheetEntry.Close();
                    //Bind Data With Grid
                    this.GCStudentExamMarkSheet.DataSource = _ObjStudentExamMarkSheetBLL.GetStudentExamMarkSheet();
                    this.GVStudentExamMarkSheet.BestFitColumns(true);
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void FrmStudentExamMarkSheet_Load(object sender, EventArgs e)
        {
            try
            {
                if (HelperCls.UserName.ToLower().Trim() == "user")
                {
                    this.GCOLDeleteAction.Visible = false;
                }

                //Bind Data With Grid
                this.GCStudentExamMarkSheet.DataSource = _ObjStudentExamMarkSheetBLL.GetStudentExamMarkSheet();
                this.GVStudentExamMarkSheet.BestFitColumns(true);
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        public void BindData(FrmStudentExamMarkSheetEntry _Obj)
        {
            try
            {
                //Get Admission Detail
                _ObjAdmissionDetailBLL = new AdmissionDetailBLL();
                DataTable _DTAdmission = new DataTable();
                _DTAdmission = _ObjAdmissionDetailBLL.GetAdmissionDetail(null);

                _Obj.ddlAdmissionId.Properties.DataSource = _DTAdmission;
                _Obj.ddlAdmissionId.Properties.ValueMember = "AdmissionId";
                _Obj.ddlAdmissionId.Properties.DisplayMember = "AdmissionCode";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}