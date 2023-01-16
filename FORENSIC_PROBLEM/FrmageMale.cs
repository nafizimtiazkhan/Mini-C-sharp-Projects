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
    public partial class FrmageMale : Form
    {
        public FrmageMale()
        {
            InitializeComponent();
        }

        private void Btnyes_Click(object sender, EventArgs e)
        {
            FrmCalculationMwithAge y = new FrmCalculationMwithAge();
            y.Show();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            FrmCalculationMwithoutAge z = new FrmCalculationMwithoutAge();  
            z.Show();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
