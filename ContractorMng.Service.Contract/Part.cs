using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PartMng.Service.Contract
{
    [DataContract]
    public class Part
    {
        [DataMember]
        public int PartId { get; set; }

        [DataMember]
        public int WholesalerId { get; set; }
        [DataMember]
        public Wholesaler Wholesaler { get; set; }

        [DataMember]
        public string Producer { get; set; }

        [DataMember]
        public string PartNo { get; set; }

        [DataMember]
        public string OemNo { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public string Display { get; set; }
        
        public override string ToString()
        {
            return PartId.ToString()+" "+Producer + " " +PartNo + " " +OemNo + " " + Price.ToString();
        }
        
        public Part()
        { 
            Display = PartId.ToString() + " " + Producer + " " + PartNo + " " + OemNo + " " + Price.ToString();
        }

    }
}
