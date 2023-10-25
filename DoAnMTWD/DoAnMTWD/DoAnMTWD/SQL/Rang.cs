namespace DoAnMTWD.SQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rang")]
    public partial class Rang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rang()
        {
            DieuTris = new HashSet<DieuTri>();
        }

        [Key]
        [StringLength(10)]
        public string MaRang { get; set; }

        [StringLength(50)]
        public string LoaiRang { get; set; }

        [StringLength(50)]
        public string TenRang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DieuTri> DieuTris { get; set; }
    }
}
