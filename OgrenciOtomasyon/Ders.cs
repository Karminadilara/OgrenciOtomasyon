using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OgrenciOtomasyon.Business;

namespace OgrenciOtomasyon
{
    public partial class Ders : Form
    {
        public Ders()
        {
            InitializeComponent();
        }

        DersIslemleri islemler = new DersIslemleri();
        bool kaydetMi = true;

        private void Listele()
        {
            List<Entity.Ders> liste = islemler.DersListele();

            lvDersler.Items.Clear();

            foreach (var item in liste)
            {
                var satir = new ListViewItem(new string[] { item.Id.ToString(), item.Adi });

                lvDersler.Items.Add(satir);
            }
        }

        private void Ders_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void KontrolleriBosalt()
        {
            txtDersAdi.Clear();
            txtId.Clear();
            txtId.ReadOnly = false;
            kaydetMi = true;
            btnKaydet.Text = "Ders Kaydet";
            btnSil.Visible = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Entity.Ders ders = new Entity.Ders();
            ders.Id = Convert.ToInt32(txtId.Text);
            ders.Adi = txtDersAdi.Text;



            if (kaydetMi)
            {
                if (!islemler.IdKontrol(ders.Id))
                {
                    MessageBox.Show("ID Kayıtlı", "Id Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                bool sonuc = islemler.Kaydet(ders);

                if (sonuc)
                {
                    MessageBox.Show("Başarıyla Kaydedildi");
                    Listele();
                    KontrolleriBosalt();
                }
                else
                {
                    MessageBox.Show("Kaydedilirken bir hata oluştu.");
                    KontrolleriBosalt();
                }
            }
            else
            {
                bool sonuc = islemler.Guncelle(ders);
                if (sonuc)
                {
                    MessageBox.Show("Başarıyla Güncellendi.");
                    Listele();
                    KontrolleriBosalt();
                }
                else
                {
                    MessageBox.Show("Güncellenirken bir hata oluştu.");
                    KontrolleriBosalt();
                }

            }
        }

        private void lvDersler_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = lvDersler.SelectedItems[0];

            Entity.Ders ders = new Entity.Ders();

            ders = islemler.DersGetirIdyeGore(Convert.ToInt32(item.Text));
                        
            txtId.Text = ders.Id.ToString();
            txtDersAdi.Text = ders.Adi;

            txtId.ReadOnly = true;

            btnKaydet.Text = "Ders Güncelle";
            kaydetMi = false;
            btnSil.Visible = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Entity.Ders ders = new Entity.Ders();
            ders = islemler.DersGetirIdyeGore(Convert.ToInt32(txtId.Text));

            bool sonuc = islemler.Sil(ders);


            if (sonuc)
            {
                MessageBox.Show("Başarıyla Silindi");
                Listele();
                KontrolleriBosalt();
            }
            else
            {
                MessageBox.Show("Silinme işlemi sırasında bir hata oldu.");
                Listele();
                KontrolleriBosalt();
            }
        }
    }
}
