using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hasta_Randevu_Alma
{
    public partial class FrmHastaneRandevusuAl : Form
    {
        public FrmHastaneRandevusuAl()
        {
            InitializeComponent();
        }

        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmHastaneRandevusuAl_Load(object sender, EventArgs e)
        {
            // Ad Soyad Çekme
            LblTC.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad from Tbl_Hasta where HastaTC=" + tc, bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ProfilMenu.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            // TODO: This line of code loads data into the 'dS_RandevuAlma.Tbl_Doktor' table. You can move, or remove it, as needed.
            this.tbl_DoktorTableAdapter.Fill(this.dS_RandevuAlma.Tbl_Doktor);
            // TODO: This line of code loads data into the 'dS_RandevuAlma.Tbl_MuayeneYeri' table. You can move, or remove it, as needed.
            this.tbl_MuayeneYeriTableAdapter.Fill(this.dS_RandevuAlma.Tbl_MuayeneYeri);
            // TODO: This line of code loads data into the 'dS_RandevuAlma.Tbl_Hastane' table. You can move, or remove it, as needed.
            this.tbl_HastaneTableAdapter.Fill(this.dS_RandevuAlma.Tbl_Hastane);
            // TODO: This line of code loads data into the 'dS_RandevuAlma.Tbl_Brans' table. You can move, or remove it, as needed.
            this.tbl_BransTableAdapter.Fill(this.dS_RandevuAlma.Tbl_Brans);
            // TODO: This line of code loads data into the 'dS_RandevuAlma.Tbl_Hastaneilce' table. You can move, or remove it, as needed.
            this.tbl_HastaneilceTableAdapter.Fill(this.dS_RandevuAlma.Tbl_Hastaneilce);
            // TODO: This line of code loads data into the 'dS_RandevuAlma.Tbl_Hastaneil' table. You can move, or remove it, as needed.
            this.tbl_HastaneilTableAdapter.Fill(this.dS_RandevuAlma.Tbl_Hastaneil);

        }

        private void BtnGeriGel_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frm = new FrmAnaSayfa();
            frm.tc = tc;
            frm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frm = new FrmAnaSayfa();
            frm.tc = tc;
            frm.Show();
            this.Hide();
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into Tbl_Randevu (HastaTC,RandevuBrans,RandevuHastane,RandevuDoktor,RandevuTarih,RandevuSaat) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            komut.Parameters.AddWithValue("@p2", CmbKlinik.Text);
            komut.Parameters.AddWithValue("@p3", CmbHastane.Text);
            komut.Parameters.AddWithValue("@p4", CmbDoktor.Text);
            komut.Parameters.AddWithValue("@p5", MskTarih.Text);
            komut.Parameters.AddWithValue("@p6", MskSaat.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevunuz Oluşturuldu.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Cmb_il.Text = "";
            Cmb_ilce.Text = "";
            CmbKlinik.Text = "";
            CmbHastane.Text = "";
            CmbMuayeneYeri.Text = "";
            CmbDoktor.Text = "";
            MskTarih.Text = "";
            MskSaat.Text = "";
        }

        private void KimlikBilgileriMenu_Click(object sender, EventArgs e)
        {
            FrmKimlikBilgileri frm = new FrmKimlikBilgileri();
            frm.tc = tc;
            frm.Show();
            this.Hide();
        }

        private void iletisimBilgileriMenu_Click(object sender, EventArgs e)
        {
            Frm_iletisimBilgileri frm = new Frm_iletisimBilgileri();
            frm.tc = tc;
            frm.Show();
            this.Hide();
        }

        private void ParolaIslemleriMenu_Click(object sender, EventArgs e)
        {
            FrmSifreIslemleri frm = new FrmSifreIslemleri();
            frm.tc = tc;
            frm.Show();
            this.Hide();
        }

        private void RandevuGecmisiMenu_Click(object sender, EventArgs e)
        {
            FrmRandevuGecmisi frm = new FrmRandevuGecmisi();
            frm.tc = tc;
            frm.Show();
            this.Hide();
        }

        private void RandevuTalepleriMenu_Click(object sender, EventArgs e)
        {
            FrmRandevuTalepleri frm = new FrmRandevuTalepleri();
            frm.tc = tc;
            frm.Show();
            this.Hide();
        }

        private void CikisMenu_Click(object sender, EventArgs e)
        {
            FrmGirisler frm = new FrmGirisler();
            frm.Show();
            this.Hide();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Cmb_il.Text = "";
            Cmb_ilce.Text = "";
            CmbKlinik.Text = "";
            CmbHastane.Text = "";
            CmbMuayeneYeri.Text = "";
            CmbDoktor.Text = "";
            MskTarih.Text = "";
            MskSaat.Text = "";
        }
    }
}
