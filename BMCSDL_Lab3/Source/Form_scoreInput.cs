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


namespace BMCSDL_Lab3.Source
{
    public partial class Form_scoreInput : Form
    {
        public Form_scoreInput()
        {
            InitializeComponent();
            Functions.InitConnection();
        }

        public void show_student_score()
        {
            //MessageBox.Show(Functions.manv);
            SqlCommand cmd = new SqlCommand("student_score_list '" + Functions.manv + "',N'" + Functions.passwd + "'", Functions.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form_scoreInput_Load(object sender, EventArgs e)
        {
            show_student_score();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("student_score_insert '" + Functions.manv + "',@MASV,@MAHP,@DIEM", Functions.conn);
            try
            {
                cmd.Parameters.Add("@MASV", SqlDbType.NVarChar).Value = textBox_stuId.Text;
                cmd.Parameters.Add("@MAHP", SqlDbType.VarChar).Value = textBox_mahp.Text;
                cmd.Parameters.Add("@DIEM", SqlDbType.Int).Value = textBox_score.Text;

                if (textBox_stuId.Text != "" && cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thao tác thêm không thể thực hiện");
                }
                show_student_score();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tác thêm không thể thực hiện");
                //MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SCORE_DELETE @MASV,@MAHP", Functions.conn);
            try
            {
                cmd.Parameters.Add("@MASV", SqlDbType.NVarChar).Value = textBox_stuId.Text;
                cmd.Parameters.Add("@MAHP", SqlDbType.NVarChar).Value = textBox_mahp.Text;
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("Xóa thành công");
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Thao tác xóa không thể thực hiện");
                }
                show_student_score();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thao tác xóa không thể thực hiện");
                //MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                textBox_stuId.Text = selectedRow.Cells["Mã sinh viên"].Value.ToString();
                textBox_mahp.Text = selectedRow.Cells["Mã học phần"].Value.ToString();
                textBox_score.Text = selectedRow.Cells["Điểm"].Value.ToString();
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
