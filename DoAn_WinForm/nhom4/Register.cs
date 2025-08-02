using nhom4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace nhom4
{
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }

        private void Form_Register_Load(object sender, EventArgs e)
        {
            txt_HoVaTen.Focus();
       


        }

        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_HoVaTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {
            txt_Pass.PasswordChar = '*'; // Ẩn mật khẩu bằng ký tự *

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radio_Admin_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Admin.Checked)
            {
                Form_AdminPassword f = new Form_AdminPassword();
                f.ShowDialog(); // Mở form nhập mật khẩu

                if (f.IsPasswordCorrect)
                {
                    // Cho phép chọn Admin, không cần làm gì thêm
                }
                else
                {
                    // Nếu sai mật khẩu → chuyển về radio User
                    radioUser.Checked = true;
                }
            }
        }

        private void radioUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string hoVaTen = txt_HoVaTen.Text.Trim();
            string tenDangNhap = txt_Username.Text.Trim();
            string matKhau = txt_Pass.Text.Trim();
            string soDienThoai = txt_SDT.Text.Trim();
            string vaiTro = radio_Admin.Checked ? "Admin" : "User";

            // Kiểm tra trống
            if (string.IsNullOrEmpty(hoVaTen) || string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(soDienThoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //kiem  tra mat khau dai hon 6 ky tu
            if (matKhau.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra họ tên không chứa số
            if (hoVaTen.Any(char.IsDigit))
            {
                MessageBox.Show("Họ và tên không được chứa số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mật khẩu chỉ chứa số
            if (!matKhau.All(char.IsDigit))
            {
                MessageBox.Show("Mật khẩu chỉ được chứa số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Số điện thoại chỉ chứa số
            if (!soDienThoai.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new PetShopContextDB())
            {
                // Kiểm tra trùng số điện thoại
                var existingPhone = db.Users.FirstOrDefault(u => u.SoDienThoai == soDienThoai);
                if (existingPhone != null)
                {
                    MessageBox.Show("Số điện thoại đã được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra trùng tên đăng nhập
                var existingUser = db.Users.FirstOrDefault(u => u.TenDangNhap == tenDangNhap);
                if (existingUser != null)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo user mới
                var newUser = new User
                {
                    HoVaTen = hoVaTen,
                    TenDangNhap = tenDangNhap,
                    MatKhau = matKhau,
                    SoDienThoai = soDienThoai,
                    VaiTro = vaiTro,
                    TrangThai = true
                };

                db.Users.Add(newUser);
                db.SaveChanges();

                MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chuyển về form Login
                this.Hide();
                Form_Login Form_Login = new Form_Login();
                Form_Login.Show();
               

            }
        }


        private void link_FormLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_ForgotPassword Form_ForgotPassword = new Form_ForgotPassword();
            Form_ForgotPassword.Show();
        }

        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_Login Form_login = new Form_Login();
            Form_login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_HoVaTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Không cho xuống dòng
            }
        }

        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Không cho xuống dòng
            }
        }

        private void txt_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Không cho xuống dòng
            }
        }

        private void txt_SDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Không cho xuống dòng
            }
        }

       
    }
}
