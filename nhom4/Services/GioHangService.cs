using nhom4.Models;
using System;
using System.ComponentModel;
using System.Linq;

namespace nhom4.Services
{
    public static class GioHangService
    {
        // BindingList giúp GridControl tự bắt sự kiện Add/Remove/Change
        public static BindingList<GioHangItem> DanhSachGioHang { get; } = new BindingList<GioHangItem>();

        public static void ThemVaoGio(GioHangItem item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));

            var existed = DanhSachGioHang.FirstOrDefault(x => x.ID == item.ID && x.Loai == item.Loai);
            if (existed != null)
            {
                existed.SoLuong += item.SoLuong;
                DanhSachGioHang.ResetItem(DanhSachGioHang.IndexOf(existed)); // refresh 1 dòng
            }
            else
            {
                DanhSachGioHang.Add(item);
            }
        }

        public static void XoaTheoIdLoai(int id, string loai)
        {
            var it = DanhSachGioHang.FirstOrDefault(x => x.ID == id && x.Loai == loai);
            if (it != null) DanhSachGioHang.Remove(it);
        }

        public static GioHangItem LayItem(int id, string loai)
        {
            return DanhSachGioHang.FirstOrDefault(x => x.ID == id && x.Loai == loai);
        }

        public static bool CapNhatSoLuong(int id, string loai, int soLuongMoi)
        {
            var it = LayItem(id, loai);
            if (it == null) return false;
            if (soLuongMoi <= 0) return false;

            it.SoLuong = soLuongMoi;
            DanhSachGioHang.ResetItem(DanhSachGioHang.IndexOf(it)); // refresh đúng 1 dòng
            return true;
        }

        public static void XoaGioHang() => DanhSachGioHang.Clear();

        public static decimal TongTien() => DanhSachGioHang.Sum(x => x.ThanhTien);
    }
}
