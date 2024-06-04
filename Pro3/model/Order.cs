using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pro3.model
{
    public class Order
    {
        public int Id{ get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate{ get; set; }
        public List<OrderDetail> OrderDetails {get; set;}
    }
}