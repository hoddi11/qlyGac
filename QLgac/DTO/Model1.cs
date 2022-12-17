using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLgac.DTO
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<DAIDOI> DAIDOIs { get; set; }
        public virtual DbSet<DAMNHIEMGAC> DAMNHIEMGACs { get; set; }
        public virtual DbSet<DANGNHAP> DANGNHAPs { get; set; }
        public virtual DbSet<HOCVIEN> HOCVIENs { get; set; }
        public virtual DbSet<KIEMTRA> KIEMTRAs { get; set; }
        public virtual DbSet<LICHGAC> LICHGACs { get; set; }
        public virtual DbSet<NGUOIKIEMTRA> NGUOIKIEMTRAs { get; set; }
        public virtual DbSet<QUYDINH> QUYDINHs { get; set; }
        public virtual DbSet<SUVIEC> SUVIECs { get; set; }
        public virtual DbSet<TIEUDOAN> TIEUDOANs { get; set; }
        public virtual DbSet<VATCHAT> VATCHATs { get; set; }
        public virtual DbSet<VIPHAM> VIPHAMs { get; set; }
        public virtual DbSet<VONGGAC> VONGGACs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DAIDOI>()
                .Property(e => e.MaDD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAIDOI>()
                .Property(e => e.MaTD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAIDOI>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAIDOI>()
                .HasMany(e => e.DAMNHIEMGACs)
                .WithRequired(e => e.DAIDOI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DAMNHIEMGAC>()
                .Property(e => e.MaGac)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAMNHIEMGAC>()
                .Property(e => e.MaDD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAMNHIEMGAC>()
                .HasMany(e => e.LICHGACs)
                .WithRequired(e => e.DAMNHIEMGAC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DANGNHAP>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOCVIEN>()
                .Property(e => e.MaHV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOCVIEN>()
                .Property(e => e.MaDD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOCVIEN>()
                .Property(e => e.MaVG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KIEMTRA>()
                .Property(e => e.MaVG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KIEMTRA>()
                .Property(e => e.SoHieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LICHGAC>()
                .Property(e => e.MaSo)
                .IsFixedLength();

            modelBuilder.Entity<LICHGAC>()
                .Property(e => e.MaGac)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIKIEMTRA>()
                .Property(e => e.SoHieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIKIEMTRA>()
                .HasMany(e => e.KIEMTRAs)
                .WithRequired(e => e.NGUOIKIEMTRA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QUYDINH>()
                .Property(e => e.MaQD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SUVIEC>()
                .Property(e => e.MaSV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SUVIEC>()
                .Property(e => e.MaHV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SUVIEC>()
                .Property(e => e.MaDD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SUVIEC>()
                .Property(e => e.MaQD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TIEUDOAN>()
                .Property(e => e.MaTD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TIEUDOAN>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VATCHAT>()
                .Property(e => e.MaVC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VATCHAT>()
                .Property(e => e.MaTD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VIPHAM>()
                .Property(e => e.MaVP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VIPHAM>()
                .Property(e => e.MaQD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VIPHAM>()
                .Property(e => e.SoHieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VONGGAC>()
                .Property(e => e.MaVG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VONGGAC>()
                .Property(e => e.MaTD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VONGGAC>()
                .HasMany(e => e.KIEMTRAs)
                .WithRequired(e => e.VONGGAC)
                .WillCascadeOnDelete(false);
        }
    }
}
