namespace OperaShop.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietDonDatHangs = new HashSet<ChiTietDonDatHang>();
            OpBanChays = new HashSet<OpBanChay>();
        }

        [Key]
        [StringLength(10)]
        public string ID_SanPham { get; set; }

        [StringLength(10)]
        public string ID_DanhMuc { get; set; }

        [StringLength(250)]
        public string TenOp { get; set; }

        [StringLength(250)]
        public string TieuDeSP { get; set; }

        [StringLength(250)]
        public string MoTaSP { get; set; }

        public int? GiaSP { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(250)]
        public string HinhAnh { get; set; }

        public int? GiaKM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonDatHang> ChiTietDonDatHangs { get; set; }

        public virtual DanhMucSanPham DanhMucSanPham { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpBanChay> OpBanChays { get; set; }
    }
}
