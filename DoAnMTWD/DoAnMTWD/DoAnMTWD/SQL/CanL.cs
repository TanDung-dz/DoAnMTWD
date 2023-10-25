namespace DoAnMTWD.SQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CanLS")]
    public partial class CanL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CanL()
        {
            DieuTris = new HashSet<DieuTri>();
        }

        [Key]
        [StringLength(10)]
        public string MaCD { get; set; }

        [StringLength(10)]
        public string MaBH { get; set; }

        [StringLength(10)]
        public string MaKT { get; set; }

        [StringLength(50)]
        public string KetQua { get; set; }

        [StringLength(50)]
        public string KetLuan { get; set; }

        public virtual BaoHanh BaoHanh { get; set; }

        public virtual XN_XQUANG XN_XQUANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DieuTri> DieuTris { get; set; }
    }
}
