using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartMng.Data.Entities
{
    [Table("Address")]
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string Street { get; set; }

        [Required]
        [StringLength(10)]
        public string BuildingNo { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        
    }
}
