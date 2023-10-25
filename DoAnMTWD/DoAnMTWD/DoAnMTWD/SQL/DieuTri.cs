namespace DoAnMTWD.SQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DieuTri")]
    public partial class DieuTri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DieuTri()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string MaDV { get; set; }

        [StringLength(50)]
        public string TenDV { get; set; }

        [StringLength(10)]
        public string MaRang { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(30)]
        public string DVT { get; set; }

        public decimal? DonGia { get; set; }

        [StringLength(10)]
        public string MaCD { get; set; }

        [StringLength(10)]
        public string MaDC { get; set; }

        public virtual CanL CanL { get; set; }

        public virtual DCVT DCVT { get; set; }

        public virtual Rang Rang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
