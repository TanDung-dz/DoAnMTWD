namespace DoAnMTWD.SQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XN-XQUANG")]
    public partial class XN_XQUANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XN_XQUANG()
        {
            CanLS = new HashSet<CanL>();
        }

        [Key]
        [StringLength(10)]
        public string MaKT { get; set; }

        [StringLength(20)]
        public string LoaiKT { get; set; }

        [StringLength(20)]
        public string Ten { get; set; }

        public decimal? DonGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CanL> CanLS { get; set; }
    }
}
