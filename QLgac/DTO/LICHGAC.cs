namespace QLgac.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LICHGAC")]
    public partial class LICHGAC
    {
        [Key]
        [StringLength(10)]
        public string MaSo { get; set; }

        public int CaGac { get; set; }

        [Required]
        [StringLength(10)]
        public string MaGac { get; set; }

        [StringLength(50)]
        public string ThoiGianGac { get; set; }

        [StringLength(50)]
        public string S3CoDinh { get; set; }

        [StringLength(50)]
        public string S3TuanTra { get; set; }

        [StringLength(50)]
        public string S1CoDinh { get; set; }

        [StringLength(50)]
        public string S1TuanTra { get; set; }

        [StringLength(50)]
        public string DocGac { get; set; }

        public virtual DAMNHIEMGAC DAMNHIEMGAC { get; set; }
    }
}
