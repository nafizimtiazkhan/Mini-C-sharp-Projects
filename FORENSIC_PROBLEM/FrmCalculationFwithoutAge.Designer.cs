namespace FORENSIC_PROBLEM
{
    partial class FrmCalculationFwithoutAge
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnRadius = new System.Windows.Forms.Button();
            this.btnHumerus = new System.Windows.Forms.Button();
            this.Btntibia = new System.Windows.Forms.Button();
            this.BtnFemur = new System.Windows.Forms.Button();
            this.Lblradius = new System.Windows.Forms.Label();
            this.Lblhumerus = new System.Windows.Forms.Label();
            this.Lbltibia = new System.Windows.Forms.Label();
            this.Lblfemur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRadius
            // 
            this.BtnRadius.Location = new System.Drawing.Point(560, 314);
            this.BtnRadius.Name = "BtnRadius";
            this.BtnRadius.Size = new System.Drawing.Size(75, 23);
            this.BtnRadius.TabIndex = 22;
            this.BtnRadius.Text = "Radius (R)";
            this.BtnRadius.UseVisualStyleBackColor = true;
            this.BtnRadius.Click += new System.EventHandler(this.BtnRadius_Click);
            // 
            // btnHumerus
            // 
            this.btnHumerus.Location = new System.Drawing.Point(560, 265);
            this.btnHumerus.Name = "btnHumerus";
            this.btnHumerus.Size = new System.Drawing.Size(75, 23);
            this.btnHumerus.TabIndex = 21;
            this.btnHumerus.Text = "Humerus (H)";
            this.btnHumerus.UseVisualStyleBackColor = true;
            this.btnHumerus.Click += new System.EventHandler(this.btnHumerus_Click);
            // 
            // Btntibia
            // 
            this.Btntibia.Location = new System.Drawing.Point(560, 217);
            this.Btntibia.Name = "Btntibia";
            this.Btntibia.Size = new System.Drawing.Size(75, 23);
            this.Btntibia.TabIndex = 20;
            this.Btntibia.Text = "Tibia (T)";
            this.Btntibia.UseVisualStyleBackColor = true;
            this.Btntibia.Click += new System.EventHandler(this.Btntibia_Click);
            // 
            // BtnFemur
            // 
            this.BtnFemur.Location = new System.Drawing.Point(560, 164);
            this.BtnFemur.Name = "BtnFemur";
            this.BtnFemur.Size = new System.Drawing.Size(75, 23);
            this.BtnFemur.TabIndex = 19;
            this.BtnFemur.Text = "Femur (F)";
            this.BtnFemur.UseVisualStyleBackColor = true;
            this.BtnFemur.Click += new System.EventHandler(this.BtnFemur_Click);
            // 
            // Lblradius
            // 
            this.Lblradius.AutoSize = true;
            this.Lblradius.Location = new System.Drawing.Point(35, 314);
            this.Lblradius.Name = "Lblradius";
            this.Lblradius.Size = new System.Drawing.Size(217, 13);
            this.Lblradius.TabIndex = 18;
            this.Lblradius.Text = "The radius (R) the lower arm part (21.065cm)";
            // 
            // Lblhumerus
            // 
            this.Lblhumerus.AutoSize = true;
            this.Lblhumerus.Location = new System.Drawing.Point(35, 265);
            this.Lblhumerus.Name = "Lblhumerus";
            this.Lblhumerus.Size = new System.Drawing.Size(237, 13);
            this.Lblhumerus.TabIndex = 17;
            this.Lblhumerus.Text = "The humerus (H) the upper arm part (30-32.2) cm";
            // 
            // Lbltibia
            // 
            this.Lbltibia.AutoSize = true;
            this.Lbltibia.Location = new System.Drawing.Point(35, 217);
            this.Lbltibia.Name = "Lbltibia";
            this.Lbltibia.Size = new System.Drawing.Size(183, 13);
            this.Lbltibia.TabIndex = 16;
            this.Lbltibia.Text = "The tibia (T) lower leg part (32-56) cm";
            // 
            // Lblfemur
            // 
            this.Lblfemur.AutoSize = true;
            this.Lblfemur.Location = new System.Drawing.Point(35, 164);
            this.Lblfemur.Name = "Lblfemur";
            this.Lblfemur.Size = new System.Drawing.Size(209, 13);
            this.Lblfemur.TabIndex = 15;
            this.Lblfemur.Text = "The femur (F) upper leg part (35.9-50.8) cm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "All measurements are in centimeters";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(38, 385);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 23;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmCalculationFwithoutAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnRadius);
            this.Controls.Add(this.btnHumerus);
            this.Controls.Add(this.Btntibia);
            this.Controls.Add(this.BtnFemur);
            this.Controls.Add(this.Lblradius);
            this.Controls.Add(this.Lblhumerus);
            this.Controls.Add(this.Lbltibia);
            this.Controls.Add(this.Lblfemur);
            this.Controls.Add(this.label1);
            this.Name = "FrmCalculationFwithoutAge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculation of Female Body Without Age";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRadius;
        private System.Windows.Forms.Button btnHumerus;
        private System.Windows.Forms.Button Btntibia;
        private System.Windows.Forms.Button BtnFemur;
        private System.Windows.Forms.Label Lblradius;
        private System.Windows.Forms.Label Lblhumerus;
        private System.Windows.Forms.Label Lbltibia;
        private System.Windows.Forms.Label Lblfemur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnClose;
    }
}