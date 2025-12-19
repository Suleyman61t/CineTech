namespace Proje
{
    partial class frmFilmYonetimi
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
            this.b = new System.Windows.Forms.GroupBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.pbAfis = new System.Windows.Forms.PictureBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFilmler = new System.Windows.Forms.DataGridView();
            this.txtFilmAra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.b.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).BeginInit();
            this.SuspendLayout();
            // 
            // b
            // 
            this.b.Controls.Add(this.btnGeriDon);
            this.b.Controls.Add(this.btnSil);
            this.b.Controls.Add(this.btnKaydet);
            this.b.Controls.Add(this.btnResimSec);
            this.b.Controls.Add(this.pbAfis);
            this.b.Controls.Add(this.txtSure);
            this.b.Controls.Add(this.label4);
            this.b.Controls.Add(this.cmbTur);
            this.b.Controls.Add(this.txtYonetmen);
            this.b.Controls.Add(this.txtFilmAdi);
            this.b.Controls.Add(this.label3);
            this.b.Controls.Add(this.label2);
            this.b.Controls.Add(this.label1);
            this.b.Location = new System.Drawing.Point(18, 18);
            this.b.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b.Name = "b";
            this.b.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.b.Size = new System.Drawing.Size(350, 434);
            this.b.TabIndex = 0;
            this.b.TabStop = false;
            this.b.Text = "Yeni Film Ekle";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.Location = new System.Drawing.Point(23, 340);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(94, 53);
            this.btnGeriDon.TabIndex = 18;
            this.btnGeriDon.Text = "< GERİ DÖN";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Black;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(23, 291);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 43);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(23, 242);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(94, 43);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.BackColor = System.Drawing.Color.Teal;
            this.btnResimSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimSec.Location = new System.Drawing.Point(23, 193);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(94, 43);
            this.btnResimSec.TabIndex = 9;
            this.btnResimSec.Text = "AFİŞ SEÇ";
            this.btnResimSec.UseVisualStyleBackColor = false;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // pbAfis
            // 
            this.pbAfis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAfis.Location = new System.Drawing.Point(135, 193);
            this.pbAfis.Name = "pbAfis";
            this.pbAfis.Size = new System.Drawing.Size(150, 200);
            this.pbAfis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAfis.TabIndex = 8;
            this.pbAfis.TabStop = false;
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(164, 161);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(121, 26);
            this.txtSure.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Süre:";
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
            "Aksiyon",
            "Dram",
            "Komedi",
            "Korku",
            "Bilim Kurgu",
            "Animasyon"});
            this.cmbTur.Location = new System.Drawing.Point(164, 118);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(121, 28);
            this.cmbTur.TabIndex = 5;
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.Location = new System.Drawing.Point(164, 80);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(121, 26);
            this.txtYonetmen.TabIndex = 4;
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Location = new System.Drawing.Point(164, 42);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(121, 26);
            this.txtFilmAdi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tür:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yönetmen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı:";
            // 
            // dgvFilmler
            // 
            this.dgvFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmler.Location = new System.Drawing.Point(412, 60);
            this.dgvFilmler.Name = "dgvFilmler";
            this.dgvFilmler.RowHeadersVisible = false;
            this.dgvFilmler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmler.Size = new System.Drawing.Size(559, 392);
            this.dgvFilmler.TabIndex = 1;
            this.dgvFilmler.SelectionChanged += new System.EventHandler(this.dgvFilmler_SelectionChanged);
            // 
            // txtFilmAra
            // 
            this.txtFilmAra.Location = new System.Drawing.Point(678, 18);
            this.txtFilmAra.Name = "txtFilmAra";
            this.txtFilmAra.Size = new System.Drawing.Size(121, 26);
            this.txtFilmAra.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Film Ara:";
            // 
            // frmFilmYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(983, 514);
            this.Controls.Add(this.txtFilmAra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvFilmler);
            this.Controls.Add(this.b);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFilmYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineTech - Film Yönetim Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFilmYonetimi_FormClosed);
            this.Load += new System.EventHandler(this.frmFilmYonetimi_Load);
            this.b.ResumeLayout(false);
            this.b.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.PictureBox pbAfis;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.DataGridView dgvFilmler;
        private System.Windows.Forms.TextBox txtFilmAra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGeriDon;
    }
}