using CineTech.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proje
{
    public partial class frmGiseSatis : Form
    {
        // Yöneticiler
        FilmManager fManager = new FilmManager();
        SeansManager sManager = new SeansManager();
        SatisManager satisManager = new SatisManager();

        // Değişkenler
        Seans suankiSeans = null;
        List<string> anlikSecilenKoltuklar = new List<string>();

        public frmGiseSatis()
        {
            InitializeComponent();
        }

        // ==========================================
        //              FORM YÜKLENME
        // ==========================================
        private void frmGiseSatis_Load(object sender, EventArgs e)
        {
            // Tarifeler
            cmbTarife.Items.Clear();
            cmbTarife.Items.Add("Tam - 100 TL");
            cmbTarife.Items.Add("Öğrenci - 80 TL");
            cmbTarife.SelectedIndex = 0;

            // 1. Filmleri Doldur
            cmbFilm.DataSource = fManager.FilmleriGetir();
            cmbFilm.DisplayMember = "Ad";
            cmbFilm.ValueMember = "ID";

            // Başlangıçta boş olsun
            cmbFilm.SelectedIndex = -1;
            cmbSalon.DataSource = null;
            cmbSeans.DataSource = null;
        }

        // ==========================================
        //           1. ADIM: FİLM SEÇİMİ
        // ==========================================
        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilm.SelectedItem == null) return;

            Film secilen = (Film)cmbFilm.SelectedItem;

            // Tüm seansları çek
            List<Seans> tumSeanslar = sManager.SeanslariGetir();

            // Salonları ayıkla (Trim ile temizleyerek)
            var salonlar = tumSeanslar
                .Where(s => s.FilmBilgisi.ID == secilen.ID)
                .Select(s => s.SalonAdi.Trim())
                .Distinct()
                .ToList();

            // 2. KUTUYU (Salon) DOLDUR
            cmbSalon.DataSource = salonlar;
            cmbSalon.SelectedIndex = -1;

            // Alt kutuları temizle
            cmbSeans.DataSource = null;
            pnlKoltuklar.Controls.Clear();
            Temizle();
        }

        // ==========================================
        //           2. ADIM: SALON SEÇİMİ (GÜÇLENDİRİLDİ)
        // ==========================================
        private void cmbSalon_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbFilm.SelectedItem == null || cmbSalon.SelectedItem == null) return;

            try
            {
                Film secilenFilm = (Film)cmbFilm.SelectedItem;
                string secilenSalon = cmbSalon.SelectedItem.ToString();

                // Tüm seansları çek
                List<Seans> tumSeanslar = sManager.SeanslariGetir();

                // FİLTRELEME: Film ID tutacak VE Salon Adı (büyük/küçük harf duyarsız) eşleşecek
                var uygunSeanslar = new List<Seans>();

                foreach (var s in tumSeanslar)
                {
                    if (s.FilmBilgisi.ID == secilenFilm.ID &&
                        s.SalonAdi.ToLower().Contains(secilenSalon.ToLower().Trim()))
                    {
                        uygunSeanslar.Add(s);
                    }
                }

                // 3. KUTUYU (Seans) DOLDUR
                cmbSeans.DataSource = uygunSeanslar;

                // GÖRÜNÜM AYARI: "18.12.2025 | 19:00"
                // Varsayılan bir DisplayMember atıyoruz ki boş gelmesin
                cmbSeans.DisplayMember = "Saat";

                cmbSeans.Format += (s, args) =>
                {
                    var seans = (Seans)args.ListItem;
                    if (seans != null)
                    {
                        args.Value = seans.Tarih.ToShortDateString() + " | " + seans.Saat;
                    }
                };

                cmbSeans.SelectedIndex = -1;
                pnlKoltuklar.Controls.Clear();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seanslar yüklenirken hata: " + ex.Message);
            }
        }

        // ==========================================
        //           3. ADIM: SEANS SEÇİMİ
        // ==========================================
        private void cmbSeans_SelectedIndexChanged_1(object sender, EventArgs e)
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

                if (suankiSeans == null) return;

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
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.Margin = new Padding(3);

                        // --- RENKLENDİRME ---
                        if (dolular.Contains(btn.Text))
                        {
                            btn.BackColor = Color.Red; // Satılmış
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

        // Koltuk Tıklama (Çoklu Seçim)
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
        //           FİYAT VE SATIŞ
        // ==========================================
        void FiyatHesapla()
        {
            decimal birimFiyat = cmbTarife.Text.Contains("Tam") ? 100 : 80;
            decimal toplam = anlikSecilenKoltuklar.Count * birimFiyat;
            lblToplamTutar.Text = toplam.ToString("C2");
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            if (suankiSeans == null || anlikSecilenKoltuklar.Count == 0)
            {
                MessageBox.Show("Lütfen seans ve en az bir koltuk seçiniz.");
                return;
            }

            try
            {
                decimal birimFiyat = cmbTarife.Text.Contains("Tam") ? 100 : 80;

                int personelID = Program.MevcutKullanici != null ? Program.MevcutKullanici.ID : 1;

                foreach (string koltukNo in anlikSecilenKoltuklar)
                {
                    Bilet yeniBilet = new Bilet();
                    yeniBilet.SeansBilgisi = suankiSeans;
                    yeniBilet.KoltukNo = koltukNo;
                    yeniBilet.Fiyat = birimFiyat;

                    satisManager.BiletKes(yeniBilet, personelID);
                }

                MessageBox.Show("Satış Başarılı!");
                KoltuklariOlustur(); // Ekranı yenile
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void cmbTarife_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiyatHesapla();
        }

        // ==========================================
        //           TEMİZLE VE ÇIKIŞ
        // ==========================================
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if (suankiSeans != null) KoltuklariOlustur();
            else Temizle();
        }

        void Temizle()
        {
            anlikSecilenKoltuklar.Clear();
            txtKoltuklar.Clear();
            lblToplamTutar.Text = "0.00 TL";
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmPersonelPaneli frm = new frmPersonelPaneli();
            frm.Show();
            this.Hide();
        }

        private void frmGiseSatis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}