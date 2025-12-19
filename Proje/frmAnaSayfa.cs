using CineTech.Library;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proje
{
    public partial class frmAnaSayfa : Form
    {
        FilmManager fManager = new FilmManager();

        public frmAnaSayfa()
        {
            InitializeComponent();
        }


        // ==========================================
        //              FORM YÜKLENME
        // ==========================================
        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            // Tür Filtresini Doldur
            cmbTurFiltre.Items.Clear();
            cmbTurFiltre.Items.Add("Tümü");
            cmbTurFiltre.Items.Add("Aksiyon");
            cmbTurFiltre.Items.Add("Dram");
            cmbTurFiltre.Items.Add("Komedi");
            cmbTurFiltre.Items.Add("Bilim Kurgu");
            cmbTurFiltre.Items.Add("Korku");
            cmbTurFiltre.Items.Add("Animasyon");
            cmbTurFiltre.SelectedIndex = 0;

            // Filmleri Listele
            FilmleriListele();
        }


        // ==========================================
        //           FİLM LİSTELEME MOTORU
        // ==========================================
        void FilmleriListele()
        {
            // Paneli temizle
            flpFilmler.Controls.Clear();

            var filmler = fManager.FilmleriGetir();

            string arama = txtFilmAra.Text.ToLower();
            string tur = cmbTurFiltre.Text;

            foreach (var film in filmler)
            {
                // 1. FİLTRELEME
                if (!string.IsNullOrEmpty(arama) && !film.Ad.ToLower().Contains(arama))
                    continue;

                if (tur != "Tümü" && film.Tur != tur)
                    continue;

                // 2. KART TASARIMI (GroupBox)
                GroupBox gb = new GroupBox();
                gb.Text = film.Ad;
                gb.Size = new Size(200, 320);
                gb.ForeColor = Color.White;
                gb.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                gb.Margin = new Padding(10);

                // 3. RESİM
                PictureBox pb = new PictureBox();
                pb.Size = new Size(180, 230);
                pb.Location = new Point(10, 20);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;

                if (!string.IsNullOrEmpty(film.AfisYolu))
                {
                    try { pb.ImageLocation = film.AfisYolu; }
                    catch { pb.BackColor = Color.Gray; }
                }
                else
                {
                    pb.BackColor = Color.Gray;
                }

                // 4. BUTON
                Button btn = new Button();
                btn.Text = "İNCELE / BİLET AL";
                btn.Size = new Size(180, 40);
                btn.Location = new Point(10, 260);
                btn.BackColor = Color.Orange;
                btn.ForeColor = Color.Black;
                btn.FlatStyle = FlatStyle.Flat;

                // Filmi butona sakla
                btn.Tag = film;
                btn.Click += BtnIncele_Click;

                gb.Controls.Add(pb);
                gb.Controls.Add(btn);

                flpFilmler.Controls.Add(gb);
            }
        }

        // Dinamik Buton Tıklama Olayı
        private void BtnIncele_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            Film secilenFilm = (Film)tiklanan.Tag;

            // Koltuk Seçimine Gönder
            frmKoltukSecimi frm = new frmKoltukSecimi();
            frm.SecilenFilm = secilenFilm;
            frm.Show();
        }


        // ==========================================
        //           FİLTRELEME & ARAMA
        // ==========================================
        private void txtFilmAra_TextChanged(object sender, EventArgs e)
        {
            FilmleriListele();
        }

        private void cmbTurFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilmleriListele();
        }


        // ==========================================
        //           NAVİGASYON (BUTONLAR)
        // ==========================================
        private void btnProfil_Click(object sender, EventArgs e)
        {
            frmProfilim frm = new frmProfilim();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmGiris frm = new frmGiris();
            frm.Show();
            this.Hide();
        }

        private void frmAnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}