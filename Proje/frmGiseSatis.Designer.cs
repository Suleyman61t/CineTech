namespace Proje
{
    partial class frmGiseSatis
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
            this.cmbTarife = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSeans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlKoltuklar = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.Location = new System.Drawing.Point(10, 409);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(261, 74);
            this.btnGeriDon.TabIndex = 19;
            this.btnGeriDon.Text = "< GERİ DÖN";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblToplamTutar);
            this.groupBox1.Controls.Add(this.btnGeriDon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKoltuklar);
            this.groupBox1.Controls.Add(this.cmbTarife);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbSeans);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbSalon);
            this.groupBox1.Controls.Add(this.cmbFilm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 500);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet Bilgileri";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Lime;
            this.lblToplamTutar.Location = new System.Drawing.Point(160, 272);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(92, 25);
            this.lblToplamTutar.TabIndex = 32;
            this.lblToplamTutar.Text = "0.00 TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "TOPLAM TUTAR:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Seçilen Koltuk:";
            // 
            // txtKoltuklar
            // 
            this.txtKoltuklar.Location = new System.Drawing.Point(164, 212);
            this.txtKoltuklar.Name = "txtKoltuklar";
            this.txtKoltuklar.ReadOnly = true;
            this.txtKoltuklar.Size = new System.Drawing.Size(121, 26);
            this.txtKoltuklar.TabIndex = 29;
            // 
            // cmbTarife
            // 
            this.cmbTarife.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarife.FormattingEnabled = true;
            this.cmbTarife.Items.AddRange(new object[] {
            "10:00",
            "13:00",
            "16:00",
            "19:00",
            "21:30"});
            this.cmbTarife.Location = new System.Drawing.Point(164, 163);
            this.cmbTarife.Name = "cmbTarife";
            this.cmbTarife.Size = new System.Drawing.Size(121, 28);
            this.cmbTarife.TabIndex = 28;
            this.cmbTarife.SelectedIndexChanged += new System.EventHandler(this.cmbTarife_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tarife:";
            // 
            // cmbSeans
            // 
            this.cmbSeans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeans.FormattingEnabled = true;
            this.cmbSeans.Location = new System.Drawing.Point(164, 116);
            this.cmbSeans.Name = "cmbSeans";
            this.cmbSeans.Size = new System.Drawing.Size(121, 28);
            this.cmbSeans.TabIndex = 26;
            this.cmbSeans.SelectedIndexChanged += new System.EventHandler(this.cmbSeans_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Seans Saati:";
            // 
            // cmbSalon
            // 
            this.cmbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(164, 68);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(121, 28);
            this.cmbSalon.TabIndex = 24;
            this.cmbSalon.SelectedIndexChanged += new System.EventHandler(this.cmbSalon_SelectedIndexChanged_1);
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
            this.cmbFilm.Location = new System.Drawing.Point(164, 25);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(121, 28);
            this.cmbFilm.TabIndex = 23;
            this.cmbFilm.SelectedIndexChanged += new System.EventHandler(this.cmbFilm_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Film Seç:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Salon Seç:";
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSatisYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatisYap.Location = new System.Drawing.Point(37, 537);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(261, 74);
            this.btnSatisYap.TabIndex = 22;
            this.btnSatisYap.Text = "SATIŞI ONAYLA";
            this.btnSatisYap.UseVisualStyleBackColor = false;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Maroon;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(368, 537);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(261, 74);
            this.btnTemizle.TabIndex = 23;
            this.btnTemizle.Text = "İPTAL / TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(916, 591);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "DOLU";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(815, 591);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "BOŞ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Orange;
            this.label10.Location = new System.Drawing.Point(689, 591);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "SEÇİLİ";
            // 
            // pnlKoltuklar
            // 
            this.pnlKoltuklar.AutoScroll = true;
            this.pnlKoltuklar.BackColor = System.Drawing.Color.Gray;
            this.pnlKoltuklar.Location = new System.Drawing.Point(368, 12);
            this.pnlKoltuklar.Name = "pnlKoltuklar";
            this.pnlKoltuklar.Size = new System.Drawing.Size(681, 519);
            this.pnlKoltuklar.TabIndex = 27;
            // 
            // frmGiseSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.pnlKoltuklar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGiseSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineTech - Gişe Satış Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGiseSatis_FormClosed);
            this.Load += new System.EventHandler(this.frmGiseSatis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSalon;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKoltuklar;
        private System.Windows.Forms.ComboBox cmbTarife;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSeans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.FlowLayoutPanel pnlKoltuklar;
    }
}