using nhom4.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace nhom4.Repositories
{
    public class SanPhamRepository : ISanPhamRepository
    {
        private readonly PetShopContextDB db = new PetShopContextDB();

        // Lấy tất cả sản phẩm, bao gồm thông tin danh mục liên quan
        public List<SanPham> GetAll() =>
            db.SanPhams.Include(sp => sp.DanhMucSanPham).ToList();

        // Lấy danh sách sản phẩm theo mã danh mục
        public List<SanPham> GetByCategory(int categoryId) =>
            db.SanPhams.Include(sp => sp.DanhMucSanPham)
                        .Where(sp => sp.IDLoaiSP == categoryId)
                        .ToList();

        // Lấy thông tin chi tiết một sản phẩm theo ID
        public SanPham GetById(int id) =>
            db.SanPhams.Include(sp => sp.DanhMucSanPham)
                        .FirstOrDefault(sp => sp.ID_SanPham == id);

        // Lấy tất cả danh mục sản phẩm
        public List<DanhMucSanPham> GetAllCategories() =>
            db.DanhMucSanPhams.ToList();

        // Thêm, cập nhật và xóa sản phẩm trong cơ sở dữ liệu
        public void Insert(SanPham sp)
        {
            db.SanPhams.Add(sp);
            db.SaveChanges();
        }

        public void Update(SanPham sp)
        {
            var existing = db.SanPhams.Find(sp.ID_SanPham);
            if (existing != null)
            {
                existing.TenSanPham = sp.TenSanPham;
                existing.DonGia = sp.DonGia;
                existing.MoTa = sp.MoTa;
                existing.IDLoaiSP = sp.IDLoaiSP;
                existing.SoLuongTonKho = sp.SoLuongTonKho;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var sp = db.SanPhams.Find(id);
            if (sp != null)
            {
                db.SanPhams.Remove(sp);
                db.SaveChanges();
            }
        }

    }
}
