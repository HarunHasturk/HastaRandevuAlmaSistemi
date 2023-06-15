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
using System.Net.Mail;
using System.Net;

namespace Hasta_Randevu_Alma
{
    public partial class FrmMailAktivasyon : Form
    {

        static public string e_mail { get; set; }

        public FrmMailAktivasyon()
        {
            InitializeComponent();
        }

        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmMailAktivasyon_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            MskTC.Text= LblTC.Text;
        }

        private void Btn_ileri_Click(object sender, EventArgs e)
        {
            e_mail = txtE_Posta.Text;

            FrmMailDogrulama fr = new FrmMailDogrulama();
            fr.tc = tc;
            fr.Show();
            this.Hide();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmGirisler fr = new FrmGirisler();
            fr.Show();
            this.Hide();
        }
    }
}
