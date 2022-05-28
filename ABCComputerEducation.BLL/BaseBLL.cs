using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABCComputerEducation.DAL;

namespace ABCComputerEducation.BLL
{
    public class BaseBLL
    {
        #region CommanProperty
        public int User { get; set; }
        public string Terminal { get; set; }
        #endregion

        public BaseBLL()
        {
            User = 1;
            Terminal = "127.0.0.1";
        }

        #region Common Operations
        public int DeleteRecord(int Id, string TableName)
        {
            try
            {
                BaseDAL _ObjBaseDAL = new BaseDAL();
                return _ObjBaseDAL.DeleteRecordFromTable(Id, TableName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int GetSequanceNo(string MasterName)
        {
            try
            {
                BaseDAL _ObjBaseDAL = new BaseDAL();
                return _ObjBaseDAL.GetSequanceNo(MasterName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
