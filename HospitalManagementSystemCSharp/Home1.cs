using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystemCSharp
{
    public partial class Home1 : Form
    {
        public Home1()
        {
            InitializeComponent();
        }

        private void user_onclick(object sender, EventArgs e)
        {
            Medicine obj = new Medicine();
            obj.ShowDialog();
        }

        private void user_logout_onclick(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 obj1 = new Form1();
            obj1.ShowDialog();
        }
    }
}
