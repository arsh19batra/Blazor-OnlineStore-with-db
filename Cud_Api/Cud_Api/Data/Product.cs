using System;
using System.Collections.Generic;

#nullable disable

namespace Cud_Api.Data
{
    public partial class Product
    {
        public Product()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int GenderId { get; set; }
        public int CategoryId { get; set; }
        public decimal ListPrice { get; set; }

        public virtual Category Category { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Stock Stock { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
