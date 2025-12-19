using System;
using System.Windows.Forms;

namespace Proje
{
    public partial class frmPersonelPaneli : Form
    {
        public frmPersonelPaneli()
        {
            InitializeComponent();
        }


        // ==========================================
        //              FORM YÜKLENME
        // ==========================================
        private void frmPersonelPaneli_Load(object sender, EventArgs e)
        {
            // İleride personel ismini başlığa yazdırmak istersen burayı kullanabilirsin.
            // this.Text = "Personel Paneli - Hoşgeldiniz";
        }


        // ==========================================
        //           MENÜ YÖNLENDİRMELERİ
        // ==========================================

        // 1. Gişe Satış Ekranına Git
        private void btnBiletKes_Click(object sender, EventArgs e)
        {
            frmGiseSatis frm = new frmGiseSatis();
            frm.Show();
            this.Hide();
        }

        // 2. Salon Durum Ekranına Git
        private void btnSalonDurumu_Click(object sender, EventArgs e)
        {
            frmSalonDurumu frm = new frmSalonDurumu();
            frm.Show();
            this.Hide();
        }

        // 3. Seans Yönetimi Ekranına Git
        private void btnSeansIslemleri_Click(object sender, EventArgs e)
        {
            frmSeansYonetimi frm = new frmSeansYonetimi();
            frm.Show();
            this.Hide();
        }


        // ==========================================
        //           SİSTEM / ÇIKIŞ İŞLEMLERİ
        // ==========================================

        // Çıkış Yap (Login Ekranına Dön)
        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmGiris frm = new frmGiris();
            frm.Show();
            this.Hide();
        }

        // Uygulamayı Kapat
        private void frmPersonelPaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}