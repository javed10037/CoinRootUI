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
    public partial class ExchangeUI : UserControl
    {
        public ExchangeUI()
        {
            InitializeComponent();
            exchange_comboBox.Items.Add("Bitcoin");
            exchange_comboBox.Items.Add("Bitcoin Cash");
            exchange_comboBox.Items.Add("Litecoin");
            exchange_comboBox.Items.Add("Dogocoin");


           /* recieve_comboBox.Items.Add("Bitcoin");
            recieve_comboBox.Items.Add("Bitcoin Cash");
            recieve_comboBox.Items.Add("Litecoin");
            recieve_comboBox.Items.Add("Dogocoin");
            //this.StartPosition = FormStartPosition.CenterScreen;*/
        }

        private void ExchangeUI_Load(object sender, EventArgs e)
        {

        }

        private void exchange_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (exchange_comboBox.Text == "Bitcoin")
            {
                recieve_comboBox.Items.Clear();
                recieve_comboBox.Items.Add("Bitcoin Cash");
                recieve_comboBox.Items.Add("Litecoin");
                recieve_comboBox.Items.Add("Dogocoin");

               

            }
            else if (exchange_comboBox.Text == "Bitcoin Cash")
            {
                recieve_comboBox.Items.Clear();
                recieve_comboBox.Items.Add("Bitcoin");
                recieve_comboBox.Items.Add("Litecoin");
                recieve_comboBox.Items.Add("Dogocoin");

             
            }
            else if (exchange_comboBox.Text == "Litecoin")
            {
                recieve_comboBox.Items.Clear();
                recieve_comboBox.Items.Add("Bitcoin");
                recieve_comboBox.Items.Add("Bitcoin Cash");
                recieve_comboBox.Items.Add("Dogocoin");

            }
            else if (exchange_comboBox.Text == "Dogocoin")
            {
                recieve_comboBox.Items.Clear();
                recieve_comboBox.Items.Add("Bitcoin");
                recieve_comboBox.Items.Add("Bitcoin Cash");
                recieve_comboBox.Items.Add("Litecoin");

            }

        }

        private void receive_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (exchange_comboBox.Text == "Bitcoin")
            {
                
                recieve_comboBox.Items.Add("Bitcoin Cash");
                recieve_comboBox.Items.Add("Litecoin");
                recieve_comboBox.Items.Add("Dogocoin");

              

            }
            else if (exchange_comboBox.Text == "Bitcoin Cash")
            {
                
                recieve_comboBox.Items.Add("Bitcoin");
                recieve_comboBox.Items.Add("Litecoin");
                recieve_comboBox.Items.Add("Dogocoin");

              
            }
            else if (exchange_comboBox.Text == "Litecoin")
            {
               
                recieve_comboBox.Items.Add("Bitcoin");
                recieve_comboBox.Items.Add("Bitcoin Cash");
                recieve_comboBox.Items.Add("Dogocoin");

              
            }
            else if (exchange_comboBox.Text == "Dogocoin")
            {
                
                recieve_comboBox.Items.Add("Bitcoin");
                recieve_comboBox.Items.Add("Bitcoin Cash");
                recieve_comboBox.Items.Add("Litecoin");

             
            }


        }
    }
}
