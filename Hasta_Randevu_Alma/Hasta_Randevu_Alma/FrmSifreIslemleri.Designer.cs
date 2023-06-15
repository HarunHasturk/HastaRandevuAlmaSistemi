namespace Hasta_Randevu_Alma
{
    partial class FrmSifreIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSifreIslemleri));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtSifreTekrar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
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
            this.LblTC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(129, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 35);
            this.label1.TabIndex = 18;
            this.label1.Text = "Parola İşlemleri";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(517, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(573, 28);
            this.button1.TabIndex = 17;
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
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(135, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(371, 144);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(182, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1039, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Belirlediğiniz bu parola ile sadece MHRS uygulamasına giriş yapabilir ve randevu " +
    "işlemlerini gerçekleştirebilirsiniz.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(182, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Yeni Parolanız:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(186, 348);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(1035, 34);
            this.TxtSifre.TabIndex = 37;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // TxtSifreTekrar
            // 
            this.TxtSifreTekrar.Location = new System.Drawing.Point(186, 455);
            this.TxtSifreTekrar.Name = "TxtSifreTekrar";
            this.TxtSifreTekrar.Size = new System.Drawing.Size(1035, 34);
            this.TxtSifreTekrar.TabIndex = 39;
            this.TxtSifreTekrar.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(182, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Yeni Parolanız (Tekrar):";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnKaydet.ForeColor = System.Drawing.Color.White;
            this.BtnKaydet.Location = new System.Drawing.Point(1070, 519);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(151, 48);
            this.BtnKaydet.TabIndex = 40;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.Menu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfilMenu});
            this.Menu.Location = new System.Drawing.Point(1110, 61);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(9, 1, 0, 1);
            this.Menu.Size = new System.Drawing.Size(116, 32);
            this.Menu.TabIndex = 41;
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
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(524, 20);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(185, 26);
            this.LblTC.TabIndex = 42;
            this.LblTC.Text = "T.C. Kimlik Bilgisi";
            this.LblTC.Visible = false;
            // 
            // FrmSifreIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1385, 683);
            this.Controls.Add(this.LblTC);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtSifreTekrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSifreIslemleri";
            this.Text = "FrmSifreIslemleri";
            this.Load += new System.EventHandler(this.FrmSifreIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtSifreTekrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnKaydet;
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
        private System.Windows.Forms.Label LblTC;
    }
}