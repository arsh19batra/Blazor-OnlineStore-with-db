using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadApi.Data
{
    public class Order
    {
        public int order_id { get; set; }
        public int product_id { get; set; }
        public int Quantity { get; set; }
        public decimal list_price { get; set; }
    }
}
