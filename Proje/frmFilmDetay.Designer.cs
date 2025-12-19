namespace Proje
{
    partial class frmFilmDetay
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
            this.pbAfis = new System.Windows.Forms.PictureBox();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.lblYonetmen = new System.Windows.Forms.Label();
            this.lblTurSure = new System.Windows.Forms.Label();
            this.rtbOzet = new System.Windows.Forms.RichTextBox();
            this.lblPuan = new System.Windows.Forms.Label();
            this.btnBiletAl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnGeriDon.Location = new System.Drawing.Point(12, 488);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(300, 44);
            this.btnGeriDon.TabIndex = 18;
            this.btnGeriDon.Text = "< GERİ DÖN";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // pbAfis
            // 
            this.pbAfis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAfis.Location = new System.Drawing.Point(12, 12);
            this.pbAfis.Name = "pbAfis";
            this.pbAfis.Size = new System.Drawing.Size(300, 450);
            this.pbAfis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAfis.TabIndex = 19;
            this.pbAfis.TabStop = false;
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmAdi.Location = new System.Drawing.Point(318, 12);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(151, 37);
            this.lblFilmAdi.TabIndex = 20;
            this.lblFilmAdi.Text = "FİLM ADI";
            // 
            // lblYonetmen
            // 
            this.lblYonetmen.AutoSize = true;
            this.lblYonetmen.Location = new System.Drawing.Point(321, 60);
            this.lblYonetmen.Name = "lblYonetmen";
            this.lblYonetmen.Size = new System.Drawing.Size(218, 20);
            this.lblYonetmen.TabIndex = 21;
            this.lblYonetmen.Text = "Yönetmen: Christopher Nolan";
            // 
            // lblTurSure
            // 
            this.lblTurSure.AutoSize = true;
            this.lblTurSure.Location = new System.Drawing.Point(321, 97);
            this.lblTurSure.Name = "lblTurSure";
            this.lblTurSure.Size = new System.Drawing.Size(222, 20);
            this.lblTurSure.TabIndex = 22;
            this.lblTurSure.Text = "Tür: Bilim Kurgu | Süre: 148 dk";
            // 
            // rtbOzet
            // 
            this.rtbOzet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.rtbOzet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOzet.ForeColor = System.Drawing.Color.White;
            this.rtbOzet.Location = new System.Drawing.Point(325, 149);
            this.rtbOzet.Name = "rtbOzet";
            this.rtbOzet.ReadOnly = true;
            this.rtbOzet.Size = new System.Drawing.Size(419, 222);
            this.rtbOzet.TabIndex = 23;
            this.rtbOzet.Text = "Filmin konusu burada yer alacak...";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPuan.ForeColor = System.Drawing.Color.Gold;
            this.lblPuan.Location = new System.Drawing.Point(321, 374);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(115, 25);
            this.lblPuan.TabIndex = 24;
            this.lblPuan.Text = "⭐ 8.9 / 10";
            // 
            // btnBiletAl
            // 
            this.btnBiletAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnBiletAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBiletAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBiletAl.Location = new System.Drawing.Point(418, 488);
            this.btnBiletAl.Name = "btnBiletAl";
            this.btnBiletAl.Size = new System.Drawing.Size(300, 44);
            this.btnBiletAl.TabIndex = 25;
            this.btnBiletAl.Text = "BİLET AL";
            this.btnBiletAl.UseVisualStyleBackColor = false;
            this.btnBiletAl.Click += new System.EventHandler(this.btnBiletAl_Click);
            // 
            // frmFilmDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(756, 561);
            this.Controls.Add(this.btnBiletAl);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.rtbOzet);
            this.Controls.Add(this.lblTurSure);
            this.Controls.Add(this.lblYonetmen);
            this.Controls.Add(this.lblFilmAdi);
            this.Controls.Add(this.pbAfis);
            this.Controls.Add(this.btnGeriDon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFilmDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineTech - Film Detayı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFilmDetay_FormClosed);
            this.Load += new System.EventHandler(this.frmFilmDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAfis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.PictureBox pbAfis;
        private System.Windows.Forms.Label lblFilmAdi;
        private System.Windows.Forms.Label lblYonetmen;
        private System.Windows.Forms.Label lblTurSure;
        private System.Windows.Forms.RichTextBox rtbOzet;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Button btnBiletAl;
    }
}