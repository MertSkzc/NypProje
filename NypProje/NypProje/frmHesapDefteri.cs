using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NypProje
{
    public partial class frmHesapDefteri : Form
    {
        public string tempMusteriAd, tempSatisTarih, tempSatisTutar, tempOdemeTipi;
        public frmHesapDefteri()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmHesapDefteri_Load(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                tempMusteriAd = "";
                tempSatisTarih = "";
                tempSatisTutar = "";
                tempOdemeTipi = "";

                for (int i = 0; i < frmYonetici.dukkan.Hesap.Satislar.Count; i++)
                {
                         tempMusteriAd += frmYonetici.dukkan.Hesap.Satislar[i].musteri.Ad + "\n";
                         tempSatisTarih += frmYonetici.dukkan.Hesap.Satislar[i].SatisTarihi.ToShortDateString()+"\n";
                         tempSatisTutar += frmYonetici.dukkan.Hesap.Satislar[i].odeme.OdemeMiktari.ToString() + "\n";
                         tempOdemeTipi += frmYonetici.dukkan.Hesap.Satislar[i].odeme.OdemeTipi + "\n";

                }

                musteriAd.Text = tempMusteriAd;
                SatisTarih.Text = tempSatisTarih;
                SatisTutar.Text = tempSatisTutar;
                OdemeTipi.Text = tempOdemeTipi;
            }
            

        }
    }
}
