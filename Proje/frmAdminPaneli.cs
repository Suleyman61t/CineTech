using CineTech;
using System;
using System.Windows.Forms;

namespace Proje // Proje adını diğerleriyle uyumlu olsun diye CineTech yaptım
{
    public partial class frmAdminPaneli : Form
    {
        public frmAdminPaneli()
        {
            InitializeComponent();
        }

        // ==========================================
        //              FORM YÜKLENME
        // ==========================================
        private void frmAdminPaneli_Load(object sender, EventArgs e)
        {
            // Şu anlık burası boş, ileride admine özel karşılama mesajı eklenebilir.
        }


        // ==========================================
        //           MENÜ YÖNLENDİRMELERİ
        // ==========================================

        // 1. Film Yönetimi Sayfasına Git
        private void btnFilmIslemleri_Click(object sender, EventArgs e)
        {
            frmFilmYonetimi frm = new frmFilmYonetimi();
            frm.Show();
            this.Hide();
        }

        // 2. Personel Yönetimi Sayfasına Git
        private void btnPersonelIslemleri_Click(object sender, EventArgs e)
        {
            frmPersonelYonetimi frm = new frmPersonelYonetimi();
            frm.Show();
            this.Hide();
        }

        // 3. Raporlar Sayfasına Git
        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            frmRaporlar frm = new frmRaporlar();
            frm.Show();
            this.Hide();
        }


        // ==========================================
        //           SİSTEM / ÇIKIŞ İŞLEMLERİ
        // ==========================================

        // Güvenli Çıkış (Login Ekranına Dön)
        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmGiris frm = new frmGiris();
            frm.Show();
            this.Hide();
        }

        // Uygulamayı Tamamen Kapat
        private void frmAdminPaneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}