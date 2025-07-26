using nhom4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhom4
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.txt_Username.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_Register Form_register = new Form_Register();
            Form_register.Show();
        }

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {

        }
        // dang nhap day nha anh em !!!
        private void btn_DangNhap_Click(object sender, EventArgs e)
            {
                string tenDangNhap = txt_Username.Text.Trim();
                string matKhau = txt_Pass.Text.Trim();

                if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var db = new PetShopContextDB())
                {
                    var user = db.Users.FirstOrDefault(u => u.TenDangNhap == tenDangNhap && u.MatKhau == matKhau);

                    if (user != null)
                    {
                        if (user.TrangThai == false)
                        {
                            MessageBox.Show("Tài khoản đã bị khóa. Vui lòng liên hệ quản trị viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        XtraForm1 dashboard = new XtraForm1(); // Nếu bạn đổi tên form thì sửa lại ở đây
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


    private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_ForgotPassword Form_forgotPassword = new Form_ForgotPassword();
            Form_forgotPassword.Show();
        }
    }
}
