using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Core.Models
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime OrderDate { get; set; }
        [DataMember]
        public string OrderCode { get; set; }
        [DataMember]
        public string ProductCode { get; set; }
        [DataMember]
        public decimal Import { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
