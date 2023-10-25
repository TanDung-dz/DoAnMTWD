namespace DoAnMTWD.SQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DCVT")]
    public partial class DCVT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DCVT()
        {
            DieuTris = new HashSet<DieuTri>();
        }

        [Key]
        [StringLength(10)]
        public string MaDC { get; set; }

        [StringLength(50)]
        public string TenDC { get; set; }

        [StringLength(50)]
        public string MoTa { get; set; }

        [StringLength(30)]
        public string DVT { get; set; }

        public int? SL { get; set; }

        public decimal? DonGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DieuTri> DieuTris { get; set; }
    }
}
