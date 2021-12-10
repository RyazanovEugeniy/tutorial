using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSql2
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

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
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
            if (sqlServer.OpenDatabase(comboBoxDatabase.Text, out string state))
                Console.WriteLine("!!!");
            textBoxState.Text = state;
        }

        private void buttonRefreshTable_Click(object sender, EventArgs e)
        {
            comboBoxTable.Items.Clear();

            sqlServer.GetTableList(out List<string> databases);
            foreach (string database in databases)
                comboBoxTable.Items.Add(database);
            comboBoxTable.SelectedIndex = 0;
        }
    }
}
