using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data;
using System.Data.Common;

namespace ABCComputerEducation.DAL
{
    public class BaseDAL
    {
        public string ConnectionString = string.Empty;
        public BaseDAL()
        {
            try
            {
                //ConnectionString = @"Data Source=HP\SQLEXPRESS;Initial Catalog=ABCEducationDB;Persist Security Info=True;User ID=sa;Password=sa123";
                ConnectionString = @"Data Source=ADMIN-PC;Initial Catalog=ABCEducationDB;Persist Security Info=True;User ID=sa;Password=abccomputer";
                //ConnectionString = @"Data Source=admin-PC;Initial Catalog=ABCEducationDB;Persist Security Info=True;User ID=sa;Password=abccomputer";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteRecordFromTable(int Id, string TableName)
        {
            try
            {
                int Result = 0;

                Database _ObjDB = new SqlDatabase(ConnectionString);
                using(DbCommand _ObjCmd = _ObjDB.GetStoredProcCommand("sp_Common_Delete"))
                {
                    _ObjDB.AddInParameter(_ObjCmd, "@pId", DbType.Int32, Id);
                    _ObjDB.AddInParameter(_ObjCmd, "@pTableName", DbType.String, TableName);

                    Result = Convert.ToInt32(_ObjDB.ExecuteScalar(_ObjCmd));
                }

                return Result;
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
                int Result = 0;

                Database _ObjDB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _ObjDB.GetStoredProcCommand("sp_SequanceMaster_Get"))
                {
                    _ObjDB.AddInParameter(_ObjCmd, "@pMasterName", DbType.String, MasterName);

                    Result = Convert.ToInt32(_ObjDB.ExecuteScalar(_ObjCmd));
                }

                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
