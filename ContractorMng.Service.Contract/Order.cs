using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PartMng.Service.Contract
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int OrderId { get; set; }
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public User User { get; set; }
        [DataMember]
        public int PartId { get; set; }
        [DataMember]
        public Part Part { get; set; }
        [DataMember]
        public int AddressId { get; set; }
        [DataMember]
        public Address Address { get; set; }
        [DataMember]
        public int Qty { get; set; }
    }
}
