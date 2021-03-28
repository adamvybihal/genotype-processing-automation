using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenotypeDataProcessing.CLUMPP
{
    /// <summary>
    /// struct ClumppParamStruct holds data for clumpp's paramfile
    /// </summary>
    public struct ClumppParamStruct
    {
        /// <summary>
        /// 0 = individual data in the file specified by INDFILE,
        /// 1 = population data in the file specified by POPFILE
        /// </summary>
        public int dataType;
        /// <summary>
        /// The name of the individual datafile
        /// </summary>
        public string indFile;
        /// <summary>
        /// The name of the population datafile
        /// </summary>
        public string popFile;
        /// <summary>
        /// The average cluster membership coefficients across the permuted
        /// runs are printed here
        /// </summary>
        public string outFile;
        /// <summary>
        /// The parameters used and a summary of the results are printed here
        /// </summary>
        public string miscFile;
        /// <summary>
        /// Number of clusters
        /// </summary>
        public int k;
        /// <summary>
        /// Number of individuals
        /// </summary>
        public int individuals;
        /// <summary>
        /// Number of populations
        /// </summary>
        public int populations;
        /// <summary>
        /// Number of runs
        /// </summary>
        public int r;
        /// <summary>
        /// Method to be used
        /// (1 = FullSearch,
        /// 2 = Greedy,
        /// 3 = LargeKGreedy)
        /// </summary>
        public int m;
        /// <summary>
        /// 1 = All possible input orders,
        /// 2 = random input orders,
        /// 3 = pre-specified input orders
        /// </summary>
        public int greedyOption;
        /// <summary>
        /// If GREEDY_OPTION = 2, then REPEATS determines the number of random input orders to be tested,
        /// If GREEDY_OPTION = 3, then REPEATS is the number of input orders in PERMUTATIONFILE
        /// </summary>
        public int repeats;
        /// <summary>
        /// The permutations of the runs in PERMUTATIONFILE will be used,
        /// if GREEDY_OPTION = 3
        /// </summary>
        public string permutationFile;
        /// <summary>
        /// Print the permuted data (clusters),
        /// 0 = don't print,
        /// 1 = print into one file,
        /// 2 = print into separate files for each run
        /// </summary>
        public int printPermutedData;
        /// <summary>
        /// The permuted data (clusters) will be printed to this file
        /// </summary>
        public string permutedDataFile;
        /// <summary>
        /// Print every tested permutation of the runs
        /// </summary>
        public bool printEveryPerm;
        /// <summary>
        /// Every tested permutation of the runs and the corresponding SSC will be printed here
        /// </summary>
        public string everyPermFile;
        /// <summary>
        /// Print random input orders of runs
        /// </summary>
        public bool printRandomInputOrder;
        /// <summary>
        /// Every random input order of the runs will be printed here
        /// </summary>
        public string randomInputOrderFile;
        /// <summary>
        /// This option allows the user to override non-crucial warnings
        /// </summary>
        public bool overrideWarnings;
        /// <summary>
        /// Permute the clusters of the output files by the specified run
        /// </summary>
        public bool orderByRun;
    }
}
