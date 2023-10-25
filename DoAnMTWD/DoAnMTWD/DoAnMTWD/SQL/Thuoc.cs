namespace DoAnMTWD.SQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thuoc")]
    public partial class Thuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Thuoc()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string MaThuoc { get; set; }

        [StringLength(50)]
        public string Tenthuoc { get; set; }

        [StringLength(50)]
        public string MoTa { get; set; }

        [StringLength(40)]
        public string DVT { get; set; }

        public int? SL { get; set; }

        public decimal? DonGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
