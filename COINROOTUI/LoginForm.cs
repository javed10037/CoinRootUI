using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Dynamic;
using System.Text.RegularExpressions;

namespace COINROOTUI
{
    public partial class LoginForm : Form
    {
        string username;
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            SignUp s1 = new SignUp();
            s1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex mRegxExpression;

             if (username_textBox.Text.Trim() != string.Empty && password_textBox.Text.Trim() != string.Empty)
             {

                 mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(username_textBox.Text.Trim()))
                {

                    MessageBox.Show("E-mail address format is not correct.", "COINROOT", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    username_textBox.Focus();

                }
                else
                {
                    string URL = "http://110.173.57.186:9999/auth/authentcate";

                    //System.Globalization.CultureInfo Culture;
                    dynamic foo = new ExpandoObject();
                    foo.email = username_textBox.Text.ToLower();
                    foo.password = password_textBox.Text;

                    string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(foo);


                    //string DATA = @"{""email"":""asdd@da.xaxd"",""password"":""3241"",""confirmPassword"":""3241"",""spendingpassword"":""123"",""confirmspendingpassword"":""123""}";


                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                    request.Method = "POST";
                    request.ContentType = "application/json";
                    request.ContentLength = DATA.Length;
                    using (Stream webStream = request.GetRequestStream())
                    using (StreamWriter requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
                    {
                        requestWriter.Write(DATA);
                    }

                    try
                    {
                        WebResponse webResponse = request.GetResponse();
                        using (Stream webStream = webResponse.GetResponseStream())
                        {
                            if (webStream != null)
                            {
                                using (StreamReader responseReader = new StreamReader(webStream))
                                {
                                    string response = responseReader.ReadToEnd();
                                    //Console.Out.WriteLine(response);

                                    dynamic d = JsonConvert.DeserializeObject(response);


                                    string error = d.message;
                                    //Console.WriteLine(error);
                                    string message = "error";
                                    try
                                    {
                                        message = d.user.email;
                                    }
                                    catch
                                    {
                                        message = "error";
                                    }

                                    string user = username_textBox.Text;
                                    // error_label.Text = "safasfasf";

                                    if (message == user)
                                    {
                                        Form1 f1 = new Form1();
                                        f1.ShowDialog();
                                            
                                        this.Close();
                                        // username_textBox.Text = "";
                                        // password_textBox.Text = "";

                                        /* home_logo_pictureBox.Hide();
                                         username_label.Hide();
                                         username_textBox.Hide();
                                         password_label.Hide();
                                         password_textBox.Hide();
                                         signin_button.Hide();
                                         signup_label.Hide();
                                         forgot_pass_label.Hide();

                                         label_1.Show();
                                         bitcoin_home_label.Show();
                                         Logout_button.Show();

                                         username = message;
                                         home_button.Show();
                                         wallet_button.Show();*/

                                         try
                                         {
                                            // var bitcoin_Balance = bitcoinService.GetBalance(username);
                                            // bitcoin_home_label.Text = bitcoin_Balance.ToString("0.000000") + " RPZ";
                                         }
                                         catch (Exception e1)
                                         {
                                             // Console.WriteLine(e1);
                                           //  bitcoin_home_label.Text = "Not Connected";
                                             // Console.WriteLine("Not connected");
                                         }

                                     }
                                     if (error != "")
                                     {

                                        // error_label.Location = new Point(250, 365);
                                         //Console.WriteLine(error);
                                         error_label.Text = error;
                                     }


                                 }
                             }
                         }
                     }
                     catch (Exception e1)
                     {
                         //Console.Out.WriteLine("-----------------");
                         //Console.Out.WriteLine(e1.Message);
                     }
                 }

             }
             else
             {
                 error_label.Text = "Please fill all the required fields!";
             }

                                        // Form1 f1 = new Form1();
                                        // f1.Show();
                                        // this.Hide();




                                    }



                                    private void label56_Click(object sender, EventArgs e)
                                    {
                                        Application.Exit();
                                    }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
                            }
                        
                    
                  

