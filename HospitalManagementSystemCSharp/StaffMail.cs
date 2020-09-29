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
    public partial class StaffMail : Form
    {
        public StaffMail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Timeout = 10000;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("/* Genuine Mail ID */".Trim(), "/* Password of the Mail ID */".Trim());
                MailMessage msg = new MailMessage();
                msg.IsBodyHtml = true;
                msg.To.Add(textBox1.Text);
                msg.From = new MailAddress("/*Sender Mail ID */");
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
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = openFileDialog1.FileName.ToString();
            }
        }
    }
}
