namespace DoAnMTWD.SQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BenhNhan")]
    public partial class BenhNhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BenhNhan()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string MaBN { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(10)]
        public string NamSinh { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKham { get; set; }

        [StringLength(50)]
        public string LiDoKham { get; set; }

        [StringLength(10)]
        public string MaKT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
