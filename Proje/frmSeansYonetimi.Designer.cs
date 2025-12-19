namespace Proje
{
    partial class frmSeansYonetimi
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
            this.a = new System.Windows.Forms.GroupBox();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSeanslar = new System.Windows.Forms.DataGridView();
            this.a.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeanslar)).BeginInit();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Controls.Add(this.cmbSaat);
            this.a.Controls.Add(this.dtpTarih);
            this.a.Controls.Add(this.cmbSalon);
            this.a.Controls.Add(this.btnGeriDon);
            this.a.Controls.Add(this.cmbFilm);
            this.a.Controls.Add(this.btnEkle);
            this.a.Controls.Add(this.label4);
            this.a.Controls.Add(this.label3);
            this.a.Controls.Add(this.label2);
            this.a.Controls.Add(this.label1);
            this.a.ForeColor = System.Drawing.Color.White;
            this.a.Location = new System.Drawing.Point(13, 27);
            this.a.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.a.Name = "a";
            this.a.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.a.Size = new System.Drawing.Size(350, 434);
            this.a.TabIndex = 1;
            this.a.TabStop = false;
            this.a.Text = "Yeni Seans Oluştur";
            // 
            // cmbSaat
            // 
            this.cmbSaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.Items.AddRange(new object[] {
            "10:00",
            "13:00",
            "16:00",
            "19:00",
            "21:30"});
            this.cmbSaat.Location = new System.Drawing.Point(164, 158);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(121, 28);
            this.cmbSaat.TabIndex = 21;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(164, 118);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(121, 26);
            this.dtpTarih.TabIndex = 20;
            // 
            // cmbSalon
            // 
            this.cmbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(164, 77);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(121, 28);
            this.cmbSalon.TabIndex = 19;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.Location = new System.Drawing.Point(24, 366);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(261, 43);
            this.btnGeriDon.TabIndex = 18;
            this.btnGeriDon.Text = "< GERİ DÖN";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // cmbFilm
            // 
            this.cmbFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Items.AddRange(new object[] {
            "Aksiyon",
            "Dram",
            "Komedi",
            "Korku",
            "Bilim Kurgu",
            "Animasyon"});
            this.cmbFilm.Location = new System.Drawing.Point(164, 34);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(121, 28);
            this.cmbFilm.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(23, 317);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(262, 43);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "SEANS EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salon Seç:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Seç:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(564, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Güncel Seans Listesi";
            // 
            // dgvSeanslar
            // 
            this.dgvSeanslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeanslar.Location = new System.Drawing.Point(394, 61);
            this.dgvSeanslar.Name = "dgvSeanslar";
            this.dgvSeanslar.RowHeadersVisible = false;
            this.dgvSeanslar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeanslar.Size = new System.Drawing.Size(463, 400);
            this.dgvSeanslar.TabIndex = 23;
            // 
            // frmSeansYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.dgvSeanslar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.a);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSeansYonetimi";
            this.Text = "CineTech - Seans Yönetimi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSeansYonetimi_FormClosed);
            this.Load += new System.EventHandler(this.frmSeansYonetimi_Load);
            this.a.ResumeLayout(false);
            this.a.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeanslar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox a;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.ComboBox cmbSalon;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSeanslar;
    }
}