using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace ABCComputerEducation.Forms
{
    public partial class FrmSplashScreen : SplashScreen
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            try
            {
                this.Tmr_Splash.Interval = 3000;
                this.Tmr_Splash.Start();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void Tmr_Splash_Tick(object sender, EventArgs e)
        {
            try
            {
                this.Tmr_Splash.Stop();
                this.Hide();
                var _FrmSplash = this;

                FrmLogin _FrmLogin = new FrmLogin();

                if (_FrmLogin.ShowDialog() == DialogResult.OK)
                {
                    FrmMainPage _FrmMain = new FrmMainPage();
                    if(_FrmMain.ShowDialog() == DialogResult.Abort)
                    {
                        this.Close();
                    }
                    
                }
                else 
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }
    }
}