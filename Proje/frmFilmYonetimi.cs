using CineTech.Library;
using Proje;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proje
{
    public partial class frmFilmYonetimi : Form
    {
        FilmManager fManager = new FilmManager();
        string resimDosyaYolu = "";

        public frmFilmYonetimi()
        {
            InitializeComponent();
        }


        // ==========================================
        //              FORM YÜKLENME
        // ==========================================
        private void frmFilmYonetimi_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Grid Ayarları
                dgvFilmler.AllowUserToAddRows = false;
                dgvFilmler.AllowUserToDeleteRows = false;
                dgvFilmler.ReadOnly = true;
                dgvFilmler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvFilmler.MultiSelect = false;
                dgvFilmler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvFilmler.RowHeadersVisible = false;

                // 2. Tür Combobox Doldurma
                cmbTur.Items.Clear();
                cmbTur.Items.AddRange(new string[] { "Aksiyon", "Dram", "Komedi", "Korku", "Bilim Kurgu", "Animasyon" });
                cmbTur.SelectedIndex = 0;

                // 3. Verileri Listele
                ListeyiYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // ==========================================
        //           LİSTELEME & TEMİZLEME
        // ==========================================
        void ListeyiYenile()
        {
            try
            {
                // Seçim olayını geçici olarak kapat (Hata almamak için)
                dgvFilmler.SelectionChanged -= dgvFilmler_SelectionChanged;

                dgvFilmler.DataSource = null;
                dgvFilmler.DataSource = fManager.FilmleriGetir();

                // Gereksiz Kolonları Gizle
                if (dgvFilmler.Columns["AfisYolu"] != null) dgvFilmler.Columns["AfisYolu"].Visible = false;
                if (dgvFilmler.Columns["ID"] != null) dgvFilmler.Columns["ID"].Visible = false;
                if (dgvFilmler.Columns["KayitTarihi"] != null) dgvFilmler.Columns["KayitTarihi"].Visible = false;

                dgvFilmler.ClearSelection();
                Temizle();

                // Olayı geri aç
                dgvFilmler.SelectionChanged += dgvFilmler_SelectionChanged;
            }
            catch { }
        }

        void Temizle()
        {
            txtFilmAdi.Clear();
            txtYonetmen.Clear();
            txtSure.Clear();
            pbAfis.Image = null;
            resimDosyaYolu = "";
        }


        // ==========================================
        //              BUTON İŞLEMLERİ
        // ==========================================

        // 1. FİLM KAYDET
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Boşluk Kontrolü
                if (string.IsNullOrWhiteSpace(txtFilmAdi.Text) || string.IsNullOrWhiteSpace(txtSure.Text))
                {
                    MessageBox.Show("Lütfen Film Adı ve Süresini giriniz.");
                    return;
                }

                // Sayısal Değer Kontrolü
                if (!int.TryParse(txtSure.Text, out int sure))
                {
                    MessageBox.Show("Süre sadece sayı olmalıdır.");
                    return;
                }

                Film yeniFilm = new Film
                {
                    Ad = txtFilmAdi.Text,
                    Yonetmen = txtYonetmen.Text,
                    Tur = cmbTur.Text,
                    Sure = sure,
                    AfisYolu = resimDosyaYolu
                };

                fManager.FilmEkle(yeniFilm);

                MessageBox.Show("Film başarıyla eklendi.");
                ListeyiYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 2. FİLM SİL
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFilmler.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silinecek filmi seçin.");
                    return;
                }

                if (dgvFilmler.SelectedRows[0].DataBoundItem == null) return;

                Film secilen = (Film)dgvFilmler.SelectedRows[0].DataBoundItem;

                fManager.FilmSil(secilen.Ad);

                MessageBox.Show("Film silindi.");
                ListeyiYenile();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 3. AFİŞ RESMİ SEÇ
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png"
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbAfis.ImageLocation = ofd.FileName;
                    resimDosyaYolu = ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 4. GERİ DÖN
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            frmAdminPaneli frm = new frmAdminPaneli();
            frm.Show();
            this.Hide();
        }


        // ==========================================
        //           GRID SEÇİM DEĞİŞİKLİĞİ
        // ==========================================
        private void dgvFilmler_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvFilmler.SelectedRows.Count == 0) return;

                DataGridViewRow satir = dgvFilmler.SelectedRows[0];
                if (satir.DataBoundItem == null) return;

                Film secilenData = (Film)satir.DataBoundItem;

                // Bilgileri Kutulara Doldur
                txtFilmAdi.Text = secilenData.Ad;
                txtYonetmen.Text = secilenData.Yonetmen;
                txtSure.Text = secilenData.Sure.ToString();
                cmbTur.Text = secilenData.Tur;

                // Resmi Göster
                if (!string.IsNullOrEmpty(secilenData.AfisYolu))
                {
                    try
                    {
                        pbAfis.ImageLocation = secilenData.AfisYolu;
                        resimDosyaYolu = secilenData.AfisYolu;
                    }
                    catch
                    {
                        pbAfis.Image = null;
                    }
                }
                else
                {
                    pbAfis.Image = null;
                    resimDosyaYolu = "";
                }
            }
            catch { }
        }


        // ==========================================
        //              ÇIKIŞ İŞLEMİ
        // ==========================================
        private void frmFilmYonetimi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}