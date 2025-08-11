namespace nhom4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ChiTietSanPham_HoaDon
    {
        [Key]
        public int ID_CTHD_SanPham { get; set; }

        public int HoaDonID { get; set; }

        public int SanPhamID { get; set; }

        public int SoLuong { get; set; }

        public decimal DonGia { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
