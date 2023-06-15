namespace Hasta_Randevu_Alma
{
    partial class FrmRandevuGecmisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRandevuGecmisi));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(524, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(573, 28);
            this.button1.TabIndex = 22;
            this.button1.Text = "Randevu aradığınız hastane, klinik veya hekim bilgisini yazınız.";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(142, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(371, 144);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(33, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1303, 528);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Geçmişi Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1297, 495);
            this.dataGridView1.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Menu.Dock = System.Windows.Forms.DockStyle.None;
            this.Menu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProfilMenu});
            this.Menu.Location = new System.Drawing.Point(1109, 61);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(9, 1, 0, 1);
            this.Menu.Size = new System.Drawing.Size(116, 32);
            this.Menu.TabIndex = 24;
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
            this.LblTC.Location = new System.Drawing.Point(537, 20);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(185, 26);
            this.LblTC.TabIndex = 43;
            this.LblTC.Text = "T.C. Kimlik Bilgisi";
            this.LblTC.Visible = false;
            // 
            // FrmRandevuGecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 730);
            this.Controls.Add(this.LblTC);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmRandevuGecmisi";
            this.Text = "FrmRandevuGecmisi";
            this.Load += new System.EventHandler(this.FrmRandevuGecmisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
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