using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartMng.Data.Entities
{
    [Table("Wholesalers")]
    public class Wholesalers
    {
        [Key]
        public int WholesalerId { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address address { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

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
