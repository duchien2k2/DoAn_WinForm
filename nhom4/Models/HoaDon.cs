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
            ChiTietDichVuSpa_HoaDon = new HashSet<ChiTietDichVuSpa_HoaDon>();
            ChiTietSanPham_HoaDon = new HashSet<ChiTietSanPham_HoaDon>();
            ChiTietThuCungGui_HoaDon = new HashSet<ChiTietThuCungGui_HoaDon>();
        }

        [Key]
        public int ID_HoaDon { get; set; }

        public DateTime NgayLap { get; set; }

        public decimal TongTien { get; set; }

        [StringLength(50)]
        public string HinhThucThanhToan { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public int UserID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDichVuSpa_HoaDon> ChiTietDichVuSpa_HoaDon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSanPham_HoaDon> ChiTietSanPham_HoaDon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietThuCungGui_HoaDon> ChiTietThuCungGui_HoaDon { get; set; }

        public virtual User User { get; set; }
    }
}
