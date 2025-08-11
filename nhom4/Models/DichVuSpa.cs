namespace nhom4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DichVuSpa")]
    public partial class DichVuSpa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DichVuSpa()
        {
            ChiTietDichVuSpa_HoaDon = new HashSet<ChiTietDichVuSpa_HoaDon>();
        }

        [Key]
        public int ID_DichVu { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDichVu { get; set; }

        public decimal Gia { get; set; }

        public string MoTa { get; set; }

        public int IDLoaiDV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDichVuSpa_HoaDon> ChiTietDichVuSpa_HoaDon { get; set; }

        public virtual DanhMucDichVu DanhMucDichVu { get; set; }
    }
}
