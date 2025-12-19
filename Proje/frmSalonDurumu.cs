using CineTech.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proje
{
    public partial class frmSalonDurumu : Form
    {
        // Yöneticiler
        FilmManager fManager = new FilmManager();
        SeansManager sManager = new SeansManager();
        SatisManager satisManager = new SatisManager();

        Seans suankiSeans = null;
        Button seciliButon = null;

        public frmSalonDurumu()
        {
            InitializeComponent();
        }

        private void frmSalonDurumu_Load(object sender, EventArgs e)
        {
            cmbFilm.DataSource = fManager.FilmleriGetir();
            cmbFilm.DisplayMember = "Ad";
            cmbFilm.ValueMember = "ID";
            cmbFilm.SelectedIndex = -1;

            cmbSalon.DataSource = null;
            cmbSeans.DataSource = null;
        }

        // 1. ADIM: FİLM SEÇİMİ
        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilm.SelectedItem == null) return;

            Film secilenFilm = (Film)cmbFilm.SelectedItem;
            List<Seans> tumSeanslar = sManager.SeanslariGetir();
            var salonlar = tumSeanslar.Where(s => s.FilmBilgisi.ID == secilenFilm.ID).Select(s => s.SalonAdi.Trim()).Distinct().ToList();

            cmbSalon.DataSource = salonlar;
            cmbSalon.SelectedIndex = -1;
            cmbSeans.DataSource = null;
            pnlKoltuklar.Controls.Clear();
            lblDoluluk.Text = "Doluluk: -";
        }

        // 2. ADIM: SALON SEÇİMİ
        private void cmbSalon_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbFilm.SelectedItem == null || cmbSalon.SelectedItem == null) return;
            try
            {
                Film secilenFilm = (Film)cmbFilm.SelectedItem;
                string secilenSalon = cmbSalon.SelectedItem.ToString();
                List<Seans> tumSeanslar = sManager.SeanslariGetir();

                var uygunSeanslar = tumSeanslar.Where(s => s.FilmBilgisi.ID == secilenFilm.ID && s.SalonAdi.ToLower().Contains(secilenSalon.ToLower().Trim())).ToList();

                cmbSeans.DataSource = uygunSeanslar;
                cmbSeans.DisplayMember = "Saat";
                cmbSeans.Format += (s, args) => { var seans = (Seans)args.ListItem; if (seans != null) args.Value = seans.Tarih.ToShortDateString() + " | " + seans.Saat; };
                cmbSeans.SelectedIndex = -1;
                pnlKoltuklar.Controls.Clear();
            }
            catch { }
        }

        // 3. ADIM: SEANS SEÇİMİ
        private void cmbSeans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSeans.SelectedItem == null) return;
            suankiSeans = (Seans)cmbSeans.SelectedItem;
            KoltuklariOlustur();
        }

        // KOLTUK OLUŞTURMA & YÜZDE HESAPLAMA
        void KoltuklariOlustur()
        {
            try
            {
                pnlKoltuklar.Controls.Clear();
                seciliButon = null;

                if (suankiSeans == null) return;

                List<string> tumDolular = satisManager.DoluKoltuklariGetir(suankiSeans);
                List<string> bakimdakiler = satisManager.BakimdakiKoltuklariGetir(suankiSeans);

                int doluSayisi = 0;
                int toplamKoltuk = 0;
                string[] siralar = { "A", "B", "C", "D", "E", "F" };

                foreach (string sira in siralar)
                {
                    for (int no = 1; no <= 10; no++)
                    {
                        toplamKoltuk++;
                        Button btn = new Button();
                        btn.Width = 45;
                        btn.Height = 45;
                        btn.Text = sira + no.ToString();
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.Margin = new Padding(3);

                        // --- RENKLENDİRME ---
                        if (bakimdakiler.Contains(btn.Text))
                        {
                            btn.BackColor = Color.Black;
                            btn.ForeColor = Color.White;
                            doluSayisi++; // Bakım da doluluktan sayılır
                        }
                        else if (tumDolular.Contains(btn.Text))
                        {
                            btn.BackColor = Color.Red;
                            btn.Enabled = false;
                            doluSayisi++; // Satılanlar
                        }
                        else
                        {
                            btn.BackColor = Color.LightGreen;
                        }

                        btn.Click += Koltuk_Click;
                        pnlKoltuklar.Controls.Add(btn);
                    }
                }

                // --- YÜZDE HESAPLAMA VE YAZDIRMA ---
                double oran = 0;
                if (toplamKoltuk > 0)
                {
                    oran = (double)doluSayisi / toplamKoltuk * 100;
                }

                // Format: "Doluluk: 15 / 60 (%25)"
                lblDoluluk.Text = string.Format("{0} / {1} (%{2:0})", doluSayisi, toplamKoltuk, oran);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void Koltuk_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            seciliButon = tiklanan;
            MessageBox.Show("Seçilen Koltuk: " + tiklanan.Text);
        }

        private void btnBakim_Click(object sender, EventArgs e)
        {
            if (seciliButon == null)
            {
                MessageBox.Show("Lütfen önce listeden bir koltuk seçin.");
                return;
            }

            try
            {
                int adminID = Program.MevcutKullanici != null ? Program.MevcutKullanici.ID : 1;

                if (seciliButon.BackColor == Color.LightGreen)
                {
                    // Bakıma Al
                    Bilet bakimBileti = new Bilet();
                    bakimBileti.SeansBilgisi = suankiSeans;
                    bakimBileti.KoltukNo = seciliButon.Text;
                    bakimBileti.Fiyat = 0;

                    satisManager.BiletKes(bakimBileti, adminID);

                    seciliButon.BackColor = Color.Black;
                    seciliButon.ForeColor = Color.White;
                    MessageBox.Show(seciliButon.Text + " nolu koltuk bakıma alındı.");
                }
                else if (seciliButon.BackColor == Color.Black)
                {
                    // Bakımdan Çıkar
                    satisManager.BiletIptal(suankiSeans.ID, seciliButon.Text);

                    seciliButon.BackColor = Color.LightGreen;
                    seciliButon.ForeColor = Color.Black;
                    MessageBox.Show(seciliButon.Text + " nolu koltuk kullanıma açıldı.");
                }
                else
                {
                    MessageBox.Show("Satılmış koltuğa işlem yapılamaz!");
                }

                // Sayacı ve yüzdeyi güncellemek için tekrar çağırıyoruz
                KoltuklariOlustur();
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem sırasında hata: " + ex.Message);
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmPersonelPaneli frm = new frmPersonelPaneli();
            frm.Show();
            this.Hide();
        }

        private void frmSalonDurumu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}