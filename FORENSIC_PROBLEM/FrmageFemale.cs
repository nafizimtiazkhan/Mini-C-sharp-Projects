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
    public partial class FrmageFemale : Form
    {
        public FrmageFemale()
        {
            InitializeComponent();
        }

        private void Btnyes_Click(object sender, EventArgs e)
        {
            FrmCalculationFwithAge w = new FrmCalculationFwithAge();
            w.Show();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            FrmCalculationFwithoutAge v= new FrmCalculationFwithoutAge();
            v.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
