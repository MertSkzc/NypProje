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
    public partial class frmYonetici : Form
    {
        public static Dukkan dukkan = new Dukkan();
        int no = 1;
        public static int musteriindeks,gorevliindeks,kayitlar=0,urunindeks,satisSay=0;
        public frmYonetici()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmYonetici.dukkan.Ad= "Emsalsiz Market";
            frmYonetici.dukkan.Adres = "123 sokak No:1 Daire:2 İzmir / Karşıyaka";
            frmYonetici.dukkan.Telefon = 05654894964;
            frmYonetici.dukkan.katolog = new UrunKatalogu();
            
        }

        private void txtKasiyerSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGorevliEkle_Click(object sender, EventArgs e)
        {
            if (PnlKasiyerEkle.Visible == false)
                PnlKasiyerEkle.Visible = true;

            txtKasiyerAd.Clear();
            txtKasiyerKimlikNo.Clear();
            txtKasiyerSoyad.Clear();
            txtYeniTerminalNo.Clear();

            btnKasiyerKaydet.Text = "Kaydet";
            
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if (PnlMusteriEkle.Visible == false)
                PnlMusteriEkle.Visible = true;

            txtKasiyerAd.Clear();
            txtKasiyerKimlikNo.Clear();
            txtKasiyerSoyad.Clear();
            txtYeniTerminalNo.Clear();

            btnMusteriKaydet.Text = "Kaydet";

        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            if (listMusteriler.SelectedIndex != -1 && listGorevliler.SelectedIndex != -1)
            {
                frmSatis frmsatis = new frmSatis();
                frmYonetici.musteriindeks = listMusteriler.SelectedIndex;   //Hangi müşteri ile işlem yapılacak
                frmYonetici.gorevliindeks = listGorevliler.SelectedIndex;   //Satış yapan görevli
                frmYonetici.urunindeks = listUrunler.SelectedIndex;
                frmsatis.Show();

                
            }
            else
                MessageBox.Show("Kasiyer veya Müşteri seçmediniz !!!");

        }

        private void btnHesapDefteri_Click(object sender, EventArgs e)
        {
            if (kayitlar<1)
                MessageBox.Show("Şuan için hiçbir kayıt bulunmamaktadır!");
            else
            {
                frmHesapDefteri formhsp = new frmHesapDefteri();
                formhsp.Show();
            }
          
            
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (PnlUrunEkle.Visible == false)
                PnlUrunEkle.Visible = true;

            txtUrunAdi.Clear();
            txtUrunKodu.Clear();
            txtStok.Clear();
            txtFiyat.Clear();
            txtAciklama.Clear();

            btnUrunKaydet.Text = "Kaydet";

        }

        private void btnKasiyerKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnKasiyerKaydet.Text == "Kaydet")
                {
                    KasaGorevlisi kg = new KasaGorevlisi();
                    kg.Ad = txtKasiyerAd.Text;
                    kg.Soyad = txtKasiyerSoyad.Text;
                    kg.TCKimlikNo = txtKasiyerKimlikNo.Text;

                    Terminal yeniterminal = new Terminal();
                    yeniterminal.Gorevli = kg;
                    yeniterminal.SeriNo = Convert.ToInt32(txtYeniTerminalNo.Text);
                    frmYonetici.dukkan.Terminaller.Add(yeniterminal);
                    listGorevliler.Items.Add(kg.Ad + " " + kg.Soyad + " Terminal : " + yeniterminal.SeriNo);
                    txtKasiyerAd.Clear();
                    txtKasiyerKimlikNo.Clear();
                    txtKasiyerSoyad.Clear();
                    txtYeniTerminalNo.Clear();
                }
                else
                {
                    int indeks = listGorevliler.SelectedIndex;
                    KasaGorevlisi kg = new KasaGorevlisi();
                    kg.Ad = txtKasiyerAd.Text;
                    kg.Soyad = txtKasiyerSoyad.Text;
                    kg.TCKimlikNo = txtKasiyerKimlikNo.Text;

                    Terminal yeniterminal = new Terminal();
                    yeniterminal.Gorevli = kg;
                    yeniterminal.SeriNo = Convert.ToInt32(txtYeniTerminalNo.Text);

                    listGorevliler.Items.RemoveAt(indeks);//sil
                    frmYonetici.dukkan.Terminaller.RemoveAt(indeks);//sil

                    frmYonetici.dukkan.Terminaller.Insert(indeks, yeniterminal);//güncellenmişi ekle
                    listGorevliler.Items.Insert(indeks, kg.Ad + " " + kg.Soyad + " Terminal : " + yeniterminal.SeriNo);//güncellenmişi ekle

                    txtKasiyerAd.Clear();
                    txtKasiyerKimlikNo.Clear();
                    txtKasiyerSoyad.Clear();
                    txtYeniTerminalNo.Clear();

                }
            }
            catch(Exception ex)
            {
                if (btnKasiyerKaydet.Text == "Kaydet")
                    MessageBox.Show("Veri girişi yapınız!");
                else
                    MessageBox.Show("Lütfen seçim yapınız.!");
            }  

        }

        private void btnGorevliDüzenle_Click(object sender, EventArgs e)
        {
            if (PnlKasiyerEkle.Visible == false)
                PnlKasiyerEkle.Visible = true;

            btnKasiyerKaydet.Text = "Düzenle";
            

            int saydir = 0;
            foreach (Terminal t in frmYonetici.dukkan.Terminaller)
            {
                if(saydir==listGorevliler.SelectedIndex)
                {
                    txtKasiyerAd.Text = t.Gorevli.Ad;
                    txtKasiyerSoyad.Text = t.Gorevli.Soyad;
                    txtKasiyerKimlikNo.Text = t.Gorevli.TCKimlikNo;
                    txtYeniTerminalNo.Text = t.SeriNo.ToString();
                }
                saydir++;
            }

        }

        private void btnGorevliSil_Click(object sender, EventArgs e)
        {
           DialogResult onay = MessageBox.Show("Kayıt Silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                listGorevliler.Items.RemoveAt(frmYonetici.gorevliindeks);
                frmYonetici.dukkan.Terminaller.RemoveAt(frmYonetici.gorevliindeks);
                txtKasiyerAd.Clear();
                txtKasiyerKimlikNo.Clear();
                txtKasiyerSoyad.Clear();
                txtYeniTerminalNo.Clear();
            }
        }

        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
            try
            { 
                if (btnMusteriKaydet.Text == "Kaydet")
                {
                    if (txtMusteriAd.Text != "" && txtMusteriSoyad.Text != "")
                    {
                        Musteri m = new Musteri();
                        m.Ad = txtMusteriAd.Text;
                        m.Soyad = txtMusteriSoyad.Text;
                        m.MusteriNo = no;
                        no++;
                        frmYonetici.dukkan.Musteriler.Add(m);
                        listMusteriler.Items.Add(m.MusteriNo + " " + m.KisiBilgiGoster());      //MÜŞTERİ EKLEME KONTROLÜ YAPILDI SAAT 00:10



                        txtMusteriAd.Clear();
                        txtMusteriSoyad.Clear();
                    }
                    else
                        MessageBox.Show("Bilgi eksik !");
                }
                else
                {
                    int indeks = listMusteriler.SelectedIndex;
                    Musteri m = new Musteri();
                    m.Ad = txtMusteriAd.Text;
                    m.Soyad = txtMusteriSoyad.Text;
                    m.MusteriNo = indeks + 1;
                

                    listMusteriler.Items.RemoveAt(indeks);//sil
                    frmYonetici.dukkan.Musteriler.RemoveAt(indeks);//sil

                    frmYonetici.dukkan.Musteriler.Insert(indeks, m);//güncellenmişi ekle
                    listMusteriler.Items.Insert(indeks, m.MusteriNo+ " " + m.KisiBilgiGoster());//güncellenmişi ekle

                    txtMusteriAd.Clear();
                    txtMusteriSoyad.Clear();

                }
            }
            catch (Exception ex)
            {
                if (btnMusteriKaydet.Text == "Kaydet")
                    MessageBox.Show("Veri girişi yapınız!");
                else
                    MessageBox.Show("Seçim yapınız!");
            }
        }

        private void btnMusteriDuzenle_Click(object sender, EventArgs e)
        {
            
            if (PnlMusteriEkle.Visible == false)
                PnlMusteriEkle.Visible = true;
            
            btnMusteriKaydet.Text = "Düzenle";


            int saydir = 0;
            foreach (Musteri musteri in frmYonetici.dukkan.Musteriler)
            {
                if (saydir == listMusteriler.SelectedIndex)
                {
                    txtMusteriAd.Text = musteri.Ad;
                    txtMusteriSoyad.Text = musteri.Soyad;
                }
                saydir++;
            }
            

        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Kayıt Silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                listMusteriler.Items.RemoveAt(frmYonetici.musteriindeks);
                frmYonetici.dukkan.Musteriler.RemoveAt(frmYonetici.musteriindeks);
                txtMusteriAd.Clear();
                txtMusteriSoyad.Clear();
            }
        }

        private void btnUrunDuzenle_Click(object sender, EventArgs e)
        {
            if (PnlUrunEkle.Visible == false)
                PnlUrunEkle.Visible = true;

            btnUrunKaydet.Text = "Düzenle";
            

            int saydir = 0;
            foreach (Urun u in frmYonetici.dukkan.katolog.Urunler)
            {
                if (saydir == listUrunler.SelectedIndex)
                {
                    txtUrunAdi.Text = u.UrunAdi;
                    txtUrunKodu.Text = u.UrunKodu.ToString();
                    txtStok.Text = u.Stok.Miktar.ToString();
                    txtFiyat.Text = u.Fiyat.ToString();
                    txtAciklama.Text = u.Aciklama;
                }
                saydir++;
            }
        }


        public void StokYenile()
        {
            listUrunler.Items.Clear();
            
            foreach (Urun gUrun in dukkan.katolog.Urunler)
            {
                listUrunler.Items.Add(gUrun.UrunBilgisiGoster());

                txtUrunAdi.Clear();
                txtUrunKodu.Clear();
                txtStok.Clear();
                txtFiyat.Clear();
                txtAciklama.Clear();
            }
        }


        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Kayıt Silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                listUrunler.Items.RemoveAt(listUrunler.SelectedIndex);
                frmYonetici.dukkan.katolog.Urunler.RemoveAt(frmYonetici.urunindeks);
                txtUrunAdi.Clear();
                txtUrunKodu.Clear();
                txtStok.Clear();
                txtFiyat.Clear();
                txtAciklama.Clear();

            }
        }
        

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnUrunKaydet.Text == "Kaydet")
                {
                    Urun urun = new Urun();
                    urun.UrunAdi= txtUrunAdi.Text;
                    urun.UrunKodu = Convert.ToInt32(txtUrunKodu.Text);
                    urun.Stok.Miktar = Convert.ToInt32(txtStok.Text);
                    urun.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                    urun.Aciklama = txtAciklama.Text;

                    frmYonetici.dukkan.katolog.Urunler.Add(urun);
                    listUrunler.Items.Add(urun.UrunBilgisiGoster());

                    txtUrunAdi.Clear();
                    txtUrunKodu.Clear();
                    txtStok.Clear();
                    txtFiyat.Clear();
                    txtAciklama.Clear();

                }
                else
                {
                    int indeks = listUrunler.SelectedIndex;
                    Urun urun = new Urun();
                    urun.UrunAdi = txtUrunAdi.Text;
                    urun.UrunKodu = Convert.ToInt32(txtUrunKodu.Text);
                    urun.Stok.Miktar = Convert.ToInt32(txtStok.Text);
                    urun.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                    urun.Aciklama = txtAciklama.Text;


                    listUrunler.Items.RemoveAt(indeks);//sil
                    frmYonetici.dukkan.katolog.Urunler.RemoveAt(indeks);//sil

                    frmYonetici.dukkan.katolog.Urunler.Insert(indeks, urun);//güncellenmişi ekle
                    listUrunler.Items.Insert(indeks,urun.UrunBilgisiGoster());//güncellenmişi ekle

                    txtUrunAdi.Clear();
                    txtUrunKodu.Clear();
                    txtStok.Clear();
                    txtFiyat.Clear();
                    txtAciklama.Clear();


                }
            }
            catch (Exception ex)
            {
                if (btnUrunKaydet.Text == "Kaydet")
                    MessageBox.Show("Veri girişi yapınız!");
                else
                    MessageBox.Show("Seçim yapınız!");
            }
        }
    }
}
