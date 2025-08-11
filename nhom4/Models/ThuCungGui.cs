namespace nhom4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThuCungGui")]
    public partial class ThuCungGui
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThuCungGui()
        {
            ChiTietThuCungGui_HoaDon = new HashSet<ChiTietThuCungGui_HoaDon>();
            DichVuGiuThuCungs = new HashSet<DichVuGiuThuCung>();
        }

        [Key]
        public int ID_ThuCung { get; set; }

        [Required]
        [StringLength(20)]
        public string TenThuCung { get; set; }

        [Required]
        [StringLength(5)]
        public string GioiTinh { get; set; }

        public double CanNang { get; set; }

        public string MoTa { get; set; }

        public int IDLoaiTC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietThuCungGui_HoaDon> ChiTietThuCungGui_HoaDon { get; set; }

        public virtual DanhMucThuCung DanhMucThuCung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DichVuGiuThuCung> DichVuGiuThuCungs { get; set; }
    }
}
