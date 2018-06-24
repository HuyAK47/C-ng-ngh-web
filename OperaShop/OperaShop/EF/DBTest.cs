namespace OperaShop.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBTest : DbContext
    {
        public DBTest()
            : base("name=DBTest2")
        {
        }

        public virtual DbSet<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }
        public virtual DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<NhanVienGiaoHang> NhanVienGiaoHangs { get; set; }
        public virtual DbSet<OpBanChay> OpBanChays { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TinhTrangHoaDon> TinhTrangHoaDons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanhMucSanPham>()
                .Property(e => e.TenDM)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.DiaDiemNhan)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.GhiChu)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.TenKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVienGiaoHang>()
                .Property(e => e.TenNV)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.TenOp)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.TieuDeSP)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MoTaSP)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.HinhAnh)
                .IsUnicode(false);

            modelBuilder.Entity<TinhTrangHoaDon>()
                .Property(e => e.TinhTrangHD)
                .IsUnicode(false);
        }
    }
}
