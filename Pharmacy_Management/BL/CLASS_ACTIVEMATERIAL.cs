using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy_Management.DAL;
using System.Data;
using Pharmacy_Management.BL;

namespace Pharmacy_Management.BL
{
    class CLASS_ACTIVEMATERIAL
    {
        public static int SP_ADDACTIVEMATERIAL(string AMNAME, string AMdesc)
        {
            DataAccessLayer.open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_ADDACTIVEMATERIAL",
                CommandType.StoredProcedure,

                DataAccessLayer.CreateParameter("@AMNAME", SqlDbType.VarChar, AMNAME),
                DataAccessLayer.CreateParameter("@ACMDES", SqlDbType.VarChar, AMdesc));
            DataAccessLayer.close();
            return i;
        }

        public static DataTable SP_SELECTALLACTIVEMATERIAL()
        {


            DataAccessLayer.open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SELECTALLACTIVEMATERIAL", CommandType.StoredProcedure);
            DataAccessLayer.close();
            return dt;

        }
        public static DataTable SP_SELECTSEARCHACTIVEMATERIAL(string search)
        {


            DataAccessLayer.open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SELECTSEARCHACTIVEMATERIAL", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.VarChar, search));
            DataAccessLayer.close();
            return dt;
        }

        public static  int SP_ACTIVEMATERIALUPDATE(int AMID , String AMNAME , String AMDESCRIPTION)
        {
            DataAccessLayer.open();
            int I = DataAccessLayer.ExecuteNonQuery("SP_ACTIVEMATERIALUPDATE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ACI_ID", SqlDbType.Int, AMID),
                DataAccessLayer.CreateParameter("@AC_NAME", SqlDbType.VarChar, AMNAME),
                 DataAccessLayer.CreateParameter("@AC_DES", SqlDbType.VarChar, AMDESCRIPTION));
            DataAccessLayer.close();
            return I;


        }
        public static int ACTIVEMATERIALDELETE(int ID)
        {
            DataAccessLayer.open();

            int R = DataAccessLayer.ExecuteNonQuery("ACTIVEMATERIALDELETE", CommandType.StoredProcedure,
                 DataAccessLayer.CreateParameter("@AC_ID", SqlDbType.Int, ID));



            DataAccessLayer.close();
            return R;


        }
    }
    

}
