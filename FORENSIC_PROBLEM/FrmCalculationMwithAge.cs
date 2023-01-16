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
    public partial class FrmCalculationMwithAge : Form
    {
        public FrmCalculationMwithAge()
        {
            InitializeComponent();
        }

        private void BtnFemur_Click(object sender, EventArgs e)
        {
            int age;
            age = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter The age of the Body: ", "Age", ""));
            double femur = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Femur Length: ", "Femur Length", "" ));
            double height = 69.089 + (2.238 * femur );
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
        private void heightCalculator() //Height Calculator Method
        {
            int age;
            age = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter The age of the Body: ", "Age", ""));
            double femur = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Femur Length: ", "Femur Length", ""));
            double height = 69.089 + (2.238 * femur);
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
            double height = 81.688 + (2.392 * tibia);
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
            double height = 73.570 + (2.970 * humerus);
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
            double height = 80.405 + (3.650 * radius);
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

        private void FrmCalculationMwithAge_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
