using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework1.Repository
{
    public class ZooContext :DbContext
    {
        public ZooContext(DbContextOptions<ZooContext> options) : base(options) { }

        public virtual DbSet<KingDom> KingDom { get; set; }
        public virtual DbSet<Character> Character { set; get; }
    }
}
