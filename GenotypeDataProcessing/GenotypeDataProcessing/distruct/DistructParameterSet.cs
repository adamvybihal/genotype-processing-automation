using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenotypeDataProcessing.distruct
{
    /// <summary>
    /// Class for managing distruct parameter sets
    /// </summary>
    public class DistructParameterSet
    {

        private DistructParamStruct distructParamStruct;
        private string directoryPath;
        private bool isDrawparamsCreated = false;

        /// <summary>
        /// Constructor with two parameters
        /// </summary>
        /// <param name="distructParam">Structure containing distruct parameters</param>
        /// <param name="path">path where will distruct parameter file be created</param>
        public DistructParameterSet(DistructParamStruct distructParam, string path)
        {
            distructParamStruct = distructParam;
            directoryPath = path;

            CreateDirectory();
        }

        private void CreateDirectory()
        {
            try
            {
                directoryPath = Path.Combine(ProjectInfo.projectNamePath, ProjectInfo.distructFolder);

                if (Directory.Exists(directoryPath))
                {
                    return;
                }

                Directory.CreateDirectory(directoryPath);
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    e.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Method creates drawparams file
        /// </summary>
        public void CreateDrawparams()
        {
            isDrawparamsCreated = false;
            string drawparamsString = SetDrawparamsString();

            string drawparamsPath = Path.Combine(directoryPath, "drawparams.");

            try
            {
                using (FileStream fs = File.Create(drawparamsPath))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(drawparamsString);
                    fs.Write(info, 0, info.Length);
                }

                isDrawparamsCreated = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private string SetDrawparamsString()
        {
            return "#define INFILE_POPQ     clumpp-testData/K3.popq" + "\n" +    
                "#define INFILE_INDIVQ      clumpp-testData/K3.indivq" + "\n" +
                "#define INFILE_LABEL_BELOW " + distructParamStruct.infileLabelBelow + "\n" +
                "#define INFILE_LABEL_ATOP  " + distructParamStruct.infileLabelAtop + "\n" +
                "#define INFILE_CLUST_PERM  " + distructParamStruct.infileClustPerm + "\n" +
                "#define OUTFILE            outfile.ps" + "\n" +

                "#define K	" + distructParamStruct.k + "\n" +
                "#define NUMPOPS " + distructParamStruct.numPops + "\n" +
                "#define NUMINDS " + distructParamStruct.numInds + "\n" +

                "#define PRINT_INDIVS      " + ReturnLogical(distructParamStruct.printIndivs) + "\n" +
                "#define PRINT_LABEL_ATOP  " + ReturnLogical(distructParamStruct.printLabelAtop) + "\n" +
                "#define PRINT_LABEL_BELOW " + ReturnLogical(distructParamStruct.printLabelBelow) + "\n" +
                "#define PRINT_SEP         " + ReturnLogical(distructParamStruct.printSep) + "\n" +

                "#define FONTHEIGHT " + distructParamStruct.fontHeight.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define DIST_ABOVE " + distructParamStruct.distAbove.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define DIST_BELOW " + distructParamStruct.distBelow.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define BOXHEIGHT  " + distructParamStruct.boxHeight.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define INDIVWIDTH " + distructParamStruct.indivWidth.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +

                "#define ORIENTATION 0" + "\n" +
                "#define XORIGIN 72" + "\n" +
                "#define YORIGIN 288" + "\n" +
                "#define XSCALE 1" + "\n" +
                "#define YSCALE 1" + "\n" +
                "#define ANGLE_LABEL_ATOP 60" + "\n" +
                "#define ANGLE_LABEL_BELOW 60" + "\n" +
                "#define LINEWIDTH_RIM  3" + "\n" +
                "#define LINEWIDTH_SEP 0.3" + "\n" +
                "#define LINEWIDTH_IND 0.3" + "\n" +
                "#define GRAYSCALE 0" + "\n" +
                "#define ECHO_DATA 1" + "\n" +
                "#define REPRINT_DATA 1" + "\n" +
                "#define PRINT_INFILE_NAME 0" + "\n" +
                "#define PRINT_COLOR_BREWER 1";
        }
        
        /// <summary>
        /// Informs of successful creation of file drawparams
        /// </summary>
        /// <returns>true if drawparams was created, false if not</returns>
        public bool IsDrawparamsCreated()
        {
            return isDrawparamsCreated;
        }

        /// <summary>
        /// returns 0 or 1, based on bool value
        /// </summary>
        /// <param name="boolValue">bool param</param>
        /// <returns>0 or 1</returns>
        public static int ReturnLogical(bool boolValue)
        {
            if (boolValue) return 1;
            else return 0;
        }
    }
}
