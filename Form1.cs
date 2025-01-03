using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = txtUN.Text;
            string pass = txtP.Text;

            if (username =="hms" && pass =="pass")
            {
                //MessageBox.Show("you have enterd username and password");
                this.Hide();
                Form2 ds = new Form2();
                ds.Show();
            }

            else
                MessageBox.Show("wrong user id or password");

        }
    }
}
