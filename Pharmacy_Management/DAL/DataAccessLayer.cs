using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Pharmacy_Management.DAL
{
    class DataAccessLayer
    {
        static string curentDirectory = Directory.GetCurrentDirectory();


      
         private static string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=YourProjectlocationPath\Pharmacy_Management\Pharmacy_Management\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30";


    
        //private static string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Pharmacy.mdf;Integrated Security=True;Connect Timeout=30";
        //                                                  folder name
        public static SqlConnection cn;


        // open the connection 
        public static void open()
        {
            cn = new SqlConnection(con);
            cn.Open();



        }
        //close the connection 
        public static void close()
        {
            cn = new SqlConnection(con);
            cn.Close();


        }
        //                                return one value 
        public static object executeScaler(string query , CommandType type , params SqlParameter[] arr)
        {

            SqlCommand cmd = new SqlCommand(query,cn );
            cmd.Parameters.AddRange(arr);
            cmd.CommandType = type;
            object o = cmd.ExecuteScalar();
            return o;
            


        }
      
        ///                            return the number of rows which updated inserted deleted 
       

        public static int ExecuteNonQuery( string query , CommandType type , params SqlParameter[] arr)
        {
           
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = type;
            cmd.Parameters.AddRange(arr);
            int n = cmd.ExecuteNonQuery();
            return n;
           


        }


        //   return table
        public static DataTable ExecuteTable(string query , CommandType type , params SqlParameter[] arr)

        {
            SqlConnection cn = new SqlConnection(con);
            cn.Open();
          
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.CommandType = type;
            cmd.Parameters.AddRange(arr);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        //                     return parameter 
        public static SqlParameter CreateParameter(string Name , SqlDbType type , object value)
        {
            SqlParameter pr = new SqlParameter();
            pr.ParameterName = Name;
            pr.SqlDbType = type;
            pr.SqlValue = value;
            return pr;



        }































    }
}
