using System;
using System.Collections.Generic;

#nullable disable

namespace Cud_Api.Data
{
    public partial class OrderItem
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal ListPrice { get; set; }

        public virtual Product Product { get; set; }
    }
}
