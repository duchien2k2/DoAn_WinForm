using nhom4.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System;

namespace nhom4.Repositories
{
    public class PetHotelRepository : IPetHotelRepository
    {
        private readonly PetShopContextDB db = new PetShopContextDB();

        // Lấy danh sách dịch vụ giữ thú cưng đang trong trạng thái "TrongPhong"
        public List<DichVuGiuThuCung> GetAllDangGiu() =>
            db.DichVuGiuThuCungs.Where(x => x.TinhTrang == "TrongPhong").ToList();

        // Cập nhật trạng thái các dịch vụ giữ thú cưng đã quá hạn nhận thành "DaNhan"
        public void UpdateTinhTrangQuaHan()
        {
            var homNay = DateTime.Now;
            var dsQuaHan = db.DichVuGiuThuCungs
                .Where(p => p.TinhTrang == "TrongPhong"
                    && DbFunctions.TruncateTime(p.NgayNhan) < DbFunctions.TruncateTime(homNay))
                .ToList();

            if (dsQuaHan.Any())
            {
                dsQuaHan.ForEach(p => p.TinhTrang = "DaNhan");
                db.SaveChanges();
            }
        }

        // Kiểm tra phòng có đang được sử dụng (còn giữ thú cưng) hay không
        public bool IsPhongDangSuDung(string maPhong) =>
            db.DichVuGiuThuCungs.Any(x => x.MaPhong == maPhong && x.TinhTrang == "TrongPhong");

        // Thêm mới thú cưng và tạo dịch vụ giữ phòng tương ứng
        public void AddThuCungVaGiuPhong(ThuCungGui thuCung, DichVuGiuThuCung giu)
        {
            db.ThuCungGuis.Add(thuCung);
            db.SaveChanges();

            giu.ThuCungID = thuCung.ID_ThuCung;
            db.DichVuGiuThuCungs.Add(giu);
            db.SaveChanges();
        }

        // Lấy thông tin chi tiết về thú cưng, loại và dịch vụ giữ trong một phòng
        public (ThuCungGui, DanhMucThuCung, DichVuGiuThuCung) GetThongTinPhong(string maPhong)
        {
            var query = (from gtc in db.DichVuGiuThuCungs
                         join tc in db.ThuCungGuis on gtc.ThuCungID equals tc.ID_ThuCung
                         join dm in db.DanhMucThuCungs on tc.IDLoaiTC equals dm.ID_LoaiTC
                         where gtc.MaPhong == maPhong && gtc.TinhTrang == "TrongPhong"
                         select new { tc, dm, gtc }).FirstOrDefault();

            if (query == null) return (null, null, null);

            return (query.tc, query.dm, query.gtc);
        }

        // Lấy danh sách các loại thú cưng có thể gửi
        public List<DanhMucThuCung> LayDanhSachLoaiThuCung() =>
            db.DanhMucThuCungs.ToList();
    }
}
