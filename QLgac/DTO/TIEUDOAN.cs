namespace QLgac.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TIEUDOAN")]
    public partial class TIEUDOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIEUDOAN()
        {
            VATCHATs = new HashSet<VATCHAT>();
            VONGGACs = new HashSet<VONGGAC>();
        }

        [Key]
        [StringLength(10)]
        public string MaTD { get; set; }

        [StringLength(50)]
        public string TenTD { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        public int? QuanSo { get; set; }

        [StringLength(10)]
        public string Id { get; set; }

        public virtual DANGNHAP DANGNHAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VATCHAT> VATCHATs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VONGGAC> VONGGACs { get; set; }
    }
}
