using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace nhom4.Models
{
    public partial class PetShopContextDB : DbContext
    {
        public PetShopContextDB()
            : base("name=PetShopContextDB")
        {
        }

        public virtual DbSet<ChiTietDichVuSpa_HoaDon> ChiTietDichVuSpa_HoaDon { get; set; }
        public virtual DbSet<ChiTietSanPham_HoaDon> ChiTietSanPham_HoaDon { get; set; }
        public virtual DbSet<ChiTietThuCungGui_HoaDon> ChiTietThuCungGui_HoaDon { get; set; }
        public virtual DbSet<DanhMucDichVu> DanhMucDichVus { get; set; }
        public virtual DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; }
        public virtual DbSet<DanhMucThuCung> DanhMucThuCungs { get; set; }
        public virtual DbSet<DichVuGiuThuCung> DichVuGiuThuCungs { get; set; }
        public virtual DbSet<DichVuSpa> DichVuSpas { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ThuCungGui> ThuCungGuis { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanhMucDichVu>()
                .HasMany(e => e.DichVuSpas)
                .WithRequired(e => e.DanhMucDichVu)
                .HasForeignKey(e => e.IDLoaiDV)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DanhMucSanPham>()
                .HasMany(e => e.SanPhams)
                .WithRequired(e => e.DanhMucSanPham)
                .HasForeignKey(e => e.IDLoaiSP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DanhMucThuCung>()
                .HasMany(e => e.ThuCungGuis)
                .WithRequired(e => e.DanhMucThuCung)
                .HasForeignKey(e => e.IDLoaiTC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DichVuSpa>()
                .Property(e => e.Gia)
                .HasPrecision(10, 2);

            modelBuilder.Entity<DichVuSpa>()
                .HasMany(e => e.ChiTietDichVuSpa_HoaDon)
                .WithRequired(e => e.DichVuSpa)
                .HasForeignKey(e => e.DichVuID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietDichVuSpa_HoaDon)
                .WithRequired(e => e.HoaDon)
                .HasForeignKey(e => e.HoaDonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietSanPham_HoaDon)
                .WithRequired(e => e.HoaDon)
                .HasForeignKey(e => e.HoaDonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietThuCungGui_HoaDon)
                .WithRequired(e => e.HoaDon)
                .HasForeignKey(e => e.HoaDonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.DonGia)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietSanPham_HoaDon)
                .WithRequired(e => e.SanPham)
                .HasForeignKey(e => e.SanPhamID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThuCungGui>()
                .HasMany(e => e.ChiTietThuCungGui_HoaDon)
                .WithRequired(e => e.ThuCungGui)
                .HasForeignKey(e => e.ThuCungID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThuCungGui>()
                .HasMany(e => e.DichVuGiuThuCungs)
                .WithRequired(e => e.ThuCungGui)
                .HasForeignKey(e => e.ThuCungID);

            modelBuilder.Entity<User>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);
        }
    }
}
