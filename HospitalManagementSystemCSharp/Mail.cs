using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mime;
using System.Net.Mail;

namespace HospitalManagementSystemCSharp
{
    public partial class Mail : Form
    {   
        
        public Mail()
        {
            InitializeComponent();
        }

        private void Mail_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com"; //Format only for Gmail mail addresses
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Timeout = 10000;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("//Genuine Mail ID".Trim(), "//Mail ID for the password".Trim());
                MailMessage msg = new MailMessage();
                msg.IsBodyHtml = true;
                msg.To.Add(textBox1.Text);
                if (textBox5.Text != "")
                {
                    msg.CC.Add(textBox5.Text);
                }
                msg.From = new MailAddress("/*Sender's Mail ID*/");
                msg.Subject = textBox2.Text;
                msg.Body = textBox3.Text;
                if (textBox4.Text != "")
                {
                    msg.Attachments.Add(new Attachment(textBox4.Text));
                }
                smtp.Send(msg);
                MessageBox.Show("Successfully sent Mail");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                textBox4.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                textBox5.Enabled = true;
            }
        }
    }
}
