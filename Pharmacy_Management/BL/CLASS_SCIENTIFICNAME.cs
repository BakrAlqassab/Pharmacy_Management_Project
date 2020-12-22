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
    class CLASS_SCIENTIFICNAME
    {
        public static int SP_ADDSCIENTIFICNAME(string snname)
        {

            DataAccessLayer.open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_ADDSCIENTIFICNAME", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SNNAME", SqlDbType.VarChar, snname));
            DataAccessLayer.close();
            return i;
        }
       public static DataTable SP_SELECTALLSCIENTIFICNAME()
        {
            DataAccessLayer.open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SELECTALLSCIENTIFICNAME", CommandType.StoredProcedure);
            DataAccessLayer.close();
            return dt;
                
            
        }
        public static DataTable SP_SEARCHSCIENTIFICNAME( string Search)
        {
            DataAccessLayer.open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SEARCHSCIENTIFICNAME", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.VarChar, Search));
            DataAccessLayer.close();
            return dt;



        }
        public static int SP_UPDATESCIENTIFICNAME(int sn_id ,string sn_name)
        {

            DataAccessLayer.open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UPDATESCIENTIFICNAME", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SN_ID", SqlDbType.Int, sn_id),
                DataAccessLayer.CreateParameter("@SN_NAME", SqlDbType.VarChar, sn_name));
            DataAccessLayer.close();
            return i;
        }
        public static int SP_DELETESCIENTIFICNAME(int SN_ID)
        {
            DataAccessLayer.open();
            int I = DataAccessLayer.ExecuteNonQuery("SP_DELETESCIENTIFICNAME", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SN_ID", SqlDbType.Int, SN_ID));
            DataAccessLayer.close();
            return I;

        }



    }

}
