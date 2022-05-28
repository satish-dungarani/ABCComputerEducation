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
    public partial class FrmStudentMasterEntry : DevExpress.XtraEditors.XtraForm
    {
        public int _StudentId = 0;
        StudentMasterBLL _ObjStudentMasterBLL;
        public FrmStudentMasterEntry()
        {
            InitializeComponent();
            _ObjStudentMasterBLL = new StudentMasterBLL();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                {
                    //Send From To DB 
                    _ObjStudentMasterBLL.StudentId = Convert.ToInt32(txtStudentId.Text);
                    _ObjStudentMasterBLL.StudentName = txtStudentName.Text;
                    _ObjStudentMasterBLL.Gender = radGender.EditValue.ToString();
                    _ObjStudentMasterBLL.Address = txtAddress.Text;
                    _ObjStudentMasterBLL.City = txtCity.Text;
                    _ObjStudentMasterBLL.State = txtState.Text;
                    _ObjStudentMasterBLL.Pincode = Convert.ToDecimal(txtPincode.Text);
                    _ObjStudentMasterBLL.ContactNo = txtContactNo.Text;
                    _ObjStudentMasterBLL.PersonalNo = Convert.ToDecimal(txtPersonalNo.Text);
                    _ObjStudentMasterBLL.FatherContactNo = Convert.ToDecimal(txtFatherContactNo.Text);
                    _ObjStudentMasterBLL.RecidentialNo = txtRecidentialNo.Text;
                    _ObjStudentMasterBLL.EmailId = txtEmailId.Text;
                    _ObjStudentMasterBLL.LastEducation = txtLastEducation.Text;
                    _ObjStudentMasterBLL.User = HelperCls.User;
                    _ObjStudentMasterBLL.Terminal = HelperCls.Terminal;

                    this._StudentId = _ObjStudentMasterBLL.SetStudentMaster();

                    if (this._StudentId > 0)
                        HelperCls.MsgBox("Student Registration successfully done.", HelperCls.MessageType.Success);
                    else
                        HelperCls.MsgBox("Student Registration failed.", HelperCls.MessageType.Error);

                    this.DialogResult = DialogResult.OK;

                }
                else
                    this.DialogResult = DialogResult.None;

                this.Focus();
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
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        public bool Validation()
        {
            try
            {
                decimal _decValue;

                if (string.IsNullOrEmpty(txtStudentName.Text))
                {
                    HelperCls.MsgBox("Student Name can not left blank.", HelperCls.MessageType.Warning);
                    txtStudentName.Focus();
                    return false;
                }
                else if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    HelperCls.MsgBox("Student Address can not left blank.", HelperCls.MessageType.Warning);
                    txtAddress.Focus();
                    return false;
                }
                else if (string.IsNullOrEmpty(txtPersonalNo.Text))
                {
                    HelperCls.MsgBox("Personal No can not left blank.", HelperCls.MessageType.Warning);
                    txtPersonalNo.Focus();
                    return false;
                }
                else if (!Decimal.TryParse(txtPersonalNo.Text, out _decValue))
                {
                    HelperCls.MsgBox("Personal No must be in numeric.", HelperCls.MessageType.Warning);
                    txtPersonalNo.Focus();
                    return false;
                }
                else if (string.IsNullOrEmpty(txtFatherContactNo.Text))
                {
                    HelperCls.MsgBox("Father Contact No can not left blank.", HelperCls.MessageType.Warning);
                    txtFatherContactNo.Focus();
                    return false;
                }
                else if (!Decimal.TryParse(txtFatherContactNo.Text, out _decValue))
                {
                    HelperCls.MsgBox("Father Contact No must be in numeric.", HelperCls.MessageType.Warning);
                    txtFatherContactNo.Focus();
                    return false;
                }
                else if (string.IsNullOrEmpty(txtPincode.Text))
                {
                    HelperCls.MsgBox("Pincode can not left blank.", HelperCls.MessageType.Warning);
                    txtPincode.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
                return false;
            }
        }

    }
}