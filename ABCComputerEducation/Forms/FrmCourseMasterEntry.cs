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
    public partial class FrmCourseMasterEntry : DevExpress.XtraEditors.XtraForm
    {
        MasterValuesBLL _OBjMasterValueBLL;
        public FrmCourseMasterEntry()
        {
            InitializeComponent();
            _OBjMasterValueBLL = new MasterValuesBLL();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                decimal _decOut;
                //Validation
                if (string.IsNullOrEmpty(this.txtMasterValue.Text))
                {
                    HelperCls.MsgBox("Course Value can't left blank", HelperCls.MessageType.Warning);
                    this.txtMasterValue.Focus();
                    return;
                }
                //if (!decimal.TryParse(this.txtOtherValue.Text,out _decOut))
                //{
                //    HelperCls.MsgBox("Fee must be in numeric format", HelperCls.MessageType.Warning);
                //    this.txtOtherValue.Focus();
                //    return;
                //}


                //Send Data For Store In DB
                _OBjMasterValueBLL.MasterValId = Convert.ToInt32(this.txtMasterValId.Text);
                _OBjMasterValueBLL.RefMasterSetup_MasterSetupId = Convert.ToInt32(this.txtMasterSetupId.Text);
                _OBjMasterValueBLL.MasterValue = this.txtMasterValue.Text;
                _OBjMasterValueBLL.ShortValue = this.txtShortValue.Text;
                _OBjMasterValueBLL.MasterDesc = this.txtMasterDesc.Text;
                if (decimal.TryParse(this.txtOtherValue.Text, out _decOut))
                    _OBjMasterValueBLL.OtherValue = this.txtOtherValue.Text;
                _OBjMasterValueBLL.User = HelperCls.User;
                _OBjMasterValueBLL.Terminal = HelperCls.Terminal;
                if (_OBjMasterValueBLL.SetMasterValues() > 0)
                {
                    if (this.txtMasterValId.Text == "0")
                        HelperCls.MsgBox("New Course successfully add in List.", HelperCls.MessageType.Success);
                    else
                        HelperCls.MsgBox("Course successfully updated in List.", HelperCls.MessageType.Success);

                    this.DialogResult = DialogResult.OK;
                }
                else
                    HelperCls.MsgBox("Course data operation fail.", HelperCls.MessageType.Warning);
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }
    }
}