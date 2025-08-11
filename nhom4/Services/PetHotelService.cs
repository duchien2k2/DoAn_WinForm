using nhom4.Models;
using nhom4.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nhom4.Services
{
    public class PetHotelService
    {
        private readonly IPetHotelRepository _repo = new PetHotelRepository();

        public const decimal GIA_NGAY_MAC_DINH = 150000m; // chỉnh số nếu cần

        public List<(string MaPhong, string TrangThai)> GetDanhSachPhong()
        {
            try
            {
                _repo.UpdateTinhTrangQuaHan();

                var dsDangGiu = _repo.GetAllDangGiu();
                var result = new List<(string, string)>();

                for (int i = 1; i <= 20; i++)
                {
                    var ma = "P" + i;
                    var phong = dsDangGiu.FirstOrDefault(p => p.MaPhong == ma);

                    if (phong == null)
                        result.Add((ma, "Trong"));
                    else
                    {
                        var daysLeft = (phong.NgayNhan.Date - DateTime.Now.Date).TotalDays;
                        if (daysLeft <= 1)
                            result.Add((ma, "SapNhan"));
                        else
                            result.Add((ma, "DangGiu"));
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách phòng: " + ex.Message);
                return new List<(string, string)>();
            }
        }

        public bool IsPhongDangSuDung(string maPhong)
        {
            try
            {
                return _repo.IsPhongDangSuDung(maPhong);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi kiểm tra phòng: " + ex.Message);
                return false;
            }
        }

        public void GuiThuCung(ThuCungGui thuCung, DichVuGiuThuCung giu)
        {
            try
            {
                _repo.AddThuCungVaGiuPhong(thuCung, giu);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi gửi thú cưng: " + ex.Message);
            }
        }

        public (ThuCungGui, DanhMucThuCung, DichVuGiuThuCung) GetThongTinPhong(string maPhong)
        {
            try
            {
                return _repo.GetThongTinPhong(maPhong);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy thông tin phòng: " + ex.Message);
                return (null, null, null);
            }
        }

        public List<DanhMucThuCung> LayDanhSachLoaiThuCung()
        {
            try
            {
                return _repo.LayDanhSachLoaiThuCung();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh sách loại thú cưng: " + ex.Message);
                return new List<DanhMucThuCung>();
            }
        }

        public static int SoNgayTinhPhi(DateTime ngayGiu, DateTime ngayNhan)
        {
            // Tối thiểu 1 ngày
            var days = (ngayNhan.Date - ngayGiu.Date).Days;
            return Math.Max(1, days);
        }

        public static decimal TinhTien(DateTime ngayGiu, DateTime ngayNhan)
        {
            return SoNgayTinhPhi(ngayGiu, ngayNhan) * GIA_NGAY_MAC_DINH;
        }
    }
}
