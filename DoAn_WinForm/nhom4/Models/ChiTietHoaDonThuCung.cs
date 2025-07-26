namespace nhom4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDonThuCung")]
    public partial class ChiTietHoaDonThuCung
    {
        [Key]
        public int ID_CTHD_ThuCung { get; set; }

        public int HoaDonID { get; set; }

        public int ThuCungID { get; set; }

        public decimal DonGia { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual ThuCung ThuCung { get; set; }
    }
}
