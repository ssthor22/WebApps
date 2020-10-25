using System;
using System.Collections.Generic;

namespace ProTherm
{
    public partial class Protherm
    {
        public int EntryId { get; set; }
        public string ProteinName { get; set; }
        public string Source { get; set; }
        public int? Length { get; set; }
        public double? MolecularWt { get; set; }
        public string PirId { get; set; }
        public string SwissProtId { get; set; }
        public string EcNum { get; set; }
        public string PmdNum { get; set; }
        public string WtPdb { get; set; }
        public string MutPdb { get; set; }
        public string WtPdbUrl { get; set; }
        public string MutPdbUrl { get; set; }
        public string Mutation { get; set; }
        public string Chain { get; set; }
        public double? DGH2o { get; set; }
        public double? DdGH2o { get; set; }
        public double? DG { get; set; }
        public double? DdG { get; set; }
        public double? TM { get; set; }
        public double? DTM { get; set; }
    }
}
