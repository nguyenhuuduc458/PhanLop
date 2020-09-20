using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Util
{
    public class DatabaseManager
    {
        /**
         * Using singleton pattern to build this class
         * Explain purpose: Using this pattern to make sure that 
         * just one instance of the class in the entire application  
         */
        private string connectionString = "";
        SqlConnection sqlConnection;

        private  DatabaseManager() { }

        private static DatabaseManager _instance;

        public static DatabaseManager getInstance()
        {
            if (_instance == null)
            {
                _instance = new DatabaseManager();
            }
            return _instance;
        }

        public void openConnection()
        {
            if (connectionString == null) return;
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }

        public void closeConnection()
        {
            if (connectionString != null)
            {
                sqlConnection.Close();
            }
        }

        public void excecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            cmd.ExecuteNonQuery();
        } 

        public SqlDataReader dataReader(string query)
        {
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

    }
}
