namespace Proje
{
    partial class frmAdminPaneli
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilmIslemleri = new System.Windows.Forms.Button();
            this.btnPersonelIslemleri = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(267, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "YÖNETİM PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(655, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hoşgeldin, Admin";
            // 
            // btnFilmIslemleri
            // 
            this.btnFilmIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.btnFilmIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmIslemleri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilmIslemleri.Location = new System.Drawing.Point(132, 101);
            this.btnFilmIslemleri.Name = "btnFilmIslemleri";
            this.btnFilmIslemleri.Size = new System.Drawing.Size(205, 132);
            this.btnFilmIslemleri.TabIndex = 3;
            this.btnFilmIslemleri.Text = "FİLM İŞLEMLERİ";
            this.btnFilmIslemleri.UseVisualStyleBackColor = false;
            this.btnFilmIslemleri.Click += new System.EventHandler(this.btnFilmIslemleri_Click);
            // 
            // btnPersonelIslemleri
            // 
            this.btnPersonelIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(203)))), ((int)(((byte)(110)))));
            this.btnPersonelIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelIslemleri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPersonelIslemleri.Location = new System.Drawing.Point(132, 262);
            this.btnPersonelIslemleri.Name = "btnPersonelIslemleri";
            this.btnPersonelIslemleri.Size = new System.Drawing.Size(205, 132);
            this.btnPersonelIslemleri.TabIndex = 4;
            this.btnPersonelIslemleri.Text = "PERSONEL\r\nİŞLEMLERİ";
            this.btnPersonelIslemleri.UseVisualStyleBackColor = false;
            this.btnPersonelIslemleri.Click += new System.EventHandler(this.btnPersonelIslemleri_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnRaporlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaporlar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRaporlar.Location = new System.Drawing.Point(439, 101);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(205, 132);
            this.btnRaporlar.TabIndex = 5;
            this.btnRaporlar.Text = "RAPORLAR";
            this.btnRaporlar.UseVisualStyleBackColor = false;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Gray;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCikis.Location = new System.Drawing.Point(439, 262);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(205, 132);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "OTURUMU KAPAT";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // frmAdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnPersonelIslemleri);
            this.Controls.Add(this.btnFilmIslemleri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAdminPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineTech - Yönetici Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminPaneli_FormClosed);
            this.Load += new System.EventHandler(this.frmAdminPaneli_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFilmIslemleri;
        private System.Windows.Forms.Button btnPersonelIslemleri;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnCikis;
    }
}