
namespace OgrenciOtomasyon
{
    partial class NotIslemleri
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
            this.cmbSinif = new System.Windows.Forms.ComboBox();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.lvOgrenciler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtVize = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOgrenciId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.NotListesi = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvNotListesi = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNotId = new System.Windows.Forms.TextBox();
            this.btnTab = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvGecen = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvKalan = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NotListesi.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSinif
            // 
            this.cmbSinif.FormattingEnabled = true;
            this.cmbSinif.Location = new System.Drawing.Point(131, 25);
            this.cmbSinif.Name = "cmbSinif";
            this.cmbSinif.Size = new System.Drawing.Size(121, 21);
            this.cmbSinif.TabIndex = 0;
            this.cmbSinif.SelectedIndexChanged += new System.EventHandler(this.cmbSinif_SelectedIndexChanged);
            // 
            // cmbDers
            // 
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(131, 65);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(121, 21);
            this.cmbDers.TabIndex = 1;
            // 
            // lvOgrenciler
            // 
            this.lvOgrenciler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvOgrenciler.HideSelection = false;
            this.lvOgrenciler.Location = new System.Drawing.Point(298, 12);
            this.lvOgrenciler.Name = "lvOgrenciler";
            this.lvOgrenciler.Size = new System.Drawing.Size(251, 332);
            this.lvOgrenciler.TabIndex = 2;
            this.lvOgrenciler.UseCompatibleStateImageBehavior = false;
            this.lvOgrenciler.View = System.Windows.Forms.View.Details;
            this.lvOgrenciler.DoubleClick += new System.EventHandler(this.lvOgrenciler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Öğrenci Ad-Soyad";
            this.columnHeader2.Width = 118;
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(131, 201);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(121, 20);
            this.txtVize.TabIndex = 3;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(131, 235);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(121, 20);
            this.txtFinal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sınıf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ogrenci Id";
            // 
            // txtOgrenciId
            // 
            this.txtOgrenciId.Location = new System.Drawing.Point(131, 136);
            this.txtOgrenciId.Name = "txtOgrenciId";
            this.txtOgrenciId.ReadOnly = true;
            this.txtOgrenciId.Size = new System.Drawing.Size(121, 20);
            this.txtOgrenciId.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ögrenci Ad";
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(131, 167);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.ReadOnly = true;
            this.txtOgrenciAd.Size = new System.Drawing.Size(121, 20);
            this.txtOgrenciAd.TabIndex = 12;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(131, 314);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 23);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // NotListesi
            // 
            this.NotListesi.Controls.Add(this.tabPage1);
            this.NotListesi.Controls.Add(this.tabPage2);
            this.NotListesi.Controls.Add(this.tabPage3);
            this.NotListesi.Location = new System.Drawing.Point(608, 12);
            this.NotListesi.Name = "NotListesi";
            this.NotListesi.SelectedIndex = 0;
            this.NotListesi.Size = new System.Drawing.Size(422, 332);
            this.NotListesi.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvNotListesi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(414, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Not Listesi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvNotListesi
            // 
            this.lvNotListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvNotListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNotListesi.HideSelection = false;
            this.lvNotListesi.Location = new System.Drawing.Point(3, 3);
            this.lvNotListesi.Name = "lvNotListesi";
            this.lvNotListesi.Size = new System.Drawing.Size(408, 300);
            this.lvNotListesi.TabIndex = 0;
            this.lvNotListesi.UseCompatibleStateImageBehavior = false;
            this.lvNotListesi.View = System.Windows.Forms.View.Details;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvGecen);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(414, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Geçen Öğrenciler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvKalan);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(414, 306);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kalan Öğrenciler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Not Id";
            // 
            // txtNotId
            // 
            this.txtNotId.Location = new System.Drawing.Point(131, 103);
            this.txtNotId.Name = "txtNotId";
            this.txtNotId.Size = new System.Drawing.Size(121, 20);
            this.txtNotId.TabIndex = 15;
            // 
            // btnTab
            // 
            this.btnTab.Location = new System.Drawing.Point(724, 381);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(203, 43);
            this.btnTab.TabIndex = 17;
            this.btnTab.Text = "Tabları Yenile";
            this.btnTab.UseVisualStyleBackColor = true;
            this.btnTab.Click += new System.EventHandler(this.btnTab_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Öğrenci Ad Soyad";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vize";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Final";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ortalama";
            // 
            // lvGecen
            // 
            this.lvGecen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.lvGecen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGecen.HideSelection = false;
            this.lvGecen.Location = new System.Drawing.Point(0, 0);
            this.lvGecen.Name = "lvGecen";
            this.lvGecen.Size = new System.Drawing.Size(414, 306);
            this.lvGecen.TabIndex = 0;
            this.lvGecen.UseCompatibleStateImageBehavior = false;
            this.lvGecen.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Öğrenci Ad-Soyad";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ortalama";
            // 
            // lvKalan
            // 
            this.lvKalan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.lvKalan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvKalan.HideSelection = false;
            this.lvKalan.Location = new System.Drawing.Point(0, 0);
            this.lvKalan.Name = "lvKalan";
            this.lvKalan.Size = new System.Drawing.Size(414, 306);
            this.lvKalan.TabIndex = 0;
            this.lvKalan.UseCompatibleStateImageBehavior = false;
            this.lvKalan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Öğrenci Ad-Soyad";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ortalama";
            // 
            // NotIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 580);
            this.Controls.Add(this.btnTab);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNotId);
            this.Controls.Add(this.NotListesi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtOgrenciAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOgrenciId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtVize);
            this.Controls.Add(this.lvOgrenciler);
            this.Controls.Add(this.cmbDers);
            this.Controls.Add(this.cmbSinif);
            this.Name = "NotIslemleri";
            this.Text = "Not İşlemleri";
            this.Load += new System.EventHandler(this.NotIslemleri_Load);
            this.NotListesi.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSinif;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.ListView lvOgrenciler;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOgrenciId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabControl NotListesi;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lvNotListesi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNotId;
        private System.Windows.Forms.Button btnTab;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvGecen;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView lvKalan;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}