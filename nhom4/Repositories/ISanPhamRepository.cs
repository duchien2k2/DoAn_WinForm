using nhom4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhom4.Repositories
{
    public interface ISanPhamRepository
    {
        // Lấy tất cả sản phẩm từ database, bao gồm thông tin danh mục
        List<SanPham> GetAll();

        // Lấy danh sách sản phẩm theo mã danh mục chỉ định
        List<SanPham> GetByCategory(int categoryId);

        // Tìm và trả về thông tin chi tiết của một sản phẩm theo ID
        SanPham GetById(int id);

        // Lấy danh sách tất cả các danh mục sản phẩm
        List<DanhMucSanPham> GetAllCategories();
        // Thêm, cập nhật và xóa sản phẩm trong cơ sở dữ liệu
        void Insert(SanPham sp);
        void Update(SanPham sp);
        void Delete(int id);
    }
}
