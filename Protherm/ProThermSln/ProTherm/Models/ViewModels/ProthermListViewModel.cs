using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProTherm.Models;

namespace ProTherm.Models.ViewModels
{
    public class ProthermListViewModel
    {
        public IEnumerable<Protherm> Protherms { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
