using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSql2
{
    class SqlServer
    {
        private MySqlConnection connection = new MySqlConnection();

        public bool OpenConnection(string host, string port, string username, string password, out string state)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.ConnectionString = String.Format("Server=" + host + ";port=" + port
                                                    + ";User Id=" + username + ";password=" + password);

                try
                {
                    connection.Open();
                    state = "Connection is open";
                    return true;
                }
                catch (Exception e)
                {
                    state = "Error: " + e.Message;
                }
            }
            else
                state = "Connection is already open";
            return false;

        }

        public bool connectionIsOpened() => connection.State == System.Data.ConnectionState.Open;

        public bool CloseConnection(out string state)
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                try
                {
                    connection.Close();
                    state = "Connection is closed";
                    return true;
                }
                catch (Exception e)
                {
                    state = "Error: " + e.Message;
                }
            }
            else
                state = "Connection is already closed";
            return false;
        }

        public bool GetDatabaseList(out List<string> databaseList)
        {
            databaseList = new List<string>();

            if (connection.State == System.Data.ConnectionState.Open)
            {
                MySqlDataReader reader = new MySqlCommand(String.Format("show databases;"), connection).ExecuteReader();

                while (reader.Read())
                {
                    databaseList.Add(reader.GetString(0));
                }

                reader.Close();
                return true;
            }
            else
                return false;
        }

        public bool OpenDatabase(string database, out string state)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    MySqlDataReader reader = new MySqlCommand(String.Format("use {0};", database), connection).ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0));
                    }

                    reader.Close();

                    state = "Database is open";
                    return true;
                }
                catch (Exception e)
                {
                    state = "Error: " + e.Message;
                }
            }
            else
                state = "Connection is closed";

            return false;
        }

        public bool GetTableList(out List<string> tableList)
        {
            tableList = new List<string>();

            if (connection.State == System.Data.ConnectionState.Open)
            {
                MySqlDataReader reader = new MySqlCommand(String.Format("show tables;"), connection).ExecuteReader();

                while (reader.Read())
                {
                    tableList.Add(reader.GetString(0));
                }

                reader.Close();
                return true;
            }
            else
                return false;
        }
    }
}
