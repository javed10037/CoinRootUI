﻿using System;
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
    public partial class receivedogocoin : Form
    {
        public receivedogocoin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void receivedogocoin_Load(object sender, EventArgs e)
        {
            QRCodeGenerator qrcoder = new QRCodeGenerator();
            QRCodeData qrdata = qrcoder.CreateQrCode("Akash Gautam", QRCodeGenerator.ECCLevel.Q);
            QRCode qrcode = new QRCode(qrdata);
            pictureBox.BackgroundImage = qrcode.GetGraphic(8);
        }
    }
}
