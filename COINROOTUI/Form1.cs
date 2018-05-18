using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using System.IO;

/*using BitcoinLib.Auxiliary;
using BitcoinLib.ExceptionHandling.Rpc;
using BitcoinLib.RPC.RequestResponse;
using BitcoinLib.RPC.Specifications;
using BitcoinLib.Services.Coins.Base;
using BitcoinLib.CoinParameters.Bitcoin;
using BitcoinLib.Services.Coins.Bitcoin;
using BitcoinLib.Services.Coins.Litecoin;
using BitcoinLib.Services.Coins.Dogecoin;
using BitcoinLib.Services.Coins.Cryptocoin;

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Dynamic;

using System.Text.RegularExpressions;*/

namespace COINROOTUI
{
    public partial class Form1 : Form
    {
        /*string API_URL = "http://192.168.0.105:4009/";
        IBitcoinService bitcoinService = new BitcoinService();
        ILitecoinService litecoinService = new LitecoinService();
        IDogecoinService dogecoinService = new DogecoinService();
        ICryptocoinService bitcoincashService = new CryptocoinService("http://104.219.251.122:8332", "bitcoinxbt", "bitcoinxbt123", "123");*/

        public Form1()
        {
            InitializeComponent();
           
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(new ExchangeUI());
        }

        private void label56_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            panel3.Controls.Clear();
            panel3.Controls.Add(new HomeUI());
            
            
            
          //  button1.FlatAppearance.MouseOverBackColor = Color.Red;
            // panel3.BackColor = Color.Red;

        }


        private void button2_Click(object sender, EventArgs e)
        {

            panel3.Controls.Clear();
            panel3.Controls.Add(new WalletUI());
        }

        private void home_button_Click(object sender, EventArgs e)
        {

            panel3.Controls.Clear();
            panel3.Controls.Add(new HomeUI());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(new SettingUI());
           
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            LoginForm f1 = new LoginForm();
            f1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mediaplayer m1 = new mediaplayer();
            m1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
