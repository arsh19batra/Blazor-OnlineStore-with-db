using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadApi.Data
{
    public class Product
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public int gender_id { get; set; }
        public int category_id { get; set; }
        public decimal list_price { get; set; }
    }
}
