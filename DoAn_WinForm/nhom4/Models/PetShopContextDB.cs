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

        public virtual DbSet<ChiTietHoaDonDichVu> ChiTietHoaDonDichVus { get; set; }
        public virtual DbSet<ChiTietHoaDonSanPham> ChiTietHoaDonSanPhams { get; set; }
        public virtual DbSet<ChiTietHoaDonThuCung> ChiTietHoaDonThuCungs { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<LoaiDichVu> LoaiDichVus { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<LoaiThuCung> LoaiThuCungs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<ThuCung> ThuCungs { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DichVu>()
                .HasMany(e => e.ChiTietHoaDonDichVus)
                .WithRequired(e => e.DichVu)
                .HasForeignKey(e => e.DichVuID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietHoaDonDichVus)
                .WithRequired(e => e.HoaDon)
                .HasForeignKey(e => e.HoaDonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietHoaDonSanPhams)
                .WithRequired(e => e.HoaDon)
                .HasForeignKey(e => e.HoaDonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietHoaDonThuCungs)
                .WithRequired(e => e.HoaDon)
                .HasForeignKey(e => e.HoaDonID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiDichVu>()
                .HasMany(e => e.DichVus)
                .WithOptional(e => e.LoaiDichVu)
                .HasForeignKey(e => e.IDLoaiDV);

            modelBuilder.Entity<LoaiSanPham>()
                .HasMany(e => e.SanPhams)
                .WithOptional(e => e.LoaiSanPham)
                .HasForeignKey(e => e.IDLoaiSP);

            modelBuilder.Entity<LoaiThuCung>()
                .HasMany(e => e.ThuCungs)
                .WithOptional(e => e.LoaiThuCung)
                .HasForeignKey(e => e.IDLoaiTC);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietHoaDonSanPhams)
                .WithRequired(e => e.SanPham)
                .HasForeignKey(e => e.SanPhamID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThuCung>()
                .HasMany(e => e.ChiTietHoaDonThuCungs)
                .WithRequired(e => e.ThuCung)
                .HasForeignKey(e => e.ThuCungID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.HoaDons)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.NguoiDungID);
        }
    }
}
