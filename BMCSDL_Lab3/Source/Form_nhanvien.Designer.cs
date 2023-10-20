namespace BMCSDL_Lab3.Source
{
    partial class Form_nhanvien
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
            this.textBox_manv = new System.Windows.Forms.TextBox();
            this.textBox_fullname = new System.Windows.Forms.TextBox();
            this.textBox_luong = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_passwd = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_manv = new System.Windows.Forms.Label();
            this.label_fullname = new System.Windows.Forms.Label();
            this.label_luong = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_passwd = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_manv
            // 
            this.textBox_manv.Location = new System.Drawing.Point(129, 38);
            this.textBox_manv.Name = "textBox_manv";
            this.textBox_manv.Size = new System.Drawing.Size(183, 26);
            this.textBox_manv.TabIndex = 0;
            // 
            // textBox_fullname
            // 
            this.textBox_fullname.Location = new System.Drawing.Point(510, 38);
            this.textBox_fullname.Name = "textBox_fullname";
            this.textBox_fullname.Size = new System.Drawing.Size(183, 26);
            this.textBox_fullname.TabIndex = 1;
            // 
            // textBox_luong
            // 
            this.textBox_luong.Location = new System.Drawing.Point(510, 106);
            this.textBox_luong.Name = "textBox_luong";
            this.textBox_luong.Size = new System.Drawing.Size(183, 26);
            this.textBox_luong.TabIndex = 2;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(129, 103);
            this.textBox_email.Multiline = true;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(183, 29);
            this.textBox_email.TabIndex = 3;
            // 
            // textBox_passwd
            // 
            this.textBox_passwd.Location = new System.Drawing.Point(510, 171);
            this.textBox_passwd.Name = "textBox_passwd";
            this.textBox_passwd.Size = new System.Drawing.Size(183, 26);
            this.textBox_passwd.TabIndex = 4;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(129, 171);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(183, 26);
            this.textBox_username.TabIndex = 5;
            // 
            // label_manv
            // 
            this.label_manv.AutoSize = true;
            this.label_manv.Location = new System.Drawing.Point(27, 44);
            this.label_manv.Name = "label_manv";
            this.label_manv.Size = new System.Drawing.Size(57, 20);
            this.label_manv.TabIndex = 8;
            this.label_manv.Text = "Mã NV";
            // 
            // label_fullname
            // 
            this.label_fullname.AutoSize = true;
            this.label_fullname.Location = new System.Drawing.Point(411, 44);
            this.label_fullname.Name = "label_fullname";
            this.label_fullname.Size = new System.Drawing.Size(57, 20);
            this.label_fullname.TabIndex = 9;
            this.label_fullname.Text = "Họ tên";
            // 
            // label_luong
            // 
            this.label_luong.AutoSize = true;
            this.label_luong.Location = new System.Drawing.Point(411, 112);
            this.label_luong.Name = "label_luong";
            this.label_luong.Size = new System.Drawing.Size(54, 20);
            this.label_luong.TabIndex = 10;
            this.label_luong.Text = "Lương";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(27, 103);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(48, 20);
            this.label_email.TabIndex = 11;
            this.label_email.Text = "Email";
            // 
            // label_passwd
            // 
            this.label_passwd.AutoSize = true;
            this.label_passwd.Location = new System.Drawing.Point(411, 177);
            this.label_passwd.Name = "label_passwd";
            this.label_passwd.Size = new System.Drawing.Size(75, 20);
            this.label_passwd.TabIndex = 12;
            this.label_passwd.Text = "Mật khẩu";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(7, 177);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(116, 20);
            this.label_username.TabIndex = 13;
            this.label_username.Text = "Tên đăng nhập";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(970, 350);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            //this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(218, 245);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 32);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(415, 245);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 32);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Form_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 499);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_passwd);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_luong);
            this.Controls.Add(this.label_fullname);
            this.Controls.Add(this.label_manv);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.textBox_passwd);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_luong);
            this.Controls.Add(this.textBox_fullname);
            this.Controls.Add(this.textBox_manv);
            this.Name = "Form_nhanvien";
            this.Text = "Form_nhanvien";
            this.Load += new System.EventHandler(this.Form_modifyStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_manv;
        private System.Windows.Forms.TextBox textBox_fullname;
        private System.Windows.Forms.TextBox textBox_luong;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_passwd;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_manv;
        private System.Windows.Forms.Label label_fullname;
        private System.Windows.Forms.Label label_luong;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_passwd;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
    }
}