using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMCSDL_Lab3.Source;


namespace BMCSDL_Lab3.Source
{
    public partial class Form_Main : Form
    {
        Thread t;
        public Form_Main(String uname)
        {

            InitializeComponent();
            label_uname.Text = uname;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            
           Set_Center_Username();
        }

        //mở một form con
        private Form activeForm = null;
        private void MDIChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_childform.Controls.Add(childForm);
            panel_childform.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //xử lý đăng lại và đăng xuất
        public void open_FormLogin(object obj)
        {
            Application.Run(new Form_Login());
        }

        
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(open_FormLogin);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void btn_StudentList_Click(object sender, EventArgs e)
        {
            MDIChildForm(new Form_StudentList());
            
        }

        private void btn_modifyStudent_Click(object sender, EventArgs e)
        {
            MDIChildForm(new Form_modifyStudent());
        }

        private void btn_scoreInput_Click(object sender, EventArgs e)
        {
            MDIChildForm(new Form_scoreInput());
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            MDIChildForm(new Form_nhanvien());
        }
        private void Set_Center_Username()
        {
            int y = (panel_uname.Height / 2) - (label_uname.Height / 2);
            int x = (panel_uname.Width / 2) - (label_uname.Width / 2);
            label_uname.Location = new Point(x, y - 15);
            // label_welcome.Location = new Point(x,y-40);
        }

        private void panel_childform_paint(object sender, PaintEventArgs e) { }

        
    }
}
