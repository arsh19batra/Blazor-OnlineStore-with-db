using System;
using System.Collections.Generic;

#nullable disable

namespace Cud_Api.Data
{
    public partial class Stock
    {
        public int ProductId { get; set; }
        public int? Quantity { get; set; }

        public virtual Product Product { get; set; }
    }
}
