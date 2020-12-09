using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadTrial1.Data
{
    public class ProductUpdate
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int GenderId { get; set; }
        public int CategoryId { get; set; }
        public decimal ListPrice { get; set; }
    }
}
