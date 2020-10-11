using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProTherm.Models
{
    public class ProThermDbContext : DbContext
    {
        public ProThermDbContext(DbContextOptions<ProThermDbContext> options)
            : base(options) { }

        public DbSet<Mutant> Mutants { get; set; }
    }
}
