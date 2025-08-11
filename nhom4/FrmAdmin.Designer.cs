namespace nhom4
{
    partial class FrmAdmin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_LockUser = new System.Windows.Forms.Button();
            this.txt_HoVaTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_VaiTro = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.comboBox_TrangThai = new System.Windows.Forms.ComboBox();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNV,
            this.colHoTen,
            this.colSDT,
            this.colVaiTro,
            this.colTrangThai,
            this.colTenDangNhap});
            this.dataGridView1.Location = new System.Drawing.Point(294, 127);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(837, 509);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // colMaNV
            // 
            this.colMaNV.HeaderText = "Mã NV";
            this.colMaNV.MinimumWidth = 10;
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Width = 125;
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ Và Tên";
            this.colHoTen.MinimumWidth = 10;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 125;
            // 
            // colSDT
            // 
            this.colSDT.HeaderText = "Số Điện Thoại";
            this.colSDT.MinimumWidth = 10;
            this.colSDT.Name = "colSDT";
            this.colSDT.Width = 125;
            // 
            // colVaiTro
            // 
            this.colVaiTro.HeaderText = "Vai Trò";
            this.colVaiTro.MinimumWidth = 10;
            this.colVaiTro.Name = "colVaiTro";
            this.colVaiTro.Width = 125;
            // 
            // colTrangThai
            // 
            this.colTrangThai.FillWeight = 200F;
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Width = 125;
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.HeaderText = "Tên Đăng Nhập ";
            this.colTenDangNhap.MinimumWidth = 6;
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.Width = 125;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(356, 37);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(89, 47);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(500, 37);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(86, 47);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(644, 37);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(93, 47);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_LockUser
            // 
            this.btn_LockUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_LockUser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LockUser.Location = new System.Drawing.Point(786, 37);
            this.btn_LockUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LockUser.Name = "btn_LockUser";
            this.btn_LockUser.Size = new System.Drawing.Size(110, 47);
            this.btn_LockUser.TabIndex = 5;
            this.btn_LockUser.Text = "Khóa /Sửa Nhân Viên";
            this.btn_LockUser.UseVisualStyleBackColor = false;
            this.btn_LockUser.Click += new System.EventHandler(this.btn_LockUser_Click);
            // 
            // txt_HoVaTen
            // 
            this.txt_HoVaTen.Location = new System.Drawing.Point(121, 187);
            this.txt_HoVaTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_HoVaTen.Name = "txt_HoVaTen";
            this.txt_HoVaTen.Size = new System.Drawing.Size(149, 21);
            this.txt_HoVaTen.TabIndex = 6;
            this.txt_HoVaTen.TextChanged += new System.EventHandler(this.txt_HoVaTen_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Họ Và Tên";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(121, 253);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(149, 21);
            this.txt_SDT.TabIndex = 8;
            this.txt_SDT.TextChanged += new System.EventHandler(this.txt_SDT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(10, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(10, 321);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vai Trò";
            // 
            // comboBox_VaiTro
            // 
            this.comboBox_VaiTro.FormattingEnabled = true;
            this.comboBox_VaiTro.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboBox_VaiTro.Location = new System.Drawing.Point(121, 313);
            this.comboBox_VaiTro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_VaiTro.Name = "comboBox_VaiTro";
            this.comboBox_VaiTro.Size = new System.Drawing.Size(149, 23);
            this.comboBox_VaiTro.TabIndex = 11;
            this.comboBox_VaiTro.SelectedIndexChanged += new System.EventHandler(this.comboBox_VaiTro_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(10, 465);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Trạng Thái";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Exit.Location = new System.Drawing.Point(26, 583);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(84, 39);
            this.btn_Exit.TabIndex = 14;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // comboBox_TrangThai
            // 
            this.comboBox_TrangThai.FormattingEnabled = true;
            this.comboBox_TrangThai.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.comboBox_TrangThai.Location = new System.Drawing.Point(121, 457);
            this.comboBox_TrangThai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_TrangThai.Name = "comboBox_TrangThai";
            this.comboBox_TrangThai.Size = new System.Drawing.Size(149, 23);
            this.comboBox_TrangThai.TabIndex = 15;
            this.comboBox_TrangThai.SelectedIndexChanged += new System.EventHandler(this.comboBox_TrangThai_SelectedIndexChanged);
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(121, 392);
            this.txt_TenDangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(149, 21);
            this.txt_TenDangNhap.TabIndex = 16;
            this.txt_TenDangNhap.TextChanged += new System.EventHandler(this.txt_TenDangNhap_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(10, 398);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tên Đăng Nhập ";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1141, 647);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Controls.Add(this.comboBox_TrangThai);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_VaiTro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_HoVaTen);
            this.Controls.Add(this.btn_LockUser);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAdmin";
            this.Text = "Form_Admin";
            this.Load += new System.EventHandler(this.Form_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_LockUser;
        private System.Windows.Forms.TextBox txt_HoVaTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_VaiTro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ComboBox comboBox_TrangThai;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
    }
}