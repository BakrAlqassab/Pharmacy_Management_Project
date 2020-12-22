using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pharmacy_Management.DAL;

namespace Pharmacy_Management.BL
{
    class CLASS_USER
    {
        public static int SP_INSERT_USER(string us_name, string us_pass, string us_fullname, int per_id)
        {


            DataAccessLayer.open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_INSERT_USER", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@US_NAME", SqlDbType.VarChar, us_name),
                DataAccessLayer.CreateParameter("@US_PASS", SqlDbType.VarChar, us_pass),
                DataAccessLayer.CreateParameter("@US_FULLNAME", SqlDbType.VarChar, us_fullname),
                DataAccessLayer.CreateParameter("@PER_ID", SqlDbType.Int, per_id));
            DataAccessLayer.close();
            return i;
        }

        public static DataTable SP_PREMISSION()
        {
            DataAccessLayer.open();
            DataTable DT = DataAccessLayer.ExecuteTable("SP_PREMISSION", CommandType.StoredProcedure);
            DataAccessLayer.close();
            return DT;


        }

        public static DataTable SP_USERDISPLAY()
        {

            DataAccessLayer.open();
            DataTable DT = DataAccessLayer.ExecuteTable("SP_USERDISPLAY", CommandType.StoredProcedure);
            DataAccessLayer.close();
            return DT;
        }


        public static DataTable SP_USER_SEARCH(String search)
        {

            DataAccessLayer.open();
            DataTable DT = DataAccessLayer.ExecuteTable("SP_USER_SEARCH", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.VarChar, search));
            DataAccessLayer.close();
            return DT;
        }

        public static int SP_USERUPDATE(int U_ID, string us_name, string us_pass, string us_fullname, int per_id)
        {


            DataAccessLayer.open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_USERUPDATE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@US_ID", SqlDbType.Int, U_ID),
                DataAccessLayer.CreateParameter("@US_NAME", SqlDbType.VarChar, us_name),
                DataAccessLayer.CreateParameter("@US_PASS", SqlDbType.VarChar, us_pass),
                DataAccessLayer.CreateParameter("@US_FULLNAME", SqlDbType.VarChar, us_fullname),
                DataAccessLayer.CreateParameter("@PER_ID", SqlDbType.Int, per_id));
            DataAccessLayer.close();
            return i;
        }

        public static int SP_DELTEUSER(int us_id)
        {
            DataAccessLayer.open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_DELTEUSER", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@US_ID", SqlDbType.Int, us_id));
            DataAccessLayer.close();
            return i;



        }


    }
}
