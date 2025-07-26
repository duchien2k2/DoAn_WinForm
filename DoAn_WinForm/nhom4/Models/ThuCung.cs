namespace nhom4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThuCung")]
    public partial class ThuCung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThuCung()
        {
            ChiTietHoaDonThuCungs = new HashSet<ChiTietHoaDonThuCung>();
        }

        [Key]
        public int ID_ThuCung { get; set; }

        [Required]
        [StringLength(20)]
        public string TenThuCung { get; set; }

        [StringLength(5)]
        public string GioiTinh { get; set; }

        [StringLength(25)]
        public string HinhAnh { get; set; }

        public double? CanNang { get; set; }

        public string MoTa { get; set; }

        public int? IDLoaiTC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDonThuCung> ChiTietHoaDonThuCungs { get; set; }

        public virtual LoaiThuCung LoaiThuCung { get; set; }
    }
}
