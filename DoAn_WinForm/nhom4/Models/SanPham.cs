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
            ChiTietHoaDonSanPhams = new HashSet<ChiTietHoaDonSanPham>();
        }

        [Key]
        public int ID_SanPham { get; set; }

        [Required]
        [StringLength(100)]
        public string TenSanPham { get; set; }

        public decimal DonGia { get; set; }

        [StringLength(255)]
        public string HinhAnh { get; set; }

        public string MoTa { get; set; }

        public int? IDLoaiSP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDonSanPham> ChiTietHoaDonSanPhams { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; }
    }
}
