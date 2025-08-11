using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nhom4.Models;
using nhom4;

namespace nhom4
{
    public partial class FrmTrangChu : Form
    {
        private Panel scrollPanel;

        public FrmTrangChu()
        {
            InitializeComponent();

            // Create and configure the scrollable panel
            scrollPanel = new Panel
            {
                AutoScroll = true,
                Dock = DockStyle.Fill,
                Name = "scrollPanel"
            };

            // Set the panel's size to be larger than the form vertically
            scrollPanel.Size = new Size(this.ClientSize.Width, this.ClientSize.Height * 2);

            // Move all existing controls (except scrollPanel) into the scrollPanel
            var controlsToMove = this.Controls.Cast<Control>().ToArray();
            this.Controls.Clear();
            scrollPanel.Controls.AddRange(controlsToMove);

            // Add the scrollPanel to the form
            this.Controls.Add(scrollPanel);
        }

        private void FrmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void BtnSanPham_Click(object sender, EventArgs e)
        {
            FrmSanPham frmSanPham = new FrmSanPham();
            frmSanPham.ShowDialog();
        }

        private void BtnSpa_Click(object sender, EventArgs e)
        {
            FrmSpa frmSpa = new FrmSpa();
            frmSpa.ShowDialog();
        }

        private void BtnHotel_Click(object sender, EventArgs e)
        {
            FrmHotelThuCung frmHotel = new FrmHotelThuCung();
            frmHotel.ShowDialog();
        }

        private void BtnGioHang_Click(object sender, EventArgs e)
        {
            FrmGioHang frmGioHang = new FrmGioHang();
            frmGioHang.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnNhanVien_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();
            frmAdmin.ShowDialog();
        }

        private void BtnHoaDon_Click(object sender, EventArgs e)
        {
            var f = new FrmQuanLyHoaDon();
            f.ShowDialog();
        }

        private void BtnKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
