using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenotypeDataProcessing.distruct
{
    /// <summary>
    /// DistructParamStruct holds distruct's parameters
    /// </summary>
    [Serializable]
    public struct DistructParamStruct
    {
        /// <summary>
        /// input file of population q's
        /// </summary>
        public string infilePopq;
        /// <summary>
        /// input file of individual q's
        /// </summary>
        public string infileIndivq;
        /// <summary>
        /// input file of labels for below figure
        /// </summary>
        public string infileLabelBelow;
        /// <summary>
        /// input file of labels for atop figure
        /// </summary>
        public string infileLabelAtop;
        /// <summary>
        /// input file of permutation of clusters to print
        /// </summary>
        public string infileClustPerm;
        /// <summary>
        /// name of output file
        /// </summary>
        public string outfile;
        /// <summary>
        /// number of clusters
        /// </summary>
        public int k;
        /// <summary>
        /// number of pre-defined populations
        /// </summary>
        public int numPops;
        /// <summary>
        /// number of individuals
        /// </summary>
        public int numInds;
        /// <summary>
        /// 1 if indiv q's are to be printed, 0 if only population q's
        /// </summary>
        public bool printIndivs;
        /// <summary>
        /// print labels above figure
        /// </summary>
        public bool printLabelAtop;
        /// <summary>
        /// print labels below figure
        /// </summary>
        public bool printLabelBelow;
        /// <summary>
        /// print lines to separate populations
        /// </summary>
        public bool printSep;
        /// <summary>
        /// size of font
        /// </summary>
        public double fontHeight;
        /// <summary>
        /// distance above plot to place text
        /// </summary>
        public double distAbove;
        /// <summary>
        /// distance below plot to place text
        /// </summary>
        public double distBelow;
        /// <summary>
        /// height of the figure
        /// </summary>
        public double boxHeight;
        /// <summary>
        /// width of an individual
        /// </summary>
        public double indivWidth;
    }
}
