namespace QLgac.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUVIEC")]
    public partial class SUVIEC
    {
        [Key]
        [StringLength(10)]
        public string MaSV { get; set; }

        [StringLength(50)]
        public string NoiDung { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGian { get; set; }

        [StringLength(10)]
        public string MaHV { get; set; }

        [StringLength(10)]
        public string MaDD { get; set; }

        [StringLength(10)]
        public string MaQD { get; set; }

        public virtual DAIDOI DAIDOI { get; set; }

        public virtual HOCVIEN HOCVIEN { get; set; }

        public virtual QUYDINH QUYDINH { get; set; }
    }
}
