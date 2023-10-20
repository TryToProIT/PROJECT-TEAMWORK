using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Threading;

namespace BMCSDL_Lab3
{
    public partial class Form_Login : Form
    {

        Thread t;

        public Form_Login()
        {
            InitializeComponent();
            this.textBox_uname.Leave += new System.EventHandler(this.textBox_uname_Leave);
            this.textBox_uname.Enter += new System.EventHandler(this.textBox_uname_Enter);
            this.textBox_passwd.Leave += new System.EventHandler(this.textBox_passwd_Leave);
            this.textBox_passwd.Enter += new System.EventHandler(this.textBox_passwd_Enter);
        }
        private void Login()
        {
            try
            {
                Functions.InitConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(message: ex.Message);
            }
        }

        public void open_FormMain(object obj)
        {

            Application.Run(new Source.Form_Main(Functions.uname));
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login();

            Functions.uname = textBox_uname.Text;
            Functions.passwd = textBox_passwd.Text;
            byte[] mk = Cryptography.HashSHA1(Functions.passwd);
            string hexString = BitConverter.ToString(mk).Replace("-", "");
            string sqlVarbinary = "0x" + hexString;
            SqlCommand cmd = new SqlCommand("SELECT TENDN, MATKHAU, MANV FROM NHANVIEN WHERE TENDN='" + Functions.uname + "' AND MATKHAU=" + sqlVarbinary, Functions.conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable("NHANVIEN");

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                Functions.manv = Convert.ToString(dt.Rows[0]["MANV"]);
                this.Close();
                t = new Thread(open_FormMain);
                t.SetApartmentState(ApartmentState.STA);
                t.Start();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ");
            }

            Functions.conn.Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btn_Login_Click(sender, e);
            }
        }

        private void textBox_uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_uname_Leave(object sender, EventArgs e)
        {
            if (textBox_uname.Text.Length == 0)
            {
                textBox_uname.Text = "Username";
                textBox_uname.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox_uname_Enter(object sender, EventArgs e)
        {
            if (textBox_uname.Text == "Username")
            {
                textBox_uname.Text = "";
                textBox_uname.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBox_passwd_Leave(object sender, EventArgs e)
        {
            if (textBox_passwd.Text.Length == 0)
            {
                textBox_passwd.Text = "Password";
                textBox_passwd.ForeColor = SystemColors.WindowText;
                textBox_passwd.UseSystemPasswordChar = false;
            }
        }

        private void textBox_passwd_Enter(object sender, EventArgs e)
        {
            if (textBox_passwd.Text == "Password")
            {
                textBox_passwd.Text = "";
                textBox_passwd.ForeColor = SystemColors.WindowText;
                this.textBox_passwd.PasswordChar = '*';
            }
        }

        private void textBox_passwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
