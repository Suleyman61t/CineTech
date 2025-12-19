namespace Proje
{
    partial class frmSalonDurumu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDoluluk = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSeans = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBakim = new System.Windows.Forms.Button();
            this.pnlKoltuklar = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnGeriDon.Location = new System.Drawing.Point(26, 362);
            this.btnGeriDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(288, 68);
            this.btnGeriDon.TabIndex = 18;
            this.btnGeriDon.Text = "< GERİ DÖN";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnGeriDon);
            this.groupBox1.Controls.Add(this.cmbSeans);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbSalon);
            this.groupBox1.Controls.Add(this.cmbFilm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(353, 450);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Görüntüleme Seçenekleri";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.lblDoluluk);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(38, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 100);
            this.panel1.TabIndex = 27;
            // 
            // lblDoluluk
            // 
            this.lblDoluluk.AutoSize = true;
            this.lblDoluluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoluluk.Location = new System.Drawing.Point(31, 41);
            this.lblDoluluk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoluluk.Name = "lblDoluluk";
            this.lblDoluluk.Size = new System.Drawing.Size(55, 31);
            this.lblDoluluk.TabIndex = 29;
            this.lblDoluluk.Text = "%0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "DOLULUK ORANI";
            // 
            // cmbSeans
            // 
            this.cmbSeans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeans.FormattingEnabled = true;
            this.cmbSeans.Location = new System.Drawing.Point(134, 147);
            this.cmbSeans.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSeans.Name = "cmbSeans";
            this.cmbSeans.Size = new System.Drawing.Size(180, 28);
            this.cmbSeans.TabIndex = 26;
            this.cmbSeans.SelectedIndexChanged += new System.EventHandler(this.cmbSeans_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Seans Saati:";
            // 
            // cmbSalon
            // 
            this.cmbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(134, 94);
            this.cmbSalon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(180, 28);
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
            this.cmbFilm.Location = new System.Drawing.Point(134, 41);
            this.cmbFilm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(180, 28);
            this.cmbFilm.TabIndex = 23;
            this.cmbFilm.SelectedIndexChanged += new System.EventHandler(this.cmbFilm_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Film Seç:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Salon Seç:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Orange;
            this.label10.Location = new System.Drawing.Point(652, 557);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "SEÇİLİ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(778, 557);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "BOŞ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(879, 557);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "DOLU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(972, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "ARIZALI";
            // 
            // btnBakim
            // 
            this.btnBakim.BackColor = System.Drawing.Color.Orange;
            this.btnBakim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBakim.Location = new System.Drawing.Point(18, 503);
            this.btnBakim.Name = "btnBakim";
            this.btnBakim.Size = new System.Drawing.Size(353, 74);
            this.btnBakim.TabIndex = 32;
            this.btnBakim.Text = "KOLTUĞU BAKIMA AL / AÇ";
            this.btnBakim.UseVisualStyleBackColor = false;
            this.btnBakim.Click += new System.EventHandler(this.btnBakim_Click);
            // 
            // pnlKoltuklar
            // 
            this.pnlKoltuklar.AutoScroll = true;
            this.pnlKoltuklar.BackColor = System.Drawing.Color.Gray;
            this.pnlKoltuklar.Location = new System.Drawing.Point(396, 18);
            this.pnlKoltuklar.Name = "pnlKoltuklar";
            this.pnlKoltuklar.Size = new System.Drawing.Size(681, 519);
            this.pnlKoltuklar.TabIndex = 33;
            // 
            // frmSalonDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1089, 611);
            this.Controls.Add(this.pnlKoltuklar);
            this.Controls.Add(this.btnBakim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSalonDurumu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineTech - Salon ve Koltuk Durumu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSalonDurumu_FormClosed);
            this.Load += new System.EventHandler(this.frmSalonDurumu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSeans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSalon;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDoluluk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBakim;
        private System.Windows.Forms.FlowLayoutPanel pnlKoltuklar;
    }
}