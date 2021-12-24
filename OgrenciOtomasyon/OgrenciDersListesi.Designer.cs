
namespace OgrenciOtomasyon
{
    partial class OgrenciDersListesi
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
            this.lvTumOgrenciler = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSinifOgrenciler = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.btnOgrenciCikar = new System.Windows.Forms.Button();
            this.lblDersAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvTumOgrenciler
            // 
            this.lvTumOgrenciler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.columnHeader1});
            this.lvTumOgrenciler.HideSelection = false;
            this.lvTumOgrenciler.Location = new System.Drawing.Point(44, 28);
            this.lvTumOgrenciler.Name = "lvTumOgrenciler";
            this.lvTumOgrenciler.Size = new System.Drawing.Size(188, 309);
            this.lvTumOgrenciler.TabIndex = 0;
            this.lvTumOgrenciler.UseCompatibleStateImageBehavior = false;
            this.lvTumOgrenciler.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ögrenci Adı";
            // 
            // lvSinifOgrenciler
            // 
            this.lvSinifOgrenciler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.lvSinifOgrenciler.HideSelection = false;
            this.lvSinifOgrenciler.Location = new System.Drawing.Point(480, 28);
            this.lvSinifOgrenciler.Name = "lvSinifOgrenciler";
            this.lvSinifOgrenciler.Size = new System.Drawing.Size(198, 309);
            this.lvSinifOgrenciler.TabIndex = 1;
            this.lvSinifOgrenciler.UseCompatibleStateImageBehavior = false;
            this.lvSinifOgrenciler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Id";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adı";
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(304, 129);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(100, 23);
            this.btnOgrenciEkle.TabIndex = 2;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle ->";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // btnOgrenciCikar
            // 
            this.btnOgrenciCikar.Location = new System.Drawing.Point(304, 169);
            this.btnOgrenciCikar.Name = "btnOgrenciCikar";
            this.btnOgrenciCikar.Size = new System.Drawing.Size(100, 23);
            this.btnOgrenciCikar.TabIndex = 3;
            this.btnOgrenciCikar.Text = "<- Öğrenci Çıkar";
            this.btnOgrenciCikar.UseVisualStyleBackColor = true;
            this.btnOgrenciCikar.Click += new System.EventHandler(this.btnOgrenciCikar_Click);
            // 
            // lblDersAdi
            // 
            this.lblDersAdi.AutoSize = true;
            this.lblDersAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDersAdi.Location = new System.Drawing.Point(276, 37);
            this.lblDersAdi.Name = "lblDersAdi";
            this.lblDersAdi.Size = new System.Drawing.Size(128, 20);
            this.lblDersAdi.TabIndex = 4;
            this.lblDersAdi.Text = "Ders Adı: Yazılım";
            // 
            // OgrenciDersListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDersAdi);
            this.Controls.Add(this.btnOgrenciCikar);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.lvSinifOgrenciler);
            this.Controls.Add(this.lvTumOgrenciler);
            this.Name = "OgrenciDersListesi";
            this.Text = "Öğrenci Ders Listesi";
            this.Load += new System.EventHandler(this.OgrenciDersListesi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTumOgrenciler;
        private System.Windows.Forms.ListView lvSinifOgrenciler;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Button btnOgrenciCikar;
        private System.Windows.Forms.Label lblDersAdi;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}