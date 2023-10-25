namespace DoAnMTWD.SQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        [StringLength(10)]
        public string MaBN { get; set; }

        [StringLength(10)]
        public string MaThuoc { get; set; }

        [StringLength(10)]
        public string MaDV { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        public decimal? TongTien { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }

        public virtual DieuTri DieuTri { get; set; }

        public virtual Thuoc Thuoc { get; set; }
    }
}
