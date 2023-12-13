using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PartMng.Service.Contract
{
    [DataContract]

    public enum TypeOfAddressCode
    {
        Main = 1,
        Alternative
    }

    
    public class TypeOfAddress
    {
        [DataMember]
        public int TypeOfAddressId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public TypeOfAddressCode Code { get; set; }
        [DataMember]
        public ICollection<Address> Addresses { get; set; }
    }
}
