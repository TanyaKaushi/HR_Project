using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace HR_System
{
    class DBConnection
    {
        private static string connectionString = "Data Source=" + ConfigurationSettings.AppSettings["ServerName"]
          + ";Initial Catalog=" + ConfigurationSettings.AppSettings["DBName"] + ";User ID=sa; Password=123;Connection Timeout=180;";

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        private string con;
        private double dailysales;
        private int productline;
        private double stockonhand;
        private int critical;


        public string
        MyConnection()
        {
            //   con = @"Data Source=DESKTOP-CO0778O\SQLEXPRESS;Initial Catalog=POS_DEMO_DB;Integrated Security=True";
            //con = @"Data Source=(local);Initial Catalog=POS_DEMO_DB;Integrated Security=True";

            //private static string connectionString = "Data Source=" + ConfigurationSettings.AppSettings["ServerName"]
            //    + ";Initial Catalog=" + ConfigurationSettings.AppSettings["DBName"] + ";User ID=sa; Password=123;Connection Timeout=180;";

            // con = @"Data Source=DESKTOP-P6Q4D74;Initial Catalog=POS_DEMO_DB;Integrated Security=True";
            //  con = @"Data Source= DESKTOP-CO0778O\SQLEXPRESS;Initial Catalog=POS_DEMO_DB;Integrated Security=True;  User ID = sa; Password = l23"; //akki

            con = connectionString;


            return con;

        }
    
    
    
    
    
    
    
    
    }
}
