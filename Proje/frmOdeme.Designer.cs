namespace Proje
{
    partial class frmOdeme
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskCVC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskAyYil = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskKartNo = new System.Windows.Forms.MaskedTextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.lblToplamTutar);
            this.panel1.Controls.Add(this.lblFilmAdi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(327, 30);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(145, 31);
            this.lblToplamTutar.TabIndex = 1;
            this.lblToplamTutar.Text = "150.00 TL";
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmAdi.Location = new System.Drawing.Point(3, 30);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(87, 24);
            this.lblFilmAdi.TabIndex = 0;
            this.lblFilmAdi.Text = "Film Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mskCVC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.mskAyYil);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskKartNo);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 250);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kredi Kartı Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "CVC:";
            // 
            // mskCVC
            // 
            this.mskCVC.Location = new System.Drawing.Point(178, 164);
            this.mskCVC.Mask = "000";
            this.mskCVC.Name = "mskCVC";
            this.mskCVC.Size = new System.Drawing.Size(167, 26);
            this.mskCVC.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Son Kullanma (Ay/Yıl):";
            // 
            // mskAyYil
            // 
            this.mskAyYil.Location = new System.Drawing.Point(178, 124);
            this.mskAyYil.Mask = "00/00";
            this.mskAyYil.Name = "mskAyYil";
            this.mskAyYil.Size = new System.Drawing.Size(167, 26);
            this.mskAyYil.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kart Numarası:";
            // 
            // mskKartNo
            // 
            this.mskKartNo.Location = new System.Drawing.Point(178, 79);
            this.mskKartNo.Mask = "0000-0000-0000-0000";
            this.mskKartNo.Name = "mskKartNo";
            this.mskKartNo.Size = new System.Drawing.Size(167, 26);
            this.mskKartNo.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdSoyad.Location = new System.Drawing.Point(178, 34);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(167, 26);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnOdemeYap.Location = new System.Drawing.Point(12, 405);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(193, 44);
            this.btnOdemeYap.TabIndex = 2;
            this.btnOdemeYap.Text = "ÖDEMEYİ TAMAMLA";
            this.btnOdemeYap.UseVisualStyleBackColor = false;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnIptal.Location = new System.Drawing.Point(269, 405);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(193, 44);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // frmOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOdeme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineTech - Güvenli Ödeme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOdeme_FormClosed);
            this.Load += new System.EventHandler(this.frmOdeme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblFilmAdi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskKartNo;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskCVC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskAyYil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.Button btnIptal;
    }
}