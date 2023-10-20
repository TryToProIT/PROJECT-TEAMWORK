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
    public partial class Form_StudentList : Form
    {
        
        public Form_StudentList()
        {
            InitializeComponent();
            Functions.InitConnection();
            List<string> classNames = new List<string>();
            using (SqlCommand cmd = new SqlCommand("class_list", Functions.conn))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        //MessageBox.Show(dr["MALOP"].ToString());

                        classNames.Add(dr["MALOP"].ToString());
                    }
                }
            }
            
            comboBox1.DataSource = classNames;
        }
        
        private DataTable LoadData_StudentList(string classname)
        {
            SqlCommand cmd = new SqlCommand("student_list '" + classname + "'", Functions.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView_StudentList.DataSource = dt;

            return dt;
        }  


        private void comboBox1_SelectionChanged(object sender, EventArgs e)
        {
            string className = comboBox1.SelectedItem.ToString();

            DataTable data = LoadData_StudentList(className);

            bindingSource.DataSource = data;
        }
    }
}
