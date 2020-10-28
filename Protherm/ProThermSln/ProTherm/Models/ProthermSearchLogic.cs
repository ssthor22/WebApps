using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProTherm.Models
{
    public class ProthermSearchLogic
    {
        private ProthermContext context;
        public ProthermSearchLogic()
        {
            context = new ProthermContext();
        }

        public IQueryable<Protherm> GetProtherm(ProthermSearchModel searchModel)
        {
            var result = context.Protherm.AsQueryable();
            if (searchModel != null)
            {
                if (!String.IsNullOrEmpty(searchModel.ProteinName))
                    result = result.Where(x => x.ProteinName.Contains(searchModel.ProteinName));
                if (searchModel.ProteinMinLen.HasValue)
                    result = result.Where(x => x.Length >= searchModel.ProteinMinLen);
                if (searchModel.ProteinMaxLen.HasValue)
                    result = result.Where(x => x.Length <= searchModel.ProteinMaxLen);
                if (!String.IsNullOrEmpty(searchModel.WTAA))
                    result = result.Where(x => x.Mutation.StartsWith(searchModel.WTAA));
                if (!String.IsNullOrEmpty(searchModel.MutAA))
                    result = result.Where(x => x.Mutation.EndsWith(searchModel.MutAA));
            }
            return result;
        }
    }
}
