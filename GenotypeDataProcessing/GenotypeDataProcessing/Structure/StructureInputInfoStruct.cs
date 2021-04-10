using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenotypeDataProcessing.Structure
{
    /// <summary>
    /// Contains information about Structure's input file 
    /// </summary>
    [Serializable]
    public struct StructureInputInfoStruct
    {
        /// <summary>
        /// Number of individuals in input file
        /// </summary>
        public int numInds;
        /// <summary>
        /// Number of loci of data
        /// </summary>
        public int numLoci;
        /// <summary>
        /// Ploidy of data
        /// </summary>
        public int ploidy;
        /// <summary>
        /// Value of missing data
        /// </summary>
        public int missingDataValue;
        /// <summary>
        /// True if data per individual are in one row
        /// </summary>
        public bool oneRowPerInd;

        /// <summary>
        /// True if input file contains ID column for each individual
        /// </summary>
        public bool label;
        /// <summary>
        /// True if input file contains user defined population of origin for each individual
        /// </summary>
        public bool popData;
        /// <summary>
        /// 
        /// </summary>
        public bool popFlag;
        /// <summary>
        /// True if input file contains a user-defined sampling location for each individual
        /// </summary>
        public bool locData;
        /// <summary>
        /// True if input file contains a column of phenotype information
        /// </summary>
        public bool phenotype;
        /// <summary>
        /// Number of extra columns in input file (= 0, if there aren't any)
        /// </summary>
        public int extraCols;
        /// <summary>
        /// The top row of the data file contains a list of L names corresponding to the markers used
        /// </summary>
        public bool markerNames;
        /// <summary>
        /// Next row of data file contains a list of L integers indicating which alleles are recessive at each locus
        /// </summary>
        public bool recessiveAlleles;
        /// <summary>
        /// The next row of the data file contains a list of mapdistances between neighboring loci
        /// </summary>
        public bool mapDistances;

        /// <summary>
        /// The row(s) of genotype data for each individual are followed by a row of information about haplotype phase
        /// </summary>
        public bool phaseInfo;

        ///// <summary>
        ///// For use with polyploids when RECESSIVEALLELES=1
        ///// Defines the code indicating that genotype data at a marker are unambiguous
        ///// Must not match MISSING or any allele value in the data
        ///// </summary>
        //public int notAmbiguous;
    }
}
