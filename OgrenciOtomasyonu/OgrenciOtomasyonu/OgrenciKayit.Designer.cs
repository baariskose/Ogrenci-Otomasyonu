namespace OgrenciOtomasyonu
{
    partial class OgrenciKayit
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
            this.tabContOgrenciBilgi = new System.Windows.Forms.TabControl();
            this.OgrenciBilgi = new System.Windows.Forms.TabPage();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxOrtalama = new System.Windows.Forms.TextBox();
            this.cbxDersler = new System.Windows.Forms.ComboBox();
            this.checkCap = new System.Windows.Forms.CheckBox();
            this.cbxBolum = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTelefon = new System.Windows.Forms.TextBox();
            this.tbxSoyisim = new System.Windows.Forms.TextBox();
            this.tbxIsim = new System.Windows.Forms.TextBox();
            this.tbxTC = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.tbxOgrenciNo = new System.Windows.Forms.TextBox();
            this.ogrenciVeri = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxOgrenciNoFilter = new System.Windows.Forms.TextBox();
            this.btnSıfırla = new System.Windows.Forms.Button();
            this.cbxBolumFiltre = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgwOgrenciler = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.tabContOgrenciBilgi.SuspendLayout();
            this.OgrenciBilgi.SuspendLayout();
            this.ogrenciVeri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContOgrenciBilgi
            // 
            this.tabContOgrenciBilgi.Controls.Add(this.OgrenciBilgi);
            this.tabContOgrenciBilgi.Controls.Add(this.ogrenciVeri);
            this.tabContOgrenciBilgi.Location = new System.Drawing.Point(3, 12);
            this.tabContOgrenciBilgi.Name = "tabContOgrenciBilgi";
            this.tabContOgrenciBilgi.SelectedIndex = 0;
            this.tabContOgrenciBilgi.Size = new System.Drawing.Size(823, 464);
            this.tabContOgrenciBilgi.TabIndex = 0;
            // 
            // OgrenciBilgi
            // 
            this.OgrenciBilgi.Controls.Add(this.btnBack);
            this.OgrenciBilgi.Controls.Add(this.btnDersEkle);
            this.OgrenciBilgi.Controls.Add(this.btnGuncelle);
            this.OgrenciBilgi.Controls.Add(this.btnEkle);
            this.OgrenciBilgi.Controls.Add(this.tbxSifre);
            this.OgrenciBilgi.Controls.Add(this.label1);
            this.OgrenciBilgi.Controls.Add(this.tbxOrtalama);
            this.OgrenciBilgi.Controls.Add(this.cbxDersler);
            this.OgrenciBilgi.Controls.Add(this.checkCap);
            this.OgrenciBilgi.Controls.Add(this.cbxBolum);
            this.OgrenciBilgi.Controls.Add(this.label9);
            this.OgrenciBilgi.Controls.Add(this.label8);
            this.OgrenciBilgi.Controls.Add(this.label7);
            this.OgrenciBilgi.Controls.Add(this.label6);
            this.OgrenciBilgi.Controls.Add(this.label5);
            this.OgrenciBilgi.Controls.Add(this.label4);
            this.OgrenciBilgi.Controls.Add(this.label3);
            this.OgrenciBilgi.Controls.Add(this.label2);
            this.OgrenciBilgi.Controls.Add(this.tbxTelefon);
            this.OgrenciBilgi.Controls.Add(this.tbxSoyisim);
            this.OgrenciBilgi.Controls.Add(this.tbxIsim);
            this.OgrenciBilgi.Controls.Add(this.tbxTC);
            this.OgrenciBilgi.Controls.Add(this.lbl);
            this.OgrenciBilgi.Controls.Add(this.tbxOgrenciNo);
            this.OgrenciBilgi.Location = new System.Drawing.Point(4, 25);
            this.OgrenciBilgi.Name = "OgrenciBilgi";
            this.OgrenciBilgi.Padding = new System.Windows.Forms.Padding(3);
            this.OgrenciBilgi.Size = new System.Drawing.Size(815, 435);
            this.OgrenciBilgi.TabIndex = 0;
            this.OgrenciBilgi.Text = "Öğrenci Bilgisi";
            this.OgrenciBilgi.UseVisualStyleBackColor = true;
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(727, 33);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(82, 24);
            this.btnDersEkle.TabIndex = 43;
            this.btnDersEkle.Text = "Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.Location = new System.Drawing.Point(634, 258);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(89, 55);
            this.btnGuncelle.TabIndex = 42;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(492, 261);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(92, 55);
            this.btnEkle.TabIndex = 41;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tbxSifre
            // 
            this.tbxSifre.Location = new System.Drawing.Point(492, 145);
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.Size = new System.Drawing.Size(122, 22);
            this.tbxSifre.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(359, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Sifre:";
            // 
            // tbxOrtalama
            // 
            this.tbxOrtalama.Location = new System.Drawing.Point(492, 91);
            this.tbxOrtalama.Name = "tbxOrtalama";
            this.tbxOrtalama.Size = new System.Drawing.Size(122, 22);
            this.tbxOrtalama.TabIndex = 38;
            // 
            // cbxDersler
            // 
            this.cbxDersler.FormattingEnabled = true;
            this.cbxDersler.Location = new System.Drawing.Point(492, 33);
            this.cbxDersler.Name = "cbxDersler";
            this.cbxDersler.Size = new System.Drawing.Size(231, 24);
            this.cbxDersler.TabIndex = 37;
            // 
            // checkCap
            // 
            this.checkCap.AutoSize = true;
            this.checkCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkCap.Location = new System.Drawing.Point(173, 379);
            this.checkCap.Name = "checkCap";
            this.checkCap.Size = new System.Drawing.Size(64, 24);
            this.checkCap.TabIndex = 36;
            this.checkCap.Text = "Evet";
            this.checkCap.UseVisualStyleBackColor = true;
            this.checkCap.Click += new System.EventHandler(this.checkCap_Click);
            // 
            // cbxBolum
            // 
            this.cbxBolum.FormattingEnabled = true;
            this.cbxBolum.Location = new System.Drawing.Point(171, 258);
            this.cbxBolum.Name = "cbxBolum";
            this.cbxBolum.Size = new System.Drawing.Size(231, 24);
            this.cbxBolum.TabIndex = 35;
            this.cbxBolum.SelectedIndexChanged += new System.EventHandler(this.cbxBolum_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(359, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Genel Ortalama:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(359, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Dersler:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(38, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "ÇAP Öğrecisi Mi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(38, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Telefon No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Bölüm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Soyisim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "İsim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Öğrenci TC:";
            // 
            // tbxTelefon
            // 
            this.tbxTelefon.Location = new System.Drawing.Point(171, 314);
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(100, 22);
            this.tbxTelefon.TabIndex = 26;
            // 
            // tbxSoyisim
            // 
            this.tbxSoyisim.Location = new System.Drawing.Point(171, 202);
            this.tbxSoyisim.Name = "tbxSoyisim";
            this.tbxSoyisim.Size = new System.Drawing.Size(100, 22);
            this.tbxSoyisim.TabIndex = 25;
            // 
            // tbxIsim
            // 
            this.tbxIsim.Location = new System.Drawing.Point(171, 148);
            this.tbxIsim.Name = "tbxIsim";
            this.tbxIsim.Size = new System.Drawing.Size(100, 22);
            this.tbxIsim.TabIndex = 24;
            // 
            // tbxTC
            // 
            this.tbxTC.Location = new System.Drawing.Point(171, 91);
            this.tbxTC.Name = "tbxTC";
            this.tbxTC.Size = new System.Drawing.Size(100, 22);
            this.tbxTC.TabIndex = 23;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(38, 38);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(95, 17);
            this.lbl.TabIndex = 22;
            this.lbl.Text = "Öğrenci No:";
            // 
            // tbxOgrenciNo
            // 
            this.tbxOgrenciNo.Location = new System.Drawing.Point(171, 33);
            this.tbxOgrenciNo.Name = "tbxOgrenciNo";
            this.tbxOgrenciNo.Size = new System.Drawing.Size(100, 22);
            this.tbxOgrenciNo.TabIndex = 21;
            // 
            // ogrenciVeri
            // 
            this.ogrenciVeri.Controls.Add(this.label11);
            this.ogrenciVeri.Controls.Add(this.label10);
            this.ogrenciVeri.Controls.Add(this.tbxOgrenciNoFilter);
            this.ogrenciVeri.Controls.Add(this.btnSıfırla);
            this.ogrenciVeri.Controls.Add(this.cbxBolumFiltre);
            this.ogrenciVeri.Controls.Add(this.btnSil);
            this.ogrenciVeri.Controls.Add(this.dgwOgrenciler);
            this.ogrenciVeri.Location = new System.Drawing.Point(4, 25);
            this.ogrenciVeri.Name = "ogrenciVeri";
            this.ogrenciVeri.Padding = new System.Windows.Forms.Padding(3);
            this.ogrenciVeri.Size = new System.Drawing.Size(815, 435);
            this.ogrenciVeri.TabIndex = 1;
            this.ogrenciVeri.Text = "Öğrenci Veriler";
            this.ogrenciVeri.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(349, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(220, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "Öğrenci Numarasına Göre Filtrele:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Bölüme Göre Filtrele:";
            // 
            // tbxOgrenciNoFilter
            // 
            this.tbxOgrenciNoFilter.Location = new System.Drawing.Point(352, 51);
            this.tbxOgrenciNoFilter.Name = "tbxOgrenciNoFilter";
            this.tbxOgrenciNoFilter.Size = new System.Drawing.Size(164, 22);
            this.tbxOgrenciNoFilter.TabIndex = 47;
            this.tbxOgrenciNoFilter.TextChanged += new System.EventHandler(this.tbxOgrenciNoFilter_TextChanged);
            // 
            // btnSıfırla
            // 
            this.btnSıfırla.BackColor = System.Drawing.Color.White;
            this.btnSıfırla.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSıfırla.Location = new System.Drawing.Point(653, 51);
            this.btnSıfırla.Name = "btnSıfırla";
            this.btnSıfırla.Size = new System.Drawing.Size(84, 34);
            this.btnSıfırla.TabIndex = 46;
            this.btnSıfırla.Text = "Sıfırla";
            this.btnSıfırla.UseVisualStyleBackColor = false;
            this.btnSıfırla.Click += new System.EventHandler(this.btnSıfırla_Click);
            // 
            // cbxBolumFiltre
            // 
            this.cbxBolumFiltre.FormattingEnabled = true;
            this.cbxBolumFiltre.Location = new System.Drawing.Point(24, 51);
            this.cbxBolumFiltre.Name = "cbxBolumFiltre";
            this.cbxBolumFiltre.Size = new System.Drawing.Size(228, 24);
            this.cbxBolumFiltre.TabIndex = 45;
            this.cbxBolumFiltre.SelectedIndexChanged += new System.EventHandler(this.cbxBolumFiltre_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Font = new System.Drawing.Font("Rockwell", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(633, 366);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(82, 33);
            this.btnSil.TabIndex = 42;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgwOgrenciler
            // 
            this.dgwOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgrenciler.Location = new System.Drawing.Point(24, 114);
            this.dgwOgrenciler.Name = "dgwOgrenciler";
            this.dgwOgrenciler.RowTemplate.Height = 24;
            this.dgwOgrenciler.Size = new System.Drawing.Size(728, 219);
            this.dgwOgrenciler.TabIndex = 0;
            this.dgwOgrenciler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOgrenciler_CellClick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.BackgroundImage = global::OgrenciOtomasyonu.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Location = new System.Drawing.Point(727, 363);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 66);
            this.btnBack.TabIndex = 44;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // OgrenciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 474);
            this.Controls.Add(this.tabContOgrenciBilgi);
            this.Name = "OgrenciKayit";
            this.Text = "OgrenciKayit";
            this.Load += new System.EventHandler(this.OgrenciKayit_Load);
            this.tabContOgrenciBilgi.ResumeLayout(false);
            this.OgrenciBilgi.ResumeLayout(false);
            this.OgrenciBilgi.PerformLayout();
            this.ogrenciVeri.ResumeLayout(false);
            this.ogrenciVeri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenciler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContOgrenciBilgi;
        private System.Windows.Forms.TabPage OgrenciBilgi;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxOrtalama;
        private System.Windows.Forms.ComboBox cbxDersler;
        private System.Windows.Forms.CheckBox checkCap;
        private System.Windows.Forms.ComboBox cbxBolum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTelefon;
        private System.Windows.Forms.TextBox tbxSoyisim;
        private System.Windows.Forms.TextBox tbxIsim;
        private System.Windows.Forms.TextBox tbxTC;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tbxOgrenciNo;
        private System.Windows.Forms.TabPage ogrenciVeri;
        private System.Windows.Forms.DataGridView dgwOgrenciler;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.ComboBox cbxBolumFiltre;
        private System.Windows.Forms.Button btnSıfırla;
        private System.Windows.Forms.TextBox tbxOgrenciNoFilter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBack;
    }
}