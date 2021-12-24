using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciOtomasyon
{
    public partial class MenuEkrani : Form
    {
        public MenuEkrani()
        {
            InitializeComponent();
        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            frmOgretmen frmOgretmen = new frmOgretmen();

            frmOgretmen.Show();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            Ders frmDers = new Ders();
            frmDers.Show();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            frmOgrenci frmOgrenci = new frmOgrenci();
            frmOgrenci.Show();
        }

        private void MenuEkrani_Load(object sender, EventArgs e)
        {
            frmGiris frmGiris = new frmGiris();
            frmGiris.Close();
        }

        private void btnSinif_Click(object sender, EventArgs e)
        {
            SinifForm sinifForm = new SinifForm();
            sinifForm.Show();
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            NotIslemleri frmNot = new NotIslemleri();
            frmNot.Show();
        }
    }
}
