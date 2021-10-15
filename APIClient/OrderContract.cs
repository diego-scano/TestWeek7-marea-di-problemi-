using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace APIClient
{
    public class OrderContract
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderCode { get; set; }
        public string ProductCode { get; set; }
        public decimal Import { get; set; }
    }
}
