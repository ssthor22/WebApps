using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProTherm.Models
{
    public interface IProThermRepository
    {
        IQueryable<Mutant> Mutants { get; }
    }
}
