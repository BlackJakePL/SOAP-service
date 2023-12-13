using System.Runtime.Serialization;

namespace PartMng.Service.Contract
{
    [DataContract]
    public class Address
    {
        [DataMember]
        public int AddressId { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Street { get; set; }

        [DataMember]
        public string BuildingNo { get; set; }

        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Display { get; set; }

    }
}