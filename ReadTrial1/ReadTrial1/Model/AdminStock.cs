using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadTrial1.Model
{
    public class AdminStock
    {
       
        public int ProductId { get; set; }
        public int? Quantity { get; set; }

        public virtual AdminCreate Product { get; set; }
        
    }
}
