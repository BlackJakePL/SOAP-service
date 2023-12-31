﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PartMng.Service.Contract
{
    [DataContract]
    public class Wholesaler
    {
        [DataMember]
        public int WholesalerId { get; set; }

        [DataMember]
        public int AddressId { get; set; }
        [DataMember]
        public Address Address { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Nip { get; set; }

      
    }
}
