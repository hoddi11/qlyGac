namespace QLgac.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DAIDOI")]
    public partial class DAIDOI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAIDOI()
        {
            DAMNHIEMGACs = new HashSet<DAMNHIEMGAC>();
            HOCVIENs = new HashSet<HOCVIEN>();
            SUVIECs = new HashSet<SUVIEC>();
        }

        [Key]
        [StringLength(10)]
        public string MaDD { get; set; }

        [StringLength(50)]
        public string TenDD { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(10)]
        public string MaTD { get; set; }

        public int? QuanSo { get; set; }

        [StringLength(10)]
        public string Id { get; set; }

        public virtual DANGNHAP DANGNHAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DAMNHIEMGAC> DAMNHIEMGACs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOCVIEN> HOCVIENs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUVIEC> SUVIECs { get; set; }
    }
}
