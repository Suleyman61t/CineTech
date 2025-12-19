namespace Proje
{
    partial class frmKoltukSecimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKoltuklar = new System.Windows.Forms.TextBox();
            this.cmbBiletTuru = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSeans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTarih = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlKoltuklar = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnGeriDon.Location = new System.Drawing.Point(12, 580);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(271, 44);
            this.btnGeriDon.TabIndex = 19;
            this.btnGeriDon.Text = "< GERİ DÖN";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblToplamTutar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKoltuklar);
            this.groupBox1.Controls.Add(this.cmbBiletTuru);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbSeans);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbTarih);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbSalon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblFilmAdi);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 500);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet Detayları";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.BackColor = System.Drawing.Color.Green;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(84, 399);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(100, 29);
            this.lblToplamTutar.TabIndex = 12;
            this.lblToplamTutar.Text = "0.00 TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "ÖDENECEK TUTAR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Seçilen Koltuk:";
            // 
            // txtKoltuklar
            // 
            this.txtKoltuklar.Location = new System.Drawing.Point(129, 253);
            this.txtKoltuklar.Name = "txtKoltuklar";
            this.txtKoltuklar.ReadOnly = true;
            this.txtKoltuklar.Size = new System.Drawing.Size(121, 26);
            this.txtKoltuklar.TabIndex = 9;
            // 
            // cmbBiletTuru
            // 
            this.cmbBiletTuru.FormattingEnabled = true;
            this.cmbBiletTuru.Items.AddRange(new object[] {
            "Tam",
            "Öğrenci"});
            this.cmbBiletTuru.Location = new System.Drawing.Point(129, 209);
            this.cmbBiletTuru.Name = "cmbBiletTuru";
            this.cmbBiletTuru.Size = new System.Drawing.Size(121, 28);
            this.cmbBiletTuru.TabIndex = 8;
            this.cmbBiletTuru.SelectedIndexChanged += new System.EventHandler(this.cmbBiletTuru_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bilet Türü:";
            // 
            // cmbSeans
            // 
            this.cmbSeans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeans.FormattingEnabled = true;
            this.cmbSeans.Location = new System.Drawing.Point(129, 162);
            this.cmbSeans.Name = "cmbSeans";
            this.cmbSeans.Size = new System.Drawing.Size(121, 28);
            this.cmbSeans.TabIndex = 6;
            this.cmbSeans.SelectedIndexChanged += new System.EventHandler(this.cmbSeans_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seans Saati:";
            // 
            // cmbTarih
            // 
            this.cmbTarih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarih.FormattingEnabled = true;
            this.cmbTarih.Location = new System.Drawing.Point(129, 117);
            this.cmbTarih.Name = "cmbTarih";
            this.cmbTarih.Size = new System.Drawing.Size(121, 28);
            this.cmbTarih.TabIndex = 4;
            this.cmbTarih.SelectedIndexChanged += new System.EventHandler(this.cmbTarih_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tarih:";
            // 
            // cmbSalon
            // 
            this.cmbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(129, 74);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(121, 28);
            this.cmbSalon.TabIndex = 2;
            this.cmbSalon.SelectedIndexChanged += new System.EventHandler(this.cmbSalon_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salon:";
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmAdi.ForeColor = System.Drawing.Color.Orange;
            this.lblFilmAdi.Location = new System.Drawing.Point(30, 37);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(144, 20);
            this.lblFilmAdi.TabIndex = 0;
            this.lblFilmAdi.Text = "Film Adı Gelecek";
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnOnayla.Location = new System.Drawing.Point(701, 580);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(271, 44);
            this.btnOnayla.TabIndex = 22;
            this.btnOnayla.Text = "ÖDEMEYE GEÇ >";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Orange;
            this.label10.Location = new System.Drawing.Point(301, 604);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "SEÇİLİ(Sizin Koltuğunuz)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(519, 604);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "BOŞ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(612, 604);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "DOLU";
            // 
            // pnlKoltuklar
            // 
            this.pnlKoltuklar.AutoScroll = true;
            this.pnlKoltuklar.BackColor = System.Drawing.Color.Gray;
            this.pnlKoltuklar.Location = new System.Drawing.Point(291, 28);
            this.pnlKoltuklar.Name = "pnlKoltuklar";
            this.pnlKoltuklar.Size = new System.Drawing.Size(681, 519);
            this.pnlKoltuklar.TabIndex = 30;
            // 
            // frmKoltukSecimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pnlKoltuklar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGeriDon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "frmKoltukSecimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineTech - Koltuk Seçimi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKoltukSecimi_FormClosed);
            this.Load += new System.EventHandler(this.frmKoltukSecimi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBiletTuru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSeans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSalon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFilmAdi;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKoltuklar;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel pnlKoltuklar;
    }
}