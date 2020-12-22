using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pharmacy_Management.DAL;

namespace Pharmacy_Management.BL
{
    class CLASS_CATEGORY
    {  public static int SP_ADDCATEGORY(string cat_name)
        {
            /// ADD NEW CATEGORY 
            /// CAT NAME=THE NAME OF CATEGORY
            /// RETURN =THE NUMBER OF INSERTE ROWS 
            DataAccessLayer.open();

           int count= DataAccessLayer.ExecuteNonQuery("SP_ADDCATEGORY", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@CAT_NAME", SqlDbType.VarChar, cat_name));
            DataAccessLayer.close();
            return count;
          }

        public static DataTable SP_SELECTALLCATEGORIES()
        {

            DataAccessLayer.open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SELECTALLCATEGORIES" ,CommandType.StoredProcedure);
            DataAccessLayer.close();
            return dt;

        }
        /// <summary>
        /// SELECT CERTAIN CATEGORY 
        /// </summary>
        /// <param name="SEARCH">STRING VALUEV</param>
        /// <returns> DATATABLE</returns>
        public static DataTable SP_SEARCHCATEGORIES(String SEARCH )
        {

            DataAccessLayer.open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_SEARCHCATEGORIES", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.VarChar, SEARCH));
            DataAccessLayer.close();
            return dt;
        }
 
    public static int SP_UPDATECATEGORY(int Cat_ID,  string Cat_Name)
    {
        DataAccessLayer.open();
        int i = DataAccessLayer.ExecuteNonQuery("SP_UPDATECATEGORY", CommandType.StoredProcedure,
            DataAccessLayer.CreateParameter("@CAT_ID", SqlDbType.Int, Cat_ID),
            DataAccessLayer.CreateParameter("@CAT_NAME", SqlDbType.VarChar, Cat_Name)) ;
        DataAccessLayer.close();

        return i;

            


    }

        public static int SPDELETECATEGORY(int CAT_ID)
        {

            DataAccessLayer.open();
            int I = DataAccessLayer.ExecuteNonQuery("SPDELETECATEGORY", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@cat_id", SqlDbType.Int, CAT_ID));
            DataAccessLayer.close();
            return I;


        }



    }





}
