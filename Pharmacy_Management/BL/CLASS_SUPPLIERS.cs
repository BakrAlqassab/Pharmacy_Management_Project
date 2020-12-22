using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pharmacy_Management.DAL;
namespace Pharmacy_Management.BL
{
    class CLASS_SUPPLIERS
    {
        public static int SP_ADDNEWSUPPLIERS( string NAME , string MOBILE)
        {

            DataAccessLayer.open();
            int I = DataAccessLayer.ExecuteNonQuery("SP_ADDNEWSUPPLIERS", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SUNAME", SqlDbType.VarChar, NAME),
                DataAccessLayer.CreateParameter("@SUMOBILE", SqlDbType.VarChar, MOBILE));
            DataAccessLayer.close();
            return I;
        }

        public static DataTable SP_SUPPLIERSELECT()
        {
            DataAccessLayer.open();
            DataTable DT = DataAccessLayer.ExecuteTable("SP_SUPPLIERSELECT", CommandType.StoredProcedure);
            DataAccessLayer.close();
            return DT;

        }
        public static DataTable SP_SUPPLIERSEARCH(string SEARCH)
        {

            DataAccessLayer.open();
            DataTable DT = DataAccessLayer.ExecuteTable("SP_SUPPLIERSEARCH", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.VarChar, SEARCH));
            DataAccessLayer.close();
            return DT;


        }
        public static DataTable SP_SUPPLIERSSELECTBYID( int ID)
        {

            DataAccessLayer.open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SUPPLIERSSELECTBYID", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, ID));
            DataAccessLayer.close();
            return dt;
        }
        public static int SP_SUPPLIERUPDATE(int ID,string SU_NAME,string SU_MOBILE)
        {
            DataAccessLayer.open();
            int I = DataAccessLayer.ExecuteNonQuery("SP_SUPPLIERUPDATE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, ID),
                DataAccessLayer.CreateParameter("@Su_Name", SqlDbType.VarChar, SU_NAME),
                DataAccessLayer.CreateParameter("@Su_Mobile", SqlDbType.VarChar, SU_MOBILE));
            DataAccessLayer.close();
            return I;


        }
        public static int SP_SUPPLIERDELETE(int ID)
        {
            DataAccessLayer.open();
           int I = DataAccessLayer.ExecuteNonQuery("SP_SUPPLIERDELETE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, ID));
            DataAccessLayer.close();
            return I;
        }


    }
}
