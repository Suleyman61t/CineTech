namespace Proje
{
    partial class frmAnaSayfa
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
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilmAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbTurFiltre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flpFilmler = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btnProfil);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFilmAra);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 70);
            this.panel1.TabIndex = 0;
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.btnProfil.Location = new System.Drawing.Point(945, 9);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(85, 45);
            this.btnProfil.TabIndex = 3;
            this.btnProfil.Text = "PROFİLİM";
            this.btnProfil.UseVisualStyleBackColor = false;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Black;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(1036, 9);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(40, 45);
            this.btnCikis.TabIndex = 20;
            this.btnCikis.Text = "X";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(312, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ara";
            // 
            // txtFilmAra
            // 
            this.txtFilmAra.Location = new System.Drawing.Point(381, 14);
            this.txtFilmAra.Name = "txtFilmAra";
            this.txtFilmAra.Size = new System.Drawing.Size(300, 26);
            this.txtFilmAra.TabIndex = 1;
            this.txtFilmAra.TextChanged += new System.EventHandler(this.txtFilmAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CineTech";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(76)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.cmbTurFiltre);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 50);
            this.panel2.TabIndex = 21;
            // 
            // cmbTurFiltre
            // 
            this.cmbTurFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurFiltre.FormattingEnabled = true;
            this.cmbTurFiltre.Items.AddRange(new object[] {
            "Tümü",
            "Aksiyon",
            "Komedi",
            "Dram",
            "Bilim Kurgu"});
            this.cmbTurFiltre.Location = new System.Drawing.Point(100, 14);
            this.cmbTurFiltre.Name = "cmbTurFiltre";
            this.cmbTurFiltre.Size = new System.Drawing.Size(121, 28);
            this.cmbTurFiltre.TabIndex = 5;
            this.cmbTurFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbTurFiltre_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tür Seçin:";
            // 
            // flpFilmler
            // 
            this.flpFilmler.AutoScroll = true;
            this.flpFilmler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFilmler.Location = new System.Drawing.Point(0, 120);
            this.flpFilmler.Name = "flpFilmler";
            this.flpFilmler.Size = new System.Drawing.Size(1084, 541);
            this.flpFilmler.TabIndex = 22;
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.flpFilmler);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CineTech - Vizyondaki Filmler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAnaSayfa_FormClosed);
            this.Load += new System.EventHandler(this.frmAnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilmAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbTurFiltre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpFilmler;
    }
}