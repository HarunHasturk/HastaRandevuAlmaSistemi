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
    public partial class Frm_iletisimBilgileri : Form
    {
        public Frm_iletisimBilgileri()
        {
            InitializeComponent();
        }

        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void Frm_iletisimBilgileri_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad from Tbl_Hasta where HastaTC=" + tc, bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ProfilMenu.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("select HastaTelefon, HastaYakiniTel, HastaE_DevletTel, HastaE_Posta from Tbl_Hasta_İletisim where HastaTC =" + tc, bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                MskTel.Text = (string)dr2[0];
                MskYakiniTel.Text = (string)dr2[1];
                MskE_DevletTel.Text = (string)dr2[2];
                MskE_Posta.Text = (string)dr2[3];
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frm = new FrmAnaSayfa();
            frm.tc = tc;
            frm.Show();
            this.Hide();
        }

        private void BtnTelSil_Click(object sender, EventArgs e)
        {
            MskTel.Text = " ";
            MskTel.Enabled = true;
            BtnTelGuncelle.Enabled = true;
        }

        private void BtnYakiniTelSil_Click(object sender, EventArgs e)
        {
            MskYakiniTel.Text = " ";
            MskYakiniTel.Enabled = true;
            BtnYakiniTelGuncelle.Enabled = true;
        }

        private void BtnE_DevletTelSil_Click(object sender, EventArgs e)
        {
            MskE_DevletTel.Text = " ";
            MskE_DevletTel.Enabled = true;
            BtnE_DevletTelGuncelle.Enabled = true;
        }

        private void BtnE_PostaSil_Click(object sender, EventArgs e)
        {
            MskE_Posta.Text = " ";
            MskE_Posta.Enabled = true;
            BtnE_PostaGuncelle.Enabled = true;
        }

        private void BtnTelGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Hasta_İletisim set HastaTelefon=@p1 where HastaTC=" + tc, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",MskTel.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Telefon Bilgileri alanı güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MskTel.Enabled = false;
            BtnTelGuncelle.Enabled = false;
        }

        private void BtnYakiniTelGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Hasta_İletisim set HastaYakiniTel=@p1 where HastaTC=" + tc, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",MskYakiniTel.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Telefon Bilgileri alanı güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MskYakiniTel.Enabled = false;
            BtnYakiniTelGuncelle.Enabled = false;
        }

        private void BtnE_DevletTelGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Hasta_İletisim set HastaE_DevletTel=@p1 where HastaTC=" + tc, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskE_DevletTel.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Telefon Bilgileri alanı güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MskE_DevletTel.Enabled = false;
            BtnE_DevletTelGuncelle.Enabled = false;
        }

        private void BtnE_PostaGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Hasta_İletisim set HastaE_Posta=@p1 where HastaTC=" + tc, bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskE_Posta.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("E-Posta Bilgileri alanı güncellendi.","Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            MskE_Posta.Enabled = false;
            BtnE_PostaGuncelle.Enabled = false;
        }
    }
}
