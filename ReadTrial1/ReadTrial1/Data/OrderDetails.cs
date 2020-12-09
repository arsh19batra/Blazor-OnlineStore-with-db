using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadTrial1.Data
{
    public class OrderDetails
    {
        public int order_id { get; set; }
        public int product_id { get; set; }
        public int Quantity { get; set; }
        public decimal list_price { get; set; }
    }
}
