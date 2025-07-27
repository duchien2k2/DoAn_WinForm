using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhom4.Models
{


    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {

        private User currentUser;
        public XtraForm1(User user)
        {
            InitializeComponent();
            currentUser = user; // lưu lại người đăng nhập
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void imageEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void svgImageBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                // Gán text cho label
                lbl_UserInfo.Text = $"{currentUser.TenDangNhap} ({currentUser.VaiTro})";

                // Gán ảnh tương ứng
                string imagePath = "";

                if (currentUser.VaiTro == "Admin")
                {
                    imagePath = @"Images\admin.jpg";
                }
                else
                {
                    imagePath = @"Images\User.jpg";
                }

                if (System.IO.File.Exists(imagePath))
                {
                    pic_UserIcon.Image = Image.FromFile(imagePath);
                }

                // Tuỳ chỉnh PictureEdit
                pic_UserIcon.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
                pic_UserIcon.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            }
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_Login form_Login = new Form_Login();
            form_Login.Show();
        }

        private void btn_FormAdmin_Click(object sender, EventArgs e)
        {
            if (currentUser != null && currentUser.VaiTro == "Admin")
            {
                Form_Admin formAdmin = new Form_Admin();
                formAdmin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập khu vực Admin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}