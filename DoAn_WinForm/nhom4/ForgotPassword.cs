using DevExpress.PivotGrid.OLAP.Mdx;
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
    public partial class Form_ForgotPassword : Form
    {
        public Form_ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_SDT_TextChanged(object sender, EventArgs e)
        {
            string sdt = txt_SDT.Text;
            if (!sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa chữ số.");
                txt_SDT.Text = ""; // Xoá hoặc giữ tuỳ bạn
                txt_SDT.Focus();
            }
        }


        private void txt_PassNew_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ComPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_Login Form_login = new Form_Login();
            Form_login.Show();
        }

        private void link_FormRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_Register Form_Register = new Form_Register();
            Form_Register.Show();
        }

        private void btn_DongY_Click(object sender, EventArgs e)
        {
            string sdt = txt_SDT.Text.Trim();
            string passNew = txt_PassNew.Text.Trim();
            string confirmPass = txt_ComPass.Text.Trim();

            if (sdt == "" || passNew == "" || confirmPass == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (passNew != confirmPass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.");
                return;
            }

            using (var db = new Models.PetShopContextDB()) // đổi lại tên DbContext nếu khác
            {
                var user = db.Users.FirstOrDefault(u => u.SoDienThoai == sdt);

                if (user == null)
                {
                    MessageBox.Show("Số điện thoại không tồn tại.");
                    return;
                }

                // Cập nhật mật khẩu mới
                user.MatKhau = passNew;

                db.SaveChanges();

                MessageBox.Show("Đổi mật khẩu thành công. Hãy đăng nhập lại.");

                // Chuyển về form login
                this.Hide();
                Form_Login f = new Form_Login();
                f.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_ComPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_DongY.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }


        }

        private void txt_SDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn không cho xuống dòng
            }
        }

        private void txt_PassNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txt_ComPass.Focus(); // focus ô kế tiếp
            }
        }
    }
}