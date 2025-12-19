using CineTech.Library;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proje
{
    public partial class frmProfilim : Form
    {
        SatisManager satisManager = new SatisManager();

        public frmProfilim()
        {
            InitializeComponent();
        }


        // ==========================================
        //              FORM YÜKLENME
        // ==========================================
        private void frmProfilim_Load(object sender, EventArgs e)
        {
            try
            {
                lbBiletler.Items.Clear();

                // Giriş yapmış kullanıcı var mı kontrol et
                if (Program.MevcutKullanici != null)
                {
                    // 1. Kişisel Bilgileri Doldur
                    txtAdSoyad.Text = Program.MevcutKullanici.Ad + " " + Program.MevcutKullanici.Soyad;
                    txtSifre.Text = "******"; // Şifreyi gizli göster

                    // 2. Kullanıcının Biletlerini Çek
                    List<Bilet> benimBiletlerim = satisManager.MusteriBiletleriniGetir(Program.MevcutKullanici.ID);

                    // 3. Listeye Ekle
                    foreach (var bilet in benimBiletlerim)
                    {
                        string bilgi = string.Format("{0} | {1} {2} | Koltuk: {3} | {4} TL",
                            bilet.SeansBilgisi.FilmBilgisi.Ad,
                            bilet.SeansBilgisi.Tarih.ToShortDateString(),
                            bilet.SeansBilgisi.Saat,
                            bilet.KoltukNo,
                            bilet.Fiyat);

                        lbBiletler.Items.Add(bilgi);
                    }

                    // Hiç bilet yoksa bilgi ver
                    if (lbBiletler.Items.Count == 0)
                        lbBiletler.Items.Add("Henüz satın alınmış bir biletiniz yok.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profil bilgileri yüklenirken hata oluştu: " + ex.Message);
            }
        }


        // ==========================================
        //           GÜNCELLEME İŞLEMİ
        // ==========================================
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            // Basit Doğrulama
            if (string.IsNullOrEmpty(txtAdSoyad.Text) || !mskTelefon.MaskCompleted)
            {
                MessageBox.Show("Lütfen bilgilerinizi eksiksiz giriniz.");
                return;
            }

            // Not: Gerçek bir güncelleme için Manager'a "KullaniciGuncelle" metodu yazılmalıdır.
            // Şimdilik sadece simülasyon yapıyoruz.
            MessageBox.Show("Bilgileriniz başarıyla güncellendi!", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // ==========================================
        //           GERİ DÖN VE ÇIKIŞ
        // ==========================================
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmAnaSayfa frm = new frmAnaSayfa();
            frm.Show();
            this.Hide();
        }

        private void frmProfilim_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}