using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pharmacy_Management.DAL;
using Pharmacy_Management.BL;

namespace Pharmacy_Management.BL
{
    class CLASS_PRODUCTS
    {
        public static DataTable SP_CATFILLCATCMB()
        {
            DataAccessLayer.open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_CATFILLCATCMB", CommandType.StoredProcedure);
            DataAccessLayer.close();
            return dt;
        }
        public static DataTable SP_CATFILLACM()
        {


            DataAccessLayer.open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_CATFILLACM", CommandType.StoredProcedure);
            DataAccessLayer.close();
            return dt;
        }
        public static DataTable SP_CATFILLSCN()
        {
            DataAccessLayer.open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_CATFILLSCN", CommandType.StoredProcedure);
            DataAccessLayer.close();
            return dt;
        }
        public static int SP_ADDNEWPRODUCT(String prname,string prdesc, byte[] img , string buyprice ,string sellprice ,int catid ,int amid ,int snid ,
            string barcode )
        {
            DataAccessLayer.open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_ADDNEWPRODUCT", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@PR_NAME", SqlDbType.VarChar, prname), DataAccessLayer.CreateParameter("@PR_DESECRIPTION", SqlDbType.VarChar, prdesc),
                DataAccessLayer.CreateParameter("@PR_IMG", SqlDbType.Image, img),
                DataAccessLayer.CreateParameter("@BUYPRICE", SqlDbType.VarChar, buyprice),
                 DataAccessLayer.CreateParameter("@PR_SELLPRICE", SqlDbType.VarChar, sellprice),
                  DataAccessLayer.CreateParameter("@CAT_ID", SqlDbType.Int, catid),
                   DataAccessLayer.CreateParameter("@AMID", SqlDbType.Int, amid),
                    DataAccessLayer.CreateParameter("@SNID", SqlDbType.Int, snid),
                     DataAccessLayer.CreateParameter("@BARCODE", SqlDbType.VarChar, barcode));
            DataAccessLayer.close();
            return i;




        }
        public static DataTable SP_PRODECTSELECT()
        {
            DataAccessLayer.open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_PRODECTSELECT", CommandType.StoredProcedure);
            DataAccessLayer.close();
            return dt;


        }
        
        public static DataTable SP_PRODECTSearch(string SEARCH)
        {
            DataAccessLayer.open();
            DataTable DT = DataAccessLayer.ExecuteTable("SP_PRODECTSearch", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@SEARCH", SqlDbType.VarChar, SEARCH));
            DataAccessLayer.close();
            return DT;
              
        }

        public static byte[] SP_PRODUCTGETIMG(int ID)
        {
            DataAccessLayer.open();
            byte[] Arr =(byte[]) DataAccessLayer.executeScaler("SP_PRODUCTGETIMG", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.BigInt,ID));
            DataAccessLayer.close();
            return Arr;
        }
        public static DataTable SP_PRODUCTGETEXPIREDATE(int id )
        {
            DataAccessLayer.open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_PRODUCTGETEXPIREDATE", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.BigInt, id));
            DataAccessLayer.close();
            return dt;


        }

        public static  int SP_DELETEPRODUCTS(int ID)
        {
            DataAccessLayer.open();
           int i = DataAccessLayer.ExecuteNonQuery("SP_DELETEPRODUCTS", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.BigInt, ID));
            DataAccessLayer.close();
            return i;

        }
        public static DataTable SP_GETSELECTEDPRODUCT( int id)
        {
            DataAccessLayer.open();
            DataTable dt = DataAccessLayer.ExecuteTable("SP_GETSELECTEDPRODUCT", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID", SqlDbType.Int, id));
            DataAccessLayer.close();
            return dt;


        }

        public static int SP_UPDATEPRODUCT(int id, string prname, string prdesc, byte[] img, string buyprice, string sellprice, int catid, int amid, int snid,
      string barcode)
        {
            DataAccessLayer.open();
            int i = DataAccessLayer.ExecuteNonQuery("SP_UPDATEPRODUCT", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@ID",SqlDbType.BigInt,id),
                DataAccessLayer.CreateParameter("@PR_NAME", SqlDbType.VarChar, prname), DataAccessLayer.CreateParameter("@PR_DESECRIPTION", SqlDbType.VarChar, prdesc),
                DataAccessLayer.CreateParameter("@PR_IMG", SqlDbType.Image, img),
                DataAccessLayer.CreateParameter("@BUYPRICE", SqlDbType.VarChar, buyprice),
                 DataAccessLayer.CreateParameter("@PR_SELLPRICE", SqlDbType.VarChar, sellprice),
                  DataAccessLayer.CreateParameter("@CAT_ID", SqlDbType.Int, catid),
                   DataAccessLayer.CreateParameter("@AMID", SqlDbType.Int, amid),
                    DataAccessLayer.CreateParameter("@SNID", SqlDbType.Int, snid),
                     DataAccessLayer.CreateParameter("@BARCODE", SqlDbType.VarChar, barcode));
            DataAccessLayer.close();
            return i;




        }

    }
}
