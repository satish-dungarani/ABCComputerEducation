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
using ABCComputerEducation;
using ABCComputerEducation.BLL;
using System.Windows;

namespace ABCComputerEducation.Forms
{
    public partial class FrmCourseMaster : DevExpress.XtraEditors.XtraForm
    {

        FrmMainPage _ObjFrmMain;
        MasterValuesBLL _ObjMasterValueBLL;
        FrmCourseMasterEntry _ObjMasterValueEntry;
        public FrmCourseMaster()
        {
            InitializeComponent();

            _ObjFrmMain = new FrmMainPage();
            _ObjMasterValueBLL = new MasterValuesBLL();
        }

        private void FrmCourseMaster_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Course Master";

                if(HelperCls.UserName.ToLower().Trim() == "user")
                {
                    this.GCOLDeleteAction.Visible = false;
                    this.GCOLOtherValue.Visible = false;
                }
                //Binding Data With Grid
                this.GCMasterValues.DataSource = _ObjMasterValueBLL.GetMasterValues();
                this.GVMasterValues.BestFitColumns(true);
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
                _ObjMasterValueEntry = new FrmCourseMasterEntry();
                _ObjMasterValueEntry.lblTitle.Text = "Add Course";
                _ObjMasterValueEntry.txtMasterValId.Text = "0";
                _ObjMasterValueEntry.txtMasterSetupId.Text = HelperCls.MasterSetupId.ToString();
                if (_ObjMasterValueEntry.ShowDialog() == DialogResult.OK)
                {
                    _ObjMasterValueEntry.Close();

                    //Binding Data With Grid
                    this.GCMasterValues.DataSource = _ObjMasterValueBLL.GetMasterValues();
                    this.GVMasterValues.BestFitColumns(true);
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void RIBEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                _ObjMasterValueEntry = new FrmCourseMasterEntry();
                _ObjMasterValueEntry.lblTitle.Text = "Edit Course";
                int MasterValId = Convert.ToInt32(this.GVMasterValues.GetFocusedRowCellValue("MasterValId"));
                DataTable _DTMasterData = new DataTable();
                _DTMasterData = _ObjMasterValueBLL.GetMasterValues(MasterValId, HelperCls.MasterSetupId);
                _ObjMasterValueEntry.txtMasterValId.Text = _DTMasterData.Rows[0]["MasterValId"].ToString();
                _ObjMasterValueEntry.txtMasterSetupId.Text = _DTMasterData.Rows[0]["RefMasterSetup_MasterSetupId"].ToString();
                _ObjMasterValueEntry.txtMasterValue.Text = _DTMasterData.Rows[0]["MasterValue"].ToString();
                _ObjMasterValueEntry.txtShortValue.Text = _DTMasterData.Rows[0]["ShortValue"].ToString();
                _ObjMasterValueEntry.txtMasterDesc.Text = _DTMasterData.Rows[0]["MasterDesc"].ToString();
                _ObjMasterValueEntry.txtOtherValue.Text = _DTMasterData.Rows[0]["OtherValue"].ToString();
                if (_ObjMasterValueEntry.ShowDialog() == DialogResult.OK)
                {
                    _ObjMasterValueEntry.Close();
                    //Binding Data With Grid
                    this.GCMasterValues.DataSource = _ObjMasterValueBLL.GetMasterValues();
                    this.GVMasterValues.BestFitColumns(true);
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
                if (HelperCls.MsgBox("Are you sure to delete Course?", HelperCls.MessageType.Question) == DialogResult.Yes)
                {
                    int MasterValId = Convert.ToInt32(this.GVMasterValues.GetFocusedRowCellValue("MasterValId"));
                    if (_ObjMasterValueBLL.DeleteRecord(MasterValId, "MasterValues") > 0)
                    {
                        HelperCls.MsgBox("Course Record successfully deleted!", HelperCls.MessageType.Success);
                        //Binding Data With Grid
                        this.GCMasterValues.DataSource = _ObjMasterValueBLL.GetMasterValues();
                        this.GVMasterValues.BestFitColumns(true);
                    }
                    else if (_ObjMasterValueBLL.DeleteRecord(MasterValId, "MasterValues") == -1)
                        HelperCls.MsgBox("Course name used in another admission. So, You can't delete it!", HelperCls.MessageType.Warning);
                    else
                        HelperCls.MsgBox("Somthing goes wrong! Course Record delete fail!", HelperCls.MessageType.Warning);
                }
                
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }
    }
}