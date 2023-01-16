using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORENSIC_PROBLEM
{
    public partial class FrmForensicintro : Form
    {
        public FrmForensicintro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnMale_Click(object sender, EventArgs e)
        {
            FrmageMale x = new FrmageMale();
            x.Show();
        }

        private void BtnFemale_Click(object sender, EventArgs e)
        {
           FrmageFemale w= new FrmageFemale();
            w.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
