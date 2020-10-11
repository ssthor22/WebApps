using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProTherm.Models;

namespace ProTherm.Models.ViewModels
{
    public class MutantsListViewModel
    {
        public IEnumerable<Mutant> Mutants { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
