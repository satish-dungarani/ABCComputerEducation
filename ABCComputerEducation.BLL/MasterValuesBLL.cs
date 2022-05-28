using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABCComputerEducation.DAL;
using System.Data;

namespace ABCComputerEducation.BLL
{
    public class MasterValuesBLL : BaseBLL
    {
        MasterValuesDAL _ObjMasterValueDAL = new MasterValuesDAL();

        #region Properites
        public int MasterValId { get; set; }
        public int RefMasterSetup_MasterSetupId { get; set; }
        public string MasterValue { get; set; }
        public string ShortValue { get; set; }
        public string MasterDesc { get; set; }
        public string OtherValue { get; set; }
        public Nullable<int> InsUser { get; set; }
        public Nullable<DateTime> InsDateTime { get; set; }
        public string InsTerminal { get; set; }
        public Nullable<int> UpdUser { get; set; }
        public Nullable<DateTime> UpdDateTime { get; set; }
        public string UpdTerminal { get; set; }
        #endregion

        #region Operational Funcations
        //Save Data
        public int SetMasterValues()
        {
            try
            {
                return _ObjMasterValueDAL.SaveMasterValues(MasterValId, RefMasterSetup_MasterSetupId, MasterValue, ShortValue, MasterDesc, OtherValue, User, Terminal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get Data
        public DataTable GetMasterValues(int? MasterValId = null, int? MasterSetupId = null)
        {
            try
            {
                return _ObjMasterValueDAL.GetMasterValues(MasterValId, MasterSetupId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
