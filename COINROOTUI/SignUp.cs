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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            LoginForm s1 = new LoginForm();
            s1.ShowDialog();
           // this.Hide();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex mRegxExpression;

            if (email_textbox.Text.Trim() != string.Empty && password_textBox.Text.Trim() != string.Empty && confirmpass_textBox.Text.Trim() != string.Empty)
            {
                if (spendingpassword_textBox.Text.Trim() != string.Empty && confirm_spendingpassword_textBox.Text.Trim() != string.Empty)
                {
                    mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                    if (!mRegxExpression.IsMatch(email_textbox.Text.Trim()))
                    {

                        MessageBox.Show("E-mail address format is not correct.", " COINROOT ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        email_textbox.Focus();

                    }
                    else
                    {
                        string URL = "http://110.173.57.186:9999/user/createNewUser";

                        dynamic foo = new ExpandoObject();
                        foo.email = email_textbox.Text.ToLower();
                        foo.password = password_textBox.Text;
                        foo.confirmPassword = confirmpass_textBox.Text;
                        foo.spendingpassword = spendingpassword_textBox.Text;
                        foo.confirmspendingpassword = confirm_spendingpassword_textBox.Text;

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

                                        string message = d.message;
                                        Console.WriteLine(response);

                                        if (message == "You have successfully signed up!!!")
                                        {
                                            /* email_textbox.Text = "";
                                             password_textBox.Text = "";
                                             confirmpass_textbox.Text = "";
                                             confirm_spendingpassword_textBox.Text = "";
                                             spendingpassword_textBox.Text = "";*/
                                            LoginForm f1 = new LoginForm();
                                            f1.Show();
                                            this.Hide();
                                            MessageBox.Show("You Have Successfully SignUp");

                                            error_label.Text = message;
                                        }
                                        else
                                        {
                                            //Console.WriteLine(d.message);
                                            error_label.Text = message;
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

            }
            else
            {
                error_label.Text = "Please fill all the required fields!";
            }


            ///
            // MessageBox.Show("You have signup successfully");
        }

        private void label56_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
