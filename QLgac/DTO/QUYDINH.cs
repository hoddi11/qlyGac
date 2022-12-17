namespace QLgac.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUYDINH")]
    public partial class QUYDINH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QUYDINH()
        {
            SUVIECs = new HashSet<SUVIEC>();
            VIPHAMs = new HashSet<VIPHAM>();
        }

        [Key]
        [StringLength(10)]
        public string MaQD { get; set; }

        [StringLength(50)]
        public string NoiDung { get; set; }

        [StringLength(50)]
        public string HinhThucXuLy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUVIEC> SUVIECs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VIPHAM> VIPHAMs { get; set; }
    }
}
