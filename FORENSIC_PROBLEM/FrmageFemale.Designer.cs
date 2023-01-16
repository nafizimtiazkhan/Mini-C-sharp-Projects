namespace FORENSIC_PROBLEM
{
    partial class FrmageFemale
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
            this.Lblage = new System.Windows.Forms.Label();
            this.Btnyes = new System.Windows.Forms.Button();
            this.BtnNo = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lblage
            // 
            this.Lblage.AutoSize = true;
            this.Lblage.Location = new System.Drawing.Point(267, 121);
            this.Lblage.Name = "Lblage";
            this.Lblage.Size = new System.Drawing.Size(245, 13);
            this.Lblage.TabIndex = 1;
            this.Lblage.Text = "Have you Found out About The age of The Body?";
            // 
            // Btnyes
            // 
            this.Btnyes.Location = new System.Drawing.Point(270, 213);
            this.Btnyes.Name = "Btnyes";
            this.Btnyes.Size = new System.Drawing.Size(75, 23);
            this.Btnyes.TabIndex = 2;
            this.Btnyes.Text = "Yes";
            this.Btnyes.UseVisualStyleBackColor = true;
            this.Btnyes.Click += new System.EventHandler(this.Btnyes_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.Location = new System.Drawing.Point(437, 213);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(75, 23);
            this.BtnNo.TabIndex = 3;
            this.BtnNo.Text = "No";
            this.BtnNo.UseVisualStyleBackColor = true;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(12, 392);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 15;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmageFemale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.Btnyes);
            this.Controls.Add(this.Lblage);
            this.Name = "FrmageFemale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculation For Female";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lblage;
        private System.Windows.Forms.Button Btnyes;
        private System.Windows.Forms.Button BtnNo;
        private System.Windows.Forms.Button BtnClose;
    }
}