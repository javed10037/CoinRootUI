using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COINROOTUI
{
    public partial class sendBitcoin : Form
    {
        public sendBitcoin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void sendCoin_Load(object sender, EventArgs e)
        {

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void address_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void amount_numericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {

        }
    }
}
