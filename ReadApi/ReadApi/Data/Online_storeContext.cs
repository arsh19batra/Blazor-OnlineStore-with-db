using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadApi.Data
{
    public class Online_storeContext:DbContext
    {
        public Online_storeContext() { }
        public Online_storeContext(DbContextOptions<Online_storeContext> options) : base(options) { }
    }
}
