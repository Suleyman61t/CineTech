using CineTech.Library;
using System;
using System.Windows.Forms;

namespace Proje
{
    public partial class frmKayitOl : Form
    {
        KullaniciManager kManager = new KullaniciManager();

        public frmKayitOl()
        {
            InitializeComponent();
        }


        // ==========================================
        //              KAYIT İŞLEMİ
        // ==========================================
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            // 1. Boş Alan Kontrolü
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) ||
                string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen tüm zorunlu alanları doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Yeni Müşteri Nesnesi Oluşturma
                Musteri yeniMusteri = new Musteri();
                yeniMusteri.Ad = txtAd.Text;
                yeniMusteri.Soyad = txtSoyad.Text;
                yeniMusteri.Telefon = mskTelefon.Text;
                yeniMusteri.Eposta = txtMail.Text;
                yeniMusteri.KullaniciAdi = txtKullaniciAdi.Text;
                yeniMusteri.Sifre = txtSifre.Text;

                // 3. Veritabanına Ekle
                // (Eğer kullanıcı adı alınmışsa Manager hata fırlatır, catch yakalar)
                kManager.Ekle(yeniMusteri);

                MessageBox.Show("Kayıt Başarılı! Giriş yapabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Giriş Ekranına Yönlendir
                frmGiris frm = new frmGiris();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Hata varsa (Örn: Kullanıcı adı doluysa) mesaj göster
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // ==========================================
        //           NAVİGASYON (GERİ DÖN)
        // ==========================================
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            frmGiris frm = new frmGiris();
            frm.Show();
            this.Hide();
        }


        // ==========================================
        //              ÇIKIŞ İŞLEMİ
        // ==========================================
        private void frmKayitOl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmKayitOl_Load(object sender, EventArgs e)
        {
            // Yüklenme anında yapılacak bir işlem yok.
        }
    }
}