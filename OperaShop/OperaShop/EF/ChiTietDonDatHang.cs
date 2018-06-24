namespace OperaShop.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDonDatHang")]
    public partial class ChiTietDonDatHang
    {
        [Key]
        [StringLength(10)]
        public string ID_ChiTietHD { get; set; }

        public int? GiaSP { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(10)]
        public string ID_HoaDon { get; set; }

        [StringLength(10)]
        public string ID_SanPham { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
