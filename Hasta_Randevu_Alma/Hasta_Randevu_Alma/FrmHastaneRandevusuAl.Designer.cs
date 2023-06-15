namespace Hasta_Randevu_Alma
{
    partial class FrmHastaneRandevusuAl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaneRandevusuAl));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGeriGel = new System.Windows.Forms.Button();
            this.Cmb_il = new System.Windows.Forms.ComboBox();
            this.tblHastaneilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_RandevuAlma = new Hasta_Randevu_Alma.DS_RandevuAlma();
            this.Cmb_ilce = new System.Windows.Forms.ComboBox();
            this.fKTblHastaneilceTblHastaneilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.CmbKlinik = new System.Windows.Forms.ComboBox();
            this.fKTblBransTblHastaneilceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.CmbHastane = new System.Windows.Forms.ComboBox();
            this.fKTblHastaneTblBransBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.CmbMuayeneYeri = new System.Windows.Forms.ComboBox();
            this.fKTblMuayeneYeriTblHastaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.CmbDoktor = new System.Windows.Forms.ComboBox();
            this.fKTblDoktorTblMuayeneYeriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnRandevuAl = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.tbl_HastaneilTableAdapter = new Hasta_Randevu_Alma.DS_RandevuAlmaTableAdapters.Tbl_HastaneilTableAdapter();
            this.tbl_HastaneilceTableAdapter = new Hasta_Randevu_Alma.DS_RandevuAlmaTableAdapters.Tbl_HastaneilceTableAdapter();
            this.tbl_BransTableAdapter = new Hasta_Randevu_Alma.DS_RandevuAlmaTableAdapters.Tbl_BransTableAdapter();
            this.tbl_HastaneTableAdapter = new Hasta_Randevu_Alma.DS_RandevuAlmaTableAdapters.Tbl_HastaneTableAdapter();
            this.tbl_MuayeneYeriTableAdapter = new Hasta_Randevu_Alma.DS_RandevuAlmaTableAdapters.Tbl_MuayeneYeriTableAdapter();
            this.tbl_DoktorTableAdapter = new Hasta_Randevu_Alma.DS_RandevuAlmaTableAdapters.Tbl_DoktorTableAdapter();
            this.LblTC = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.ProfilMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HesapBilgileriMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.KimlikBilgileriMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.iletisimBilgileriMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ParolaIslemleriMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RandevuBilgileriMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RandevuGecmisiMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RandevuTalepleriMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FavorilerimMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CikisMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHastaneilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_RandevuAlma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTblHastaneilceTblHastaneilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTblBransTblHastaneilceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTblHastaneTblBransBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTblMuayeneYeriTblHastaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTblDoktorTblMuayeneYeriBindingSource)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(516, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(573, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Randevu aradığınız hastane, klinik veya hekim bilgisini yazınız.";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(134, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(371, 144);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(137, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 27);
            this.label3.TabIndex = 23;
            this.label3.Text = "İl:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(204, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 35);
            this.label1.TabIndex = 22;
            this.label1.Text = "Randevu Ara";
            // 
            // BtnGeriGel
            // 
            this.BtnGeriGel.Location = new System.Drawing.Point(157, 168);
            this.BtnGeriGel.Name = "BtnGeriGel";
            this.BtnGeriGel.Size = new System.Drawing.Size(41, 34);
            this.BtnGeriGel.TabIndex = 25;
            this.BtnGeriGel.Text = "<";
            this.BtnGeriGel.UseVisualStyleBackColor = true;
            this.BtnGeriGel.Click += new System.EventHandler(this.BtnGeriGel_Click);
            // 
            // Cmb_il
            // 
            this.Cmb_il.DataSource = this.tblHastaneilBindingSource;
            this.Cmb_il.DisplayMember = "Hastaneil";
            this.Cmb_il.FormattingEnabled = true;
            this.Cmb_il.Location = new System.Drawing.Point(134, 257);
            this.Cmb_il.Name = "Cmb_il";
            this.Cmb_il.Size = new System.Drawing.Size(1086, 34);
            this.Cmb_il.TabIndex = 26;
            // 
            // tblHastaneilBindingSource
            // 
            this.tblHastaneilBindingSource.DataMember = "Tbl_Hastaneil";
            this.tblHastaneilBindingSource.DataSource = this.dS_RandevuAlma;
            // 
            // dS_RandevuAlma
            // 
            this.dS_RandevuAlma.DataSetName = "DS_RandevuAlma";
            this.dS_RandevuAlma.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cmb_ilce
            // 
            this.Cmb_ilce.DataSource = this.fKTblHastaneilceTblHastaneilBindingSource;
            this.Cmb_ilce.DisplayMember = "Hastaneilce";
            this.Cmb_ilce.FormattingEnabled = true;
            this.Cmb_ilce.Location = new System.Drawing.Point(134, 327);
            this.Cmb_ilce.Name = "Cmb_ilce";
            this.Cmb_ilce.Size = new System.Drawing.Size(1086, 34);
            this.Cmb_ilce.TabIndex = 28;
            // 
            // fKTblHastaneilceTblHastaneilBindingSource
            // 
            this.fKTblHastaneilceTblHastaneilBindingSource.DataMember = "FK_Tbl_Hastaneilce_Tbl_Hastaneil";
            this.fKTblHastaneilceTblHastaneilBindingSource.DataSource = this.tblHastaneilBindingSource;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(137, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 27);
            this.label2.TabIndex = 27;
            this.label2.Text = "İlçe:";
            // 
            // CmbKlinik
            // 
            this.CmbKlinik.DataSource = this.fKTblBransTblHastaneilceBindingSource;
            this.CmbKlinik.DisplayMember = "HastaneBrans";
            this.CmbKlinik.FormattingEnabled = true;
            this.CmbKlinik.Location = new System.Drawing.Point(134, 397);
            this.CmbKlinik.Name = "CmbKlinik";
            this.CmbKlinik.Size = new System.Drawing.Size(1086, 34);
            this.CmbKlinik.TabIndex = 30;
            // 
            // fKTblBransTblHastaneilceBindingSource
            // 
            this.fKTblBransTblHastaneilceBindingSource.DataMember = "FK_Tbl_Brans_Tbl_Hastaneilce";
            this.fKTblBransTblHastaneilceBindingSource.DataSource = this.fKTblHastaneilceTblHastaneilBindingSource;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(137, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 27);
            this.label4.TabIndex = 29;
            this.label4.Text = "Klinik:";
            // 
            // CmbHastane
            // 
            this.CmbHastane.DataSource = this.fKTblHastaneTblBransBindingSource;
            this.CmbHastane.DisplayMember = "Hastane";
            this.CmbHastane.FormattingEnabled = true;
            this.CmbHastane.Location = new System.Drawing.Point(134, 468);
            this.CmbHastane.Name = "CmbHastane";
            this.CmbHastane.Size = new System.Drawing.Size(1086, 34);
            this.CmbHastane.TabIndex = 32;
            // 
            // fKTblHastaneTblBransBindingSource
            // 
            this.fKTblHastaneTblBransBindingSource.DataMember = "FK_Tbl_Hastane_Tbl_Brans";
            this.fKTblHastaneTblBransBindingSource.DataSource = this.fKTblBransTblHastaneilceBindingSource;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(137, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "Hastane:";
            // 
            // CmbMuayeneYeri
            // 
            this.CmbMuayeneYeri.DataSource = this.fKTblMuayeneYeriTblHastaneBindingSource;
            this.CmbMuayeneYeri.DisplayMember = "HastaneMuayeneYeri";
            this.CmbMuayeneYeri.FormattingEnabled = true;
            this.CmbMuayeneYeri.Location = new System.Drawing.Point(134, 538);
            this.CmbMuayeneYeri.Name = "CmbMuayeneYeri";
            this.CmbMuayeneYeri.Size = new System.Drawing.Size(1086, 34);
            this.CmbMuayeneYeri.TabIndex = 34;
            // 
            // fKTblMuayeneYeriTblHastaneBindingSource
            // 
            this.fKTblMuayeneYeriTblHastaneBindingSource.DataMember = "FK_Tbl_MuayeneYeri_Tbl_Hastane";
            this.fKTblMuayeneYeriTblHastaneBindingSource.DataSource = this.fKTblHastaneTblBransBindingSource;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(137, 509);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 27);
            this.label6.TabIndex = 33;
            this.label6.Text = "Muayene Yeri:";
            // 
            // CmbDoktor
            // 
            this.CmbDoktor.DataSource = this.fKTblDoktorTblMuayeneYeriBindingSource;
            this.CmbDoktor.DisplayMember = "DoktorAdSoyad";
            this.CmbDoktor.FormattingEnabled = true;
            this.CmbDoktor.Location = new System.Drawing.Point(134, 608);
            this.CmbDoktor.Name = "CmbDoktor";
            this.CmbDoktor.Size = new System.Drawing.Size(1086, 34);
            this.CmbDoktor.TabIndex = 36;
            // 
            // fKTblDoktorTblMuayeneYeriBindingSource
            // 
            this.fKTblDoktorTblMuayeneYeriBindingSource.DataMember = "FK_Tbl_Doktor_Tbl_MuayeneYeri";
            this.fKTblDoktorTblMuayeneYeriBindingSource.DataSource = this.fKTblMuayeneYeriTblHastaneBindingSource;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(137, 579);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 27);
            this.label7.TabIndex = 35;
            this.label7.Text = "Hekim:";
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(218, 653);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(458, 34);
            this.MskTarih.TabIndex = 37;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(137, 660);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 27);
            this.label8.TabIndex = 38;
            this.label8.Text = "Tarih:";
            // 
            // BtnRandevuAl
            // 
            this.BtnRandevuAl.Location = new System.Drawing.Point(142, 703);
            this.BtnRandevuAl.Name = "BtnRandevuAl";
            this.BtnRandevuAl.Size = new System.Drawing.Size(534, 40);
            this.BtnRandevuAl.TabIndex = 41;
            this.BtnRandevuAl.Text = "Randevu Al";
            this.BtnRandevuAl.UseVisualStyleBackColor = true;
            this.BtnRandevuAl.Click += new System.EventHandler(this.BtnRandevuAl_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackColor = System.Drawing.Color.DarkRed;
            this.BtnTemizle.ForeColor = System.Drawing.Color.White;
            this.BtnTemizle.Location = new System.Drawing.Point(686, 703);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(534, 40);
            this.BtnTemizle.TabIndex = 42;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = false;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // tbl_HastaneilTableAdapter
            // 
            this.tbl_HastaneilTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_HastaneilceTableAdapter
            // 
            this.tbl_HastaneilceTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_BransTableAdapter
            // 
            this.tbl_BransTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_HastaneTableAdapter
            // 
            this.tbl_HastaneTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_MuayeneYeriTableAdapter
            // 
            this.tbl_MuayeneYeriTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_DoktorTableAdapter
            // 
            this.tbl_DoktorTableAdapter.ClearBeforeFill = true;
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(565, 19);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(185, 26);
            this.LblTC.TabIndex = 43;
            this.LblTC.Text = "T.C. Kimlik Bilgisi";
            this.LblTC.Visible = false;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.Menu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfilMenu});
            this.Menu.Location = new System.Drawing.Point(1105, 61);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(9, 1, 0, 1);
            this.Menu.Size = new System.Drawing.Size(116, 32);
            this.Menu.TabIndex = 44;
            this.Menu.Text = "menuStrip1";
            // 
            // ProfilMenu
            // 
            this.ProfilMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ProfilMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HesapBilgileriMenu,
            this.RandevuBilgileriMenu,
            this.FavorilerimMenu,
            this.CikisMenu});
            this.ProfilMenu.Name = "ProfilMenu";
            this.ProfilMenu.Size = new System.Drawing.Size(105, 30);
            this.ProfilMenu.Text = "PROFİL";
            // 
            // HesapBilgileriMenu
            // 
            this.HesapBilgileriMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KimlikBilgileriMenu,
            this.iletisimBilgileriMenu,
            this.ParolaIslemleriMenu});
            this.HesapBilgileriMenu.Name = "HesapBilgileriMenu";
            this.HesapBilgileriMenu.Size = new System.Drawing.Size(260, 30);
            this.HesapBilgileriMenu.Text = "Hesap Bilgileri";
            // 
            // KimlikBilgileriMenu
            // 
            this.KimlikBilgileriMenu.Name = "KimlikBilgileriMenu";
            this.KimlikBilgileriMenu.Size = new System.Drawing.Size(246, 30);
            this.KimlikBilgileriMenu.Text = "Kimlik Bilgileri";
            this.KimlikBilgileriMenu.Click += new System.EventHandler(this.KimlikBilgileriMenu_Click);
            // 
            // iletisimBilgileriMenu
            // 
            this.iletisimBilgileriMenu.Name = "iletisimBilgileriMenu";
            this.iletisimBilgileriMenu.Size = new System.Drawing.Size(246, 30);
            this.iletisimBilgileriMenu.Text = "İletişim Bilgileri";
            this.iletisimBilgileriMenu.Click += new System.EventHandler(this.iletisimBilgileriMenu_Click);
            // 
            // ParolaIslemleriMenu
            // 
            this.ParolaIslemleriMenu.Name = "ParolaIslemleriMenu";
            this.ParolaIslemleriMenu.Size = new System.Drawing.Size(246, 30);
            this.ParolaIslemleriMenu.Text = "Parola İşlemleri";
            this.ParolaIslemleriMenu.Click += new System.EventHandler(this.ParolaIslemleriMenu_Click);
            // 
            // RandevuBilgileriMenu
            // 
            this.RandevuBilgileriMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RandevuGecmisiMenu,
            this.RandevuTalepleriMenu});
            this.RandevuBilgileriMenu.Name = "RandevuBilgileriMenu";
            this.RandevuBilgileriMenu.Size = new System.Drawing.Size(260, 30);
            this.RandevuBilgileriMenu.Text = "Randevu Bilgileri";
            // 
            // RandevuGecmisiMenu
            // 
            this.RandevuGecmisiMenu.Name = "RandevuGecmisiMenu";
            this.RandevuGecmisiMenu.Size = new System.Drawing.Size(267, 30);
            this.RandevuGecmisiMenu.Text = "Randevu Geçmişi";
            this.RandevuGecmisiMenu.Click += new System.EventHandler(this.RandevuGecmisiMenu_Click);
            // 
            // RandevuTalepleriMenu
            // 
            this.RandevuTalepleriMenu.Name = "RandevuTalepleriMenu";
            this.RandevuTalepleriMenu.Size = new System.Drawing.Size(267, 30);
            this.RandevuTalepleriMenu.Text = "Randevu Talepleri";
            this.RandevuTalepleriMenu.Click += new System.EventHandler(this.RandevuTalepleriMenu_Click);
            // 
            // FavorilerimMenu
            // 
            this.FavorilerimMenu.Name = "FavorilerimMenu";
            this.FavorilerimMenu.Size = new System.Drawing.Size(260, 30);
            this.FavorilerimMenu.Text = "Favorilerim";
            // 
            // CikisMenu
            // 
            this.CikisMenu.Name = "CikisMenu";
            this.CikisMenu.Size = new System.Drawing.Size(260, 30);
            this.CikisMenu.Text = "Çıkış";
            this.CikisMenu.Click += new System.EventHandler(this.CikisMenu_Click);
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(763, 653);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(458, 34);
            this.MskSaat.TabIndex = 39;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(693, 660);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 27);
            this.label9.TabIndex = 40;
            this.label9.Text = "Saat:";
            // 
            // FrmHastaneRandevusuAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1392, 762);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.LblTC);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnRandevuAl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MskSaat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MskTarih);
            this.Controls.Add(this.CmbDoktor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbMuayeneYeri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CmbHastane);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbKlinik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cmb_ilce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cmb_il);
            this.Controls.Add(this.BtnGeriGel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmHastaneRandevusuAl";
            this.Text = "FrmHastaneRandevusuAl";
            this.Load += new System.EventHandler(this.FrmHastaneRandevusuAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHastaneilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_RandevuAlma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTblHastaneilceTblHastaneilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTblBransTblHastaneilceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTblHastaneTblBransBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTblMuayeneYeriTblHastaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTblDoktorTblMuayeneYeriBindingSource)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGeriGel;
        private System.Windows.Forms.ComboBox Cmb_il;
        private System.Windows.Forms.ComboBox Cmb_ilce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbKlinik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbHastane;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbMuayeneYeri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbDoktor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnRandevuAl;
        private System.Windows.Forms.Button BtnTemizle;
        private DS_RandevuAlma dS_RandevuAlma;
        private System.Windows.Forms.BindingSource tblHastaneilBindingSource;
        private DS_RandevuAlmaTableAdapters.Tbl_HastaneilTableAdapter tbl_HastaneilTableAdapter;
        private System.Windows.Forms.BindingSource fKTblHastaneilceTblHastaneilBindingSource;
        private DS_RandevuAlmaTableAdapters.Tbl_HastaneilceTableAdapter tbl_HastaneilceTableAdapter;
        private System.Windows.Forms.BindingSource fKTblBransTblHastaneilceBindingSource;
        private DS_RandevuAlmaTableAdapters.Tbl_BransTableAdapter tbl_BransTableAdapter;
        private System.Windows.Forms.BindingSource fKTblHastaneTblBransBindingSource;
        private DS_RandevuAlmaTableAdapters.Tbl_HastaneTableAdapter tbl_HastaneTableAdapter;
        private System.Windows.Forms.BindingSource fKTblMuayeneYeriTblHastaneBindingSource;
        private DS_RandevuAlmaTableAdapters.Tbl_MuayeneYeriTableAdapter tbl_MuayeneYeriTableAdapter;
        private System.Windows.Forms.BindingSource fKTblDoktorTblMuayeneYeriBindingSource;
        private DS_RandevuAlmaTableAdapters.Tbl_DoktorTableAdapter tbl_DoktorTableAdapter;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem ProfilMenu;
        private System.Windows.Forms.ToolStripMenuItem HesapBilgileriMenu;
        private System.Windows.Forms.ToolStripMenuItem KimlikBilgileriMenu;
        private System.Windows.Forms.ToolStripMenuItem iletisimBilgileriMenu;
        private System.Windows.Forms.ToolStripMenuItem ParolaIslemleriMenu;
        private System.Windows.Forms.ToolStripMenuItem RandevuBilgileriMenu;
        private System.Windows.Forms.ToolStripMenuItem RandevuGecmisiMenu;
        private System.Windows.Forms.ToolStripMenuItem RandevuTalepleriMenu;
        private System.Windows.Forms.ToolStripMenuItem FavorilerimMenu;
        private System.Windows.Forms.ToolStripMenuItem CikisMenu;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.Label label9;
    }
}