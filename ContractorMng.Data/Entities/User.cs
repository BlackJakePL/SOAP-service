using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartMng.Data.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public bool IsAdmin { get; set; }   

        [Required]
        [StringLength(100)]
        public string Login { get; set; }

        [Required]
        [StringLength(100)]
        public string Pass { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string Nip { get; set; }
        
        [StringLength(20)]
        public string PhoneNo { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address MAddress { get; set; }

        public ICollection<Address> Addresses { get; set; }

        public User()
        {
            Addresses = new List<Address>();
        }
    }
}
