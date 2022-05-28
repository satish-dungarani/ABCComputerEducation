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
using System.Security.Cryptography;
using System.IO;
using ABCComputerEducation.BLL;

namespace ABCComputerEducation.Forms
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        UserMasterBLL _ObjUserMasterBLL = new UserMasterBLL();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Validation
                if (string.IsNullOrEmpty(this.txtUserName.Text))
                {
                    HelperCls.MsgBox("User name can not left blank!", HelperCls.MessageType.Warning);
                    this.txtUserName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtPassword.Text))
                {
                    HelperCls.MsgBox("Password can not left blank!", HelperCls.MessageType.Warning);
                    this.txtPassword.Focus();
                    return;
                }

                string clearText = string.Empty;
                byte[] clearBytes = Encoding.Unicode.GetBytes(this.txtPassword.Text);
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


                DataTable _DTUserDetail = _ObjUserMasterBLL.CehckAuthentication(this.txtUserName.Text, clearText);

                if (_DTUserDetail != null && _DTUserDetail.Rows.Count > 0)
                {
                    HelperCls.UserName = this.txtUserName.Text;
                    HelperCls.User = Convert.ToInt32(_DTUserDetail.Rows[0]["UserId"].ToString());
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    HelperCls.MsgBox("Please check your user name and password are correct or not!", HelperCls.MessageType.Warning);
                    this.txtPassword.SelectAll();
                    this.txtPassword.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
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
    }
}