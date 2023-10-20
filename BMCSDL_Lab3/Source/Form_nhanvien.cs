using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace BMCSDL_Lab3.Source
{


    public partial class Form_nhanvien : Form
    {

        public Form_nhanvien()
        {
            InitializeComponent();
            Functions.InitConnection();

        }

        public void show_nhanvien()
        {
            //MessageBox.Show(Functions.manv);
            SqlCommand cmd = new SqlCommand("SP_SEL_PUBLIC_ENCRYPT_NHANVIEN", Functions.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataColumn newColumn = new DataColumn("LUONGCB", typeof(string));
            dt.Columns.Add(newColumn);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["MANV"].ToString() == Functions.manv)
                {
                    RSA rsa = new RSA(512);
                    rsa.ImportPrivateKeyFromFile("../../keys/" + Functions.manv + ".xml");

                    dt.Rows[i]["LUONGCB"] = rsa.Decrypt((byte[])dt.Rows[i]["LUONG"]);
                }
                else
                {
                    dt.Rows[i]["LUONGCB"] = "Encrypted";
                }
            }
            if (dt.Columns.Contains("LUONG"))
            {
                dt.Columns.Remove("LUONG");
            }
            dataGridView1.DataSource = dt;
        }
        private void Form_modifyStudent_Load(object sender, EventArgs e)
        {
            show_nhanvien();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            RSA rsa = new RSA(512);
            string pubkey = rsa.GetPublicKey();
            rsa.ExportPrivateKeyToFile("../../keys/" + textBox_manv.Text + ".xml");

            SqlCommand cmd = new SqlCommand("SP_INS_PUBLIC_ENCRYPT_NHANVIEN @MANV,@HOTEN,@EMAIL,@LUONG,@TENDN,@MATKHAU,@PUBKEY", Functions.conn);
            try
            {
                cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = textBox_manv.Text;
                cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = textBox_fullname.Text;
                //string temp = Cryptography.AES256(textBox_passwd.Text, "20120264", true);
                //MessageBox.Show(temp);
                cmd.Parameters.Add("@LUONG", SqlDbType.VarBinary).Value = rsa.Encrypt(textBox_luong.Text);
                cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar).Value = textBox_email.Text;
                cmd.Parameters.Add("@TENDN", SqlDbType.NVarChar).Value = textBox_username.Text;
                cmd.Parameters.Add("@MATKHAU", SqlDbType.VarBinary).Value = Cryptography.HashSHA1(textBox_passwd.Text);
                cmd.Parameters.Add("@PUBKEY", SqlDbType.VarChar).Value = pubkey;
                if (textBox_manv.Text != "" && cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thao tác thêm không thể thực hiện");
                }

                show_nhanvien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("NHANVIEN_DELETE @MANV", Functions.conn);
            try
            {
                cmd.Parameters.Add("@MANV", SqlDbType.NVarChar).Value = textBox_manv.Text;
                if (textBox_manv.Text != "" && cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Thao tác xóa không thể thực hiện");
                }
                show_nhanvien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tác thêm không thể thực hiện");
                //MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                textBox_manv.Text = selectedRow.Cells["MANV"].Value.ToString();
                textBox_fullname.Text = selectedRow.Cells["HOTEN"].Value.ToString();
                textBox_email.Text = selectedRow.Cells["EMAIL"].Value.ToString();
                textBox_luong.Text = selectedRow.Cells["LUONGCB"].Value.ToString();
   
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dataGridView1.Rows[e.RowIndex].Selected)
            {
                DataGridViewRow clickedRow = dataGridView1.Rows[e.RowIndex];

                // Select the entire row
                clickedRow.Selected = true;
            }
        }

        
    }
}
