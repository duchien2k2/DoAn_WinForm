namespace nhom4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDonDichVu")]
    public partial class ChiTietHoaDonDichVu
    {
        [Key]
        public int ID_CTHD_DichVU { get; set; }

        public int HoaDonID { get; set; }

        public int DichVuID { get; set; }

        public int? SoLuong { get; set; }

        public decimal DonGia { get; set; }

        public virtual DichVu DichVu { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
}
