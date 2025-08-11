using nhom4.Models;
using nhom4.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace nhom4
{
    public partial class FrmNhapThuCungMoi : Form
    {
        private readonly string _maPhong;
        private readonly PetHotelService _hotelService;
        public bool GiuThanhCong { get; private set; } = false;

        public FrmNhapThuCungMoi(string maPhong, PetHotelService hotelService)
        {
            InitializeComponent();
            _maPhong = maPhong;
            _hotelService = hotelService;
            this.Load += frmNhapThuCungMoi_Load;
        }

        // Khi form load: hiển thị mã phòng, thiết lập combobox giới tính, loại thú cưng, ngày gửi/nhận mặc định
        private void frmNhapThuCungMoi_Load(object sender, EventArgs e)
        {
            lblMaPhong.Text = $"Phòng: {_maPhong}";

            // Thêm lựa chọn giới tính nếu chưa có
            if (cbbGioiTinh.Properties.Items.Count == 0)
            {
                cbbGioiTinh.Properties.Items.AddRange(new[] { "Đực", "Cái" });
            }
            cbbGioiTinh.SelectedIndex = 0;

            // Lấy danh sách loại thú cưng từ service và gán vào combobox
            var danhSachLoai = _hotelService.LayDanhSachLoaiThuCung()
                .Select(loai => new {
                    loai.ID_LoaiTC,
                    loai.TenLoai
                }).ToList();
            cbbLoaiThuCung.Properties.DataSource = danhSachLoai;
            cbbLoaiThuCung.Properties.DisplayMember = "TenLoai";
            cbbLoaiThuCung.Properties.ValueMember = "ID_LoaiTC";
            cbbLoaiThuCung.Properties.NullText = "-- Chọn loại thú cưng --";

            // Thiết lập ngày gửi là hôm nay, ngày nhận là ngày mai
            dtpNgayGiu.EditValue = DateTime.Now;
            dtpNgayNhan.EditValue = DateTime.Now.AddDays(1);
        }

        // Xử lý khi nhấn nút Lưu: kiểm tra dữ liệu, tạo đối tượng, gọi service lưu thông tin
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào đã đủ chưa
            if (string.IsNullOrWhiteSpace(txtTenThuCung.Text) ||
                cbbGioiTinh.SelectedIndex < 0 ||
                string.IsNullOrWhiteSpace(txtCanNang.Text) ||
                cbbLoaiThuCung.EditValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra cân nặng hợp lệ
            if (!float.TryParse(txtCanNang.Text, out float canNang))
            {
                MessageBox.Show("Cân nặng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            canNang = (float)Math.Round(canNang, 2);

            // Kiểm tra ngày nhận phải sau hoặc bằng ngày gửi
            if (dtpNgayGiu.DateTime.Date > dtpNgayNhan.DateTime.Date)
            {
                MessageBox.Show("Ngày nhận phải lớn hơn hoặc bằng ngày gửi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã phòng từ label
            string maPhong = lblMaPhong.Text.Replace("Phòng:", "").Trim();

            // Tạo đối tượng thú cưng gửi
            var thuCung = new ThuCungGui
            {
                TenThuCung = txtTenThuCung.Text.Trim(),
                GioiTinh = cbbGioiTinh.Text,
                CanNang = canNang,
                MoTa = rtbMoTa.Text,
                IDLoaiTC = Convert.ToInt32(cbbLoaiThuCung.EditValue)
            };

            // Tạo đối tượng dịch vụ giữ thú cưng
            var giu = new DichVuGiuThuCung
            {
                MaPhong = maPhong,
                NgayGiu = dtpNgayGiu.DateTime,
                NgayNhan = dtpNgayNhan.DateTime,
                TinhTrang = "TrongPhong"
            };

            // Gọi service lưu thông tin thú cưng và dịch vụ giữ
            _hotelService.GuiThuCung(thuCung, giu);

            // ==== BỔ SUNG: Add vào giỏ sau khi lưu thành công ====
            // Lấy lại thông tin phòng để có ID thú cưng & phiên giữ
            // Lấy lại phiên giữ vừa lưu để tính tiền & add vào giỏ
            var (tc, loai, giuSaved) = _hotelService.GetThongTinPhong(maPhong);
            if (tc != null && giuSaved != null)
            {
                int soNgay = nhom4.Services.PetHotelService.SoNgayTinhPhi(giuSaved.NgayGiu, giuSaved.NgayNhan);
                decimal donGiaTong = nhom4.Services.PetHotelService.TinhTien(giuSaved.NgayGiu, giuSaved.NgayNhan);

                nhom4.Services.GioHangService.ThemVaoGio(new nhom4.Models.GioHangItem
                {
                    ID = tc.ID_ThuCung,
                    Ten = $"{tc.TenThuCung} - Phòng {maPhong} ({soNgay} ngày)",
                    Loai = "Hotel",
                    SoLuong = 1,             // mỗi booking là 1 dòng
                    DonGia = donGiaTong      // DON GIA = TỔNG tiền của phiên giữ
                });
            }


            MessageBox.Show("Gửi thú cưng thành công! Đã thêm vào giỏ.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GiuThanhCong = true;
            this.Close();
        }

        // Đóng form khi nhấn nút Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}