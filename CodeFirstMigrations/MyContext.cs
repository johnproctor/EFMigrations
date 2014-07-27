using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstMigrations
{
    public class MyContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
    }
}
