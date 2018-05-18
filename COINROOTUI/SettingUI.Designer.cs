namespace COINROOTUI
{
    partial class SettingUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.oldpass_label = new System.Windows.Forms.Label();
            this.oldpass_textBox = new System.Windows.Forms.TextBox();
            this.newpass_textBox = new System.Windows.Forms.TextBox();
            this.newpass_label = new System.Windows.Forms.Label();
            this.cnewpass_textBox = new System.Windows.Forms.TextBox();
            this.cnewpass_label = new System.Windows.Forms.Label();
            this.oldpass_submitbutton = new System.Windows.Forms.Button();
            this.submitspanpass_button = new System.Windows.Forms.Button();
            this.cnewspanpass_textBox = new System.Windows.Forms.TextBox();
            this.cnewspanpass_label = new System.Windows.Forms.Label();
            this.newspanpass_textBox = new System.Windows.Forms.TextBox();
            this.newspanpass_label = new System.Windows.Forms.Label();
            this.oldspanpass_textBox = new System.Windows.Forms.TextBox();
            this.oldspanpass_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(165, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "UPDATE PASSWORD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(404, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "UPDATE SPENNING PASSWORD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // oldpass_label
            // 
            this.oldpass_label.AutoSize = true;
            this.oldpass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldpass_label.ForeColor = System.Drawing.Color.White;
            this.oldpass_label.Location = new System.Drawing.Point(490, 144);
            this.oldpass_label.Name = "oldpass_label";
            this.oldpass_label.Size = new System.Drawing.Size(102, 18);
            this.oldpass_label.TabIndex = 12;
            this.oldpass_label.Text = "Old Password";
            // 
            // oldpass_textBox
            // 
            this.oldpass_textBox.BackColor = System.Drawing.Color.Green;
            this.oldpass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldpass_textBox.Location = new System.Drawing.Point(484, 165);
            this.oldpass_textBox.Multiline = true;
            this.oldpass_textBox.Name = "oldpass_textBox";
            this.oldpass_textBox.PasswordChar = '*';
            this.oldpass_textBox.Size = new System.Drawing.Size(307, 34);
            this.oldpass_textBox.TabIndex = 13;
            this.oldpass_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oldpass_textBox.TextChanged += new System.EventHandler(this.oldpass_textBox_TextChanged);
            // 
            // newpass_textBox
            // 
            this.newpass_textBox.BackColor = System.Drawing.Color.Green;
            this.newpass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass_textBox.Location = new System.Drawing.Point(484, 232);
            this.newpass_textBox.Multiline = true;
            this.newpass_textBox.Name = "newpass_textBox";
            this.newpass_textBox.PasswordChar = '*';
            this.newpass_textBox.Size = new System.Drawing.Size(307, 34);
            this.newpass_textBox.TabIndex = 15;
            this.newpass_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newpass_label
            // 
            this.newpass_label.AutoSize = true;
            this.newpass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass_label.ForeColor = System.Drawing.Color.White;
            this.newpass_label.Location = new System.Drawing.Point(490, 211);
            this.newpass_label.Name = "newpass_label";
            this.newpass_label.Size = new System.Drawing.Size(109, 18);
            this.newpass_label.TabIndex = 14;
            this.newpass_label.Text = "New Password";
            // 
            // cnewpass_textBox
            // 
            this.cnewpass_textBox.BackColor = System.Drawing.Color.Green;
            this.cnewpass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnewpass_textBox.Location = new System.Drawing.Point(484, 297);
            this.cnewpass_textBox.Multiline = true;
            this.cnewpass_textBox.Name = "cnewpass_textBox";
            this.cnewpass_textBox.PasswordChar = '*';
            this.cnewpass_textBox.Size = new System.Drawing.Size(307, 34);
            this.cnewpass_textBox.TabIndex = 17;
            this.cnewpass_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cnewpass_label
            // 
            this.cnewpass_label.AutoSize = true;
            this.cnewpass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnewpass_label.ForeColor = System.Drawing.Color.White;
            this.cnewpass_label.Location = new System.Drawing.Point(490, 276);
            this.cnewpass_label.Name = "cnewpass_label";
            this.cnewpass_label.Size = new System.Drawing.Size(157, 18);
            this.cnewpass_label.TabIndex = 16;
            this.cnewpass_label.Text = "Cnfirm New Password";
            // 
            // oldpass_submitbutton
            // 
            this.oldpass_submitbutton.BackColor = System.Drawing.Color.Green;
            this.oldpass_submitbutton.ForeColor = System.Drawing.Color.Transparent;
            this.oldpass_submitbutton.Location = new System.Drawing.Point(484, 389);
            this.oldpass_submitbutton.Name = "oldpass_submitbutton";
            this.oldpass_submitbutton.Size = new System.Drawing.Size(307, 34);
            this.oldpass_submitbutton.TabIndex = 18;
            this.oldpass_submitbutton.Text = "Submit";
            this.oldpass_submitbutton.UseVisualStyleBackColor = false;
            // 
            // submitspanpass_button
            // 
            this.submitspanpass_button.BackColor = System.Drawing.Color.Green;
            this.submitspanpass_button.ForeColor = System.Drawing.Color.Transparent;
            this.submitspanpass_button.Location = new System.Drawing.Point(118, 389);
            this.submitspanpass_button.Name = "submitspanpass_button";
            this.submitspanpass_button.Size = new System.Drawing.Size(307, 34);
            this.submitspanpass_button.TabIndex = 25;
            this.submitspanpass_button.Text = "Submit";
            this.submitspanpass_button.UseVisualStyleBackColor = false;
            // 
            // cnewspanpass_textBox
            // 
            this.cnewspanpass_textBox.BackColor = System.Drawing.Color.Green;
            this.cnewspanpass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnewspanpass_textBox.Location = new System.Drawing.Point(118, 297);
            this.cnewspanpass_textBox.Multiline = true;
            this.cnewspanpass_textBox.Name = "cnewspanpass_textBox";
            this.cnewspanpass_textBox.PasswordChar = '*';
            this.cnewspanpass_textBox.Size = new System.Drawing.Size(307, 34);
            this.cnewspanpass_textBox.TabIndex = 24;
            this.cnewspanpass_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cnewspanpass_label
            // 
            this.cnewspanpass_label.AutoSize = true;
            this.cnewspanpass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnewspanpass_label.ForeColor = System.Drawing.Color.White;
            this.cnewspanpass_label.Location = new System.Drawing.Point(124, 276);
            this.cnewspanpass_label.Name = "cnewspanpass_label";
            this.cnewspanpass_label.Size = new System.Drawing.Size(199, 18);
            this.cnewspanpass_label.TabIndex = 23;
            this.cnewspanpass_label.Text = "Cnfirm New Span  Password";
            // 
            // newspanpass_textBox
            // 
            this.newspanpass_textBox.BackColor = System.Drawing.Color.Green;
            this.newspanpass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newspanpass_textBox.Location = new System.Drawing.Point(118, 232);
            this.newspanpass_textBox.Multiline = true;
            this.newspanpass_textBox.Name = "newspanpass_textBox";
            this.newspanpass_textBox.PasswordChar = '*';
            this.newspanpass_textBox.Size = new System.Drawing.Size(307, 34);
            this.newspanpass_textBox.TabIndex = 22;
            this.newspanpass_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newspanpass_label
            // 
            this.newspanpass_label.AutoSize = true;
            this.newspanpass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newspanpass_label.ForeColor = System.Drawing.Color.White;
            this.newspanpass_label.Location = new System.Drawing.Point(124, 211);
            this.newspanpass_label.Name = "newspanpass_label";
            this.newspanpass_label.Size = new System.Drawing.Size(147, 18);
            this.newspanpass_label.TabIndex = 21;
            this.newspanpass_label.Text = "New Span Password";
            // 
            // oldspanpass_textBox
            // 
            this.oldspanpass_textBox.BackColor = System.Drawing.Color.Green;
            this.oldspanpass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldspanpass_textBox.Location = new System.Drawing.Point(118, 165);
            this.oldspanpass_textBox.Multiline = true;
            this.oldspanpass_textBox.Name = "oldspanpass_textBox";
            this.oldspanpass_textBox.PasswordChar = '*';
            this.oldspanpass_textBox.Size = new System.Drawing.Size(307, 34);
            this.oldspanpass_textBox.TabIndex = 20;
            this.oldspanpass_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oldspanpass_label
            // 
            this.oldspanpass_label.AutoSize = true;
            this.oldspanpass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldspanpass_label.ForeColor = System.Drawing.Color.White;
            this.oldspanpass_label.Location = new System.Drawing.Point(124, 144);
            this.oldspanpass_label.Name = "oldspanpass_label";
            this.oldspanpass_label.Size = new System.Drawing.Size(140, 18);
            this.oldspanpass_label.TabIndex = 19;
            this.oldspanpass_label.Text = "Old Span Password";
            // 
            // SettingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.submitspanpass_button);
            this.Controls.Add(this.cnewspanpass_textBox);
            this.Controls.Add(this.cnewspanpass_label);
            this.Controls.Add(this.newspanpass_textBox);
            this.Controls.Add(this.newspanpass_label);
            this.Controls.Add(this.oldspanpass_textBox);
            this.Controls.Add(this.oldspanpass_label);
            this.Controls.Add(this.oldpass_submitbutton);
            this.Controls.Add(this.cnewpass_textBox);
            this.Controls.Add(this.cnewpass_label);
            this.Controls.Add(this.newpass_textBox);
            this.Controls.Add(this.newpass_label);
            this.Controls.Add(this.oldpass_textBox);
            this.Controls.Add(this.oldpass_label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SettingUI";
            this.Size = new System.Drawing.Size(846, 591);
            this.Load += new System.EventHandler(this.SettingUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label oldpass_label;
        private System.Windows.Forms.TextBox oldpass_textBox;
        private System.Windows.Forms.TextBox newpass_textBox;
        private System.Windows.Forms.Label newpass_label;
        private System.Windows.Forms.TextBox cnewpass_textBox;
        private System.Windows.Forms.Label cnewpass_label;
        private System.Windows.Forms.Button oldpass_submitbutton;
        private System.Windows.Forms.Button submitspanpass_button;
        private System.Windows.Forms.TextBox cnewspanpass_textBox;
        private System.Windows.Forms.Label cnewspanpass_label;
        private System.Windows.Forms.TextBox newspanpass_textBox;
        private System.Windows.Forms.Label newspanpass_label;
        private System.Windows.Forms.TextBox oldspanpass_textBox;
        private System.Windows.Forms.Label oldspanpass_label;
    }
}
