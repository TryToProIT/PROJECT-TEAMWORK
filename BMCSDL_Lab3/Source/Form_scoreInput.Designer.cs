namespace BMCSDL_Lab3.Source
{
    partial class Form_scoreInput
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
            this.label_stuId = new System.Windows.Forms.Label();
            this.label_mahp = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.textBox_stuId = new System.Windows.Forms.TextBox();
            this.textBox_mahp = new System.Windows.Forms.TextBox();
            this.textBox_score = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_stuId
            // 
            this.label_stuId.AutoSize = true;
            this.label_stuId.Location = new System.Drawing.Point(75, 47);
            this.label_stuId.Name = "label_stuId";
            this.label_stuId.Size = new System.Drawing.Size(117, 20);
            this.label_stuId.TabIndex = 0;
            this.label_stuId.Text = "Mã số sinh viên";
            // 
            // label_mahp
            // 
            this.label_mahp.AutoSize = true;
            this.label_mahp.Location = new System.Drawing.Point(75, 109);
            this.label_mahp.Name = "label_mahp";
            this.label_mahp.Size = new System.Drawing.Size(101, 20);
            this.label_mahp.TabIndex = 1;
            this.label_mahp.Text = "Mã học phần";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Location = new System.Drawing.Point(79, 182);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(46, 20);
            this.label_score.TabIndex = 2;
            this.label_score.Text = "Điểm";
            // 
            // textBox_stuId
            // 
            this.textBox_stuId.Location = new System.Drawing.Point(255, 47);
            this.textBox_stuId.Name = "textBox_stuId";
            this.textBox_stuId.Size = new System.Drawing.Size(144, 26);
            this.textBox_stuId.TabIndex = 3;
            // 
            // textBox_mahp
            // 
            this.textBox_mahp.Location = new System.Drawing.Point(255, 109);
            this.textBox_mahp.Name = "textBox_mahp";
            this.textBox_mahp.Size = new System.Drawing.Size(144, 26);
            this.textBox_mahp.TabIndex = 3;
            // 
            // textBox_score
            // 
            this.textBox_score.Location = new System.Drawing.Point(255, 182);
            this.textBox_score.Name = "textBox_score";
            this.textBox_score.Size = new System.Drawing.Size(144, 26);
            this.textBox_score.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(535, 180);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(98, 30);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Nhập";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(970, 350);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(535, 109);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 30);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Form_scoreInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 499);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.textBox_score);
            this.Controls.Add(this.textBox_mahp);
            this.Controls.Add(this.textBox_stuId);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_mahp);
            this.Controls.Add(this.label_stuId);
            this.Name = "Form_scoreInput";
            this.Text = "Form_scoreInput";
            this.Load += new System.EventHandler(this.Form_scoreInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_stuId;
        private System.Windows.Forms.Label label_mahp;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.TextBox textBox_stuId;
        private System.Windows.Forms.TextBox textBox_mahp;
        private System.Windows.Forms.TextBox textBox_score;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_delete;
    }
}