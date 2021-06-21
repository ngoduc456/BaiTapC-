namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [StringLength(5)]
        public string IDpr { get; set; }

        [StringLength(2)]
        public string IDCtg { get; set; }

        [Required]
        [StringLength(50)]
        public string NamePr { get; set; }

        public double Price { get; set; }

        public int SL { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] ImgUrl { get; set; }

        [StringLength(255)]
        public string MT { get; set; }

        public bool? TrThai { get; set; }

        public virtual Category Category { get; set; }
    }
}
