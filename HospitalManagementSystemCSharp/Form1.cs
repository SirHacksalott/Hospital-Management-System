using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalManagementSystemCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
                if (textBox1.Text == "admin" && textBox2.Text == "pass")
                {
                    MessageBox.Show("Welcome Admin. You are logged in successfully.");
                    this.Visible = false;
                    Home obj1 = new Home();
                    obj1.ShowDialog();
                    textBox1.Text = "";
                    textBox2.Text = "";                 
                }
                else if (textBox1.Text == "user" && textBox2.Text == "12345")
                {
                    MessageBox.Show("Welcome User. You are logged in successfully.");
                    this.Visible = false;
                    Home1 obj = new Home1();
                    obj.ShowDialog();
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            else
                {
                    MessageBox.Show("Invalid Username Or Password.");
                }
         }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
