using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates5
{
    public partial class Form1 : Form
    {
        private byte test = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test += 50;
            button1.BackColor = Color.FromArgb(test, test, test);
        }

        private void button1_Click2(object sender, EventArgs e)
        {
            MessageBox.Show("!!!" + e.ToString());
        }
    }
}
