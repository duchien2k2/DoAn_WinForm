namespace nhom4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMucThuCung")]
    public partial class DanhMucThuCung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhMucThuCung()
        {
            ThuCungGuis = new HashSet<ThuCungGui>();
        }

        [Key]
        public int ID_LoaiTC { get; set; }

        [Required]
        [StringLength(30)]
        public string TenLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThuCungGui> ThuCungGuis { get; set; }
    }
}
