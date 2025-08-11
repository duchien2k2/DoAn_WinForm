using nhom4.Models;
using nhom4.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace nhom4
{
    public partial class FrmHotelThuCung : Form
    {
        private Button phongDangChon = null;
        private Dictionary<Button, string> danhSachPhong = new Dictionary<Button, string>();
        private readonly PetHotelService _hotelService = new PetHotelService();

        public FrmHotelThuCung()
        {
            InitializeComponent();
        }

        // Khi form load: lấy danh sách phòng, tạo button cho từng phòng và hiển thị lên giao diện
        private void frmHotelThuCung_Load(object sender, EventArgs e)
        {
            var danhSach = _hotelService.GetDanhSachPhong();
            foreach (var (maPhong, trangThai) in danhSach)
            {
                // Tạo button đại diện cho mỗi phòng
                Button btn = new Button
                {
                    Text = maPhong,
                    Width = 60,
                    Height = 60,
                    Margin = new Padding(5),
                    BackColor = Color.White
                };

                // Đổi màu theo trạng thái phòng
                if (trangThai == "DangGiu")
                    btn.BackColor = Color.Gold;
                else if (trangThai == "SapNhan")
                    btn.BackColor = Color.DeepSkyBlue;

                // Gán sự kiện click cho button phòng
                btn.Click += Btn_Click;
                danhSachPhong.Add(btn, maPhong);
                flpPhong.Controls.Add(btn);
            }
        }

        // Xử lý khi click vào một phòng: chọn phòng, đổi màu, hiển thị thông tin phòng
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            // Nếu đã chọn phòng khác trước đó thì trả lại màu cũ
            if (phongDangChon != null && phongDangChon.BackColor == Color.LightGreen)
                phongDangChon.BackColor = Color.White;

            phongDangChon = btn;
            lblPhongDangChon.Text = $"Phòng đang chọn: {btn.Text}";

            // Nếu phòng đã được đặt thì thông báo, không cho chọn
            if (btn.BackColor == Color.Gold || btn.BackColor == Color.DeepSkyBlue)
            {
                MessageBox.Show("Phòng này đã được đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Đổi màu phòng đang chọn
                btn.BackColor = Color.LightGreen;
            }

            // Hiển thị thông tin chi tiết của phòng
            HienThongTinPhong(btn.Text);
        }

        // Hiển thị thông tin chi tiết về thú cưng và dịch vụ giữ trong phòng
        private void HienThongTinPhong(string maPhong)
        {
            var (thuCung, loai, giu) = _hotelService.GetThongTinPhong(maPhong);

            if (thuCung != null && loai != null && giu != null)
            {
                lblTenThuCung.Text = "Tên: " + thuCung.TenThuCung;
                lblLoaiThuCung.Text = "Loại: " + loai.TenLoai;
                lblGioiTinh.Text = "Giới tính: " + thuCung.GioiTinh;
                lblNgayGiu.Text = "Ngày gửi: " + giu.NgayGiu.ToShortDateString();
                lblNgayNhan.Text = "Ngày nhận: " + giu.NgayNhan.ToShortDateString();
                //lblTinhTrang.Text = "Tình trạng: " + giu.TinhTrang;

                // Tính số ngày còn lại đến ngày nhận để phân loại “Sắp nhận”
                string hienThiTrangThai;
                if (string.Equals(giu.TinhTrang, "TrongPhong", StringComparison.OrdinalIgnoreCase))
                {
                    var daysLeft = (giu.NgayNhan.Date - DateTime.Now.Date).TotalDays;
                    hienThiTrangThai = (daysLeft <= 1) ? "Sắp nhận" : "Đang giữ";
                }
                else if (string.Equals(giu.TinhTrang, "DaNhan", StringComparison.OrdinalIgnoreCase))
                {
                    hienThiTrangThai = "Đã nhận";
                }
                else
                {
                    // Phòng trống hoặc trạng thái lạ
                    hienThiTrangThai = "Trống";
                }

                lblTinhTrang.Text = "Tình trạng: " + hienThiTrangThai;
            }
            else
            {
                // Nếu phòng trống thì hiển thị thông tin mặc định
                lblTenThuCung.Text = "Tên: -";
                lblLoaiThuCung.Text = "Loại: -";
                lblGioiTinh.Text = "Giới tính: -";
                lblNgayGiu.Text = "Ngày gửi: -";
                lblNgayNhan.Text = "Ngày nhận: -";
                lblTinhTrang.Text = "Tình trạng: Trống";
            }
        }

        // Xử lý khi nhấn nút "Gửi thú cưng": mở form nhập thông tin, cập nhật trạng thái phòng nếu gửi thành công
        private void btnGuiThuCung_Click(object sender, EventArgs e)
        {
            if (phongDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn một phòng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhong = phongDangChon.Text;
            var frm = new FrmNhapThuCungMoi(maPhong, _hotelService);
            frm.ShowDialog();

            // Nếu gửi thành công thì cập nhật trạng thái phòng và reset thông tin
            if (frm.GiuThanhCong)
            {
                phongDangChon.BackColor = Color.Gold;
                phongDangChon.Enabled = false;
                phongDangChon = null;
                lblPhongDangChon.Text = "Phòng đang chọn: Chưa chọn";

                lblTenThuCung.Text = "Tên: -";
                lblLoaiThuCung.Text = "Loại: -";
                lblGioiTinh.Text = "Giới tính: -";
                lblNgayGiu.Text = "Ngày gửi: -";
                lblNgayNhan.Text = "Ngày nhận: -";
                lblTinhTrang.Text = "Tình trạng: -";
            }
        }

        // Đóng form khi nhấn nút "Quay lại"
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flpPhong_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}