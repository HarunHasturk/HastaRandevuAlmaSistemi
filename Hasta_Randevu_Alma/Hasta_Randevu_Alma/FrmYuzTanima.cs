using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MjpegProcessor;

namespace Hasta_Randevu_Alma
{
    public partial class FrmYuzTanima : Form
    {
        MjpegDecoder mjp;
        public FrmYuzTanima()
        {
            InitializeComponent();
            mjp = new MjpegDecoder();
            mjp.FrameReady += mjp_FrameReady;
        }

        void mjp_FrameReady(object sender, FrameReadyEventArgs e)
        {
            pictureBox1.Image = e.Bitmap;
        }
        private void BtnBasla_Click(object sender, EventArgs e)
        {
            mjp.ParseStream(new Uri("http://192.168.1.33:4747/video?640x480"));
        }
    }
}
