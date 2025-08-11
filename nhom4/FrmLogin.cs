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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txt_Pass.PasswordChar = '*'; // Ẩn mật khẩu mặc định
            this.txt_Username.KeyDown += txt_Username_KeyDown;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.txt_Username.Focus();
            this.txt_Username.Focus();
            this.txt_Username.KeyDown += txt_Username_KeyDown;
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
            FrmRegister Form_register = new FrmRegister();
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

                    AppSession.CurrentUser = user;
                    MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    FrmTrangChu frm = new FrmTrangChu();
                    frm.ShowDialog();
                    this.Show();
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
            FrmForgotPassword Form_forgotPassword = new FrmForgotPassword();
            Form_forgotPassword.Show();
        }

        private void txt_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Nếu nhấn phím Enter
            {
                btn_DangNhap.PerformClick(); // Giả lập click vào nút đăng nhập
                e.Handled = true;            // Đánh dấu là đã xử lý phím này
                e.SuppressKeyPress = true;   // Không phát ra tiếng beep hoặc xuống dòng
            }
        }
        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true; // Không phát ra tiếng beep, không xuống dòng
                txt_Pass.Focus(); // Di chuyển xuống textbox mật khẩu
            }
        }

        private void txt_Username_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                txt_Pass.Focus();
            }
        }

        private void chk_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ShowPass.Checked)
            {
                txt_Pass.PasswordChar = '\0'; // Hiện mật khẩu
            }
            else
            {
                txt_Pass.PasswordChar = '*'; // Ẩn mật khẩu
            }
        }
    }
}


