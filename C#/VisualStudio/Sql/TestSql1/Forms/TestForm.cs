using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSql1
{
    public partial class LoginForm : Form
    {
        private Point lastPoint;
        private SqlServer sqlServer = new SqlServer();

        public LoginForm()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabDb);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonConnectDisconnect_Click(object sender, EventArgs e)
        {
            if (!sqlServer.connectionIsOpened())
            {
                if (sqlServer.OpenConnection(textBoxHost.Text, textBoxPort.Text, textBoxUsername.Text, textBoxPassword.Text, out string state))
                {
                    buttonConnectDisconnect.Text = "Disconnect";
                    tabControl1.TabPages.Add(tabDb);
                    tabControl1.SelectedTab = tabDb;
                }
                textBoxState.Text = state;
            }
            else
            {
                if (sqlServer.CloseConnection(out string state))
                {
                    buttonConnectDisconnect.Text = "Connect";
                    tabControl1.TabPages.Remove(tabDb);
                }
                textBoxState.Text = state;
            }
        }

        private void textBoxPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void buttonRefreshDatabase_Click(object sender, EventArgs e)
        {
            comboBoxDatabase.Items.Clear();

            sqlServer.GetDatabaseList(out List<string> databases);
            foreach (string database in databases)
                comboBoxDatabase.Items.Add(database);
            comboBoxDatabase.SelectedIndex = 0;
        }

        private void buttonOpenDatabase_Click(object sender, EventArgs e)
        {
            if (sqlServer.OpenDatabase(comboBoxDatabase.Text, out string status))
            {
                buttonRefreshDatabase.Enabled = false;
                buttonOpenDatabase.Enabled = false;
                comboBoxDatabase.Enabled = false;
            }

            textBoxState.Text = status;
        }

        private void buttonRefreshTable_Click(object sender, EventArgs e)
        {
            comboBoxTable.Items.Clear();

            if (sqlServer.GetTableList(out List<string> tables, out string status))
            {
                foreach (string table in tables)
                    comboBoxTable.Items.Add(table);
                comboBoxTable.SelectedIndex = 0;
            }

            textBoxState.Text = status;
        }

        private void buttonShowTable_Click(object sender, EventArgs e)
        {
            if (sqlServer.GetTable(comboBoxTable.Text, out DataSet dataset, out string status))
            {
                dataGridViewTable.DataSource = dataset.Tables[0];
                dataGridViewTable.ReadOnly = true;
            }
            textBoxState.Text = status;
        }

        private void buttonSaveTable_Click(object sender, EventArgs e)
        {
            /*MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            commandBuilder = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = new SqlCommand("sp_CreateUser", connection);
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50, "Name"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@age", SqlDbType.Int, 0, "Age"));

            SqlParameter parameter = adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            parameter.Direction = ParameterDirection.Output;

            adapter.Update(ds);*/
        }

        private void tableLayoutBase_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void tableLayoutBase_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
