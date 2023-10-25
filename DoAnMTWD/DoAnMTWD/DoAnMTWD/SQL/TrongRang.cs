namespace DoAnMTWD.SQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrongRang")]
    public partial class TrongRang
    {
        [Key]
        [StringLength(10)]
        public string MaCL { get; set; }

        [StringLength(50)]
        public string PhanLoai { get; set; }

        [StringLength(50)]
        public string ChatLieu { get; set; }

        public decimal? DonGia { get; set; }
    }
}
