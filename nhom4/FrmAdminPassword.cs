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
    public partial class FrmAdminPassword : Form
    {
        public bool IsPasswordCorrect { get; private set; } = false;

        public FrmAdminPassword()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_AdminPassword_Load(object sender, EventArgs e)
        {

        }

        private void txt_AdminPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            string password = txt_AdminPassword.Text.Trim();

            if (password == "admin") // mật khẩu admin cố định
            {
                IsPasswordCorrect = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu admin không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_AdminPassword.Clear();
                txt_AdminPassword.Focus();
            }
        }
    }
}
