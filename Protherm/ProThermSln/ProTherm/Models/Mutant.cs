using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace ProTherm.Models
{
    public class Mutant
    {
        public long mutantID { get; set; }
        public string name { get; set; }
        public string PDB { get; set; }
        public string pdburl { get; set; }
        public int size { get; set; }
        public string chain { get; set; }
        public string original { get; set; }
        public int site { get; set; }
        public string mutation { get; set; }

        [Column(TypeName = "decimal(5, 2)")]
        public decimal ddg { get; set; }

    }
}
