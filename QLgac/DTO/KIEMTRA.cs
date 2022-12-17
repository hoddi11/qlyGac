namespace QLgac.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KIEMTRA")]
    public partial class KIEMTRA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaVG { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string SoHieu { get; set; }

        public DateTime? ThoiGian { get; set; }

        [StringLength(50)]
        public string TinhTrang { get; set; }

        public virtual NGUOIKIEMTRA NGUOIKIEMTRA { get; set; }

        public virtual VONGGAC VONGGAC { get; set; }
    }
}
