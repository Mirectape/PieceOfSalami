using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstYeah
{
    class CatContext : DbContext
    {
        public CatContext() : base("DbConnection") { }

        public DbSet<Cat> Cats { get; set; }
    }
}
