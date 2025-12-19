using CineTech.Library;
using Proje;
using System;
using System.Data;
using System.Linq; // Filtreleme için gerekli
using System.Windows.Forms;

namespace CineTech
{
    public partial class frmPersonelYonetimi : Form
    {
        KullaniciManager kManager = new KullaniciManager();

        public frmPersonelYonetimi()
        {
            InitializeComponent();
        }


        // ==========================================
        //              FORM YÜKLENME
        // ==========================================
        private void frmPersonelYonetimi_Load(object sender, EventArgs e)
        {
            ListeyiYenile();
        }


        // ==========================================
        //           LİSTELEME & TEMİZLEME
        // ==========================================
        void ListeyiYenile()
        {
            dgvPersonel.DataSource = null;

            // Tüm kullanıcıları çek
            var tumKullanicilar = kManager.TumKullanicilar();

            // Sadece 'Personel' rolündekileri filtrele
            var sadecePersoneller = tumKullanicilar
                .Where(x => x.Rol == "Personel")
                .ToList();

            dgvPersonel.DataSource = sadecePersoneller;

            // Şifre gibi kritik kolonları gizle (Güvenlik)
            if (dgvPersonel.Columns["Sifre"] != null)
                dgvPersonel.Columns["Sifre"].Visible = false;
        }

        void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtSicilNo.Clear();
            txtMaas.Clear();
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
        }


        // ==========================================
        //              KAYIT İŞLEMİ
        // ==========================================
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // 1. Boş Alan Kontrolü
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Ad ve Kullanıcı Adı zorunludur!");
                return;
            }

            try
            {
                // 2. Yeni Personel Nesnesi
                Personel yeniPersonel = new Personel();
                yeniPersonel.Ad = txtAd.Text;
                yeniPersonel.Soyad = txtSoyad.Text;
                yeniPersonel.SicilNo = txtSicilNo.Text;
                yeniPersonel.KullaniciAdi = txtKullaniciAdi.Text;
                yeniPersonel.Sifre = txtSifre.Text;

                // Maaş Dönüştürme (Hata çıkarsa catch yakalar)
                if (decimal.TryParse(txtMaas.Text, out decimal maas))
                {
                    yeniPersonel.Maas = maas;
                }
                else
                {
                    MessageBox.Show("Lütfen maaş kısmına geçerli bir sayı giriniz.");
                    return;
                }

                // 3. Veritabanına Ekle
                kManager.Ekle(yeniPersonel);

                MessageBox.Show("Personel başarıyla kaydedildi.");
                ListeyiYenile();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        // ==========================================
        //              SİLME İŞLEMİ
        // ==========================================
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonel.SelectedRows.Count > 0)
                {
                    // Seçili satırdaki Kullanıcı Adını al
                    string silinecekKAdi = dgvPersonel.SelectedRows[0].Cells["KullaniciAdi"].Value.ToString();

                    // Silme işlemini yap
                    kManager.Sil(silinecekKAdi);

                    MessageBox.Show("Personel silindi.");
                    ListeyiYenile();
                }
                else
                {
                    MessageBox.Show("Lütfen silinecek personeli seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
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

        private void frmPersonelYonetimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}