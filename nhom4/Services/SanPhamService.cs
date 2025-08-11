using nhom4.Models;
using System;
using System.Collections.Generic;
using nhom4.Repositories;

namespace nhom4.Services
{
    public class SanPhamService
    {
        private readonly ISanPhamRepository repository = new SanPhamRepository();

        public List<SanPham> LayTatCaSanPham()
        {
            try
            {
                return repository.GetAll();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy tất cả sản phẩm: " + ex.Message);
                return new List<SanPham>();
            }
        }

        public List<SanPham> LaySanPhamTheoDanhMuc(int idLoai)
        {
            try
            {
                return repository.GetByCategory(idLoai);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy sản phẩm theo danh mục: " + ex.Message);
                return new List<SanPham>();
            }
        }

        public SanPham LaySanPhamTheoId(int id)
        {
            try
            {
                return repository.GetById(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy sản phẩm theo ID: " + ex.Message);
                return null;
            }
        }

        public List<DanhMucSanPham> LayTatCaDanhMuc()
        {
            try
            {
                return repository.GetAllCategories();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy danh mục sản phẩm: " + ex.Message);
                return new List<DanhMucSanPham>();
            }
        }

        public void ThemSanPham(SanPham sp)
        {
            try
            {
                repository.Insert(sp);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thêm sản phẩm: " + ex.Message);
            }
        }

        public void CapNhatSanPham(SanPham sp)
        {
            try
            {
                repository.Update(sp);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi cập nhật sản phẩm: " + ex.Message);
            }
        }

        public void XoaSanPham(int id)
        {
            try
            {
                repository.Delete(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa sản phẩm: " + ex.Message);
            }
        }
    }
}