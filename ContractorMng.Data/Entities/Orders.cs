using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartMng.Data.Entities
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address address { get; set; }

        [ForeignKey("Parts")]
        public int PartId { get; set; }
        public Parts Part { get; set; }

        [Required]
        public int Qty { get; set; }

        public Orders(User user, Parts part)
        {
            User = user;
            UserId = user.UserId;
            Part = part;
            PartId = Part.PartId;
        }
    }
}
