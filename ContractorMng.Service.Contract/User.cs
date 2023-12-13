using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PartMng.Service.Contract
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public bool IsAdmin { get; set; }

        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Pass { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Nip { get; set; }

        [DataMember]
        public string PhoneNo { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public ICollection<Address> Addresses { get; set; }
    }
}