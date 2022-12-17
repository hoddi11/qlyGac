namespace QLgac.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOCVIEN")]
    public partial class HOCVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOCVIEN()
        {
            SUVIECs = new HashSet<SUVIEC>();
        }

        [Key]
        [StringLength(10)]
        public string MaHV { get; set; }

        [StringLength(50)]
        public string TenHV { get; set; }

        [StringLength(50)]
        public string CapBac { get; set; }

        [StringLength(10)]
        public string MaDD { get; set; }

        [StringLength(10)]
        public string MaVG { get; set; }

        public virtual DAIDOI DAIDOI { get; set; }

        public virtual VONGGAC VONGGAC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUVIEC> SUVIECs { get; set; }
    }
}
