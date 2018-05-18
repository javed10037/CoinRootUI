using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zen.Barcode;
using QRCoder;

namespace COINROOTUI
{
    public partial class receiveBitcoinCash : Form
    {
        public receiveBitcoinCash()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void receiveBitcoinCash_Load(object sender, EventArgs e)
        {
            QRCodeGenerator qrcoder = new QRCodeGenerator();
            QRCodeData qrdata = qrcoder.CreateQrCode("Akash Gautam", QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrdata);
            pictureBox.BackgroundImage = qrcode.GetGraphic(8);

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
