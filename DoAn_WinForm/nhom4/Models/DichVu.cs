namespace nhom4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DichVu")]
    public partial class DichVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DichVu()
        {
            ChiTietHoaDonDichVus = new HashSet<ChiTietHoaDonDichVu>();
        }

        [Key]
        public int ID_DichVu { get; set; }

        [Required]
        [StringLength(100)]
        public string TenDichVu { get; set; }

        public decimal Gia { get; set; }

        public string MoTa { get; set; }

        public int? IDLoaiDV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDonDichVu> ChiTietHoaDonDichVus { get; set; }

        public virtual LoaiDichVu LoaiDichVu { get; set; }
    }
}
