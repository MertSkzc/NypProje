namespace NypProje
{
    partial class frmYonetici
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
            this.tabControlAnaMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGorevliDüzenle = new System.Windows.Forms.Button();
            this.btnGorevliSil = new System.Windows.Forms.Button();
            this.BtnGorevliEkle = new System.Windows.Forms.Button();
            this.PnlKasiyerEkle = new System.Windows.Forms.Panel();
            this.txtYeniTerminalNo = new System.Windows.Forms.TextBox();
            this.lblTerminalNo = new System.Windows.Forms.Label();
            this.btnKasiyerKaydet = new System.Windows.Forms.Button();
            this.txtKasiyerKimlikNo = new System.Windows.Forms.TextBox();
            this.txtKasiyerSoyad = new System.Windows.Forms.TextBox();
            this.txtKasiyerAd = new System.Windows.Forms.TextBox();
            this.lblKimlikNo = new System.Windows.Forms.Label();
            this.lblKasiyerSoyad = new System.Windows.Forms.Label();
            this.lblKasiyerAd = new System.Windows.Forms.Label();
            this.listGorevliler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnMusteriDuzenle = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.PnlMusteriEkle = new System.Windows.Forms.Panel();
            this.btnMusteriKaydet = new System.Windows.Forms.Button();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.lblMusteriSoyad = new System.Windows.Forms.Label();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.listMusteriler = new System.Windows.Forms.ListBox();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnUrunDuzenle = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.PnlUrunEkle = new System.Windows.Forms.Panel();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnUrunKaydet = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblUrunKodu = new System.Windows.Forms.Label();
            this.listUrunler = new System.Windows.Forms.ListBox();
            this.lblUrun = new System.Windows.Forms.Label();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnHesapDefteri = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControlAnaMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.PnlKasiyerEkle.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.PnlMusteriEkle.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.PnlUrunEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAnaMenu
            // 
            this.tabControlAnaMenu.Controls.Add(this.tabPage1);
            this.tabControlAnaMenu.Controls.Add(this.tabPage2);
            this.tabControlAnaMenu.Controls.Add(this.tabPage3);
            this.tabControlAnaMenu.Location = new System.Drawing.Point(0, 0);
            this.tabControlAnaMenu.Name = "tabControlAnaMenu";
            this.tabControlAnaMenu.SelectedIndex = 0;
            this.tabControlAnaMenu.Size = new System.Drawing.Size(305, 491);
            this.tabControlAnaMenu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnGorevliDüzenle);
            this.tabPage1.Controls.Add(this.btnGorevliSil);
            this.tabPage1.Controls.Add(this.BtnGorevliEkle);
            this.tabPage1.Controls.Add(this.PnlKasiyerEkle);
            this.tabPage1.Controls.Add(this.listGorevliler);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(297, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kasa Görevlisi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGorevliDüzenle
            // 
            this.btnGorevliDüzenle.Location = new System.Drawing.Point(112, 241);
            this.btnGorevliDüzenle.Name = "btnGorevliDüzenle";
            this.btnGorevliDüzenle.Size = new System.Drawing.Size(75, 23);
            this.btnGorevliDüzenle.TabIndex = 5;
            this.btnGorevliDüzenle.Text = "Düzenle";
            this.btnGorevliDüzenle.UseVisualStyleBackColor = true;
            this.btnGorevliDüzenle.Click += new System.EventHandler(this.btnGorevliDüzenle_Click);
            // 
            // btnGorevliSil
            // 
            this.btnGorevliSil.Location = new System.Drawing.Point(208, 241);
            this.btnGorevliSil.Name = "btnGorevliSil";
            this.btnGorevliSil.Size = new System.Drawing.Size(75, 23);
            this.btnGorevliSil.TabIndex = 4;
            this.btnGorevliSil.Text = "Sil";
            this.btnGorevliSil.UseVisualStyleBackColor = true;
            this.btnGorevliSil.Click += new System.EventHandler(this.btnGorevliSil_Click);
            // 
            // BtnGorevliEkle
            // 
            this.BtnGorevliEkle.Location = new System.Drawing.Point(11, 241);
            this.BtnGorevliEkle.Name = "BtnGorevliEkle";
            this.BtnGorevliEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnGorevliEkle.TabIndex = 3;
            this.BtnGorevliEkle.Text = "Görevli Ekle";
            this.BtnGorevliEkle.UseVisualStyleBackColor = true;
            this.BtnGorevliEkle.Click += new System.EventHandler(this.BtnGorevliEkle_Click);
            // 
            // PnlKasiyerEkle
            // 
            this.PnlKasiyerEkle.Controls.Add(this.txtYeniTerminalNo);
            this.PnlKasiyerEkle.Controls.Add(this.lblTerminalNo);
            this.PnlKasiyerEkle.Controls.Add(this.btnKasiyerKaydet);
            this.PnlKasiyerEkle.Controls.Add(this.txtKasiyerKimlikNo);
            this.PnlKasiyerEkle.Controls.Add(this.txtKasiyerSoyad);
            this.PnlKasiyerEkle.Controls.Add(this.txtKasiyerAd);
            this.PnlKasiyerEkle.Controls.Add(this.lblKimlikNo);
            this.PnlKasiyerEkle.Controls.Add(this.lblKasiyerSoyad);
            this.PnlKasiyerEkle.Controls.Add(this.lblKasiyerAd);
            this.PnlKasiyerEkle.Location = new System.Drawing.Point(11, 285);
            this.PnlKasiyerEkle.Name = "PnlKasiyerEkle";
            this.PnlKasiyerEkle.Size = new System.Drawing.Size(272, 173);
            this.PnlKasiyerEkle.TabIndex = 2;
            this.PnlKasiyerEkle.Visible = false;
            // 
            // txtYeniTerminalNo
            // 
            this.txtYeniTerminalNo.Location = new System.Drawing.Point(101, 103);
            this.txtYeniTerminalNo.Name = "txtYeniTerminalNo";
            this.txtYeniTerminalNo.Size = new System.Drawing.Size(136, 20);
            this.txtYeniTerminalNo.TabIndex = 7;
            // 
            // lblTerminalNo
            // 
            this.lblTerminalNo.AutoSize = true;
            this.lblTerminalNo.Location = new System.Drawing.Point(15, 106);
            this.lblTerminalNo.Name = "lblTerminalNo";
            this.lblTerminalNo.Size = new System.Drawing.Size(67, 13);
            this.lblTerminalNo.TabIndex = 6;
            this.lblTerminalNo.Text = "Terminal No:";
            // 
            // btnKasiyerKaydet
            // 
            this.btnKasiyerKaydet.Location = new System.Drawing.Point(101, 130);
            this.btnKasiyerKaydet.Name = "btnKasiyerKaydet";
            this.btnKasiyerKaydet.Size = new System.Drawing.Size(136, 23);
            this.btnKasiyerKaydet.TabIndex = 4;
            this.btnKasiyerKaydet.Text = "Kaydet";
            this.btnKasiyerKaydet.UseVisualStyleBackColor = true;
            this.btnKasiyerKaydet.Click += new System.EventHandler(this.btnKasiyerKaydet_Click);
            // 
            // txtKasiyerKimlikNo
            // 
            this.txtKasiyerKimlikNo.Location = new System.Drawing.Point(101, 77);
            this.txtKasiyerKimlikNo.Name = "txtKasiyerKimlikNo";
            this.txtKasiyerKimlikNo.Size = new System.Drawing.Size(136, 20);
            this.txtKasiyerKimlikNo.TabIndex = 5;
            // 
            // txtKasiyerSoyad
            // 
            this.txtKasiyerSoyad.Location = new System.Drawing.Point(101, 46);
            this.txtKasiyerSoyad.Name = "txtKasiyerSoyad";
            this.txtKasiyerSoyad.Size = new System.Drawing.Size(136, 20);
            this.txtKasiyerSoyad.TabIndex = 4;
            this.txtKasiyerSoyad.TextChanged += new System.EventHandler(this.txtKasiyerSoyad_TextChanged);
            // 
            // txtKasiyerAd
            // 
            this.txtKasiyerAd.Location = new System.Drawing.Point(101, 13);
            this.txtKasiyerAd.Name = "txtKasiyerAd";
            this.txtKasiyerAd.Size = new System.Drawing.Size(136, 20);
            this.txtKasiyerAd.TabIndex = 3;
            // 
            // lblKimlikNo
            // 
            this.lblKimlikNo.AutoSize = true;
            this.lblKimlikNo.Location = new System.Drawing.Point(15, 80);
            this.lblKimlikNo.Name = "lblKimlikNo";
            this.lblKimlikNo.Size = new System.Drawing.Size(51, 13);
            this.lblKimlikNo.TabIndex = 2;
            this.lblKimlikNo.Text = "KimlikNo:";
            // 
            // lblKasiyerSoyad
            // 
            this.lblKasiyerSoyad.AutoSize = true;
            this.lblKasiyerSoyad.Location = new System.Drawing.Point(15, 49);
            this.lblKasiyerSoyad.Name = "lblKasiyerSoyad";
            this.lblKasiyerSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblKasiyerSoyad.TabIndex = 1;
            this.lblKasiyerSoyad.Text = "Soyad:";
            // 
            // lblKasiyerAd
            // 
            this.lblKasiyerAd.AutoSize = true;
            this.lblKasiyerAd.Location = new System.Drawing.Point(15, 16);
            this.lblKasiyerAd.Name = "lblKasiyerAd";
            this.lblKasiyerAd.Size = new System.Drawing.Size(23, 13);
            this.lblKasiyerAd.TabIndex = 0;
            this.lblKasiyerAd.Text = "Ad:";
            // 
            // listGorevliler
            // 
            this.listGorevliler.FormattingEnabled = true;
            this.listGorevliler.Location = new System.Drawing.Point(11, 23);
            this.listGorevliler.Name = "listGorevliler";
            this.listGorevliler.Size = new System.Drawing.Size(272, 199);
            this.listGorevliler.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kasa Görevlileri";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnMusteriDuzenle);
            this.tabPage2.Controls.Add(this.btnMusteriSil);
            this.tabPage2.Controls.Add(this.btnMusteriEkle);
            this.tabPage2.Controls.Add(this.PnlMusteriEkle);
            this.tabPage2.Controls.Add(this.listMusteriler);
            this.tabPage2.Controls.Add(this.lblMusteri);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(297, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Müşteri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnMusteriDuzenle
            // 
            this.btnMusteriDuzenle.Location = new System.Drawing.Point(109, 240);
            this.btnMusteriDuzenle.Name = "btnMusteriDuzenle";
            this.btnMusteriDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnMusteriDuzenle.TabIndex = 9;
            this.btnMusteriDuzenle.Text = "Düzenle";
            this.btnMusteriDuzenle.UseVisualStyleBackColor = true;
            this.btnMusteriDuzenle.Click += new System.EventHandler(this.btnMusteriDuzenle_Click);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Location = new System.Drawing.Point(205, 240);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(75, 23);
            this.btnMusteriSil.TabIndex = 8;
            this.btnMusteriSil.Text = "Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(8, 240);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(75, 23);
            this.btnMusteriEkle.TabIndex = 7;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // PnlMusteriEkle
            // 
            this.PnlMusteriEkle.Controls.Add(this.btnMusteriKaydet);
            this.PnlMusteriEkle.Controls.Add(this.txtMusteriSoyad);
            this.PnlMusteriEkle.Controls.Add(this.txtMusteriAd);
            this.PnlMusteriEkle.Controls.Add(this.lblMusteriSoyad);
            this.PnlMusteriEkle.Controls.Add(this.lblMusteriAd);
            this.PnlMusteriEkle.Location = new System.Drawing.Point(8, 284);
            this.PnlMusteriEkle.Name = "PnlMusteriEkle";
            this.PnlMusteriEkle.Size = new System.Drawing.Size(272, 155);
            this.PnlMusteriEkle.TabIndex = 6;
            this.PnlMusteriEkle.Visible = false;
            // 
            // btnMusteriKaydet
            // 
            this.btnMusteriKaydet.Location = new System.Drawing.Point(101, 103);
            this.btnMusteriKaydet.Name = "btnMusteriKaydet";
            this.btnMusteriKaydet.Size = new System.Drawing.Size(136, 23);
            this.btnMusteriKaydet.TabIndex = 4;
            this.btnMusteriKaydet.Text = "Kaydet";
            this.btnMusteriKaydet.UseVisualStyleBackColor = true;
            this.btnMusteriKaydet.Click += new System.EventHandler(this.btnMusteriKaydet_Click);
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(101, 65);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(136, 20);
            this.txtMusteriSoyad.TabIndex = 4;
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(101, 26);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(136, 20);
            this.txtMusteriAd.TabIndex = 3;
            // 
            // lblMusteriSoyad
            // 
            this.lblMusteriSoyad.AutoSize = true;
            this.lblMusteriSoyad.Location = new System.Drawing.Point(15, 68);
            this.lblMusteriSoyad.Name = "lblMusteriSoyad";
            this.lblMusteriSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblMusteriSoyad.TabIndex = 1;
            this.lblMusteriSoyad.Text = "Soyad:";
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Location = new System.Drawing.Point(15, 29);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(23, 13);
            this.lblMusteriAd.TabIndex = 0;
            this.lblMusteriAd.Text = "Ad:";
            // 
            // listMusteriler
            // 
            this.listMusteriler.FormattingEnabled = true;
            this.listMusteriler.Location = new System.Drawing.Point(11, 22);
            this.listMusteriler.Name = "listMusteriler";
            this.listMusteriler.Size = new System.Drawing.Size(272, 199);
            this.listMusteriler.TabIndex = 3;
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Location = new System.Drawing.Point(8, 6);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(52, 13);
            this.lblMusteri.TabIndex = 2;
            this.lblMusteri.Text = "Müşteriler";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnUrunDuzenle);
            this.tabPage3.Controls.Add(this.btnUrunSil);
            this.tabPage3.Controls.Add(this.btnUrunEkle);
            this.tabPage3.Controls.Add(this.PnlUrunEkle);
            this.tabPage3.Controls.Add(this.listUrunler);
            this.tabPage3.Controls.Add(this.lblUrun);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(297, 465);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ürün";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnUrunDuzenle
            // 
            this.btnUrunDuzenle.Location = new System.Drawing.Point(110, 240);
            this.btnUrunDuzenle.Name = "btnUrunDuzenle";
            this.btnUrunDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnUrunDuzenle.TabIndex = 15;
            this.btnUrunDuzenle.Text = "Düzenle";
            this.btnUrunDuzenle.UseVisualStyleBackColor = true;
            this.btnUrunDuzenle.Click += new System.EventHandler(this.btnUrunDuzenle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(206, 240);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(75, 23);
            this.btnUrunSil.TabIndex = 14;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(9, 240);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(75, 23);
            this.btnUrunEkle.TabIndex = 13;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // PnlUrunEkle
            // 
            this.PnlUrunEkle.Controls.Add(this.txtStok);
            this.PnlUrunEkle.Controls.Add(this.lblStok);
            this.PnlUrunEkle.Controls.Add(this.lblAciklama);
            this.PnlUrunEkle.Controls.Add(this.txtAciklama);
            this.PnlUrunEkle.Controls.Add(this.txtFiyat);
            this.PnlUrunEkle.Controls.Add(this.lblFiyat);
            this.PnlUrunEkle.Controls.Add(this.btnUrunKaydet);
            this.PnlUrunEkle.Controls.Add(this.txtUrunAdi);
            this.PnlUrunEkle.Controls.Add(this.txtUrunKodu);
            this.PnlUrunEkle.Controls.Add(this.lblUrunAdi);
            this.PnlUrunEkle.Controls.Add(this.lblUrunKodu);
            this.PnlUrunEkle.Location = new System.Drawing.Point(9, 269);
            this.PnlUrunEkle.Name = "PnlUrunEkle";
            this.PnlUrunEkle.Size = new System.Drawing.Size(272, 190);
            this.PnlUrunEkle.TabIndex = 12;
            this.PnlUrunEkle.Visible = false;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(101, 88);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(158, 20);
            this.txtStok.TabIndex = 11;
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(14, 91);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(32, 13);
            this.lblStok.TabIndex = 10;
            this.lblStok.Text = "Stok:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(14, 118);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(53, 13);
            this.lblAciklama.TabIndex = 9;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(101, 113);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(158, 47);
            this.txtAciklama.TabIndex = 8;
            this.txtAciklama.TextChanged += new System.EventHandler(this.txtAciklama_TextChanged);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(101, 61);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(158, 20);
            this.txtFiyat.TabIndex = 7;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(14, 63);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(32, 13);
            this.lblFiyat.TabIndex = 6;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.Location = new System.Drawing.Point(101, 162);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(158, 23);
            this.btnUrunKaydet.TabIndex = 4;
            this.btnUrunKaydet.Text = "Kaydet";
            this.btnUrunKaydet.UseVisualStyleBackColor = true;
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(101, 35);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(158, 20);
            this.txtUrunAdi.TabIndex = 4;
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(101, 9);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(158, 20);
            this.txtUrunKodu.TabIndex = 3;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(14, 37);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(51, 13);
            this.lblUrunAdi.TabIndex = 1;
            this.lblUrunAdi.Text = "Ürün Adı:";
            // 
            // lblUrunKodu
            // 
            this.lblUrunKodu.AutoSize = true;
            this.lblUrunKodu.Location = new System.Drawing.Point(14, 12);
            this.lblUrunKodu.Name = "lblUrunKodu";
            this.lblUrunKodu.Size = new System.Drawing.Size(61, 13);
            this.lblUrunKodu.TabIndex = 0;
            this.lblUrunKodu.Text = "Ürün Kodu:";
            // 
            // listUrunler
            // 
            this.listUrunler.FormattingEnabled = true;
            this.listUrunler.Location = new System.Drawing.Point(12, 22);
            this.listUrunler.Name = "listUrunler";
            this.listUrunler.Size = new System.Drawing.Size(272, 199);
            this.listUrunler.TabIndex = 11;
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(9, 6);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(41, 13);
            this.lblUrun.TabIndex = 10;
            this.lblUrun.Text = "Ürünler";
            // 
            // btnSatis
            // 
            this.btnSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatis.Location = new System.Drawing.Point(321, 22);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(210, 203);
            this.btnSatis.TabIndex = 1;
            this.btnSatis.Text = "SATIŞ";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnHesapDefteri
            // 
            this.btnHesapDefteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapDefteri.Location = new System.Drawing.Point(321, 278);
            this.btnHesapDefteri.Name = "btnHesapDefteri";
            this.btnHesapDefteri.Size = new System.Drawing.Size(210, 203);
            this.btnHesapDefteri.TabIndex = 2;
            this.btnHesapDefteri.Text = "HESAP DEFTERİ";
            this.btnHesapDefteri.UseVisualStyleBackColor = true;
            this.btnHesapDefteri.Click += new System.EventHandler(this.btnHesapDefteri_Click);
            // 
            // frmYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 493);
            this.Controls.Add(this.btnHesapDefteri);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.tabControlAnaMenu);
            this.Name = "frmYonetici";
            this.Text = "Yönetici";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlAnaMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.PnlKasiyerEkle.ResumeLayout(false);
            this.PnlKasiyerEkle.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.PnlMusteriEkle.ResumeLayout(false);
            this.PnlMusteriEkle.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.PnlUrunEkle.ResumeLayout(false);
            this.PnlUrunEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAnaMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BtnGorevliEkle;
        private System.Windows.Forms.Panel PnlKasiyerEkle;
        private System.Windows.Forms.Button btnKasiyerKaydet;
        private System.Windows.Forms.TextBox txtKasiyerKimlikNo;
        private System.Windows.Forms.TextBox txtKasiyerSoyad;
        private System.Windows.Forms.TextBox txtKasiyerAd;
        private System.Windows.Forms.Label lblKimlikNo;
        private System.Windows.Forms.Label lblKasiyerSoyad;
        private System.Windows.Forms.Label lblKasiyerAd;
        private System.Windows.Forms.ListBox listGorevliler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGorevliDüzenle;
        private System.Windows.Forms.Button btnGorevliSil;
        private System.Windows.Forms.Button btnMusteriDuzenle;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Panel PnlMusteriEkle;
        private System.Windows.Forms.Button btnMusteriKaydet;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label lblMusteriSoyad;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.ListBox listMusteriler;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Button btnUrunDuzenle;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Panel PnlUrunEkle;
        private System.Windows.Forms.Button btnUrunKaydet;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblUrunKodu;
        private System.Windows.Forms.ListBox listUrunler;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnHesapDefteri;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtYeniTerminalNo;
        private System.Windows.Forms.Label lblTerminalNo;
    }
}

