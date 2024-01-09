namespace OkulAppSube1BIL
{
    partial class frmGiris
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
            this.btnOgr = new System.Windows.Forms.Button();
            this.btnOgrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgr
            // 
            this.btnOgr.Location = new System.Drawing.Point(70, 36);
            this.btnOgr.Name = "btnOgr";
            this.btnOgr.Size = new System.Drawing.Size(75, 23);
            this.btnOgr.TabIndex = 0;
            this.btnOgr.Text = "ÖğrenciEkle";
            this.btnOgr.UseVisualStyleBackColor = true;
            this.btnOgr.Click += new System.EventHandler(this.btnOgr_Click);
            // 
            // btnOgrt
            // 
            this.btnOgrt.Location = new System.Drawing.Point(259, 36);
            this.btnOgrt.Name = "btnOgrt";
            this.btnOgrt.Size = new System.Drawing.Size(75, 23);
            this.btnOgrt.TabIndex = 1;
            this.btnOgrt.Text = "ÖğretmenEkle";
            this.btnOgrt.UseVisualStyleBackColor = true;
            this.btnOgrt.Click += new System.EventHandler(this.btnOgrt_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 122);
            this.Controls.Add(this.btnOgrt);
            this.Controls.Add(this.btnOgr);
            this.Name = "frmGiris";
            this.Text = "frmGiris";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgr;
        private System.Windows.Forms.Button btnOgrt;
    }
}