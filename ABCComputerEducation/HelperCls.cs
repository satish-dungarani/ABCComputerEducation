using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data;
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;
using System.IO;

namespace ABCComputerEducation
{
    public static class HelperCls
    {
        public static int User = 0;
        public static string UserName = string.Empty;
        public static string Terminal = Dns.GetHostByName(Dns.GetHostName()).HostName.ToString();
        public static int MasterSetupId = 0;
        public static string _Action = string.Empty;
        public static string EncryptionKey = ConfigurationManager.AppSettings["EncryptionKey"].ToString();
        //Enum For Message Type
        public enum MessageType
        {
            Question = 1,
            Warning = 2,
            Success = 3,
            Error = 4,
            Information = 5
        }

        //Enum For Master Setup
        public enum MasterSetup
        {
            Course = 1
        }

        public static DialogResult MsgBox(string Msg, MessageType Type)
        {
            try
            {
                if (Type == MessageType.Question)
                    return MessageBox.Show(Msg, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                else if (Type == MessageType.Success)
                    return MessageBox.Show(Msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                else if (Type == MessageType.Warning)
                    return MessageBox.Show(Msg, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                else if (Type == MessageType.Information)
                    return MessageBox.Show(Msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                else
                    return MessageBox.Show(Msg, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            catch (Exception ex)
            {
                return MessageBox.Show(ex.Message, "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, false);
            }
        }

        public static bool ExportToExcel(DataTable _DT, string _FileName)
        {
            try
            {
                //string _ExcelFilePath = AppDomain.CurrentDomain.BaseDirectory + "ExportFiles\\" + _FileName + ".xlsx";
                string _ExcelFilePath = _FileName + ".xlsx";
                Excel.Application xlApp;

                if (File.Exists(_ExcelFilePath))
                    File.Delete(_ExcelFilePath);
                if (!File.Exists(_ExcelFilePath))
                {
                    xlApp = new Excel.Application();
                    Excel._Workbook xlWorkBook = xlApp.Workbooks.Add(Type.Missing);

                    Microsoft.Office.Interop.Excel._Worksheet xlWorkSheet = null;

                    //xlApp.Visible = true;

                    xlWorkSheet = xlWorkBook.Sheets["Sheet1"];
                    xlWorkSheet = xlWorkBook.ActiveSheet;
                    //xlWorkSheet.Name = "Student List";

                    for (int j = 0; j < _DT.Columns.Count; j++)
                    {
                        xlWorkSheet.Cells[1, j + 1] = _DT.Columns[j].ColumnName;
                    }

                    for (int i = 0; i < _DT.Rows.Count; i++)
                    {
                        for (int j = 0; j < _DT.Columns.Count; j++)
                        {
                            if (string.IsNullOrEmpty(_DT.Rows[i][j].ToString()))
                                xlWorkSheet.Cells[i + 2, j + 1] = null;
                            else
                                xlWorkSheet.Cells[i + 2, j + 1] = _DT.Rows[i][j].ToString();
                        }
                    }

                    xlWorkBook.Password = "123";
                    xlWorkBook.SaveAs(_ExcelFilePath);
                    xlWorkBook.Close();
                    xlApp.Quit();

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
