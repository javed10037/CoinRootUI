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
    public partial class sendDogocoin : Form
    {
        public sendDogocoin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sendDogocoin_Load(object sender, EventArgs e)
        {

        }
    }
}
