namespace Proje
{
    partial class frmRaporlar
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblToplamHasilat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbSatislar = new System.Windows.Forms.Label();
            this.lblToplamBilet = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPopulerFilm = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chartSatislar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvSatislar = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(347, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "GENEL SATIŞ RAPORLARI";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnGeriDon.Location = new System.Drawing.Point(12, 555);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(127, 44);
            this.btnGeriDon.TabIndex = 18;
            this.btnGeriDon.Text = "< GERİ DÖN";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.lblToplamHasilat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(71, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 120);
            this.panel1.TabIndex = 19;
            // 
            // lblToplamHasilat
            // 
            this.lblToplamHasilat.AutoSize = true;
            this.lblToplamHasilat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamHasilat.ForeColor = System.Drawing.Color.Transparent;
            this.lblToplamHasilat.Location = new System.Drawing.Point(63, 58);
            this.lblToplamHasilat.Name = "lblToplamHasilat";
            this.lblToplamHasilat.Size = new System.Drawing.Size(106, 31);
            this.lblToplamHasilat.TabIndex = 21;
            this.lblToplamHasilat.Text = "0.00 TL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(55, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Toplam Hasılat";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.lbSatislar);
            this.panel2.Controls.Add(this.lblToplamBilet);
            this.panel2.Location = new System.Drawing.Point(372, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 120);
            this.panel2.TabIndex = 22;
            // 
            // lbSatislar
            // 
            this.lbSatislar.AutoSize = true;
            this.lbSatislar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSatislar.ForeColor = System.Drawing.Color.Transparent;
            this.lbSatislar.Location = new System.Drawing.Point(80, 58);
            this.lbSatislar.Name = "lbSatislar";
            this.lbSatislar.Size = new System.Drawing.Size(92, 31);
            this.lbSatislar.TabIndex = 21;
            this.lbSatislar.Text = "0 Adet";
            // 
            // lblToplamBilet
            // 
            this.lblToplamBilet.AutoSize = true;
            this.lblToplamBilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamBilet.ForeColor = System.Drawing.Color.Transparent;
            this.lblToplamBilet.Location = new System.Drawing.Point(76, 14);
            this.lblToplamBilet.Name = "lblToplamBilet";
            this.lblToplamBilet.Size = new System.Drawing.Size(96, 20);
            this.lblToplamBilet.TabIndex = 20;
            this.lblToplamBilet.Text = "Toplam Bilet";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.lblPopulerFilm);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(654, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 120);
            this.panel3.TabIndex = 23;
            // 
            // lblPopulerFilm
            // 
            this.lblPopulerFilm.AutoSize = true;
            this.lblPopulerFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPopulerFilm.ForeColor = System.Drawing.Color.Transparent;
            this.lblPopulerFilm.Location = new System.Drawing.Point(80, 64);
            this.lblPopulerFilm.Name = "lblPopulerFilm";
            this.lblPopulerFilm.Size = new System.Drawing.Size(50, 25);
            this.lblPopulerFilm.TabIndex = 21;
            this.lblPopulerFilm.Text = "Yok";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(64, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "En Popüler Film";
            // 
            // chartSatislar
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSatislar.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSatislar.Legends.Add(legend2);
            this.chartSatislar.Location = new System.Drawing.Point(12, 228);
            this.chartSatislar.Name = "chartSatislar";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartSatislar.Series.Add(series2);
            this.chartSatislar.Size = new System.Drawing.Size(950, 244);
            this.chartSatislar.TabIndex = 24;
            this.chartSatislar.Text = "chart1";
            // 
            // dgvSatislar
            // 
            this.dgvSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatislar.Location = new System.Drawing.Point(192, 503);
            this.dgvSatislar.Name = "dgvSatislar";
            this.dgvSatislar.RowHeadersVisible = false;
            this.dgvSatislar.Size = new System.Drawing.Size(613, 124);
            this.dgvSatislar.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(448, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Son Satışlar";
            // 
            // frmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(984, 639);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvSatislar);
            this.Controls.Add(this.chartSatislar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRaporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineTech - Raporlama ve Analiz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRaporlar_FormClosed);
            this.Load += new System.EventHandler(this.frmRaporlar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplamHasilat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbSatislar;
        private System.Windows.Forms.Label lblToplamBilet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPopulerFilm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSatislar;
        private System.Windows.Forms.DataGridView dgvSatislar;
        private System.Windows.Forms.Label label4;
    }
}