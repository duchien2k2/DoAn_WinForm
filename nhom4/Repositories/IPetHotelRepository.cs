using System.Collections.Generic;
using nhom4.Models;

namespace nhom4.Repositories
{
    public interface IPetHotelRepository
    {
        // Lấy danh sách thú cưng đang được giữ trong khách sạn
        List<DichVuGiuThuCung> GetAllDangGiu();

        // Cập nhật trạng thái các phòng có thú cưng đã quá hạn nhận
        void UpdateTinhTrangQuaHan();

        // Kiểm tra một phòng có đang được sử dụng hay không
        bool IsPhongDangSuDung(string maPhong);

        // Thêm thú cưng mới và tạo dịch vụ giữ thú cưng tương ứng
        void AddThuCungVaGiuPhong(ThuCungGui thuCung, DichVuGiuThuCung giu);

        // Lấy thông tin chi tiết về thú cưng, loại và dịch vụ giữ trong một phòng
        (ThuCungGui, DanhMucThuCung, DichVuGiuThuCung) GetThongTinPhong(string maPhong);

        // Lấy danh sách các loại thú cưng có thể giữ
        List<DanhMucThuCung> LayDanhSachLoaiThuCung();
    }
}
