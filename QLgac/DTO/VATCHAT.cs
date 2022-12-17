namespace QLgac.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VATCHAT")]
    public partial class VATCHAT
    {
        [Key]
        [StringLength(10)]
        public string MaVC { get; set; }

        [StringLength(50)]
        public string TenVC { get; set; }

        [StringLength(50)]
        public string TinhTrang { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(10)]
        public string MaTD { get; set; }

        public virtual TIEUDOAN TIEUDOAN { get; set; }
    }
}
