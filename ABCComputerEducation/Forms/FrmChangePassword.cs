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
using System.Security.Cryptography;
using System.IO;

namespace ABCComputerEducation.Forms
{
    public partial class FrmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        UserMasterBLL _ObjUserMasterBLL = new UserMasterBLL();
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(this.txtPwd.Text))
                {
                    this.txtPwd.Focus();
                    HelperCls.MsgBox("Password can not left blank!", HelperCls.MessageType.Warning);
                    return;
                }
                else if (string.IsNullOrEmpty(this.txtConfPwd.Text))
                {
                    this.txtConfPwd.Focus();
                    HelperCls.MsgBox("Confirm Password can not left blank!", HelperCls.MessageType.Warning);
                    return;
                }
                else if (!this.txtConfPwd.Text.Equals(this.txtPwd.Text))
                {
                    this.txtConfPwd.Focus();
                    this.txtConfPwd.SelectAll();
                    HelperCls.MsgBox("Password and Confirm Password not matched!", HelperCls.MessageType.Warning);
                    return;
                }

                //Password Encrypt
                string clearText = string.Empty;
                byte[] clearBytes = Encoding.Unicode.GetBytes(this.txtPwd.Text);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(HelperCls.EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(clearBytes, 0, clearBytes.Length);
                            cs.Close();
                        }
                        clearText = Convert.ToBase64String(ms.ToArray());
                    }
                }

                //Save New Password 

                _ObjUserMasterBLL.UserName = this.cmbUserName.Text;
                _ObjUserMasterBLL.Password = clearText;
                if(!string.IsNullOrEmpty(_ObjUserMasterBLL.ChangePassword()))
                {
                    HelperCls.MsgBox("Password successfully chnage for Admin User.", HelperCls.MessageType.Success);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    HelperCls.MsgBox("Server Error!, Password fail to chnage for Admin User. Please try again.", HelperCls.MessageType.Error);
                }


            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }
    }
}