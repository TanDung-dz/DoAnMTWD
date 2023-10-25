using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAnMTWD.SQL
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model13")
        {
        }

        public virtual DbSet<BaoHanh> BaoHanhs { get; set; }
        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<CanL> CanLS { get; set; }
        public virtual DbSet<DCVT> DCVTs { get; set; }
        public virtual DbSet<DieuTri> DieuTris { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<Rang> Rangs { get; set; }
        public virtual DbSet<Thuoc> Thuocs { get; set; }
        public virtual DbSet<TrongRang> TrongRangs { get; set; }
        public virtual DbSet<XN_XQUANG> XN_XQUANG { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaoHanh>()
                .Property(e => e.MaBH)
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.MaBN)
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.NamSinh)
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<BenhNhan>()
                .Property(e => e.MaKT)
                .IsUnicode(false);

            modelBuilder.Entity<CanL>()
                .Property(e => e.MaCD)
                .IsUnicode(false);

            modelBuilder.Entity<CanL>()
                .Property(e => e.MaBH)
                .IsUnicode(false);

            modelBuilder.Entity<CanL>()
                .Property(e => e.MaKT)
                .IsUnicode(false);

            modelBuilder.Entity<DCVT>()
                .Property(e => e.MaDC)
                .IsUnicode(false);

            modelBuilder.Entity<DCVT>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DieuTri>()
                .Property(e => e.MaDV)
                .IsUnicode(false);

            modelBuilder.Entity<DieuTri>()
                .Property(e => e.MaRang)
                .IsUnicode(false);

            modelBuilder.Entity<DieuTri>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DieuTri>()
                .Property(e => e.MaCD)
                .IsUnicode(false);

            modelBuilder.Entity<DieuTri>()
                .Property(e => e.MaDC)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaBN)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaDV)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TongTien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Rang>()
                .Property(e => e.MaRang)
                .IsUnicode(false);

            modelBuilder.Entity<Thuoc>()
                .Property(e => e.MaThuoc)
                .IsUnicode(false);

            modelBuilder.Entity<Thuoc>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TrongRang>()
                .Property(e => e.MaCL)
                .IsUnicode(false);

            modelBuilder.Entity<TrongRang>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<XN_XQUANG>()
                .Property(e => e.MaKT)
                .IsUnicode(false);

            modelBuilder.Entity<XN_XQUANG>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);
        }
    }
}
