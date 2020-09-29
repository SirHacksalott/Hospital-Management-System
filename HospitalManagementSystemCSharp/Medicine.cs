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
    public partial class Medicine : Form
    {
        public Medicine()
        {
            InitializeComponent();
        }

        private void CommonCold_click(object sender, EventArgs e)
        {
            string filename = "Common Cold.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void Diabetes_click(object sender, EventArgs e)
        {
            string filename = "Diabetes.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void Migraine_click(object sender, EventArgs e)
        {
            string filename = "Migraine.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void MouthUlcer_click(object sender, EventArgs e)
        {
            string filename = "Mouth Ulcer.pdf";
            System.Diagnostics.Process.Start(filename);
        }
    }
}
