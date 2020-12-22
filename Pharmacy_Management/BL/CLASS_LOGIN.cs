using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pharmacy_Management.DAL;

namespace Pharmacy_Management.BL
{
    class CLASS_LOGIN
    {
        public static DataTable SpLogin(string uname , string upass)
        {

            DataAccessLayer.open();
          DataTable dt=   DataAccessLayer.ExecuteTable("SP_LOGIN", CommandType.StoredProcedure, DataAccessLayer.CreateParameter("UsName", SqlDbType.VarChar, uname),
               (DataAccessLayer.CreateParameter("UsPassowrd", SqlDbType.VarChar, upass)));
          
            DataAccessLayer.close();
            return dt;
          


               
        }


    }
}
