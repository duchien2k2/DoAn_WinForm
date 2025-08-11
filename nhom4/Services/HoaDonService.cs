using nhom4.Models;
using nhom4.Models.ViewModels;
using System;
using System.Linq;
using System.Data.Entity;

namespace nhom4.Services
{
    public partial class HoaDonService
    {
        // Chuẩn hóa tên loại từ giỏ hàng về 3 nhóm
        private string MapLoai(string loai)
        {
            var l = (loai ?? "").Trim().ToLowerInvariant();
            if (l.Contains("spa") || l.Contains("dịch")) return "spa";                // DV Spa
            if (l.Contains("gửi") || l.Contains("giữ") || l.Contains("thú") || l.Contains("hotel")) return "hotel"; // Gửi thú
            return "sanpham"; // mặc định là Sản phẩm
        }

        /// <summary>
        /// Lập hóa đơn từ GioHangService.DanhSachGioHang. Trả về ID_HoaDon.
        /// </summary>
        public int LapHoaDonFromGioHang(int userId, string hinhThucThanhToan)
        {
            var items = GioHangService.DanhSachGioHang.ToList();
            if (items == null || items.Count == 0)
                throw new InvalidOperationException("Giỏ hàng đang trống.");

            using (var db = new PetShopContextDB())
            {
                var hd = new HoaDon
                {
                    NgayLap = DateTime.Now,
                    UserID = userId,
                    HinhThucThanhToan = string.IsNullOrWhiteSpace(hinhThucThanhToan) ? "Tiền mặt" : hinhThucThanhToan,
                    TrangThai = "Paid",
                    TongTien = 0m
                };

                db.HoaDons.Add(hd);
                db.SaveChanges(); // cần ID_HoaDon

                decimal tong = 0m;

                foreach (var it in items)
                {
                    int sl = it.SoLuong > 0 ? it.SoLuong : 1;
                    decimal line = sl * it.DonGia;
                    tong += line;

                    switch (MapLoai(it.Loai))
                    {
                        case "sanpham":
                            db.ChiTietSanPham_HoaDon.Add(new ChiTietSanPham_HoaDon
                            {
                                HoaDonID = hd.ID_HoaDon,
                                SanPhamID = it.ID,
                                SoLuong = sl,
                                DonGia = it.DonGia
                            });
                            break;

                        case "spa":
                            db.ChiTietDichVuSpa_HoaDon.Add(new ChiTietDichVuSpa_HoaDon
                            {
                                HoaDonID = hd.ID_HoaDon,
                                DichVuID = it.ID,
                                SoLuong = sl,          // nếu cột SoLuong là nullable thì vẫn OK
                                DonGia = it.DonGia
                            });
                            break;

                        case "hotel": // gửi/giữ thú
                            db.ChiTietThuCungGui_HoaDon.Add(new ChiTietThuCungGui_HoaDon
                            {
                                HoaDonID = hd.ID_HoaDon,
                                ThuCungID = it.ID,
                                DonGia = it.DonGia
                                // loại này thường không có số lượng -> tính 1 dòng
                            });
                            break;

                        default:
                            throw new Exception("Loại dòng hàng không hợp lệ: " + it.Loai);
                    }
                }

                hd.TongTien = tong;
                db.SaveChanges();

                // Xóa giỏ hàng sau khi lưu
                GioHangService.XoaGioHang();

                return hd.ID_HoaDon;
            }
        }

        public HoaDonReportVM BuildReportData(int hoaDonId)
        {
            using (var db = new PetShopContextDB())
            {
                var hd = db.HoaDons
                    .Include(h => h.User)
                    .Include(h => h.ChiTietSanPham_HoaDon.Select(ct => ct.SanPham))
                    .Include(h => h.ChiTietDichVuSpa_HoaDon.Select(ct => ct.DichVuSpa))
                    .Include(h => h.ChiTietThuCungGui_HoaDon.Select(ct => ct.ThuCungGui))
                    .SingleOrDefault(h => h.ID_HoaDon == hoaDonId);

                if (hd == null)
                    throw new Exception("Không tìm thấy hóa đơn #" + hoaDonId);

                var vm = new HoaDonReportVM
                {
                    SoHoaDon = hd.ID_HoaDon,
                    NgayLap = hd.NgayLap,
                    // Lấy tên NV an toàn theo dữ liệu của bạn
                    NhanVien = (hd.User != null
                                ? (hd.User.TenDangNhap ?? ("User#" + hd.UserID))
                                : "NV chưa rõ"),
                    HinhThucThanhToan = string.IsNullOrWhiteSpace(hd.HinhThucThanhToan)
                                        ? "Tiền mặt" : hd.HinhThucThanhToan
                };

                int stt = 1;

                // Sản phẩm
                foreach (var ct in hd.ChiTietSanPham_HoaDon)
                {
                    vm.Lines.Add(new InvoiceLineVM
                    {
                        STT = stt++,
                        Loai = "Sản phẩm",
                        Ten = ct.SanPham?.TenSanPham ?? ("SP#" + ct.SanPhamID),
                        SoLuong = ct.SoLuong,
                        DonGia = ct.DonGia
                    });
                }

                // Dịch vụ Spa
                foreach (var ct in hd.ChiTietDichVuSpa_HoaDon)
                {
                    vm.Lines.Add(new InvoiceLineVM
                    {
                        STT = stt++,
                        Loai = "DV Spa",
                        Ten = ct.DichVuSpa?.TenDichVu ?? ("DV#" + ct.DichVuID),
                        SoLuong = ct.SoLuong ?? 1,
                        DonGia = ct.DonGia
                    });
                }

                // Gửi thú
                foreach (var ct in hd.ChiTietThuCungGui_HoaDon)
                {
                    vm.Lines.Add(new InvoiceLineVM
                    {
                        STT = stt++,
                        Loai = "Gửi thú",
                        Ten = ct.ThuCungGui?.TenThuCung ?? ("Thú#" + ct.ThuCungID),
                        SoLuong = 1,
                        DonGia = ct.DonGia
                    });
                }

                return vm;
            }
        }
    }
}
