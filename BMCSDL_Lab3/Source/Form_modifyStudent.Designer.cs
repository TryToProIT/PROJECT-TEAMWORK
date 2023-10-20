namespace BMCSDL_Lab3.Source
{
    partial class Form_modifyStudent
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
            this.textBox_stuId = new System.Windows.Forms.TextBox();
            this.textBox_fullname = new System.Windows.Forms.TextBox();
            this.textBox_bday = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_classid = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_stuId = new System.Windows.Forms.Label();
            this.label_fullname = new System.Windows.Forms.Label();
            this.label_bday = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_classid = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_stuId
            // 
            this.textBox_stuId.Location = new System.Drawing.Point(129, 38);
            this.textBox_stuId.Name = "textBox_stuId";
            this.textBox_stuId.Size = new System.Drawing.Size(183, 26);
            this.textBox_stuId.TabIndex = 0;
            // 
            // textBox_fullname
            // 
            this.textBox_fullname.Location = new System.Drawing.Point(129, 106);
            this.textBox_fullname.Name = "textBox_fullname";
            this.textBox_fullname.Size = new System.Drawing.Size(183, 26);
            this.textBox_fullname.TabIndex = 1;
            // 
            // textBox_bday
            // 
            this.textBox_bday.Location = new System.Drawing.Point(129, 162);
            this.textBox_bday.Name = "textBox_bday";
            this.textBox_bday.Size = new System.Drawing.Size(183, 26);
            this.textBox_bday.TabIndex = 2;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(510, 103);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(183, 85);
            this.textBox_address.TabIndex = 3;
            // 
            // textBox_classid
            // 
            this.textBox_classid.Location = new System.Drawing.Point(129, 223);
            this.textBox_classid.Name = "textBox_classid";
            this.textBox_classid.Size = new System.Drawing.Size(183, 26);
            this.textBox_classid.TabIndex = 4;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(510, 38);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(183, 26);
            this.textBox_username.TabIndex = 5;
            // 
            // label_stuId
            // 
            this.label_stuId.AutoSize = true;
            this.label_stuId.Location = new System.Drawing.Point(27, 44);
            this.label_stuId.Name = "label_stuId";
            this.label_stuId.Size = new System.Drawing.Size(96, 20);
            this.label_stuId.TabIndex = 8;
            this.label_stuId.Text = "Mã sinh viên";
            // 
            // label_fullname
            // 
            this.label_fullname.AutoSize = true;
            this.label_fullname.Location = new System.Drawing.Point(44, 106);
            this.label_fullname.Name = "label_fullname";
            this.label_fullname.Size = new System.Drawing.Size(57, 20);
            this.label_fullname.TabIndex = 9;
            this.label_fullname.Text = "Họ tên";
            // 
            // label_bday
            // 
            this.label_bday.AutoSize = true;
            this.label_bday.Location = new System.Drawing.Point(27, 168);
            this.label_bday.Name = "label_bday";
            this.label_bday.Size = new System.Drawing.Size(78, 20);
            this.label_bday.TabIndex = 10;
            this.label_bday.Text = "Ngày sinh";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(411, 106);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(57, 20);
            this.label_address.TabIndex = 11;
            this.label_address.Text = "Địa chỉ";
            // 
            // label_classid
            // 
            this.label_classid.AutoSize = true;
            this.label_classid.Location = new System.Drawing.Point(44, 229);
            this.label_classid.Name = "label_classid";
            this.label_classid.Size = new System.Drawing.Size(56, 20);
            this.label_classid.TabIndex = 12;
            this.label_classid.Text = "Mã lớp";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(381, 41);
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
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(415, 223);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 32);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(535, 223);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(94, 32);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(659, 223);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 32);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Form_modifyStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 499);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_classid);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_bday);
            this.Controls.Add(this.label_fullname);
            this.Controls.Add(this.label_stuId);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.textBox_classid);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_bday);
            this.Controls.Add(this.textBox_fullname);
            this.Controls.Add(this.textBox_stuId);
            this.Name = "Form_modifyStudent";
            this.Text = "Form_modifyStudent";
            this.Load += new System.EventHandler(this.Form_modifyStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_stuId;
        private System.Windows.Forms.TextBox textBox_fullname;
        private System.Windows.Forms.TextBox textBox_bday;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_classid;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_stuId;
        private System.Windows.Forms.Label label_fullname;
        private System.Windows.Forms.Label label_bday;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_classid;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
    }
}