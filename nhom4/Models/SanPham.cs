namespace nhom4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietSanPham_HoaDon = new HashSet<ChiTietSanPham_HoaDon>();
        }

        [Key]
        public int ID_SanPham { get; set; }

        [Required]
        [StringLength(100)]
        public string TenSanPham { get; set; }

        public decimal DonGia { get; set; }

        public string MoTa { get; set; }

        public int IDLoaiSP { get; set; }

        public int? SoLuongTonKho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSanPham_HoaDon> ChiTietSanPham_HoaDon { get; set; }

        public virtual DanhMucSanPham DanhMucSanPham { get; set; }
    }
}
