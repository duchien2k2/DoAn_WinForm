namespace nhom4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DichVuGiuThuCung")]
    public partial class DichVuGiuThuCung
    {
        [Key]
        public int ID_Giu { get; set; }

        public int ThuCungID { get; set; }

        public DateTime NgayGiu { get; set; }

        public DateTime NgayNhan { get; set; }

        [Required]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [StringLength(10)]
        public string TinhTrang { get; set; }

        public virtual ThuCungGui ThuCungGui { get; set; }
    }
}
