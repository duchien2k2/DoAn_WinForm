namespace nhom4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public int ID_User { get; set; }

        [Required]
        [StringLength(30)]
        public string HoVaTen { get; set; }

        [Required]
        [StringLength(30)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(100)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(5)]
        public string VaiTro { get; set; }

        [StringLength(10)]
        public string SoDienThoai { get; set; }

        public bool? TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
