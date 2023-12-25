namespace OkulAppSube1BIL
{
    partial class frmOgrtKayit
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
            this.grpOgretmen = new System.Windows.Forms.GroupBox();
            this.txtOgrtAd = new System.Windows.Forms.TextBox();
            this.txtOgrtSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrtTc = new System.Windows.Forms.TextBox();
            this.txtOgrAd = new System.Windows.Forms.Label();
            this.txtOgrSoyad = new System.Windows.Forms.Label();
            this.txtOgrTc = new System.Windows.Forms.Label();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.grpOgretmen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgretmen
            // 
            this.grpOgretmen.Controls.Add(this.txtOgrTc);
            this.grpOgretmen.Controls.Add(this.txtOgrSoyad);
            this.grpOgretmen.Controls.Add(this.txtOgrAd);
            this.grpOgretmen.Controls.Add(this.txtOgrtTc);
            this.grpOgretmen.Controls.Add(this.txtOgrtSoyad);
            this.grpOgretmen.Controls.Add(this.txtOgrtAd);
            this.grpOgretmen.Location = new System.Drawing.Point(23, 13);
            this.grpOgretmen.Name = "grpOgretmen";
            this.grpOgretmen.Size = new System.Drawing.Size(315, 186);
            this.grpOgretmen.TabIndex = 0;
            this.grpOgretmen.TabStop = false;
            this.grpOgretmen.Text = "Öğretmen Bilgileri";
            this.grpOgretmen.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtOgrtAd
            // 
            this.txtOgrtAd.Location = new System.Drawing.Point(184, 46);
            this.txtOgrtAd.Name = "txtOgrtAd";
            this.txtOgrtAd.Size = new System.Drawing.Size(100, 20);
            this.txtOgrtAd.TabIndex = 0;
            // 
            // txtOgrtSoyad
            // 
            this.txtOgrtSoyad.Location = new System.Drawing.Point(184, 87);
            this.txtOgrtSoyad.Name = "txtOgrtSoyad";
            this.txtOgrtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtOgrtSoyad.TabIndex = 1;
            // 
            // txtOgrtTc
            // 
            this.txtOgrtTc.Location = new System.Drawing.Point(184, 132);
            this.txtOgrtTc.Name = "txtOgrtTc";
            this.txtOgrtTc.Size = new System.Drawing.Size(100, 20);
            this.txtOgrtTc.TabIndex = 2;
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.AutoSize = true;
            this.txtOgrAd.Location = new System.Drawing.Point(60, 52);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(69, 13);
            this.txtOgrAd.TabIndex = 3;
            this.txtOgrAd.Text = "Öğretmen Ad";
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.AutoSize = true;
            this.txtOgrSoyad.Location = new System.Drawing.Point(63, 93);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(86, 13);
            this.txtOgrSoyad.TabIndex = 4;
            this.txtOgrSoyad.Text = "Öğretmen Soyad";
            // 
            // txtOgrTc
            // 
            this.txtOgrTc.AutoSize = true;
            this.txtOgrTc.Location = new System.Drawing.Point(66, 132);
            this.txtOgrTc.Name = "txtOgrTc";
            this.txtOgrTc.Size = new System.Drawing.Size(70, 13);
            this.txtOgrTc.TabIndex = 5;
            this.txtOgrTc.Text = "Öğretmen TC";
            // 
            // btnKayıt
            // 
            this.btnKayıt.Location = new System.Drawing.Point(138, 205);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(75, 23);
            this.btnKayıt.TabIndex = 1;
            this.btnKayıt.Text = "Kaydet";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // frmOgrtKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 254);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.grpOgretmen);
            this.Name = "frmOgrtKayit";
            this.Text = "frmOgrtKayit";
            this.grpOgretmen.ResumeLayout(false);
            this.grpOgretmen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgretmen;
        private System.Windows.Forms.Label txtOgrTc;
        private System.Windows.Forms.Label txtOgrSoyad;
        private System.Windows.Forms.Label txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrtTc;
        private System.Windows.Forms.TextBox txtOgrtSoyad;
        private System.Windows.Forms.TextBox txtOgrtAd;
        private System.Windows.Forms.Button btnKayıt;
    }
}