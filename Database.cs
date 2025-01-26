using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeDB
{
    internal class Database
    {
        private static Boolean connection = false;
        private static SqlConnection SqlConnection = null;
        public Database() { 
            
        }
        public static SqlConnection getConnection()
        {
            if (connection == false)
            {
                SqlConnection = new SqlConnection(@"Data Source=DESKTOP-4PPVB83;Initial Catalog=AnimeDB;Integrated Security=True");
                connection = true;
      
            }
            return SqlConnection;
        }
        public static void openConnection()
        {
            SqlConnection.Open();
        }
        public static void closeConnection()
        {
            SqlConnection.Close();
        }
    }
}
