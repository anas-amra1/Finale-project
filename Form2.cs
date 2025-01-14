using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelIn2.ForeColor = System.Drawing.Color.Red;
            panel2.Visible = true;




        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelIn4.ForeColor = System.Drawing.Color.Red;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelIn1.ForeColor = System.Drawing.Color.Red;
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelIn3.ForeColor = System.Drawing.Color.Red;
            panel3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;


        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string adress = txtAddress.Text;
                Int32 contact = Convert.ToInt32(txtContact_Number.Text);
                int age = Convert.ToInt32(txtAge.Text);
                string gender = comboGender.Text;
                string blood = txtBlood_Groub.Text;
                string any = txtAMD.Text;
                int pid = Convert.ToInt32(txtPatient_ID.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString="data source = LAPTOP-PJTMME5C\\SQLEXPRESS; database = hospital; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into AddPatint value ('" + name + "','" + adress + "','" + contact + "','" + age + "','" + gender + "','" + blood + "','" + any + "','" + pid + "')";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DA.Fill(ds);

            }
            catch (Exception ex)
            {
                MessageBox.Show("invalid data format or invalid pid ");
            }

            MessageBox.Show("Data Saved!");

            txtName.Clear();
            txtAddress.Clear();
            txtContact_Number.Clear();
            txtAge.Clear();
            txtBlood_Groub.Clear();
            txtAMD.Clear();
            txtPatient_ID.Clear();
            comboGender.ResetText();
        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(textBox1.Text);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(textBox1.Text);
                string sympt = textBox2.Text;
                string diag = textBox3.Text;
                string medicine = textBox4.Text;
                string ward = comboBox1.Text;
                string wardType = comboBox2.Text;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Any field is empty 'OR' Data is in WRONG format.");
            }
            MessageBox.Show("Data Saved");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();   
            textBox4.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
        }

        private void label19_Click_1(object sender, EventArgs e)
        {

        }
    }
}
