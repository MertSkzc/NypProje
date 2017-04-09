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
    public partial class frmSatis : Form
    {
        int saydir, sepetsay,gecici=0,indeksAl=0,indeksSay;
        string temp;
        decimal SepetTutar = 0,tektutar=0;

        public frmSatis()
        {
            InitializeComponent();
        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboUrunSec.SelectedText!= "Seçiniz..")
                {
                    if (frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex].UrunSepetAdeti == 0)
                    {

                        //Adeti al
                        frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex].UrunSepetAdeti = Convert.ToInt32(AdetSay.Value);

                        listSepet.Items.Add("Ürün Adı: " + frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex].UrunAdi +
                            " - " + Convert.ToInt32(AdetSay.Value) + " Adet - " + frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex].Fiyat
                            * Convert.ToInt32(AdetSay.Value) + " TL");

                        //müşterinin sepetine ekle
                        frmYonetici.dukkan.Musteriler[frmYonetici.musteriindeks].sepet.Sepettekiler.Add(frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex]);
                        tektutar = frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex].UrunSepetAdeti * frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex].Fiyat;
                    }
                    else
                    {
                        SepetTutar -= frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex].UrunSepetAdeti * frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex].Fiyat;
                        gecici = frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex].UrunSepetAdeti;
                        ////////////////////////////////    
                        saydir = 0;
                        foreach (Urun u in frmYonetici.dukkan.Musteriler[frmYonetici.musteriindeks].sepet.Sepettekiler)
                        {
                            if (u.UrunKodu == frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex].UrunKodu)
                            {
                                indeksAl = saydir;
                            }
                            saydir++;
                        }
                        ////////////////////////////////

                        frmYonetici.dukkan.Musteriler[frmYonetici.musteriindeks].sepet.Sepettekiler.RemoveAt(indeksAl);
                        listSepet.Items.RemoveAt(indeksAl);
                        ////////////////////////////////
                        frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex].UrunSepetAdeti = gecici + Convert.ToInt32(AdetSay.Value);
                        frmYonetici.dukkan.Musteriler[frmYonetici.musteriindeks].sepet.Sepettekiler.Insert(indeksAl, frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex]);
                        listSepet.Items.Insert(indeksAl, "Ürün Adı: " + frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex].UrunAdi +
                            " - " + frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex].UrunSepetAdeti + " Adet - " + frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex].Fiyat
                            * frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex].UrunSepetAdeti + " TL");
                        tektutar = frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex].UrunSepetAdeti * frmYonetici.dukkan.katolog.Urunler[comboUrunSec.SelectedIndex].Fiyat;
                    }

                    SepetTutar += tektutar;
                    txtToplamTutar.Text = SepetTutar.ToString();
                    AdetSay.Value = 1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ürün seçtiğinizden emin olun!");
            }
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            this.Text = frmYonetici.dukkan.Ad + " - Satış İşlemi";
            saydir = 0;
            foreach (Musteri m in frmYonetici.dukkan.Musteriler)
            {
                if (saydir == frmYonetici.musteriindeks)
                    lblMusteriAdi.Text = m.Ad + " " + m.Soyad;
                saydir++;
            }

            foreach (Urun u in frmYonetici.dukkan.katolog.Urunler)
            {
                comboUrunSec.Items.Add(u.UrunAdi);
            }

            comboOdemeSekli.Items.Add("Nakit");
            comboOdemeSekli.Items.Add("Kredi Kartı");
            comboOdemeSekli.Items.Add("Banka Kartı");

            AdetSay.Minimum = 1;
        }

        private void comboUrunSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            saydir = 0;
            foreach (Urun u in frmYonetici.dukkan.katolog.Urunler)
            {
                if (saydir == comboUrunSec.SelectedIndex)
                {
                    lblUrunAdiGetir.Text = u.UrunAdi;
                    lblUrunFiyatGetir.Text = u.Fiyat.ToString()+" TL";
                    AdetSay.Maximum = u.Stok.Miktar;
                    AdetSay.Minimum = 1;
                }
                saydir++;
            }
        }

        private void btnSatinAl_Click(object sender, EventArgs e)
        {
            ///////////////////////Satın alma işlemleri///////////////////////
            if (comboOdemeSekli.SelectedIndex != -1 && comboUrunSec.SelectedIndex != -1&& listSepet.Items.Count > 0)
            {
                saydir = 0;
                foreach (Terminal t in frmYonetici.dukkan.Terminaller)
                {
                    if (frmYonetici.gorevliindeks == saydir)
                    {

                        Satis sat = new Satis();


                        sat.musteri.Ad = lblMusteriAdi.Text;
                        sat.odeme.OdemeMiktari = Convert.ToDecimal(txtToplamTutar.Text);
                        sat.odeme.OdemeTipi = comboOdemeSekli.SelectedItem.ToString();
                        sat.SatisTarihi = DateTime.Now;



                        frmYonetici.dukkan.Hesap.Satislar.Insert(frmYonetici.satisSay, sat);
                        frmYonetici.satisSay++;
                        t.satis = sat;
                        temp = "";
                        sepetsay = 0;
                        foreach (Urun u in frmYonetici.dukkan.Musteriler[frmYonetici.musteriindeks].sepet.Sepettekiler)
                        {
                            temp += " " + u.UrunAdi + " - " + u.UrunSepetAdeti + " Adet - " + u.Fiyat * u.UrunSepetAdeti + " TL" + Environment.NewLine;

                            indeksSay = 0;
                            foreach (Urun u2 in frmYonetici.dukkan.katolog.Urunler)
                            {
                                if (u.UrunKodu == u2.UrunKodu)
                                {
                                    u2.Stok.Miktar -= u.UrunSepetAdeti;
                                }

                                indeksSay++;
                            }

                            sepetsay++;
                        }

                        //FATURA YAZDIR
                        MessageBox.Show("--" + frmYonetici.dukkan.Ad + "--" + Environment.NewLine
                            + "\nGorevli : " + t.Gorevli.Ad + "\n ~~~Hoşgeldiniz Sayın " + t.satis.musteri.Ad + "    \t     Tarih :" + t.satis.SatisTarihi + "\n\n" + "Ürünleriniz :\n"
                            + temp + "\nToplam Tutar = " + t.satis.odeme.OdemeMiktari + " - " + t.satis.odeme.OdemeTipi + Environment.NewLine + "\n Bizi tercih ettiğiniz için teşekkür ederiz...\n", "FATURA");

                    }
                    saydir++;
                }
            ((frmYonetici)Application.OpenForms["frmYonetici"]).StokYenile();
                foreach (Urun u in frmYonetici.dukkan.katolog.Urunler)
                {

                    u.UrunSepetAdeti = 0;
                }
                frmYonetici.dukkan.Musteriler[frmYonetici.musteriindeks].sepet.Sepettekiler.Clear();
                frmYonetici.kayitlar++;
                this.Hide();

            }
            else
            {
                MessageBox.Show("Seçimleri yapmadınız veya sepetiniz boş!!!");
            }
            /////////////////////////////////////////////////////////////////

        }



        private void AdetSay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSepetTemizle_Click(object sender, EventArgs e)
        {
            listSepet.Items.Clear();
            saydir = 0;

            foreach (Musteri m in frmYonetici.dukkan.Musteriler)
            {
                if (frmYonetici.musteriindeks == saydir)
                {
                    sepetsay = 0;
                    foreach (Urun u in frmYonetici.dukkan.katolog.Urunler)
                    {
                       
                            u.UrunSepetAdeti = 0;
                        
                        sepetsay++;
                    }
                    m.sepet.Sepettekiler.Clear();
                    SepetTutar = 0;
                    txtToplamTutar.Text = SepetTutar.ToString();
                }
                saydir++;
            }

        }

        private void btnSepetCikar_Click(object sender, EventArgs e)
        {          
                    sepetsay = 0;
                    foreach (Urun u in frmYonetici.dukkan.Musteriler[frmYonetici.musteriindeks].sepet.Sepettekiler)
                    {
                        if (sepetsay==listSepet.SelectedIndex)
                        {                            
                            SepetTutar = SepetTutar - (Convert.ToDecimal(u.Fiyat)) * u.UrunSepetAdeti; 
                            u.UrunSepetAdeti = 0;
                            indeksAl = sepetsay;  
                        }
                        sepetsay++;
                    }
                    txtToplamTutar.Text = SepetTutar.ToString();
            listSepet.Items.RemoveAt(listSepet.SelectedIndex);
            frmYonetici.dukkan.Musteriler[frmYonetici.musteriindeks].sepet.Sepettekiler.RemoveAt(indeksAl);
        }


    }
}

