using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ABCComputerEducation.DAL;

namespace ABCComputerEducation.BLL
{
    public class InstituteBLL : BaseBLL
    {
        InstituteDAL _ObjInstituteDAL = new InstituteDAL();
        public DataTable GetInstituteInfo()
        {
            try
            {
                return _ObjInstituteDAL.GetInstituteInfo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
