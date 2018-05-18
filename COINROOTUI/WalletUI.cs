using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COINROOTUI
{
    public partial class WalletUI : UserControl
    {
        
        String currency = "Bitcoin";
        
        public WalletUI()
        {
            InitializeComponent();
           // this.StartPosition = FormStartPosition.CenterScreen;
         
        }

        private void WalletUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (currency == "Bitcoin")
            {
                sendBitcoin c1 = new sendBitcoin();
                c1.ShowDialog();

            }
            else if(currency=="Litecoin")

            {
                sendLitecoin l1 = new sendLitecoin();
                l1.ShowDialog();
                   
            }
            else if (currency == "Dogocoin")
            {
                sendDogocoin c1=new sendDogocoin();
                c1.ShowDialog();
               // MessageBox.Show("Dogocoin");

            }
            else if (currency == "BitcoinCash")
            {
                sendBitcoinCash c1=new sendBitcoinCash();
                c1.ShowDialog();
               // MessageBox.Show("Ethereum");

            }
            else if (currency == "Dashcoin")
            {
                MessageBox.Show("Dashcoin");

            }
            else if (currency == "Aragon")
            {
                MessageBox.Show("Aragon");
            }
            else
            {
                MessageBox.Show("please check the error");
            }
           // sendCoin c1 = new sendCoin();
           // c1.ShowDialog();
           // this.Hide();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (currency == "Bitcoin")
            {
                reseiveCoin c1 = new reseiveCoin();
                c1.ShowDialog();

            }
            else if (currency == "Litecoin")
            {
                receiveLitecoin l1 = new receiveLitecoin();
                l1.ShowDialog();

            }
            else if (currency == "Dogocoin")
            {
                receivedogocoin l1 = new receivedogocoin();
                l1.ShowDialog();

                MessageBox.Show("Dogocoin");

            }
            else if (currency == "BitcoinCash")
            {
                receiveBitcoinCash c1 = new receiveBitcoinCash();
                c1.ShowDialog();
               // MessageBox.Show("Ethereum");

            }
            else if (currency == "Dashcoin")
            {
                MessageBox.Show("Dashcoin");

            }
            else if (currency == "Aragon")
            {
                MessageBox.Show("Aragon");
            }
            else
            {
                MessageBox.Show("please check the error");
            }

           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TabIndexChange(object sender, EventArgs e)
        {
            
           // var Bitcoin=BitServices.GetBalance("xyz",1);
            
            //label4.Text = Bitcoin.ToString("0.000000") + "COIN";
            label2.Left = ((Control)sender).Left;
            lblname.Text = ((Control)sender).Text;
            if (lblname.Text == "Bitcoin")
            {
                currency = "Bitcoin";
            }
            else if (lblname.Text == "Litecoin")
            {
                currency = "Litecoin";
            }
            else if (lblname.Text == "Dogocoin")
            {
                currency = "Dogocoin";
            }
            else if (lblname.Text == "BitcoinCash")
            {
                currency = "BitcoinCash";
            }
            else if (lblname.Text == "Dashcoin")
            {
                currency = "Dashcoin";
            }
            else if (lblname.Text == "Aragon")
            {
                currency = "Aragon";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
