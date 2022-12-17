namespace QLgac.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VONGGAC")]
    public partial class VONGGAC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VONGGAC()
        {
            HOCVIENs = new HashSet<HOCVIEN>();
            KIEMTRAs = new HashSet<KIEMTRA>();
        }

        [Key]
        [StringLength(10)]
        public string MaVG { get; set; }

        [StringLength(50)]
        public string ViTri { get; set; }

        [StringLength(500)]
        public string MucTieu { get; set; }

        [StringLength(50)]
        public string MucDoQuanTrong { get; set; }

        [StringLength(10)]
        public string MaTD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOCVIEN> HOCVIENs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KIEMTRA> KIEMTRAs { get; set; }

        public virtual TIEUDOAN TIEUDOAN { get; set; }
    }
}
