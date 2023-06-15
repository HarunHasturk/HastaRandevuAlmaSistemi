namespace Hasta_Randevu_Alma
{
    partial class FrmKimlikBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKimlikBilgileri));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.MskDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(138, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(371, 144);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(520, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(573, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Randevu aradığınız hastane, klinik veya hekim bilgisini yazınız.";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(158, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kimlik Bilgileri";
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.Enabled = false;
            this.CmbCinsiyet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(138, 557);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(1086, 34);
            this.CmbCinsiyet.TabIndex = 24;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Enabled = false;
            this.TxtSoyad.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Location = new System.Drawing.Point(138, 463);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(1086, 34);
            this.TxtSoyad.TabIndex = 23;
            // 
            // TxtAd
            // 
            this.TxtAd.Enabled = false;
            this.TxtAd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Location = new System.Drawing.Point(138, 367);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(1086, 34);
            this.TxtAd.TabIndex = 22;
            // 
            // MskTC
            // 
            this.MskTC.Enabled = false;
            this.MskTC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTC.Location = new System.Drawing.Point(138, 276);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(1086, 34);
            this.MskTC.TabIndex = 21;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(141, 622);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(141, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(141, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(141, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(141, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "T.C. Kimlik No:";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.Menu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfilMenu});
            this.Menu.Location = new System.Drawing.Point(1107, 60);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(9, 1, 0, 1);
            this.Menu.Size = new System.Drawing.Size(116, 32);
            this.Menu.TabIndex = 26;
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
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(528, 19);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(185, 26);
            this.LblTC.TabIndex = 27;
            this.LblTC.Text = "T.C. Kimlik Bilgisi";
            this.LblTC.Visible = false;
            // 
            // MskDogumTarihi
            // 
            this.MskDogumTarihi.Enabled = false;
            this.MskDogumTarihi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskDogumTarihi.Location = new System.Drawing.Point(138, 658);
            this.MskDogumTarihi.Mask = "00/00/0000";
            this.MskDogumTarihi.Name = "MskDogumTarihi";
            this.MskDogumTarihi.Size = new System.Drawing.Size(1085, 34);
            this.MskDogumTarihi.TabIndex = 28;
            this.MskDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // FrmKimlikBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1394, 762);
            this.Controls.Add(this.MskDogumTarihi);
            this.Controls.Add(this.LblTC);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmKimlikBilgileri";
            this.Text = "FrmKimlikBilgileri";
            this.Load += new System.EventHandler(this.FrmKimlikBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
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
        private System.Windows.Forms.MaskedTextBox MskDogumTarihi;
    }
}