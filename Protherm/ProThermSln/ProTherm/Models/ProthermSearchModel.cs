using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProTherm.Models
{
    public class ProthermSearchModel
    {
        public string ProteinName { get; set; }
        public int? ProteinMinLen { get; set; }
        public int? ProteinMaxLen { get; set; }
        public string WTAA { get; set; }
        public string MutAA { get; set; }
    }
}
