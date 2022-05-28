using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using ABCComputerEducation.Forms;
using DevExpress.Export;
using DevExpress.XtraPrinting;
using System.IO;
using ABCComputerEducation.Reports;
using ABCComputerEducation.BLL;

namespace ABCComputerEducation
{
    public partial class FrmMainPage : RibbonForm
    {
        public FrmMainPage()
        {
            InitializeComponent();
            InitSkinGallery(rgbiSkins);

        }
        void InitSkinGallery(dynamic _SkinName)
        {
            SkinHelper.InitSkinGallery(_SkinName, true);
        }

        private void btnCourses_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();
                FrmCourseMaster _ObjCourse = new FrmCourseMaster();
                HelperCls.MasterSetupId = (int)HelperCls.MasterSetup.Course;
                _ObjCourse.MdiParent = this;
                _ObjCourse.Show();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnEnquiryMaster_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();
                FrmEnquiryMaster _ObjEnquiry = new FrmEnquiryMaster();
                _ObjEnquiry.IsExternalData = false;
                _ObjEnquiry.MdiParent = this;
                _ObjEnquiry.Show();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void barbtnPDF_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        PrintingSystem printingSystem1 = new PrintingSystem();
        PrintableComponentLink printableComponentLink1 = new PrintableComponentLink();
        // ...

        private void barbtnXLSX_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                //FrmEnquiryMaster _ObjEnquiry = new FrmEnquiryMaster();
                //documentViewer1.Visible = true;
                //// Add the link to the printing system's collection of links.
                //printingSystem1.Links.AddRange(new object[] { printableComponentLink1 });

                //// Assign a control to be printed by this link.
                //printableComponentLink1.Component = _ObjEnquiry.GCEnquiryMaster;

                //// Assign the printing system to the document viewer.
                //documentViewer1.PrintingSystem = printingSystem1;

                StudentMasterBLL _ObjStudentMasterBLL = new StudentMasterBLL();
                DataTable _DTStudent = new DataTable();
                _DTStudent = _ObjStudentMasterBLL.GetStudentMaster(null);

                SaveFileDialog _ObjSaveFile = new SaveFileDialog();
                _ObjSaveFile.FileName = "Student List " + System.DateTime.Now.ToShortDateString().Replace('/', '_').Replace('-', '_');
                if (_ObjSaveFile.ShowDialog() == DialogResult.OK)
                {
                    if (HelperCls.ExportToExcel(_DTStudent, _ObjSaveFile.FileName))
                    {
                        HelperCls.MsgBox("All Student Record Successfully Exported in Excel.", HelperCls.MessageType.Success);
                    }
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnStudentMaster_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();
                FrmStudentMaster _ObjStudent = new FrmStudentMaster();
                _ObjStudent.MdiParent = this;
                _ObjStudent.Show();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnAdminssion_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();
                FrmAdmissionDetail _ObjAdmission = new FrmAdmissionDetail();
                _ObjAdmission.IsDropOut = false;
                _ObjAdmission.MdiParent = this;
                _ObjAdmission.Show();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnFeesReceive_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();
                FrmStudentFeesDetails _ObjStudentFeesDetails = new FrmStudentFeesDetails();
                _ObjStudentFeesDetails.MdiParent = this;
                _ObjStudentFeesDetails.Show();

            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnMarksheet_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();
                FrmStudentExamMarkSheet _ObjFrmStudentExamMarkSheet = new FrmStudentExamMarkSheet();
                _ObjFrmStudentExamMarkSheet.MdiParent = this;
                _ObjFrmStudentExamMarkSheet.Show();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnCartyRegistration_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();
                FrmCertyRegistration _ObjCertyRegistration = new FrmCertyRegistration();
                _ObjCertyRegistration.MdiParent = this;
                _ObjCertyRegistration.Show();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }


        private void FrmMainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnFeeinstallmentReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();
                FrmFeeReportsView _ObjFrmFeeReportsView = new FrmFeeReportsView();
                _ObjFrmFeeReportsView.MdiParent = this;
                _ObjFrmFeeReportsView.Show();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void FrmMainPage_Load(object sender, EventArgs e)
        {
            try
            {
                if(HelperCls.UserName.ToLower().Trim() == "user")
                {
                    this.btnChnagePwd.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    this.btnChequeDetail.Visible= false;
                    //this.btnDashboard.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                    this.ribbonPageGroup1.Visible = false;
                }
                else
                {
                    FrmDashboard _ObjFrmDashboard = new FrmDashboard();
                    _ObjFrmDashboard.MdiParent = this;
                    _ObjFrmDashboard.Show();
                }
                
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void barbtnPrint_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Form _ObjForm = this.MdiChildren[0];
                if (_ObjForm != null)
                {

                    if (_ObjForm.Name == "FrmFeeReportsView")
                    {
                        DevExpress.XtraGrid.GridControl _ObjGridControl = (DevExpress.XtraGrid.GridControl)this.MdiChildren[0].ActiveControl;
                        if (_ObjGridControl.IsPrintingAvailable)
                            _ObjGridControl.ShowPrintPreview();
                    }
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void barbtnExnquiryExcelExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                EnquiryMasterBLL _ObjEnquiryMasterBLL = new EnquiryMasterBLL();
                DataTable _DTEnquiry = new DataTable();
                _DTEnquiry = _ObjEnquiryMasterBLL.GetEnquiryMaster(null);

                //Removed Enquiry none used Columns
                _DTEnquiry.Columns.Remove("EnquiryId");
                _DTEnquiry.Columns.Remove("RefMasterValues_CourseId");
                _DTEnquiry.Columns.Remove("IsExternalData");

                SaveFileDialog _ObjSaveFile = new SaveFileDialog();
                _ObjSaveFile.FileName = "Enquiry List " + System.DateTime.Now.ToShortDateString().Replace('/', '_').Replace('-', '_');
                if (_ObjSaveFile.ShowDialog() == DialogResult.OK)
                {
                    if (HelperCls.ExportToExcel(_DTEnquiry, _ObjSaveFile.FileName))
                    {
                        HelperCls.MsgBox("All Students Enquiry Successfully Exported in Excel.", HelperCls.MessageType.Success);
                    }
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void barbtnAdmissionExcelExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                AdmissionDetailBLL _ObjAdmissionDetailBLL = new AdmissionDetailBLL();
                DataTable _DTAdmission = new DataTable();
                _DTAdmission = _ObjAdmissionDetailBLL.GetAdmissionDetail(null);

                //Removed Columns
                _DTAdmission.Columns.Remove("AdmissionId");
                _DTAdmission.Columns.Remove("IsDropOut");
                _DTAdmission.Columns.Remove("RefAdmissionId");
                _DTAdmission.Columns.Remove("RefEnquiryId");
                _DTAdmission.Columns.Remove("RefMasterValues_CourseId");
                
                SaveFileDialog _ObjSaveFile = new SaveFileDialog();
                _ObjSaveFile.FileName = "Admission List " + System.DateTime.Now.ToShortDateString().Replace('/', '_').Replace('-', '_');
                if (_ObjSaveFile.ShowDialog() == DialogResult.OK)
                {
                    if (HelperCls.ExportToExcel(_DTAdmission, _ObjSaveFile.FileName))
                    {
                        HelperCls.MsgBox("All Admission Successfully Exported in Excel.", HelperCls.MessageType.Success);
                    }
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnChnagePwd_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();
                FrmChangePassword _ObjFrmChangePassword = new FrmChangePassword();
                _ObjFrmChangePassword.MdiParent = this;
                _ObjFrmChangePassword.Show();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void rgbiSkins_DownChanged(object sender, ItemClickEventArgs e)
        {
           
        }

        private void rgbiSkins_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void rgbiSkins_GalleryItemClick(object sender, GalleryItemClickEventArgs e)
        {

        }

        private void rgbiSkins_Gallery_ItemClick(object sender, GalleryItemClickEventArgs e)
        {
            try
            {
             
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnDashboard_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                 if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();
                FrmDashboard _ObjFrmDashboard = new FrmDashboard();
                _ObjFrmDashboard.MdiParent = this;
                _ObjFrmDashboard.Show();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnExternalEnquiry_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();
                FrmEnquiryMaster _ObjEnquiry = new FrmEnquiryMaster();
                _ObjEnquiry.IsExternalData = true;
                _ObjEnquiry.MdiParent = this;
                _ObjEnquiry.Show();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnDropOutAdmission_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();
                FrmAdmissionDetail _ObjAdmission = new FrmAdmissionDetail();
                _ObjAdmission.IsDropOut = true;
                _ObjAdmission.MdiParent = this;
                _ObjAdmission.Show();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnChequeDetail_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();
                FrmChequeDetails _ObjAdmission = new FrmChequeDetails();
                _ObjAdmission.MdiParent = this;
                _ObjAdmission.Show();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnDropOutExcelExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                AdmissionDetailBLL _ObjAdmissionDetailBLL = new AdmissionDetailBLL();
                DataTable _DTAdmission = new DataTable();
                _DTAdmission = _ObjAdmissionDetailBLL.GetAdmissionDetail(null,true);

                _DTAdmission.Columns.Remove("AdmissionId");
                _DTAdmission.Columns.Remove("IsDropOut");
                _DTAdmission.Columns.Remove("RefAdmissionId");
                _DTAdmission.Columns.Remove("RefEnquiryId");
                _DTAdmission.Columns.Remove("RefMasterValues_CourseId");

                SaveFileDialog _ObjSaveFile = new SaveFileDialog();
                _ObjSaveFile.FileName = "Drop Out Admission List " + System.DateTime.Now.ToShortDateString().Replace('/', '_').Replace('-', '_');
                if (_ObjSaveFile.ShowDialog() == DialogResult.OK)
                {
                    if (HelperCls.ExportToExcel(_DTAdmission, _ObjSaveFile.FileName))
                    {
                        HelperCls.MsgBox("All Drop Out Admission Successfully Exported in Excel.", HelperCls.MessageType.Success);
                    }
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnExternalData_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                EnquiryMasterBLL _ObjEnquiryMasterBLL = new EnquiryMasterBLL();
                DataTable _DTEnquiry = new DataTable();
                _DTEnquiry = _ObjEnquiryMasterBLL.GetEnquiryMaster(null,true);

                //Removed Enquiry none used Columns
                _DTEnquiry.Columns.Remove("EnquiryId");
                _DTEnquiry.Columns.Remove("RefMasterValues_CourseId");
                _DTEnquiry.Columns.Remove("IsExternalData");

                SaveFileDialog _ObjSaveFile = new SaveFileDialog();
                _ObjSaveFile.FileName = "External Data List " + System.DateTime.Now.ToShortDateString().Replace('/', '_').Replace('-', '_');
                if (_ObjSaveFile.ShowDialog() == DialogResult.OK)
                {
                    if (HelperCls.ExportToExcel(_DTEnquiry, _ObjSaveFile.FileName))
                    {
                        HelperCls.MsgBox("All External Enquiry Data Successfully Exported in Excel.", HelperCls.MessageType.Success);
                    }
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnStudentFeeExcelExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                StudentFeesDetailsBLL _ObjStudentFeesDetailsBLL = new StudentFeesDetailsBLL();
                DataTable _DTFee = new DataTable();
                _DTFee = _ObjStudentFeesDetailsBLL.GetStudentFeesDetails();

                //Removed Student Fees none used Columns
                _DTFee.Columns.Remove("RefAdmirssionDetail_AdmissionId");
                _DTFee.Columns.Remove("ReceiptId");

                SaveFileDialog _ObjSaveFile = new SaveFileDialog();
                _ObjSaveFile.FileName = "Students Fees Detail List " + System.DateTime.Now.ToShortDateString().Replace('/', '_').Replace('-', '_');
                if (_ObjSaveFile.ShowDialog() == DialogResult.OK)
                {
                    if (HelperCls.ExportToExcel(_DTFee, _ObjSaveFile.FileName))
                    {
                        HelperCls.MsgBox("All Students Fee Data Successfully Exported in Excel.", HelperCls.MessageType.Success);
                    }
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnCertyExcelExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                CertyRegistrationBLL _ObjCertyRegistrationBLL = new CertyRegistrationBLL();
                DataTable _DTCerty = new DataTable();
                _DTCerty = _ObjCertyRegistrationBLL.GetCertRegistration();

                //Removed Certy none used Columns
                _DTCerty.Columns.Remove("CertyId");
                _DTCerty.Columns.Remove("RefStudentExamMarkSheet_MarksheetId");

                SaveFileDialog _ObjSaveFile = new SaveFileDialog();
                _ObjSaveFile.FileName = "Students Certy List " + System.DateTime.Now.ToShortDateString().Replace('/', '_').Replace('-', '_');
                if (_ObjSaveFile.ShowDialog() == DialogResult.OK)
                {
                    if (HelperCls.ExportToExcel(_DTCerty, _ObjSaveFile.FileName))
                    {
                        HelperCls.MsgBox("All Students Certy Successfully Exported in Excel.", HelperCls.MessageType.Success);
                    }
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnPassedOut_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();
                FrmAdmissionDetail _ObjAdmission = new FrmAdmissionDetail();
                _ObjAdmission.IsPassedOut = true;
                _ObjAdmission.MdiParent = this;
                _ObjAdmission.Show();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnPassedOutExcelExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                AdmissionDetailBLL _ObjAdmissionDetailBLL = new AdmissionDetailBLL();
                DataTable _DTAdmission = new DataTable();
                _DTAdmission = _ObjAdmissionDetailBLL.GetAdmissionDetail(null, false,true);

                _DTAdmission.Columns.Remove("AdmissionId");
                _DTAdmission.Columns.Remove("IsDropOut");
                _DTAdmission.Columns.Remove("RefAdmissionId");
                _DTAdmission.Columns.Remove("RefEnquiryId");
                _DTAdmission.Columns.Remove("RefMasterValues_CourseId");

                SaveFileDialog _ObjSaveFile = new SaveFileDialog();
                _ObjSaveFile.FileName = "Drop Out Admission List " + System.DateTime.Now.ToShortDateString().Replace('/', '_').Replace('-', '_');
                if (_ObjSaveFile.ShowDialog() == DialogResult.OK)
                {
                    if (HelperCls.ExportToExcel(_DTAdmission, _ObjSaveFile.FileName))
                    {
                        HelperCls.MsgBox("All Drop Out Admission Successfully Exported in Excel.", HelperCls.MessageType.Success);
                    }
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }


    }
}