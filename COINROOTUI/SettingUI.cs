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
    public partial class SettingUI : UserControl
    {
        public SettingUI()
        {
            InitializeComponent();
            oldpass_label.Location = new Point(276, 145);
            newpass_label.Location = new Point(276, 212);
            cnewpass_label.Location = new Point(276, 277);
            oldpass_submitbutton.Location = new Point(270, 390);

            oldpass_textBox.Location = new Point(270, 166);
            newpass_textBox.Location = new Point(270, 233);
            cnewpass_textBox.Location = new Point(270, 298);

            oldspanpass_label.Location = new Point(276, 145);
            newspanpass_label.Location = new Point(276, 212);
            cnewspanpass_label.Location = new Point(276, 277);
            submitspanpass_button.Location = new Point(270, 390);

            oldspanpass_textBox.Location = new Point(270, 166);
            newspanpass_textBox.Location = new Point(270, 233);
            cnewspanpass_textBox.Location = new Point(270, 298);


            oldspanpass_label.Visible = false;
            newspanpass_label.Visible = false;
            cnewspanpass_label.Visible = false;
            submitspanpass_button.Visible = false;

            oldspanpass_textBox.Visible = false;
            newspanpass_textBox.Visible = false;
            cnewspanpass_textBox.Visible = false;

        }

        private void SettingUI_Load(object sender, EventArgs e)
        {

        }

        private void oldpass_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oldpass_label.Show();
            newpass_label.Show();
            cnewpass_label.Show();
            oldpass_submitbutton.Show();

            oldpass_textBox.Show();
            newpass_textBox.Show();
            cnewpass_textBox.Show();



            oldspanpass_label.Hide();
            newspanpass_label.Hide();
            cnewspanpass_label.Hide();
            submitspanpass_button.Hide();

            oldspanpass_textBox.Hide();
            newspanpass_textBox.Hide();
            cnewspanpass_textBox.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oldpass_label.Hide();
            newpass_label.Hide();
            cnewpass_label.Hide();
            oldpass_submitbutton.Hide();

            oldpass_textBox.Hide();
            newpass_textBox.Hide();
            cnewpass_textBox.Hide();



            oldspanpass_label.Show();
            newspanpass_label.Show();
            cnewspanpass_label.Show();
            submitspanpass_button.Show();

            oldspanpass_textBox.Show();
            newspanpass_textBox.Show();
            cnewspanpass_textBox.Show();
        }
    }
}
