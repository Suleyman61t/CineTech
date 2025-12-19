using CineTech.Library;
using System;
using System.Windows.Forms;

namespace Proje
{
    public partial class frmSeansYonetimi : Form
    {
        FilmManager fManager = new FilmManager();
        SeansManager sManager = new SeansManager();

        public frmSeansYonetimi()
        {
            InitializeComponent();
        }


        // ==========================================
        //              FORM YÜKLENME
        // ==========================================
        private void frmSeansYonetimi_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Grid Ayarları
                dgvSeanslar.AllowUserToAddRows = false;
                dgvSeanslar.AllowUserToDeleteRows = false;
                dgvSeanslar.ReadOnly = true;
                dgvSeanslar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSeanslar.MultiSelect = false;
                dgvSeanslar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSeanslar.RowHeadersVisible = false;

                // 2. Filmleri Doldur
                cmbFilm.DataSource = fManager.FilmleriGetir();
                cmbFilm.DisplayMember = "Ad";
                cmbFilm.ValueMember = "ID"; // ValueMember ID olmalı
                cmbFilm.SelectedIndex = -1;

                // 3. Salonları Doldur (Manuel)
                cmbSalon.Items.Clear();
                cmbSalon.Items.AddRange(new string[] { "Salon 1", "Salon 2", "Salon 3 - VIP" });
                cmbSalon.SelectedIndex = 0;

                // 4. Saatleri Doldur
                cmbSaat.Items.Clear();
                cmbSaat.Items.AddRange(new string[] { "10:00", "13:00", "16:00", "19:00", "21:30" });
                cmbSaat.SelectedIndex = 0;

                // 5. Listeyi Getir
                ListeyiYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // ==========================================
        //           LİSTELEME İŞLEMİ
        // ==========================================
        void ListeyiYenile()
        {
            try
            {
                // Seçim olayını geçici durdur (Hata almamak için)
                dgvSeanslar.SelectionChanged -= dgvSeanslar_SelectionChanged;

                dgvSeanslar.DataSource = null;
                dgvSeanslar.DataSource = sManager.SeanslariGetir();

                // Gereksiz Kolonları Gizle
                if (dgvSeanslar.Columns["ID"] != null) dgvSeanslar.Columns["ID"].Visible = false;
                if (dgvSeanslar.Columns["KayitTarihi"] != null) dgvSeanslar.Columns["KayitTarihi"].Visible = false;

                dgvSeanslar.ClearSelection();

                // Olayı geri aç
                dgvSeanslar.SelectionChanged += dgvSeanslar_SelectionChanged;
            }
            catch { }
        }


        // ==========================================
        //           GRID SEÇİM DEĞİŞİKLİĞİ
        // ==========================================
        private void dgvSeanslar_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvSeanslar.SelectedRows.Count == 0) return;

                DataGridViewRow satir = dgvSeanslar.SelectedRows[0];
                if (satir.DataBoundItem == null) return;

                Seans secilen = (Seans)satir.DataBoundItem;

                // Verileri kutulara doldur
                cmbFilm.Text = secilen.FilmBilgisi.Ad;
                cmbSalon.Text = secilen.SalonAdi;
                cmbSaat.Text = secilen.Saat;
                dtpTarih.Value = secilen.Tarih;
            }
            catch { }
        }


        // ==========================================
        //              SEANS EKLEME
        // ==========================================
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Doğrulama
                if (cmbFilm.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir film seçiniz.");
                    return;
                }

                if (string.IsNullOrEmpty(cmbSaat.Text) || string.IsNullOrEmpty(cmbSalon.Text))
                {
                    MessageBox.Show("Saat ve Salon seçimi zorunludur.");
                    return;
                }

                // Yeni Seans Oluşturma
                Seans yeniSeans = new Seans();
                yeniSeans.FilmBilgisi = cmbFilm.SelectedItem as Film;

                if (yeniSeans.FilmBilgisi == null)
                {
                    MessageBox.Show("Film seçimi hatalı.");
                    return;
                }

                yeniSeans.SalonAdi = cmbSalon.Text;
                yeniSeans.Tarih = dtpTarih.Value.Date;
                yeniSeans.Saat = cmbSaat.Text;

                // Veritabanına Kayıt
                sManager.SeansEkle(yeniSeans);

                MessageBox.Show("Seans başarıyla oluşturuldu.");
                ListeyiYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // ==========================================
        //           GERİ DÖN VE ÇIKIŞ
        // ==========================================
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmPersonelPaneli frm = new frmPersonelPaneli();
            frm.Show();
            this.Hide();
        }

        private void frmSeansYonetimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}