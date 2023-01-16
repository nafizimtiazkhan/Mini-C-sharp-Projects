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
    public partial class FrmCalculationFwithAge : Form
    {
        public FrmCalculationFwithAge()
        {
            InitializeComponent();
        }

        private void BtnFemur_Click(object sender, EventArgs e)
        {
            int age;
            age = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter The age of the Body: ", "Age", ""));
            double femur = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Femur Length: ", "Femur Length", ""));
            double height = 61.412 + (2.238 * femur);
            if (age > 30)
            {
                height = height - ((age - 30) * .06);
                MessageBox.Show("Height is " + height.ToString() + " cm");
            }
            else
            {
                MessageBox.Show("Height is " + height.ToString() + " cm");
            }
        }

        private void Btntibia_Click(object sender, EventArgs e)
        {
            int age;
            age = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter The age of the Body: ", "Age", ""));
            double tibia = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Tibia Length: ", "Tibia Length", ""));
            double height = 72.572 + (2.533 * tibia);
            if (age > 30)
            {
                height = height - ((age - 30) * .06);
                MessageBox.Show("Height is " + height.ToString() + " cm");
            }
            else
            {
                MessageBox.Show("Height is " + height.ToString() + " cm");
            }
        }

        private void btnHumerus_Click(object sender, EventArgs e)
        {
            int age;
            age = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter The age of the Body: ", "Age", ""));
            double humerus = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Humerus Length: ", "Humerus Length", ""));
            double height = 64.977 + (3.144 * humerus);
            if (age > 30)
            {
                height = height - ((age - 30) * .06);
                MessageBox.Show("Height is " + height.ToString() + " cm");
            }
            else
            {
                MessageBox.Show("Height is " + height.ToString() + " cm");
            }
        }

        private void BtnRadius_Click(object sender, EventArgs e)
        {
            int age;
            age = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter The age of the Body: ", "Age", ""));
            double radius = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Radius Length: ", "Radius Length", ""));
            double height = 73.502 + (3.876 * radius);
            if (age > 30)
            {
                height = height - ((age - 30) * .06);
                MessageBox.Show("Height is " + height.ToString() + " cm");
            }
            else
            {
                MessageBox.Show("Height is " + height.ToString() + " cm");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
