using CineTech.Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proje
{
    public partial class frmRaporlar : Form
    {
        SatisManager satisManager = new SatisManager();

        public frmRaporlar()
        {
            InitializeComponent();
        }


        // ==========================================
        //              FORM YÜKLENME
        // ==========================================
        private void frmRaporlar_Load(object sender, EventArgs e)
        {
            RaporlariGetir();
        }


        // ==========================================
        //           RAPOR OLUŞTURMA MOTORU
        // ==========================================
        void RaporlariGetir()
        {
            try
            {
                // 1. Verileri Çek
                List<Bilet> tumSatislar = satisManager.TumSatislariGetir();

                // 2. TABLO DOLDURMA (DataGridView)
                // Verileri tabloya düzgün basmak için "sanal" bir liste yapıyoruz
                var tabloVerisi = tumSatislar.Select(x => new
                {
                    FilmAdi = x.SeansBilgisi.FilmBilgisi.Ad,
                    Tarih = x.SeansBilgisi.Tarih.ToShortDateString(),
                    Saat = x.SeansBilgisi.Saat,
                    Koltuk = x.KoltukNo,
                    Fiyat = x.Fiyat,
                    Musteri = x.MusteriBilgisi.Ad
                }).ToList();

                dgvSatislar.DataSource = null;
                dgvSatislar.DataSource = tabloVerisi;

                // Başlıkları Düzenle
                dgvSatislar.Columns[0].HeaderText = "Film Adı";
                dgvSatislar.Columns[1].HeaderText = "Tarih";
                dgvSatislar.Columns[2].HeaderText = "Saat";
                dgvSatislar.Columns[3].HeaderText = "Koltuk";
                dgvSatislar.Columns[4].HeaderText = "Fiyat (TL)";
                dgvSatislar.Columns[5].HeaderText = "Müşteri";


                // 3. TOPLAM HASILAT
                decimal toplamCiro = satisManager.ToplamHasilatGetir();
                lblToplamHasilat.Text = toplamCiro.ToString("C2");


                // 4. GRAFİK DOLDURMA (Chart)
                // Hangi filmden ne kadar kazanılmış hesapla
                var filmGelirleri = tumSatislar
                    .GroupBy(x => x.SeansBilgisi.FilmBilgisi.Ad)
                    .Select(g => new { Film = g.Key, Gelir = g.Sum(b => b.Fiyat) })
                    .ToList();

                chartSatislar.Series.Clear();
                chartSatislar.Series.Add("Hasılat");

                foreach (var veri in filmGelirleri)
                {
                    chartSatislar.Series["Hasılat"].Points.AddXY(veri.Film, veri.Gelir);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor yüklenirken hata oluştu: " + ex.Message);
            }
        }


        // ==========================================
        //           GERİ DÖN VE ÇIKIŞ
        // ==========================================
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmAdminPaneli frm = new frmAdminPaneli();
            frm.Show();
            this.Hide();
        }

        private void frmRaporlar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}