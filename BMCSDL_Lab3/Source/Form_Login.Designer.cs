namespace BMCSDL_Lab3
{
    partial class Form_Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_uname = new System.Windows.Forms.TextBox();
            this.textBox_passwd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_welcome3 = new System.Windows.Forms.Label();
            this.label_welcome2 = new System.Windows.Forms.Label();
            this.label_welcome1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_contact2 = new System.Windows.Forms.Label();
            this.label_Contact = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.AutoSize = true;
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(58)))), ((int)(((byte)(141)))));
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(114, 330);
            this.button_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(309, 44);
            this.button_login.TabIndex = 1;
            this.button_login.Text = "LOGIN";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // textBox_uname
            // 
            this.textBox_uname.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_uname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_uname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_uname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_uname.Location = new System.Drawing.Point(19, 22);
            this.textBox_uname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_uname.Name = "textBox_uname";
            this.textBox_uname.Size = new System.Drawing.Size(273, 21);
            this.textBox_uname.TabIndex = 5;
            this.textBox_uname.Text = "Username";
            this.textBox_uname.TextChanged += new System.EventHandler(this.textBox_uname_TextChanged);
            // 
            // textBox_passwd
            // 
            this.textBox_passwd.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_passwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_passwd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_passwd.Location = new System.Drawing.Point(19, 23);
            this.textBox_passwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_passwd.Name = "textBox_passwd";
            this.textBox_passwd.PasswordChar = '*';
            this.textBox_passwd.Size = new System.Drawing.Size(273, 21);
            this.textBox_passwd.TabIndex = 6;
            this.textBox_passwd.Text = "Password";
            this.textBox_passwd.TextChanged += new System.EventHandler(this.textBox_passwd_TextChanged);
            this.textBox_passwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_welcome3);
            this.panel1.Controls.Add(this.label_welcome2);
            this.panel1.Controls.Add(this.label_welcome1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 474);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(85, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Developed by phat";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_welcome3
            // 
            this.label_welcome3.AutoSize = true;
            this.label_welcome3.BackColor = System.Drawing.Color.Transparent;
            this.label_welcome3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome3.ForeColor = System.Drawing.Color.White;
            this.label_welcome3.Location = new System.Drawing.Point(185, 278);
            this.label_welcome3.Name = "label_welcome3";
            this.label_welcome3.Size = new System.Drawing.Size(73, 22);
            this.label_welcome3.TabIndex = 9;
            this.label_welcome3.Text = "System";
            // 
            // label_welcome2
            // 
            this.label_welcome2.AutoSize = true;
            this.label_welcome2.BackColor = System.Drawing.Color.Transparent;
            this.label_welcome2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome2.ForeColor = System.Drawing.Color.White;
            this.label_welcome2.Location = new System.Drawing.Point(45, 236);
            this.label_welcome2.Name = "label_welcome2";
            this.label_welcome2.Size = new System.Drawing.Size(215, 22);
            this.label_welcome2.TabIndex = 8;
            this.label_welcome2.Text = "Student Management";
            // 
            // label_welcome1
            // 
            this.label_welcome1.AutoSize = true;
            this.label_welcome1.BackColor = System.Drawing.Color.Transparent;
            this.label_welcome1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome1.ForeColor = System.Drawing.Color.White;
            this.label_welcome1.Location = new System.Drawing.Point(103, 195);
            this.label_welcome1.Name = "label_welcome1";
            this.label_welcome1.Size = new System.Drawing.Size(155, 22);
            this.label_welcome1.TabIndex = 7;
            this.label_welcome1.Text = "Welcome to the";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label_contact2);
            this.panel2.Controls.Add(this.label_Contact);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button_login);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(309, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(499, 474);
            this.panel2.TabIndex = 9;
            // 
            // label_contact2
            // 
            this.label_contact2.AutoSize = true;
            this.label_contact2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contact2.ForeColor = System.Drawing.Color.DarkGray;
            this.label_contact2.Location = new System.Drawing.Point(20, 427);
            this.label_contact2.Name = "label_contact2";
            this.label_contact2.Size = new System.Drawing.Size(184, 21);
            this.label_contact2.TabIndex = 15;
            this.label_contact2.Text = "QNU-QUYNHON- VN";
            // 
            // label_Contact
            // 
            this.label_Contact.AutoSize = true;
            this.label_Contact.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Contact.ForeColor = System.Drawing.Color.DarkGray;
            this.label_Contact.Location = new System.Drawing.Point(20, 406);
            this.label_Contact.Name = "label_Contact";
            this.label_Contact.Size = new System.Drawing.Size(82, 21);
            this.label_Contact.TabIndex = 14;
            this.label_Contact.Text = "Contact";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(350, 293);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 21);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forget?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.textBox_passwd);
            this.panel4.Location = new System.Drawing.Point(114, 214);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 63);
            this.panel4.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.textBox_uname);
            this.panel3.Location = new System.Drawing.Point(114, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 63);
            this.panel3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(210, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "LOGIN";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(808, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_uname;
        private System.Windows.Forms.TextBox textBox_passwd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_welcome3;
        private System.Windows.Forms.Label label_welcome2;
        private System.Windows.Forms.Label label_welcome1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_contact2;
        private System.Windows.Forms.Label label_Contact;
    }
}

