using CineTech.Library;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proje
{
    public partial class frmFilmDetay : Form
    {
        // Ana sayfadan gelen filmi tutmak için
        public Film SecilenFilm { get; set; }

        public frmFilmDetay()
        {
            InitializeComponent();
        }


        // ==========================================
        //              FORM YÜKLENME
        // ==========================================
        private void frmFilmDetay_Load(object sender, EventArgs e)
        {
            if (SecilenFilm != null)
            {
                // Bilgileri Doldur
                lblFilmAdi.Text = SecilenFilm.Ad;
                lblYonetmen.Text = "Yönetmen: " + SecilenFilm.Yonetmen;
                lblTurSure.Text = "Tür: " + SecilenFilm.Tur + " | Süre: " + SecilenFilm.Sure + " dk";

                // Özet (Veritabanında olmadığı için temsili yazı)
                rtbOzet.Text = SecilenFilm.Ad + " filmi, izleyicileri büyüleyen sahneleri ve derin hikayesiyle şimdi vizyonda! \n\n" +
                               "Bu film " + SecilenFilm.Tur + " türünün en iyi örneklerinden biri olarak kabul ediliyor.";

                // Afiş Yükleme
                if (!string.IsNullOrEmpty(SecilenFilm.AfisYolu))
                {
                    try
                    {
                        pbAfis.ImageLocation = SecilenFilm.AfisYolu;
                    }
                    catch
                    {
                        pbAfis.BackColor = Color.Gray;
                    }
                }
            }
        }


        // ==========================================
        //           BUTON İŞLEMLERİ
        // ==========================================

        // Bilet Al Butonu (Koltuk Seçimine Git)
        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            frmKoltukSecimi frm = new frmKoltukSecimi();

            // Filmi diğer forma taşıyoruz
            frm.SecilenFilm = this.SecilenFilm;

            frm.Show();
            this.Hide();
        }

        // Geri Dön (Ana Sayfaya)
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmAnaSayfa frm = new frmAnaSayfa();
            frm.Show();
            this.Hide();
        }


        // ==========================================
        //           ÇIKIŞ İŞLEMİ
        // ==========================================
        private void frmFilmDetay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}