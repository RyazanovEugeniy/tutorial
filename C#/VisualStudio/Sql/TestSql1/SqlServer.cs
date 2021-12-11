using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSql1
{
    class SqlServer
    {
        private MySqlConnection connection = new MySqlConnection();
        private bool databaseIsOpened = false;

        public bool OpenConnection(string host, string port, string username, string password, out string status)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.ConnectionString = String.Format("Server=" + host + ";port=" + port
                                                    + ";User Id=" + username + ";password=" + password);

                try
                {
                    connection.Open();
                    status = "Connection is open";
                    return true;
                }
                catch (Exception e)
                {
                    status = "Error: " + e.Message;
                }
            }
            else
                status = "Error: Connection is already open";
            return false;

        }

        public bool connectionIsOpened() => connection.State == ConnectionState.Open;

        public bool CloseConnection(out string status)
        {
            if (connection.State != ConnectionState.Closed)
            {
                try
                {
                    connection.Close();
                    status = "Connection is closed";
                    return true;
                }
                catch (Exception e)
                {
                    status = "Error: " + e.Message;
                }
            }
            else
                status = "Error: Connection is already closed";

            return false;
        }

        public bool OpenDatabase(string database, out string status)
        {
            if (database == string.Empty)
            {
                status = "Error: Database not choosen";
                return false;
            }

            try
            {
                Console.WriteLine(database);
                new MySqlCommand(String.Format("use {0};", database), connection).ExecuteNonQuery();
                status = "Database is open";
                databaseIsOpened = true; 
                return true;
            }
            catch (Exception e)
            {
                status = "Error: " + e.Message;
                return false;
            }
        }

        public bool GetDatabaseList(out List<string> databaseList)
        {
            databaseList = new List<string>();

            if (connection.State == ConnectionState.Open)
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

        public bool GetTableList(out List<string> tableList, out string status)
        {
            tableList = new List<string>();

            if (!databaseIsOpened)
            {
                status = "Error: Database is not opened";
                return false;
            }

            try
            {
                MySqlDataReader reader = new MySqlCommand(String.Format("show tables;"), connection).ExecuteReader();

                while (reader.Read())
                {
                    tableList.Add(reader.GetString(0));
                }
                reader.Close();
                status = "Get table list";
                return true;
            }
            catch (Exception e)
            {
                status = "Error: " + e.Message;
                return false;
            }
        }

        public bool GetTable(string table, out DataSet dataSet, out string status)
        {
            dataSet = new DataSet();

            if (!databaseIsOpened)
            {
                status = "Error: Database is not opened";
                return false;
            }

            if (table == string.Empty)
            {
                status = "Error: Table not choosen";
                return false;
            }

            try
            {
                new MySqlDataAdapter(String.Format("SELECT * FROM {0};", table), connection).Fill(dataSet);
                status = "Table displayed ";
                return true;
            }
            catch (Exception e)
            {
                status = "Error: " + e.Message;
            }

            return false;
        }

        public bool UpdateTable(string table, DataSet dataSet, out string status)
        {
            if (!databaseIsOpened)
            {
                status = "Error: Database is not opened";
                return false;
            }

            if (table == string.Empty)
            {
                status = "Error: Table not choosen";
                return false;
            }

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(String.Format("SELECT * FROM {0};", table), connection);

                MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter);

                adapter.InsertCommand = new MySqlCommand(String.Format("insert into {0} (login, pass) values (@login, @pass)", table), connection);
                adapter.InsertCommand.Parameters.Add(new MySqlParameter("@login", MySqlDbType.VarChar, 255, "login"));
                adapter.InsertCommand.Parameters.Add(new MySqlParameter("@pass", MySqlDbType.VarChar, 255, "pass"));

                MySqlParameter parameter = adapter.InsertCommand.Parameters.Add("@id", MySqlDbType.Int32, 0, "id");
                parameter.Direction = ParameterDirection.Output;

                Console.WriteLine(adapter.InsertCommand.CommandText);

                adapter.Update(dataSet);
                status = "Table updated";
                return true;
            }
            catch (Exception e)
            {
                status = "Error: " + e.Message;
                return false;
            }
        }
    }
}
