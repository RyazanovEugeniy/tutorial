using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSql2
{
    class Db
    {
        private MySqlConnection connection = new MySqlConnection();

        public string Open(string connectionString)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.ConnectionString = connectionString;

                try
                {
                    connection.Open();

                    List<string> QueryResult = new List<string>();

                    MySqlCommand cmdName = new MySqlCommand(String.Format("show databases;"), connection);

                    MySqlDataReader reader = cmdName.ExecuteReader();
                    while (reader.Read())
                    {
                        QueryResult.Add(reader.GetString(0));
                    }
                    reader.Close();
                    foreach (string str in QueryResult)
                        Console.WriteLine(str);

                    return "Connection is open";
                }
                catch (Exception e)
                {
                    return "Error: " + e.Message;
                }
            }
            else
                return "Connection is already open ";
        }

        public void close()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
