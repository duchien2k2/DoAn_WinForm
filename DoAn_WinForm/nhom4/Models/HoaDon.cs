namespace nhom4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            ChiTietHoaDonDichVus = new HashSet<ChiTietHoaDonDichVu>();
            ChiTietHoaDonSanPhams = new HashSet<ChiTietHoaDonSanPham>();
            ChiTietHoaDonThuCungs = new HashSet<ChiTietHoaDonThuCung>();
        }

        [Key]
        public int ID_HoaDon { get; set; }

        public DateTime NgayLap { get; set; }

        public decimal TongTien { get; set; }

        [StringLength(50)]
        public string HinhThucThanhToan { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public int? NguoiDungID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDonDichVu> ChiTietHoaDonDichVus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDonSanPham> ChiTietHoaDonSanPhams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDonThuCung> ChiTietHoaDonThuCungs { get; set; }

        public virtual User User { get; set; }
    }
}
