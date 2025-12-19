using CineTech.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proje
{
    public partial class frmKoltukSecimi : Form
    {
        // Yöneticiler
        SeansManager sManager = new SeansManager();
        SatisManager satisManager = new SatisManager();

        // Değişkenler
        public Film SecilenFilm { get; set; } // Önceki formdan geliyor
        Seans suankiSeans = null;
        List<string> anlikSecilenKoltuklar = new List<string>();
        decimal odenecekTutar = 0;

        public frmKoltukSecimi()
        {
            InitializeComponent();
        }

        // ==========================================
        //              FORM YÜKLENME
        // ==========================================
        private void frmKoltukSecimi_Load(object sender, EventArgs e)
        {
            // Bilet Türleri
            cmbBiletTuru.Items.Clear();
            cmbBiletTuru.Items.Add("Tam - 100 TL");
            cmbBiletTuru.Items.Add("Öğrenci - 80 TL");
            cmbBiletTuru.SelectedIndex = 0;

            // Eğer film seçili geldiyse (ki gelmeli)
            if (SecilenFilm != null)
            {
                lblFilmAdi.Text = SecilenFilm.Ad;

                // 1. ADIM: Bu filmin oynadığı TARİHLERİ getir (Tekrarsız)
                List<Seans> tumSeanslar = sManager.SeanslariGetir();

                var tarihler = tumSeanslar
                    .Where(s => s.FilmBilgisi.ID == SecilenFilm.ID)
                    .Select(s => s.Tarih.ToShortDateString())
                    .Distinct()
                    .ToList();

                cmbTarih.DataSource = tarihler;
                cmbTarih.SelectedIndex = -1;

                // Diğer kutuları temizle
                cmbSalon.DataSource = null;
                cmbSeans.DataSource = null;
            }
        }

        // ==========================================
        //           1. ADIM: TARİH SEÇİMİ
        // ==========================================
        private void cmbTarih_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbTarih.SelectedItem == null) return;

            string secilenTarih = cmbTarih.SelectedItem.ToString();

            // 2. ADIM: Bu film ve tarihteki SALONLARI getir
            List<Seans> tumSeanslar = sManager.SeanslariGetir();

            var salonlar = tumSeanslar
                .Where(s => s.FilmBilgisi.ID == SecilenFilm.ID && s.Tarih.ToShortDateString() == secilenTarih)
                .Select(s => s.SalonAdi.Trim())
                .Distinct()
                .ToList();

            cmbSalon.DataSource = salonlar;
            cmbSalon.SelectedIndex = -1;

            // Alt kutuları temizle
            cmbSeans.DataSource = null;
            pnlKoltuklar.Controls.Clear();
        }

        // ==========================================
        //           2. ADIM: SALON SEÇİMİ
        // ==========================================
        private void cmbSalon_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbSalon.SelectedItem == null || cmbTarih.SelectedItem == null) return;

            string secilenTarih = cmbTarih.SelectedItem.ToString();
            string secilenSalon = cmbSalon.SelectedItem.ToString();

            // 3. ADIM: Bu film, tarih ve salondaki SAATLERİ (Seansları) getir
            List<Seans> tumSeanslar = sManager.SeanslariGetir();

            var uygunSeanslar = tumSeanslar
                .Where(s => s.FilmBilgisi.ID == SecilenFilm.ID &&
                            s.Tarih.ToShortDateString() == secilenTarih &&
                            s.SalonAdi.Trim() == secilenSalon.Trim())
                .ToList();

            cmbSeans.DataSource = uygunSeanslar;
            cmbSeans.DisplayMember = "Saat"; // Sadece saati göster
            cmbSeans.SelectedIndex = -1;

            pnlKoltuklar.Controls.Clear();
        }

        // ==========================================
        //           3. ADIM: SAAT (SEANS) SEÇİMİ
        // ==========================================
        private void cmbSeans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSeans.SelectedItem == null) return;

            suankiSeans = (Seans)cmbSeans.SelectedItem;
            KoltuklariOlustur();
        }

        // ==========================================
        //           KOLTUK OLUŞTURMA (YEŞİL)
        // ==========================================
        void KoltuklariOlustur()
        {
            try
            {
                pnlKoltuklar.Controls.Clear();
                anlikSecilenKoltuklar.Clear();
                txtKoltuklar.Clear();
                lblToplamTutar.Text = "0.00 TL";

                // Dolu koltukları çek
                List<string> dolular = satisManager.DoluKoltuklariGetir(suankiSeans);

                string[] siralar = { "A", "B", "C", "D", "E", "F" };

                foreach (string sira in siralar)
                {
                    for (int no = 1; no <= 10; no++)
                    {
                        Button btn = new Button();
                        btn.Width = 45;
                        btn.Height = 45;
                        btn.Text = sira + no.ToString();
                        btn.Name = "btn" + btn.Text;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.Margin = new Padding(3);

                        // --- RENKLENDİRME ---
                        if (dolular.Contains(btn.Text))
                        {
                            btn.BackColor = Color.Red; // Dolu
                            btn.Enabled = false;
                        }
                        else
                        {
                            btn.BackColor = Color.LightGreen; // Boş (Yeşil)
                        }

                        btn.Click += Koltuk_Click;
                        pnlKoltuklar.Controls.Add(btn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // Koltuk Tıklama (Seçim)
        private void Koltuk_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;

            // Seçilmemişse (Yeşil) -> Turuncu yap
            if (tiklanan.BackColor == Color.LightGreen)
            {
                tiklanan.BackColor = Color.Orange;
                anlikSecilenKoltuklar.Add(tiklanan.Text);
            }
            // Seçiliyse (Turuncu) -> Geri Yeşil yap
            else if (tiklanan.BackColor == Color.Orange)
            {
                tiklanan.BackColor = Color.LightGreen;
                anlikSecilenKoltuklar.Remove(tiklanan.Text);
            }

            // Arayüzü güncelle
            txtKoltuklar.Text = string.Join(", ", anlikSecilenKoltuklar);
            FiyatHesapla();
        }

        // ==========================================
        //           FİYAT VE ÖDEME GEÇİŞİ
        // ==========================================
        void FiyatHesapla()
        {
            decimal birimFiyat = cmbBiletTuru.Text.Contains("Tam") ? 100 : 80;
            odenecekTutar = anlikSecilenKoltuklar.Count * birimFiyat;
            lblToplamTutar.Text = odenecekTutar.ToString("C2");
        }

        private void cmbBiletTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiyatHesapla();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (suankiSeans == null || anlikSecilenKoltuklar.Count == 0)
            {
                MessageBox.Show("Lütfen seans ve en az bir koltuk seçiniz.");
                return;
            }

            // Ödeme Formunu Aç
            frmOdeme frm = new frmOdeme();

            // Verileri Gönder
            frm.FilmBilgisi = SecilenFilm;
            frm.SeansBilgisi = suankiSeans;
            frm.Koltuklar = anlikSecilenKoltuklar;
            frm.Tutar = odenecekTutar;

            frm.Show();
            this.Hide();
        }

        // ==========================================
        //           ÇIKIŞ VE GERİ DÖN
        // ==========================================
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmAnaSayfa frm = new frmAnaSayfa();
            frm.Show();
            this.Hide();
        }

        private void frmKoltukSecimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}