using CineTech.Library;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proje
{
    public partial class frmOdeme : Form
    {
        // ==========================================
        //           GELEN VERİLER
        // ==========================================
        public Film FilmBilgisi { get; set; }
        public Seans SeansBilgisi { get; set; }
        public List<string> Koltuklar { get; set; }
        public decimal Tutar { get; set; }

        SatisManager satisManager = new SatisManager();

        public frmOdeme()
        {
            InitializeComponent();
        }


        // ==========================================
        //              FORM YÜKLENME
        // ==========================================
        private void frmOdeme_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. FİLM VE SEANS BİLGİSİNİ TEK ETİKETE YAZDIRALIM
                if (FilmBilgisi != null && SeansBilgisi != null)
                {
                    string koltukYazisi = (Koltuklar != null) ? string.Join(", ", Koltuklar) : "";

                    // Örnek: "Avatar 2\nSeans: 10:00 (Salon 1)\nKoltuklar: A1, A2"
                    lblFilmAdi.Text = FilmBilgisi.Ad + "\n" +
                                      "Seans: " + SeansBilgisi.Saat + " (" + SeansBilgisi.SalonAdi + ")\n" +
                                      "Koltuklar: " + koltukYazisi;
                }

                // 2. TUTARI YAZDIRALIM
                lblToplamTutar.Text = Tutar.ToString("C2"); // "180,00 ₺" formatında yazar
            }
            catch { }
        }


        // ==========================================
        //              ÖDEME İŞLEMİ
        // ==========================================
        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            // Kart Bilgileri Kontrolü (Tasarımda bu kutuların olduğundan emin ol)
            if (string.IsNullOrEmpty(txtAdSoyad.Text) ||
                !mskKartNo.MaskCompleted ||
                !mskAyYil.MaskCompleted ||
                !mskCVC.MaskCompleted)
            {
                MessageBox.Show("Lütfen kart bilgilerini eksiksiz doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Müşteri ID (Giriş yapan varsa al, yoksa 1)
                int musteriID = 1;
                if (Program.MevcutKullanici != null)
                    musteriID = Program.MevcutKullanici.ID;

                // Biletleri Kaydet
                foreach (string koltukNo in Koltuklar)
                {
                    Bilet yeniBilet = new Bilet();
                    yeniBilet.SeansBilgisi = SeansBilgisi;
                    yeniBilet.KoltukNo = koltukNo;

                    // Birim fiyat hesabı
                    yeniBilet.Fiyat = Tutar / Koltuklar.Count;

                    satisManager.BiletKes(yeniBilet, musteriID);
                }

                MessageBox.Show("Ödeme Başarılı! İyi seyirler.", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ana Sayfaya Dön
                frmAnaSayfa frm = new frmAnaSayfa();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        // ==========================================
        //           İPTAL VE ÇIKIŞ
        // ==========================================
        private void btnIptal_Click(object sender, EventArgs e)
        {
            frmKoltukSecimi frm = new frmKoltukSecimi();
            frm.SecilenFilm = FilmBilgisi;
            frm.Show();
            this.Hide();
        }

        private void frmOdeme_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}