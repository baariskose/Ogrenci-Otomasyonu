namespace OgrenciOtomasyonu.DerslerBilgi
{
    partial class DersBilgi
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
            this.tbxDersKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxKredi = new System.Windows.Forms.TextBox();
            this.tbxDerslik = new System.Windows.Forms.TextBox();
            this.cbxBolum = new System.Windows.Forms.ComboBox();
            this.cbxOgretimUyesi = new System.Windows.Forms.ComboBox();
            this.dgwDersler = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxDersKodu
            // 
            this.tbxDersKodu.Location = new System.Drawing.Point(161, 57);
            this.tbxDersKodu.Name = "tbxDersKodu";
            this.tbxDersKodu.Size = new System.Drawing.Size(171, 22);
            this.tbxDersKodu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ders Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kredi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bölüm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Öğretim Üyesi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Derslik:";
            // 
            // tbxKredi
            // 
            this.tbxKredi.Location = new System.Drawing.Point(161, 116);
            this.tbxKredi.Name = "tbxKredi";
            this.tbxKredi.Size = new System.Drawing.Size(171, 22);
            this.tbxKredi.TabIndex = 7;
            // 
            // tbxDerslik
            // 
            this.tbxDerslik.Location = new System.Drawing.Point(161, 274);
            this.tbxDerslik.Name = "tbxDerslik";
            this.tbxDerslik.Size = new System.Drawing.Size(171, 22);
            this.tbxDerslik.TabIndex = 10;
            // 
            // cbxBolum
            // 
            this.cbxBolum.FormattingEnabled = true;
            this.cbxBolum.Location = new System.Drawing.Point(161, 165);
            this.cbxBolum.Name = "cbxBolum";
            this.cbxBolum.Size = new System.Drawing.Size(171, 24);
            this.cbxBolum.TabIndex = 11;
            // 
            // cbxOgretimUyesi
            // 
            this.cbxOgretimUyesi.FormattingEnabled = true;
            this.cbxOgretimUyesi.Location = new System.Drawing.Point(161, 219);
            this.cbxOgretimUyesi.Name = "cbxOgretimUyesi";
            this.cbxOgretimUyesi.Size = new System.Drawing.Size(171, 24);
            this.cbxOgretimUyesi.TabIndex = 12;
            // 
            // dgwDersler
            // 
            this.dgwDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDersler.Location = new System.Drawing.Point(360, 57);
            this.dgwDersler.Name = "dgwDersler";
            this.dgwDersler.RowTemplate.Height = 24;
            this.dgwDersler.Size = new System.Drawing.Size(498, 182);
            this.dgwDersler.TabIndex = 13;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(408, 325);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 29);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(527, 325);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(93, 29);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(657, 325);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 29);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // DersBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(870, 490);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgwDersler);
            this.Controls.Add(this.cbxOgretimUyesi);
            this.Controls.Add(this.cbxBolum);
            this.Controls.Add(this.tbxDerslik);
            this.Controls.Add(this.tbxKredi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDersKodu);
            this.Name = "DersBilgi";
            this.Text = "DersBilgi";
            this.Load += new System.EventHandler(this.DersBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxDersKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxKredi;
        private System.Windows.Forms.TextBox tbxDerslik;
        private System.Windows.Forms.ComboBox cbxBolum;
        private System.Windows.Forms.ComboBox cbxOgretimUyesi;
        private System.Windows.Forms.DataGridView dgwDersler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
    }
}