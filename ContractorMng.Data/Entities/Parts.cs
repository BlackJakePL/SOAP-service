using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartMng.Data.Entities
{
    [Table("Parts")]
    public class Parts
    {
        [Key]
        public int PartId { get; set; }

        [ForeignKey("Wholesaler")]
        public int WholesalerId { get; set; }
        public User Wholesaler { get; set; }

        [Required]
        [StringLength(50)]
        public string Producer { get; set; }

        [Required]
        [StringLength(50)]
        public string PartNo { get; set; }

        [Required]
        [StringLength(50)]
        public string OemNo { get; set; }

        [Required]
        public double Price { get; set; }
    }
}
