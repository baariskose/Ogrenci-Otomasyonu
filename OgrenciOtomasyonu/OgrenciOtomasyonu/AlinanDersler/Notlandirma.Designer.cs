namespace OgrenciOtomasyonu.AlinanDersler
{
    partial class Notlandirma
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGenelOrt = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Vize = new System.Windows.Forms.Label();
            this.tbxOrtlama = new System.Windows.Forms.TextBox();
            this.tbxFinal = new System.Windows.Forms.TextBox();
            this.tbxVize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDersler = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTelefon = new System.Windows.Forms.TextBox();
            this.tbxSoyad = new System.Windows.Forms.TextBox();
            this.tbxAd = new System.Windows.Forms.TextBox();
            this.btnOgrenciGetir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxOgrenciNo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgwDersler = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Cornsilk;
            this.tabPage1.Controls.Add(this.btnBack);
            this.tabPage1.Controls.Add(this.btnGenelOrt);
            this.tabPage1.Controls.Add(this.btnHesapla);
            this.tabPage1.Controls.Add(this.btnKaydet);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.Vize);
            this.tabPage1.Controls.Add(this.tbxOrtlama);
            this.tabPage1.Controls.Add(this.tbxFinal);
            this.tabPage1.Controls.Add(this.tbxVize);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cbxDersler);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbxTelefon);
            this.tabPage1.Controls.Add(this.tbxSoyad);
            this.tabPage1.Controls.Add(this.tbxAd);
            this.tabPage1.Controls.Add(this.btnOgrenciGetir);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbxOgrenciNo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Notlandırma";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.BackgroundImage = global::OgrenciOtomasyonu.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Location = new System.Drawing.Point(650, 167);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 66);
            this.btnBack.TabIndex = 20;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGenelOrt
            // 
            this.btnGenelOrt.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenelOrt.Location = new System.Drawing.Point(609, 293);
            this.btnGenelOrt.Name = "btnGenelOrt";
            this.btnGenelOrt.Size = new System.Drawing.Size(118, 34);
            this.btnGenelOrt.TabIndex = 19;
            this.btnGenelOrt.Text = "Bitir";
            this.btnGenelOrt.UseVisualStyleBackColor = true;
            this.btnGenelOrt.Click += new System.EventHandler(this.btnGenelOrt_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHesapla.Location = new System.Drawing.Point(252, 326);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(84, 27);
            this.btnHesapla.TabIndex = 18;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(609, 345);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(118, 34);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(15, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ortalama:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(15, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Final:";
            // 
            // Vize
            // 
            this.Vize.AutoSize = true;
            this.Vize.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Vize.Location = new System.Drawing.Point(15, 215);
            this.Vize.Name = "Vize";
            this.Vize.Size = new System.Drawing.Size(39, 16);
            this.Vize.TabIndex = 14;
            this.Vize.Text = "Vize:";
            // 
            // tbxOrtlama
            // 
            this.tbxOrtlama.Location = new System.Drawing.Point(113, 328);
            this.tbxOrtlama.Name = "tbxOrtlama";
            this.tbxOrtlama.Size = new System.Drawing.Size(133, 22);
            this.tbxOrtlama.TabIndex = 13;
            // 
            // tbxFinal
            // 
            this.tbxFinal.Location = new System.Drawing.Point(113, 269);
            this.tbxFinal.Name = "tbxFinal";
            this.tbxFinal.Size = new System.Drawing.Size(133, 22);
            this.tbxFinal.TabIndex = 12;
            // 
            // tbxVize
            // 
            this.tbxVize.Location = new System.Drawing.Point(113, 211);
            this.tbxVize.Name = "tbxVize";
            this.tbxVize.Size = new System.Drawing.Size(133, 22);
            this.tbxVize.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dersler:";
            // 
            // cbxDersler
            // 
            this.cbxDersler.FormattingEnabled = true;
            this.cbxDersler.Location = new System.Drawing.Point(113, 128);
            this.cbxDersler.Name = "cbxDersler";
            this.cbxDersler.Size = new System.Drawing.Size(176, 24);
            this.cbxDersler.TabIndex = 9;
            this.cbxDersler.SelectedIndexChanged += new System.EventHandler(this.cbxDersler_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(525, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(299, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soyisim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "İsim:";
            // 
            // tbxTelefon
            // 
            this.tbxTelefon.Location = new System.Drawing.Point(609, 55);
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(133, 22);
            this.tbxTelefon.TabIndex = 5;
            // 
            // tbxSoyad
            // 
            this.tbxSoyad.Location = new System.Drawing.Point(365, 57);
            this.tbxSoyad.Name = "tbxSoyad";
            this.tbxSoyad.Size = new System.Drawing.Size(133, 22);
            this.tbxSoyad.TabIndex = 4;
            // 
            // tbxAd
            // 
            this.tbxAd.Location = new System.Drawing.Point(113, 57);
            this.tbxAd.Name = "tbxAd";
            this.tbxAd.Size = new System.Drawing.Size(133, 22);
            this.tbxAd.TabIndex = 3;
            // 
            // btnOgrenciGetir
            // 
            this.btnOgrenciGetir.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOgrenciGetir.Location = new System.Drawing.Point(279, 6);
            this.btnOgrenciGetir.Name = "btnOgrenciGetir";
            this.btnOgrenciGetir.Size = new System.Drawing.Size(118, 23);
            this.btnOgrenciGetir.TabIndex = 2;
            this.btnOgrenciGetir.Text = "Getir";
            this.btnOgrenciGetir.UseVisualStyleBackColor = true;
            this.btnOgrenciGetir.Click += new System.EventHandler(this.btnOgrenciGetir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci no:";
            // 
            // tbxOgrenciNo
            // 
            this.tbxOgrenciNo.Location = new System.Drawing.Point(113, 6);
            this.tbxOgrenciNo.Name = "tbxOgrenciNo";
            this.tbxOgrenciNo.Size = new System.Drawing.Size(133, 22);
            this.tbxOgrenciNo.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Cornsilk;
            this.tabPage2.Controls.Add(this.dgwDersler);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dersler";
            // 
            // dgwDersler
            // 
            this.dgwDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDersler.Location = new System.Drawing.Point(6, 6);
            this.dgwDersler.Name = "dgwDersler";
            this.dgwDersler.RowTemplate.Height = 24;
            this.dgwDersler.Size = new System.Drawing.Size(766, 239);
            this.dgwDersler.TabIndex = 0;
            // 
            // Notlandirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Notlandirma";
            this.Text = "Notlandirma";
            this.Load += new System.EventHandler(this.Notlandirma_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDersler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbxAd;
        private System.Windows.Forms.Button btnOgrenciGetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxOgrenciNo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTelefon;
        private System.Windows.Forms.TextBox tbxSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxDersler;
        private System.Windows.Forms.TextBox tbxFinal;
        private System.Windows.Forms.TextBox tbxVize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Vize;
        private System.Windows.Forms.TextBox tbxOrtlama;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.DataGridView dgwDersler;
        private System.Windows.Forms.Button btnGenelOrt;
        private System.Windows.Forms.Button btnBack;
    }
}