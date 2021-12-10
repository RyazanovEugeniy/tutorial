using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSql1
{
    class DB
    {
        private MySqlConnection mySqlConnection = new MySqlConnection("server=localhost;port=3306;username=root;" +
                                                                      "password=root;database=test_db");

        public void openConnection()
        {
            if (mySqlConnection.State == System.Data.ConnectionState.Closed)
                mySqlConnection.Open();
        }

        public void closeConnection()
        {
            if (mySqlConnection.State == System.Data.ConnectionState.Open)
                mySqlConnection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return mySqlConnection;
        }
    }
}
