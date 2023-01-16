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
    public partial class FrmCalculationMwithoutAge : Form
    {
        public FrmCalculationMwithoutAge()
        {
            InitializeComponent();
        }

        private void BtnFemur_Click(object sender, EventArgs e)
        {
            double femur = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Femur Length: ", "Femur Length", ""));
            double height = 69.089 + (2.238 * femur);
            MessageBox.Show("Height is " + height.ToString() + " cm");
        }

        private void Btntibia_Click(object sender, EventArgs e)
        {
            double tibia = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Tibia Length: ", "Tibia Length", ""));
            double height = 81.688 + (2.392 * tibia);
            MessageBox.Show("Height is " + height.ToString() + " cm");
        }

        private void btnHumerus_Click(object sender, EventArgs e)
        {
            double humerus = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Humerus Length: ", "Humerus Length", ""));
            double height = 73.570 + (2.970 * humerus);
            MessageBox.Show("Height is " + height.ToString() + " cm");
        }

        private void BtnRadius_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Radius Length: ", "Radius Length", ""));
            double height = 80.405 + (3.650 * radius);
            MessageBox.Show("Height is " + height.ToString() + " cm");
        }

        private void FrmCalculationMwithoutAge_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
