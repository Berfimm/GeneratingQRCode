using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCode
{
    public partial class QR : Form
    {
        public QR()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var yazi = QG.CreateQrCode(textOrUrl.Text,QRCoder.QRCodeGenerator.ECCLevel.H);
            var qr = new QRCoder.QRCode(yazi);
            pictureQR.Image = qr.GetGraphic(50);
        }



    }
}
