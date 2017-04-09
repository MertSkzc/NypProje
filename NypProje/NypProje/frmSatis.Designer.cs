namespace NypProje
{
    partial class frmSatis
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
            this.lblUrunler = new System.Windows.Forms.Label();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.lblUrunAdet = new System.Windows.Forms.Label();
            this.lblUrunSecim = new System.Windows.Forms.Label();
            this.comboUrunSec = new System.Windows.Forms.ComboBox();
            this.lblUrunBilgi = new System.Windows.Forms.Label();
            this.lblUrunFiyat = new System.Windows.Forms.Label();
            this.lblUrunAdiGetir = new System.Windows.Forms.Label();
            this.lblUrunFiyatGetir = new System.Windows.Forms.Label();
            this.AdetSay = new System.Windows.Forms.NumericUpDown();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.lblSepet = new System.Windows.Forms.Label();
            this.listSepet = new System.Windows.Forms.ListBox();
            this.lblOdemeSekli = new System.Windows.Forms.Label();
            this.comboOdemeSekli = new System.Windows.Forms.ComboBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.btnSepetTemizle = new System.Windows.Forms.Button();
            this.btnSepetCikar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdetSay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunler
            // 
            this.lblUrunler.AutoSize = true;
            this.lblUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunler.Location = new System.Drawing.Point(123, 9);
            this.lblUrunler.Name = "lblUrunler";
            this.lblUrunler.Size = new System.Drawing.Size(75, 25);
            this.lblUrunler.TabIndex = 0;
            this.lblUrunler.Text = "Ürünler";
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(12, 144);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(54, 13);
            this.lblUrunAd.TabIndex = 1;
            this.lblUrunAd.Text = "Ürün Adı :";
            // 
            // lblUrunAdet
            // 
            this.lblUrunAdet.AutoSize = true;
            this.lblUrunAdet.Location = new System.Drawing.Point(31, 225);
            this.lblUrunAdet.Name = "lblUrunAdet";
            this.lblUrunAdet.Size = new System.Drawing.Size(35, 13);
            this.lblUrunAdet.TabIndex = 2;
            this.lblUrunAdet.Text = "Adet :";
            // 
            // lblUrunSecim
            // 
            this.lblUrunSecim.AutoSize = true;
            this.lblUrunSecim.Location = new System.Drawing.Point(22, 53);
            this.lblUrunSecim.Name = "lblUrunSecim";
            this.lblUrunSecim.Size = new System.Drawing.Size(73, 13);
            this.lblUrunSecim.TabIndex = 3;
            this.lblUrunSecim.Text = "Ürün Seçiniz :";
            // 
            // comboUrunSec
            // 
            this.comboUrunSec.FormattingEnabled = true;
            this.comboUrunSec.Location = new System.Drawing.Point(101, 50);
            this.comboUrunSec.Name = "comboUrunSec";
            this.comboUrunSec.Size = new System.Drawing.Size(121, 21);
            this.comboUrunSec.TabIndex = 4;
            this.comboUrunSec.Text = "Seçiniz..";
            this.comboUrunSec.SelectedIndexChanged += new System.EventHandler(this.comboUrunSec_SelectedIndexChanged);
            // 
            // lblUrunBilgi
            // 
            this.lblUrunBilgi.AutoSize = true;
            this.lblUrunBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunBilgi.Location = new System.Drawing.Point(96, 93);
            this.lblUrunBilgi.Name = "lblUrunBilgi";
            this.lblUrunBilgi.Size = new System.Drawing.Size(120, 25);
            this.lblUrunBilgi.TabIndex = 5;
            this.lblUrunBilgi.Text = "Ürün Bilgileri";
            // 
            // lblUrunFiyat
            // 
            this.lblUrunFiyat.AutoSize = true;
            this.lblUrunFiyat.Location = new System.Drawing.Point(31, 183);
            this.lblUrunFiyat.Name = "lblUrunFiyat";
            this.lblUrunFiyat.Size = new System.Drawing.Size(38, 13);
            this.lblUrunFiyat.TabIndex = 6;
            this.lblUrunFiyat.Text = "Fiyat : ";
            // 
            // lblUrunAdiGetir
            // 
            this.lblUrunAdiGetir.AutoSize = true;
            this.lblUrunAdiGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdiGetir.Location = new System.Drawing.Point(98, 144);
            this.lblUrunAdiGetir.Name = "lblUrunAdiGetir";
            this.lblUrunAdiGetir.Size = new System.Drawing.Size(19, 25);
            this.lblUrunAdiGetir.TabIndex = 7;
            this.lblUrunAdiGetir.Text = "-";
            // 
            // lblUrunFiyatGetir
            // 
            this.lblUrunFiyatGetir.AutoSize = true;
            this.lblUrunFiyatGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunFiyatGetir.Location = new System.Drawing.Point(98, 183);
            this.lblUrunFiyatGetir.Name = "lblUrunFiyatGetir";
            this.lblUrunFiyatGetir.Size = new System.Drawing.Size(19, 25);
            this.lblUrunFiyatGetir.TabIndex = 8;
            this.lblUrunFiyatGetir.Text = "-";
            // 
            // AdetSay
            // 
            this.AdetSay.Location = new System.Drawing.Point(101, 221);
            this.AdetSay.Name = "AdetSay";
            this.AdetSay.Size = new System.Drawing.Size(37, 20);
            this.AdetSay.TabIndex = 9;
            this.AdetSay.ValueChanged += new System.EventHandler(this.AdetSay_ValueChanged);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(15, 287);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(207, 40);
            this.btnSepeteEkle.TabIndex = 10;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // lblSepet
            // 
            this.lblSepet.AutoSize = true;
            this.lblSepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSepet.Location = new System.Drawing.Point(309, 9);
            this.lblSepet.Name = "lblSepet";
            this.lblSepet.Size = new System.Drawing.Size(115, 25);
            this.lblSepet.TabIndex = 11;
            this.lblSepet.Text = "Sepettekiler";
            // 
            // listSepet
            // 
            this.listSepet.FormattingEnabled = true;
            this.listSepet.Location = new System.Drawing.Point(314, 50);
            this.listSepet.Name = "listSepet";
            this.listSepet.Size = new System.Drawing.Size(310, 173);
            this.listSepet.TabIndex = 12;
            // 
            // lblOdemeSekli
            // 
            this.lblOdemeSekli.AutoSize = true;
            this.lblOdemeSekli.Location = new System.Drawing.Point(311, 267);
            this.lblOdemeSekli.Name = "lblOdemeSekli";
            this.lblOdemeSekli.Size = new System.Drawing.Size(76, 13);
            this.lblOdemeSekli.TabIndex = 13;
            this.lblOdemeSekli.Text = "Ödeme Şekli : ";
            // 
            // comboOdemeSekli
            // 
            this.comboOdemeSekli.FormattingEnabled = true;
            this.comboOdemeSekli.Location = new System.Drawing.Point(416, 264);
            this.comboOdemeSekli.Name = "comboOdemeSekli";
            this.comboOdemeSekli.Size = new System.Drawing.Size(208, 21);
            this.comboOdemeSekli.TabIndex = 14;
            this.comboOdemeSekli.Text = "Seçiniz...";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(311, 297);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(76, 13);
            this.lblToplamTutar.TabIndex = 15;
            this.lblToplamTutar.Text = "Toplam Tutar :";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(416, 294);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(208, 20);
            this.txtToplamTutar.TabIndex = 16;
            this.txtToplamTutar.Text = "0";
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatinAl.Location = new System.Drawing.Point(314, 322);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(310, 35);
            this.btnSatinAl.TabIndex = 17;
            this.btnSatinAl.Text = "Satın Al";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Location = new System.Drawing.Point(473, 34);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(47, 13);
            this.lblMusteri.TabIndex = 18;
            this.lblMusteri.Text = "Müşteri :";
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Location = new System.Drawing.Point(526, 34);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(10, 13);
            this.lblMusteriAdi.TabIndex = 19;
            this.lblMusteriAdi.Text = "-";
            // 
            // btnSepetTemizle
            // 
            this.btnSepetTemizle.Location = new System.Drawing.Point(312, 229);
            this.btnSepetTemizle.Name = "btnSepetTemizle";
            this.btnSepetTemizle.Size = new System.Drawing.Size(146, 23);
            this.btnSepetTemizle.TabIndex = 20;
            this.btnSepetTemizle.Text = "Temizle";
            this.btnSepetTemizle.UseVisualStyleBackColor = true;
            this.btnSepetTemizle.Click += new System.EventHandler(this.btnSepetTemizle_Click);
            // 
            // btnSepetCikar
            // 
            this.btnSepetCikar.Location = new System.Drawing.Point(478, 229);
            this.btnSepetCikar.Name = "btnSepetCikar";
            this.btnSepetCikar.Size = new System.Drawing.Size(146, 23);
            this.btnSepetCikar.TabIndex = 21;
            this.btnSepetCikar.Text = "Çıkar";
            this.btnSepetCikar.UseVisualStyleBackColor = true;
            this.btnSepetCikar.Click += new System.EventHandler(this.btnSepetCikar_Click);
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 369);
            this.Controls.Add(this.btnSepetCikar);
            this.Controls.Add(this.btnSepetTemizle);
            this.Controls.Add(this.lblMusteriAdi);
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.comboOdemeSekli);
            this.Controls.Add(this.lblOdemeSekli);
            this.Controls.Add(this.listSepet);
            this.Controls.Add(this.lblSepet);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.AdetSay);
            this.Controls.Add(this.lblUrunFiyatGetir);
            this.Controls.Add(this.lblUrunAdiGetir);
            this.Controls.Add(this.lblUrunFiyat);
            this.Controls.Add(this.lblUrunBilgi);
            this.Controls.Add(this.comboUrunSec);
            this.Controls.Add(this.lblUrunSecim);
            this.Controls.Add(this.lblUrunAdet);
            this.Controls.Add(this.lblUrunAd);
            this.Controls.Add(this.lblUrunler);
            this.Name = "frmSatis";
            this.Text = "Satış";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdetSay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrunler;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.Label lblUrunAdet;
        private System.Windows.Forms.Label lblUrunSecim;
        private System.Windows.Forms.ComboBox comboUrunSec;
        private System.Windows.Forms.Label lblUrunBilgi;
        private System.Windows.Forms.Label lblUrunFiyat;
        private System.Windows.Forms.Label lblUrunAdiGetir;
        private System.Windows.Forms.Label lblUrunFiyatGetir;
        private System.Windows.Forms.NumericUpDown AdetSay;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Label lblSepet;
        private System.Windows.Forms.ListBox listSepet;
        private System.Windows.Forms.Label lblOdemeSekli;
        private System.Windows.Forms.ComboBox comboOdemeSekli;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Button btnSatinAl;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.Button btnSepetTemizle;
        private System.Windows.Forms.Button btnSepetCikar;
    }
}