namespace FORENSIC_PROBLEM
{
    partial class FrmForensicintro
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
            this.Lblmalefemale = new System.Windows.Forms.Label();
            this.BtnMale = new System.Windows.Forms.Button();
            this.BtnFemale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lblfemur = new System.Windows.Forms.Label();
            this.Lbltibia = new System.Windows.Forms.Label();
            this.Lblhumerus = new System.Windows.Forms.Label();
            this.Lblradius = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lblmalefemale
            // 
            this.Lblmalefemale.AutoSize = true;
            this.Lblmalefemale.Location = new System.Drawing.Point(605, 264);
            this.Lblmalefemale.Name = "Lblmalefemale";
            this.Lblmalefemale.Size = new System.Drawing.Size(126, 13);
            this.Lblmalefemale.TabIndex = 0;
            this.Lblmalefemale.Text = "Choose the Subjects Sex";
            // 
            // BtnMale
            // 
            this.BtnMale.Location = new System.Drawing.Point(634, 328);
            this.BtnMale.Name = "BtnMale";
            this.BtnMale.Size = new System.Drawing.Size(75, 23);
            this.BtnMale.TabIndex = 1;
            this.BtnMale.Text = "Male";
            this.BtnMale.UseVisualStyleBackColor = true;
            this.BtnMale.Click += new System.EventHandler(this.BtnMale_Click);
            // 
            // BtnFemale
            // 
            this.BtnFemale.Location = new System.Drawing.Point(634, 386);
            this.BtnFemale.Name = "BtnFemale";
            this.BtnFemale.Size = new System.Drawing.Size(75, 23);
            this.BtnFemale.TabIndex = 2;
            this.BtnFemale.Text = "Female";
            this.BtnFemale.UseVisualStyleBackColor = true;
            this.BtnFemale.Click += new System.EventHandler(this.BtnFemale_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "All measurements are in centimeters";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lblfemur
            // 
            this.Lblfemur.AutoSize = true;
            this.Lblfemur.Location = new System.Drawing.Point(15, 103);
            this.Lblfemur.Name = "Lblfemur";
            this.Lblfemur.Size = new System.Drawing.Size(138, 13);
            this.Lblfemur.TabIndex = 4;
            this.Lblfemur.Text = "The femur (F) upper leg part";
            // 
            // Lbltibia
            // 
            this.Lbltibia.AutoSize = true;
            this.Lbltibia.Location = new System.Drawing.Point(18, 153);
            this.Lbltibia.Name = "Lbltibia";
            this.Lbltibia.Size = new System.Drawing.Size(130, 13);
            this.Lbltibia.TabIndex = 5;
            this.Lbltibia.Text = "The tibia (T) lower leg part";
            // 
            // Lblhumerus
            // 
            this.Lblhumerus.AutoSize = true;
            this.Lblhumerus.Location = new System.Drawing.Point(18, 209);
            this.Lblhumerus.Name = "Lblhumerus";
            this.Lblhumerus.Size = new System.Drawing.Size(175, 13);
            this.Lblhumerus.TabIndex = 6;
            this.Lblhumerus.Text = "The humerus (H) the upper arm part";
            // 
            // Lblradius
            // 
            this.Lblradius.AutoSize = true;
            this.Lblradius.Location = new System.Drawing.Point(21, 264);
            this.Lblradius.Name = "Lblradius";
            this.Lblradius.Size = new System.Drawing.Size(161, 13);
            this.Lblradius.TabIndex = 7;
            this.Lblradius.Text = "The radius (R) the lower arm part";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(24, 386);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 8;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmForensicintro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.Lblradius);
            this.Controls.Add(this.Lblhumerus);
            this.Controls.Add(this.Lbltibia);
            this.Controls.Add(this.Lblfemur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFemale);
            this.Controls.Add(this.BtnMale);
            this.Controls.Add(this.Lblmalefemale);
            this.Name = "FrmForensicintro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORENSIC PROBLEM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblmalefemale;
        private System.Windows.Forms.Button BtnMale;
        private System.Windows.Forms.Button BtnFemale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lblfemur;
        private System.Windows.Forms.Label Lbltibia;
        private System.Windows.Forms.Label Lblhumerus;
        private System.Windows.Forms.Label Lblradius;
        private System.Windows.Forms.Button BtnClose;
    }
}

