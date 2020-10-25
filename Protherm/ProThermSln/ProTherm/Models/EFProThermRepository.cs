using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ProTherm.Models
{
    public class EFProThermRepository : IProthermRepository
    {
        private ProthermContext context;

        public EFProThermRepository(ProthermContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Protherm> Protherms => context.Protherm;
    }
}
