namespace OperaShop.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OpBanChay")]
    public partial class OpBanChay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoLuongBan { get; set; }

        [StringLength(10)]
        public string ID_SanPham { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
