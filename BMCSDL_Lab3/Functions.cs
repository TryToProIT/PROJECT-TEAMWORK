using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace BMCSDL_Lab3
{
    public class Functions
    {
        public static SqlConnection conn;
        //public static string uname = "";
        public static string manv = "";
        public static string uname = "";
        public static string passwd = "";
        public static void InitConnection()
        {
            conn = new SqlConnection();
            string hostname = @"LGG-TH-01\DANG";
            conn.ConnectionString = @"Data Source=" + hostname + ";Initial Catalog=QLSVNhom;Integrated Security=True";
            try { conn.Open(); }
            catch (SqlException ex){
                conn = null;
                throw new Exception(ex.Message);
                MessageBox.Show("Không thể kết nối với DB");
            }
            
        }

        public static void Disconnect()
        {
            if(conn.State == ConnectionState.Open)
            {
                //Đóng kết nối
                conn.Close();

                //Giải phóng tài nguyên
                conn.Dispose();
                conn = null;

                MessageBox.Show("Ngắt kết nối với DB");
            }
        }


    }


}
