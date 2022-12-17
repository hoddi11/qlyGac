namespace QLgac.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VIPHAM")]
    public partial class VIPHAM
    {
        [Key]
        [StringLength(10)]
        public string MaVP { get; set; }

        [StringLength(50)]
        public string NoiDung { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGian { get; set; }

        [StringLength(10)]
        public string MaQD { get; set; }

        [StringLength(10)]
        public string SoHieu { get; set; }

        public virtual NGUOIKIEMTRA NGUOIKIEMTRA { get; set; }

        public virtual QUYDINH QUYDINH { get; set; }
    }
}
