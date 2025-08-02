namespace nhom4
{
    partial class Form_Register
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
            this.link_Back = new System.Windows.Forms.LinkLabel();
            this.link_ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_HoVaTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radio_Admin = new System.Windows.Forms.RadioButton();
            this.radioUser = new System.Windows.Forms.RadioButton();
            this.label_Role = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // link_Back
            // 
            this.link_Back.AutoSize = true;
            this.link_Back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.link_Back.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.link_Back.Location = new System.Drawing.Point(332, 703);
            this.link_Back.Name = "link_Back";
            this.link_Back.Size = new System.Drawing.Size(89, 23);
            this.link_Back.TabIndex = 13;
            this.link_Back.TabStop = true;
            this.link_Back.Text = "Quay Lại";
            this.link_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Back_LinkClicked);
            // 
            // link_ForgotPassword
            // 
            this.link_ForgotPassword.AutoSize = true;
            this.link_ForgotPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.link_ForgotPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.link_ForgotPassword.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.link_ForgotPassword.Location = new System.Drawing.Point(63, 703);
            this.link_ForgotPassword.Name = "link_ForgotPassword";
            this.link_ForgotPassword.Size = new System.Drawing.Size(149, 23);
            this.link_ForgotPassword.TabIndex = 12;
            this.link_ForgotPassword.TabStop = true;
            this.link_ForgotPassword.Text = "Quên Mật Khẩu ";
            this.link_ForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_FormLogin_LinkClicked);
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.BackColor = System.Drawing.Color.LightCoral;
            this.btn_DangKy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.Location = new System.Drawing.Point(63, 618);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(354, 49);
            this.btn_DangKy.TabIndex = 11;
            this.btn_DangKy.Text = "Đăng Ký";
            this.btn_DangKy.UseVisualStyleBackColor = false;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // txt_Pass
            // 
            this.txt_Pass.AcceptsTab = true;
            this.txt_Pass.BackColor = System.Drawing.Color.LightGray;
            this.txt_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Pass.Location = new System.Drawing.Point(67, 413);
            this.txt_Pass.Multiline = true;
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(354, 38);
            this.txt_Pass.TabIndex = 2;
            this.txt_Pass.UseSystemPasswordChar = true;
            this.txt_Pass.TextChanged += new System.EventHandler(this.txt_Pass_TextChanged);
            this.txt_Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Pass_KeyDown);
            // 
            // txt_Username
            // 
            this.txt_Username.AcceptsTab = true;
            this.txt_Username.BackColor = System.Drawing.Color.LightGray;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Location = new System.Drawing.Point(63, 318);
            this.txt_Username.Multiline = true;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(354, 38);
            this.txt_Username.TabIndex = 1;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_Username_TextChanged);
            this.txt_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Username_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(63, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật Khẩu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(63, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số Điện Thoại";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_SDT
            // 
            this.txt_SDT.AcceptsTab = true;
            this.txt_SDT.BackColor = System.Drawing.Color.LightGray;
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SDT.Location = new System.Drawing.Point(67, 505);
            this.txt_SDT.Multiline = true;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(354, 38);
            this.txt_SDT.TabIndex = 3;
            this.txt_SDT.TextChanged += new System.EventHandler(this.txt_SDT_TextChanged);
            this.txt_SDT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SDT_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(59, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên Đăng Nhập";
            // 
            // txt_HoVaTen
            // 
            this.txt_HoVaTen.BackColor = System.Drawing.Color.LightGray;
            this.txt_HoVaTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_HoVaTen.Location = new System.Drawing.Point(63, 221);
            this.txt_HoVaTen.Multiline = true;
            this.txt_HoVaTen.Name = "txt_HoVaTen";
            this.txt_HoVaTen.Size = new System.Drawing.Size(354, 38);
            this.txt_HoVaTen.TabIndex = 0;
            this.txt_HoVaTen.TextChanged += new System.EventHandler(this.txt_HoVaTen_TextChanged);
            this.txt_HoVaTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_HoVaTen_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(59, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Họ Và Tên";
            // 
            // radio_Admin
            // 
            this.radio_Admin.AutoSize = true;
            this.radio_Admin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_Admin.Location = new System.Drawing.Point(172, 564);
            this.radio_Admin.Name = "radio_Admin";
            this.radio_Admin.Size = new System.Drawing.Size(85, 27);
            this.radio_Admin.TabIndex = 21;
            this.radio_Admin.TabStop = true;
            this.radio_Admin.Text = "Admin";
            this.radio_Admin.UseVisualStyleBackColor = true;
            this.radio_Admin.CheckedChanged += new System.EventHandler(this.radio_Admin_CheckedChanged);
            // 
            // radioUser
            // 
            this.radioUser.AutoSize = true;
            this.radioUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.radioUser.Location = new System.Drawing.Point(313, 564);
            this.radioUser.Name = "radioUser";
            this.radioUser.Size = new System.Drawing.Size(71, 27);
            this.radioUser.TabIndex = 22;
            this.radioUser.TabStop = true;
            this.radioUser.Text = "User";
            this.radioUser.UseVisualStyleBackColor = true;
            this.radioUser.CheckedChanged += new System.EventHandler(this.radioUser_CheckedChanged);
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label_Role.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_Role.Location = new System.Drawing.Point(63, 568);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(72, 23);
            this.label_Role.TabIndex = 23;
            this.label_Role.Text = "Vai Trò";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::nhom4.Properties.Resources.pet_shop;
            this.pictureBox1.Location = new System.Drawing.Point(172, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 771);
            this.Controls.Add(this.label_Role);
            this.Controls.Add(this.radioUser);
            this.Controls.Add(this.radio_Admin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_HoVaTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.link_Back);
            this.Controls.Add(this.link_ForgotPassword);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.Form_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel link_Back;
        private System.Windows.Forms.LinkLabel link_ForgotPassword;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_HoVaTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioUser;
        private System.Windows.Forms.RadioButton radio_Admin;
        private System.Windows.Forms.Label label_Role;
    }
}