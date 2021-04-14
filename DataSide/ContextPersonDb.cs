using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSide
{
   public class ContextPersonDb:DbContext
    {
        public ContextPersonDb(DbContextOptions options) : base(options) { }
        public DbSet<Person> people { get; }
    }
}
