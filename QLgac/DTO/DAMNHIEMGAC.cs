namespace QLgac.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DAMNHIEMGAC")]
    public partial class DAMNHIEMGAC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAMNHIEMGAC()
        {
            LICHGACs = new HashSet<LICHGAC>();
        }

        [Key]
        [StringLength(10)]
        public string MaGac { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayGac { get; set; }

        [Required]
        [StringLength(10)]
        public string MaDD { get; set; }

        public virtual DAIDOI DAIDOI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHGAC> LICHGACs { get; set; }
    }
}
