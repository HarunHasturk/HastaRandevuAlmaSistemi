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
    public partial class FrmMailDogrulama : Form
    {
        public FrmMailDogrulama()
        {
            InitializeComponent();
        }

        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();

        static Random random = new Random();

        int rand_code = random.Next(10000, 99999);

        int saniye = 60;
        int dakika = 3;

        private void Sendmail()
        {
            SmtpClient client = new SmtpClient();
            MailMessage message = new MailMessage();

            client.Credentials = new NetworkCredential("hharunahmet1@hotmail.com", "csharp.1234");
            client.Port = 587;
            client.Host = "smtp.office365.com";
            client.EnableSsl = true;

            message.To.Add(FrmMailAktivasyon.e_mail);
            message.From = new MailAddress("hharunahmet1@hotmail.com", "Harun Ahmet Hastürk");
            message.Subject = "MHRS Doğrulaması";
            message.Body = "Doğrulama Kodunuz = " + rand_code;
            client.Send(message);
        }

        private void BtnTamam_Click(object sender, EventArgs e)
        {
            if(Txt_Kod.Text == rand_code.ToString())
            {
                timer1.Stop();
                MessageBox.Show("Doğrulama Kodunuz Onaylandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmAnaSayfa fr = new FrmAnaSayfa();
                fr.tc = tc;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Doğrulama Kodunuz Onaylanmadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Kod.Text = "";
            }
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            FrmGirisler fr = new FrmGirisler();
            fr.Show();
            this.Hide();
        }

        private void FrmMailDogrulama_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            LblMail.Text = FrmMailAktivasyon.e_mail + " için gönderilen doğrulama kodunu giriniz.";
            Sendmail();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye = saniye - 1;
            LblSaniye.Text = saniye.ToString("00");
            LblDakika.Text = (dakika - 1).ToString("00");
            if(saniye==0)
            {
                dakika = dakika - 1;
                LblDakika.Text = dakika.ToString("00");
                saniye= 60;
            }
            if (LblDakika.Text == "-01")
            {
                timer1.Stop();
                LblDakika.Text = "00";
                LblSaniye.Text = "00";
                MessageBox.Show("Süreniz Bitmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_Kod.Text = "";
                rand_code = random.Next(10000, 99999);
                BtnTamam.Enabled = false;
                BtnTekrarGonder.Enabled = true;
            }
        }

        private void BtnTekrarGonder_Click(object sender, EventArgs e)
        {
            Sendmail();
            saniye = 60;
            dakika = 3;
            timer1.Start();
            BtnTekrarGonder.Enabled = false;
            BtnTamam.Enabled = true;
        }
    }
}
