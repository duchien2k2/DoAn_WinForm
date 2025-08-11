namespace nhom4
{
    partial class FrmForgotPassword
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
            this.link_FormRegister = new System.Windows.Forms.LinkLabel();
            this.btn_DongY = new System.Windows.Forms.Button();
            this.txt_PassNew = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_ComPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // link_Back
            // 
            this.link_Back.AutoSize = true;
            this.link_Back.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.link_Back.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.link_Back.Location = new System.Drawing.Point(254, 514);
            this.link_Back.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_Back.Name = "link_Back";
            this.link_Back.Size = new System.Drawing.Size(65, 19);
            this.link_Back.TabIndex = 14;
            this.link_Back.TabStop = true;
            this.link_Back.Text = "Quay lại";
            this.link_Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Back_LinkClicked);
            // 
            // link_FormRegister
            // 
            this.link_FormRegister.AutoSize = true;
            this.link_FormRegister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.link_FormRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.link_FormRegister.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.link_FormRegister.Location = new System.Drawing.Point(56, 514);
            this.link_FormRegister.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_FormRegister.Name = "link_FormRegister";
            this.link_FormRegister.Size = new System.Drawing.Size(143, 19);
            this.link_FormRegister.TabIndex = 13;
            this.link_FormRegister.TabStop = true;
            this.link_FormRegister.Text = "Đăng Ký Tài Khoản";
            this.link_FormRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_FormRegister_LinkClicked);
            // 
            // btn_DongY
            // 
            this.btn_DongY.BackColor = System.Drawing.Color.LightCoral;
            this.btn_DongY.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DongY.Location = new System.Drawing.Point(58, 422);
            this.btn_DongY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DongY.Name = "btn_DongY";
            this.btn_DongY.Size = new System.Drawing.Size(266, 40);
            this.btn_DongY.TabIndex = 12;
            this.btn_DongY.Text = "Đồng Ý";
            this.btn_DongY.UseVisualStyleBackColor = false;
            this.btn_DongY.Click += new System.EventHandler(this.btn_DongY_Click);
            // 
            // txt_PassNew
            // 
            this.txt_PassNew.AcceptsTab = true;
            this.txt_PassNew.BackColor = System.Drawing.Color.LightGray;
            this.txt_PassNew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PassNew.Location = new System.Drawing.Point(58, 292);
            this.txt_PassNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_PassNew.Multiline = true;
            this.txt_PassNew.Name = "txt_PassNew";
            this.txt_PassNew.Size = new System.Drawing.Size(266, 31);
            this.txt_PassNew.TabIndex = 1;
            this.txt_PassNew.UseSystemPasswordChar = true;
            this.txt_PassNew.TextChanged += new System.EventHandler(this.txt_PassNew_TextChanged);
            this.txt_PassNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_PassNew_KeyDown);
            // 
            // txt_SDT
            // 
            this.txt_SDT.AcceptsTab = true;
            this.txt_SDT.BackColor = System.Drawing.Color.LightGray;
            this.txt_SDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SDT.Location = new System.Drawing.Point(58, 212);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_SDT.Multiline = true;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(266, 31);
            this.txt_SDT.TabIndex = 0;
            this.txt_SDT.TextChanged += new System.EventHandler(this.txt_SDT_TextChanged);
            this.txt_SDT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SDT_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(56, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(55, 181);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Số Điện Thoại";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::nhom4.Properties.Resources.pet_shop;
            this.pictureBox1.Location = new System.Drawing.Point(141, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_ComPass
            // 
            this.txt_ComPass.AcceptsTab = true;
            this.txt_ComPass.BackColor = System.Drawing.Color.LightGray;
            this.txt_ComPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ComPass.Location = new System.Drawing.Point(58, 367);
            this.txt_ComPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ComPass.Multiline = true;
            this.txt_ComPass.Name = "txt_ComPass";
            this.txt_ComPass.Size = new System.Drawing.Size(266, 31);
            this.txt_ComPass.TabIndex = 2;
            this.txt_ComPass.TextChanged += new System.EventHandler(this.txt_ComPass_TextChanged);
            this.txt_ComPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ComPass_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(55, 336);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = " Nhập Lại Mật Khẩu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // FrmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 588);
            this.Controls.Add(this.txt_ComPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.link_Back);
            this.Controls.Add(this.link_FormRegister);
            this.Controls.Add(this.btn_DongY);
            this.Controls.Add(this.txt_PassNew);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel link_Back;
        private System.Windows.Forms.LinkLabel link_FormRegister;
        private System.Windows.Forms.Button btn_DongY;
        private System.Windows.Forms.TextBox txt_PassNew;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ComPass;
        private System.Windows.Forms.Label label3;
    }
}