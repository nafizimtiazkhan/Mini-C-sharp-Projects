namespace FORENSIC_PROBLEM
{
    partial class FrmCalculationMwithoutAge
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
            this.label1 = new System.Windows.Forms.Label();
            this.Lblfemur = new System.Windows.Forms.Label();
            this.Lbltibia = new System.Windows.Forms.Label();
            this.Lblhumerus = new System.Windows.Forms.Label();
            this.Lblradius = new System.Windows.Forms.Label();
            this.BtnFemur = new System.Windows.Forms.Button();
            this.Btntibia = new System.Windows.Forms.Button();
            this.btnHumerus = new System.Windows.Forms.Button();
            this.BtnRadius = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "All measurements are in centimeters";
            // 
            // Lblfemur
            // 
            this.Lblfemur.AutoSize = true;
            this.Lblfemur.Location = new System.Drawing.Point(12, 131);
            this.Lblfemur.Name = "Lblfemur";
            this.Lblfemur.Size = new System.Drawing.Size(200, 13);
            this.Lblfemur.TabIndex = 6;
            this.Lblfemur.Text = "The femur (F) upper leg part (37-51.4) cm";
            // 
            // Lbltibia
            // 
            this.Lbltibia.AutoSize = true;
            this.Lbltibia.Location = new System.Drawing.Point(12, 186);
            this.Lbltibia.Name = "Lbltibia";
            this.Lbltibia.Size = new System.Drawing.Size(183, 13);
            this.Lbltibia.TabIndex = 7;
            this.Lbltibia.Text = "The tibia (T) lower leg part (32-56) cm";
            // 
            // Lblhumerus
            // 
            this.Lblhumerus.AutoSize = true;
            this.Lblhumerus.Location = new System.Drawing.Point(12, 242);
            this.Lblhumerus.Name = "Lblhumerus";
            this.Lblhumerus.Size = new System.Drawing.Size(228, 13);
            this.Lblhumerus.TabIndex = 8;
            this.Lblhumerus.Text = "The humerus (H) the upper arm part (32-35) cm";
            // 
            // Lblradius
            // 
            this.Lblradius.AutoSize = true;
            this.Lblradius.Location = new System.Drawing.Point(12, 295);
            this.Lblradius.Name = "Lblradius";
            this.Lblradius.Size = new System.Drawing.Size(217, 13);
            this.Lblradius.TabIndex = 9;
            this.Lblradius.Text = "The radius (R) the lower arm part (22.859cm)";
            // 
            // BtnFemur
            // 
            this.BtnFemur.Location = new System.Drawing.Point(530, 131);
            this.BtnFemur.Name = "BtnFemur";
            this.BtnFemur.Size = new System.Drawing.Size(75, 23);
            this.BtnFemur.TabIndex = 10;
            this.BtnFemur.Text = "Femur (F)";
            this.BtnFemur.UseVisualStyleBackColor = true;
            this.BtnFemur.Click += new System.EventHandler(this.BtnFemur_Click);
            // 
            // Btntibia
            // 
            this.Btntibia.Location = new System.Drawing.Point(530, 181);
            this.Btntibia.Name = "Btntibia";
            this.Btntibia.Size = new System.Drawing.Size(75, 23);
            this.Btntibia.TabIndex = 11;
            this.Btntibia.Text = "Tibia (T)";
            this.Btntibia.UseVisualStyleBackColor = true;
            this.Btntibia.Click += new System.EventHandler(this.Btntibia_Click);
            // 
            // btnHumerus
            // 
            this.btnHumerus.Location = new System.Drawing.Point(530, 242);
            this.btnHumerus.Name = "btnHumerus";
            this.btnHumerus.Size = new System.Drawing.Size(75, 23);
            this.btnHumerus.TabIndex = 12;
            this.btnHumerus.Text = "Humerus (H)";
            this.btnHumerus.UseVisualStyleBackColor = true;
            this.btnHumerus.Click += new System.EventHandler(this.btnHumerus_Click);
            // 
            // BtnRadius
            // 
            this.BtnRadius.Location = new System.Drawing.Point(530, 295);
            this.BtnRadius.Name = "BtnRadius";
            this.BtnRadius.Size = new System.Drawing.Size(75, 23);
            this.BtnRadius.TabIndex = 13;
            this.BtnRadius.Text = "Radius (R)";
            this.BtnRadius.UseVisualStyleBackColor = true;
            this.BtnRadius.Click += new System.EventHandler(this.BtnRadius_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(24, 386);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 14;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmCalculationMwithoutAge
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
            this.Name = "FrmCalculationMwithoutAge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculation of Male Body Without Age";
            this.Load += new System.EventHandler(this.FrmCalculationMwithoutAge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lblfemur;
        private System.Windows.Forms.Label Lbltibia;
        private System.Windows.Forms.Label Lblhumerus;
        private System.Windows.Forms.Label Lblradius;
        private System.Windows.Forms.Button BtnFemur;
        private System.Windows.Forms.Button Btntibia;
        private System.Windows.Forms.Button btnHumerus;
        private System.Windows.Forms.Button BtnRadius;
        private System.Windows.Forms.Button BtnClose;
    }
}