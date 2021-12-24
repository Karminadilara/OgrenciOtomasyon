
namespace OgrenciOtomasyon
{
    partial class MenuEkrani
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
            this.btnDers = new System.Windows.Forms.Button();
            this.btnOgretmen = new System.Windows.Forms.Button();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnSinif = new System.Windows.Forms.Button();
            this.btnNot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDers
            // 
            this.btnDers.Location = new System.Drawing.Point(110, 12);
            this.btnDers.Name = "btnDers";
            this.btnDers.Size = new System.Drawing.Size(83, 53);
            this.btnDers.TabIndex = 0;
            this.btnDers.Text = "Ders İşlemleri";
            this.btnDers.UseVisualStyleBackColor = true;
            this.btnDers.Click += new System.EventHandler(this.btnDers_Click);
            // 
            // btnOgretmen
            // 
            this.btnOgretmen.Location = new System.Drawing.Point(12, 12);
            this.btnOgretmen.Name = "btnOgretmen";
            this.btnOgretmen.Size = new System.Drawing.Size(83, 53);
            this.btnOgretmen.TabIndex = 1;
            this.btnOgretmen.Text = "Öğretmen İşlemleri";
            this.btnOgretmen.UseVisualStyleBackColor = true;
            this.btnOgretmen.Click += new System.EventHandler(this.btnOgretmen_Click);
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.Location = new System.Drawing.Point(199, 12);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(83, 53);
            this.btnOgrenci.TabIndex = 2;
            this.btnOgrenci.Text = "Öğrenci İşlemleri";
            this.btnOgrenci.UseVisualStyleBackColor = true;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnSinif
            // 
            this.btnSinif.Location = new System.Drawing.Point(288, 12);
            this.btnSinif.Name = "btnSinif";
            this.btnSinif.Size = new System.Drawing.Size(83, 53);
            this.btnSinif.TabIndex = 3;
            this.btnSinif.Text = "Sınıf İşlemleri";
            this.btnSinif.UseVisualStyleBackColor = true;
            this.btnSinif.Click += new System.EventHandler(this.btnSinif_Click);
            // 
            // btnNot
            // 
            this.btnNot.Location = new System.Drawing.Point(377, 12);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(83, 53);
            this.btnNot.TabIndex = 4;
            this.btnNot.Text = "Not İşlemleri";
            this.btnNot.UseVisualStyleBackColor = true;
            this.btnNot.Click += new System.EventHandler(this.btnNot_Click);
            // 
            // MenuEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 79);
            this.Controls.Add(this.btnNot);
            this.Controls.Add(this.btnSinif);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnOgretmen);
            this.Controls.Add(this.btnDers);
            this.Name = "MenuEkrani";
            this.Text = "Menü";
            this.Load += new System.EventHandler(this.MenuEkrani_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDers;
        private System.Windows.Forms.Button btnOgretmen;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnSinif;
        private System.Windows.Forms.Button btnNot;
    }
}