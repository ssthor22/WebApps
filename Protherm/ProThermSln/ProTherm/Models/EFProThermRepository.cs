using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ProTherm.Models
{
    public class EFProThermRepository : IProThermRepository
    {
        private ProThermDbContext context;

        public EFProThermRepository(ProThermDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Mutant> Mutants => context.Mutants;
    }
}
