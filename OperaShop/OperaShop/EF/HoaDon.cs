namespace OperaShop.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            ChiTietDonDatHangs = new HashSet<ChiTietDonDatHang>();
        }

        [Key]
        [StringLength(10)]
        public string ID_HoaDon { get; set; }

        public DateTime? NgayLapHD { get; set; }

        [StringLength(250)]
        public string DiaDiemNhan { get; set; }

        [StringLength(250)]
        public string GhiChu { get; set; }

        public int? TongTien { get; set; }

        [StringLength(10)]
        public string ID_KhachHang { get; set; }

        [StringLength(10)]
        public string ID_TinhTrangHD { get; set; }

        [StringLength(10)]
        public string ID_NVGiaoHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVienGiaoHang NhanVienGiaoHang { get; set; }

        public virtual TinhTrangHoaDon TinhTrangHoaDon { get; set; }
    }
}
