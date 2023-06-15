namespace Hasta_Randevu_Alma
{
    partial class FrmMailDogrulama
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.Txt_Kod = new System.Windows.Forms.TextBox();
            this.BtnTekrarGonder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LblDakika = new System.Windows.Forms.Label();
            this.BtnVazgec = new System.Windows.Forms.Button();
            this.BtnTamam = new System.Windows.Forms.Button();
            this.LblTC = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.LblSaniye = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doğrula";
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LblMail.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMail.Location = new System.Drawing.Point(93, 106);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(69, 27);
            this.LblMail.TabIndex = 1;
            this.LblMail.Text = "Label";
            // 
            // Txt_Kod
            // 
            this.Txt_Kod.Location = new System.Drawing.Point(84, 164);
            this.Txt_Kod.Name = "Txt_Kod";
            this.Txt_Kod.Size = new System.Drawing.Size(545, 34);
            this.Txt_Kod.TabIndex = 2;
            // 
            // BtnTekrarGonder
            // 
            this.BtnTekrarGonder.Enabled = false;
            this.BtnTekrarGonder.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTekrarGonder.Location = new System.Drawing.Point(84, 230);
            this.BtnTekrarGonder.Name = "BtnTekrarGonder";
            this.BtnTekrarGonder.Size = new System.Drawing.Size(205, 45);
            this.BtnTekrarGonder.TabIndex = 3;
            this.BtnTekrarGonder.Text = "Tekrar Gönder";
            this.BtnTekrarGonder.UseVisualStyleBackColor = true;
            this.BtnTekrarGonder.Click += new System.EventHandler(this.BtnTekrarGonder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(691, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kalan Saniye";
            // 
            // LblDakika
            // 
            this.LblDakika.AutoSize = true;
            this.LblDakika.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDakika.Location = new System.Drawing.Point(720, 211);
            this.LblDakika.Name = "LblDakika";
            this.LblDakika.Size = new System.Drawing.Size(34, 26);
            this.LblDakika.TabIndex = 5;
            this.LblDakika.Text = "03";
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnVazgec.Location = new System.Drawing.Point(594, 284);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.Size = new System.Drawing.Size(116, 45);
            this.BtnVazgec.TabIndex = 6;
            this.BtnVazgec.Text = "Vazgeç";
            this.BtnVazgec.UseVisualStyleBackColor = true;
            this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // BtnTamam
            // 
            this.BtnTamam.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnTamam.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTamam.ForeColor = System.Drawing.Color.White;
            this.BtnTamam.Location = new System.Drawing.Point(739, 284);
            this.BtnTamam.Name = "BtnTamam";
            this.BtnTamam.Size = new System.Drawing.Size(116, 45);
            this.BtnTamam.TabIndex = 7;
            this.BtnTamam.Text = "Tamam";
            this.BtnTamam.UseVisualStyleBackColor = false;
            this.BtnTamam.Click += new System.EventHandler(this.BtnTamam_Click);
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(670, 34);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(185, 26);
            this.LblTC.TabIndex = 12;
            this.LblTC.Text = "T.C. Kimlik Bilgisi";
            this.LblTC.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(745, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = ":";
            // 
            // LblSaniye
            // 
            this.LblSaniye.AutoSize = true;
            this.LblSaniye.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSaniye.Location = new System.Drawing.Point(757, 211);
            this.LblSaniye.Name = "LblSaniye";
            this.LblSaniye.Size = new System.Drawing.Size(34, 26);
            this.LblSaniye.TabIndex = 14;
            this.LblSaniye.Text = "00";
            // 
            // FrmMailDogrulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(909, 364);
            this.Controls.Add(this.LblSaniye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblTC);
            this.Controls.Add(this.BtnTamam);
            this.Controls.Add(this.BtnVazgec);
            this.Controls.Add(this.LblDakika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnTekrarGonder);
            this.Controls.Add(this.Txt_Kod);
            this.Controls.Add(this.LblMail);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmMailDogrulama";
            this.Text = "FrmMailDogrulama";
            this.Load += new System.EventHandler(this.FrmMailDogrulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.TextBox Txt_Kod;
        private System.Windows.Forms.Button BtnTekrarGonder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblDakika;
        private System.Windows.Forms.Button BtnVazgec;
        private System.Windows.Forms.Button BtnTamam;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblSaniye;
    }
}