namespace QLgac.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANGNHAP")]
    public partial class DANGNHAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DANGNHAP()
        {
            DAIDOIs = new HashSet<DAIDOI>();
            TIEUDOANs = new HashSet<TIEUDOAN>();
        }

        [StringLength(10)]
        public string Id { get; set; }

        [StringLength(50)]
        public string TaiKhoan { get; set; }

        [StringLength(100)]
        public string MatKhau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAIDOI> DAIDOIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIEUDOAN> TIEUDOANs { get; set; }
    }
}
