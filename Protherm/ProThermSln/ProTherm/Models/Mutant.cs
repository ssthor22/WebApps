using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace ProTherm.Models
{
    public class Mutant
    {
        [Key]
        public long EntryID { get; set; }
        public string ProteinName { get; set; }
        public string Source { get; set; }
        public int Length { get; set; }
        public float Molecular_Wt { get; set; }
        public string PIR_ID { get; set; }
        public string Swiss_Prot_ID { get; set; }
        public string EC_Num { get; set; }
        public string PMD_Num { get; set; }
        public string WT_PDB { get; set; }
        public string Mut_PDB { get; set; }
        public string WT_PDB_URL { get; set; }
        public string Mut_PDB_URL { get; set; }
        public string Mutation { get; set; }
        public string Chain { get; set; }
        public float dG_H2O { get; set; }
        public float ddG_H2O { get; set; }
        public float dG { get; set; }
        public float ddG { get; set; }
        public float T_m { get; set; }
        public float dT_m { get; set; }

    }
}
