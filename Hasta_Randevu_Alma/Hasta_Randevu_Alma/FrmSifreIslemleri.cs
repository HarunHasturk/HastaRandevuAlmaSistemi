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
    public partial class FrmSifreIslemleri : Form
    {
        public FrmSifreIslemleri()
        {
            InitializeComponent();
        }

        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmSifreIslemleri_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad from Tbl_Hasta where HastaTC=" + tc, bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ProfilMenu.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frm = new FrmAnaSayfa();
            frm.tc = tc;
            frm.Show();
            this.Hide();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Hasta set HastaSifre=@p1 where HastaTC=" + tc, bgl.baglanti());
            if (TxtSifre.Text == TxtSifreTekrar.Text)
            {
                komut.Parameters.AddWithValue("@p1", TxtSifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Şifreniz Güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Şifrenizi Kontrol Edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
