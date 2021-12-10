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
        private Db db = new Db();

        public LoginForm()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabPage2);
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


        private void buttonConnect_Click(object sender, EventArgs e)
        {
            textBox1.Text = db.Open(String.Format("Server=" + textBoxHost.Text
                + ";Database=" + textBoxDatabase.Text
                + ";port=" + textBoxPort.Text
                + ";User Id=" + textBoxUsername.Text
                + ";password=" + textBoxPassword.Text));

        }

        private void textBoxPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != '\b')
                e.Handled = true;
        }
    }
}
