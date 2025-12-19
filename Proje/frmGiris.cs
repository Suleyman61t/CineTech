using CineTech.Library;
using System;
using System.Windows.Forms;

namespace Proje
{
    public partial class frmGiris : Form
    {
        KullaniciManager kManager = new KullaniciManager();

        public frmGiris()
        {
            InitializeComponent();
        }


        // ==========================================
        //              FORM YÜKLENME
        // ==========================================
        private void frmGiris_Load(object sender, EventArgs e)
        {
            // Form açıldığında kutuları temizle
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
        }


        // ==========================================
        //           GİRİŞ İŞLEMİ (LOGIN)
        // ==========================================
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            // 1. Veritabanından kullanıcıyı sorgula
            Kullanici girisYapan = kManager.GirisYap(txtKullaniciAdi.Text, txtSifre.Text);

            if (girisYapan != null)
            {
                // 2. Giriş başarılıysa hafızaya al (Program.cs)
                Program.MevcutKullanici = girisYapan;

                MessageBox.Show("Hoşgeldiniz: " + girisYapan.Ad + " " + girisYapan.Soyad);

                // 3. Role göre yönlendirme yap
                if (girisYapan.Rol == "Yonetici")
                {
                    frmAdminPaneli frm = new frmAdminPaneli();
                    frm.Show();
                }
                else if (girisYapan.Rol == "Personel")
                {
                    frmPersonelPaneli frm = new frmPersonelPaneli();
                    frm.Show();
                }
                else // Müşteri
                {
                    frmAnaSayfa frm = new frmAnaSayfa();
                    frm.Show();
                }

                // Giriş formunu gizle
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
            }
        }


        // ==========================================
        //           NAVİGASYON (LİNKLER)
        // ==========================================

        // Kayıt Ol Sayfasına Git
        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayitOl frm = new frmKayitOl();
            frm.Show();
            this.Hide();
        }


        // ==========================================
        //              ÇIKIŞ İŞLEMİ
        // ==========================================
        private void frmGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}