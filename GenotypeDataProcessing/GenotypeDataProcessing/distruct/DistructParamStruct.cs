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
        /// first K, to be analyzed
        /// </summary>
        public int kStart;
        /// <summary>
        /// last K, to be analyzed
        /// </summary>
        public int kEnd;

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
        /// <summary>
        /// 0 for horizontal orientation (default),
        /// 1 for vertical orientation,
        /// 2 for reverse horizontal orientation,
        /// 3 for reverse vertical orientation
        /// </summary>
        public int orientation;
        /// <summary>
        /// lower-left x-coordinate of figure
        /// </summary>
        public double xOrigin;
        /// <summary>
        /// lower-left y-coordinate of figure
        /// </summary>
        public double yOrigin;
        /// <summary>
        /// scale for x direction
        /// </summary>
        public double xScale;
        /// <summary>
        /// scale for y direction
        /// </summary>
        public double yScale;
        /// <summary>
        /// angle for labels atop figure (in [0,180])
        /// </summary>
        public double angleLabelAtop;
        /// <summary>
        /// angle for labels below figure (in [0,180])
        /// </summary>
        public double angleLabelBelow;
        /// <summary>
        /// width of "pen" for rim of box
        /// </summary>
        public double lineWidthRim;
        /// <summary>
        /// width of "pen" for separators between pops and for tics
        /// </summary>
        public double lineWidthSep;
        /// <summary>
        /// width of "pen" used for individuals
        /// </summary>
        public double lineWidthInd;
        /// <summary>
        /// use grayscale instead of colors
        /// </summary>
        public bool grayscale;
        /// <summary>
        /// print some of the data to the screen
        /// </summary>
        public bool echoData;
        /// <summary>
        /// print the data as a comment in the ps file
        /// </summary>
        public bool reprintData;
        /// <summary>
        /// print the name of INFILE_POPQ above the figure,
        /// this option is meant for use only with ORIENTATION=0
        /// </summary>
        public bool printInfileName;
        /// <summary>
        /// print ColorBrewer settings in the output file
        /// </summary>
        public bool printColorBrewer;
    }
}
