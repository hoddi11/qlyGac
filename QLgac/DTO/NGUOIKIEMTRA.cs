namespace QLgac.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUOIKIEMTRA")]
    public partial class NGUOIKIEMTRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUOIKIEMTRA()
        {
            KIEMTRAs = new HashSet<KIEMTRA>();
            VIPHAMs = new HashSet<VIPHAM>();
        }

        [Key]
        [StringLength(10)]
        public string SoHieu { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(50)]
        public string CapBac { get; set; }

        [StringLength(50)]
        public string ChucVuKiemTra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KIEMTRA> KIEMTRAs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VIPHAM> VIPHAMs { get; set; }
    }
}
