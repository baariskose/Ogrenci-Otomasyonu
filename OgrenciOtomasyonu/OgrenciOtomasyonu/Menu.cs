using OgrenciOtomasyonu.AlinanDersler;
using OgrenciOtomasyonu.BolumlerBilgi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciOtomasyonu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            OgrenciKayit ogrenciKayit = new OgrenciKayit();
            this.Hide();
            ogrenciKayit.Show();
        }

        private void btnBolum_Click(object sender, EventArgs e)
        {
            BolumBilgi bolumBilgi = new BolumBilgi();
            this.Hide();
            bolumBilgi.Show();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {

        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {

        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            Notlandirma notlandirma = new Notlandirma();
            this.Hide();
            notlandirma.Show();
        }

        private void btnHakkımda_Click(object sender, EventArgs e)
        {
            Hakkımızda hakkımızda = new Hakkımızda();
            this.Hide();
            hakkımızda.Show();

        }
    }
}
