using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class context : DbContext
    {
        public DbSet<HealthCheckOrder> Order { get; set; }
    }
}
