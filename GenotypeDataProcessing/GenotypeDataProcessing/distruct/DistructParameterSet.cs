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

        private int initK;
        private int lastK;

        private bool areParameterFilesCreated = false;

        /// <summary>
        /// DistructParameterSet constructor
        /// </summary>
        /// <param name="paramsetName">name of parameter set</param>
        /// <param name="distructParam">Structure containing distruct parameters</param>
        /// <param name="path">path where will distruct parameter file be created</param>
        /// <param name="startK">starting K</param>
        /// <param name="endK">ending K</param>
        public DistructParameterSet(string paramsetName, DistructParamStruct distructParam, string path, int startK, int endK)
        {
            distructParamStruct = distructParam;
            directoryPath = path;

            initK = startK;
            lastK = endK;

            CreateDirectory();
            CopyUserInputFiles();
        }

        private void CopyUserInputFiles()
        {
            if (distructParamStruct.infileLabelBelow != "")
            {
                try
                {
                    File.Copy(distructParamStruct.infileLabelBelowPath,
                              distructParamStruct.infileLabelBelowCopy, 
                              true);
                }
                catch (IOException copyError)
                {
                    Console.WriteLine(copyError.Message);
                }
            }

            if (distructParamStruct.infileLabelAtop != "")
            {
                try
                {
                    File.Copy(distructParamStruct.infileLabelAtopPath,
                              distructParamStruct.infileLabelAtopCopy,
                              true);
                }
                catch (IOException copyError)
                {
                    Console.WriteLine(copyError.Message);
                }
            }

            if (distructParamStruct.infileClustPerm != "")
            {
                try
                {
                    File.Copy(distructParamStruct.infileClustPermPath,
                              distructParamStruct.infileClustPermCopy,
                              true);
                }
                catch (IOException copyError)
                {
                    Console.WriteLine(copyError.Message);
                }
            }
        }

        private void CreateDirectory()
        {
            try
            {
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
        /// Create drawparams files for all Ks
        /// </summary>
        public void CreateParameterFiles()
        {
            areParameterFilesCreated = false;

            for (int i = initK; i <= lastK; i++)
            {
                CreateDrawparams(i);
            }

            areParameterFilesCreated = true;
        }

        private void CreateDrawparams(int currK)
        {
            
            string drawparamsString = SetDrawparamsString(currK);
            string drawparamsName = "drawparams" + currK;

            string drawparamsPath = Path.Combine(directoryPath, drawparamsName);

            try
            {
                using (FileStream fs = File.Create(drawparamsPath))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(drawparamsString);
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private string SetDrawparamsString(int currK)
        {
            return "#define INFILE_POPQ K" + currK + ".popq" + "\n" +
                "#define INFILE_INDIVQ K" + currK + ".indivq" + "\n" +
                "#define INFILE_LABEL_BELOW " + distructParamStruct.infileLabelBelow + "\n" +
                "#define INFILE_LABEL_ATOP  " + distructParamStruct.infileLabelAtop + "\n" +
                "#define INFILE_CLUST_PERM  " + distructParamStruct.infileClustPerm + "\n" +
                "#define OUTFILE K" + currK + ".ps" + "\n" +

                "#define K " + currK + "\n" +
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

                "#define ORIENTATION " + distructParamStruct.orientation + "\n" +
                "#define XORIGIN " + distructParamStruct.xOrigin.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define YORIGIN " + distructParamStruct.yOrigin.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define XSCALE " + distructParamStruct.xScale.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define YSCALE " + distructParamStruct.yScale.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define ANGLE_LABEL_ATOP " + distructParamStruct.angleLabelAtop.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define ANGLE_LABEL_BELOW " + distructParamStruct.angleLabelBelow.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define LINEWIDTH_RIM  " + distructParamStruct.lineWidthRim.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define LINEWIDTH_SEP " + distructParamStruct.lineWidthSep.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define LINEWIDTH_IND " + distructParamStruct.lineWidthInd.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define GRAYSCALE " + ReturnLogical(distructParamStruct.grayscale) + "\n" +
                "#define ECHO_DATA " + ReturnLogical(distructParamStruct.echoData) + "\n" +
                "#define REPRINT_DATA " + ReturnLogical(distructParamStruct.reprintData) + "\n" +
                "#define PRINT_INFILE_NAME " + ReturnLogical(distructParamStruct.printInfileName) + "\n" +
                "#define PRINT_COLOR_BREWER " + ReturnLogical(distructParamStruct.printColorBrewer);
        }
        
        /// <summary>
        /// Informs of successful creation of file drawparams
        /// </summary>
        /// <returns>true if drawparams was created, false if not</returns>
        public bool AreParamFilesCreated()
        {
            return areParameterFilesCreated;
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
