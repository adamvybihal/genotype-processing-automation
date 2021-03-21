using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenotypeDataProcessing.DUTs;

namespace GenotypeDataProcessing.Structure
{
    /// <summary>
    /// Class which loads and checks input data for Structure software.
    /// </summary>
    public class StructureInputData
    {

        private string structureDirectoryPath;
        private string[,] structureData;
        private bool dataLoaded = false;
        private ST_InputDataError inputDataError;

        /// <summary>
        /// Two value constructor
        /// </summary>
        /// <param name="inputPath">Path of input</param>
        /// <param name="projectPath">Path of project</param>
        public StructureInputData(string inputPath, string projectPath)
        {
            CreateStructureDirectory();
            CopyToProjectDir(inputPath, projectPath);
            LoadInputData();
        }

        private void CreateStructureDirectory()
        {
            try
            {
                structureDirectoryPath = Path.Combine(ProjectInfo.projectName, ProjectInfo.structureFolder);

                if (Directory.Exists(structureDirectoryPath))
                {
                    return;
                }

                Directory.CreateDirectory(structureDirectoryPath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void CopyToProjectDir(string inputPath, string projectPath)
        {
            try
            {
                File.Copy(inputPath, projectPath, true);
            }
            catch (IOException copyError)
            {
                Console.WriteLine(copyError.Message);
            }
        }

        private void LoadInputData()
        {
            try
            {
                char[] delimiterChars = { ' ', '\t' };

                string[] rawData = File.ReadAllLines(Path.Combine(structureDirectoryPath, "structureData."));
                int numOfRows = CalculateRows();
                int numOfCols = CalculateCols();

                if (rawData.Length != numOfRows)
                {
                    inputDataError.rowsError = true;
                    inputDataError.expectedRows = numOfRows;
                    inputDataError.actualRows = rawData.Length;

                    return;
                }

                if (numOfRows == 0 | numOfCols == 0)
                {
                    inputDataError.zeroExpectedColsOrRows = true;

                    return;
                }

                structureData = new string[numOfRows, numOfCols];

                int extraRows = CalculateExtraBeginningRows();
                int blankCols = CalculateBlankCols();
                string[] blank = new string[blankCols];

                int i = 0, j = 0;
                foreach (var row in rawData)
                {
                    // todo - check phaseInfo rows (if there are any)                  

                    j = 0;
                    // checks first rows for markers, map distances or recessive alleles
                    // (only if there are any)
                    if (i < extraRows)
                    {
                        string[] cols = row.Trim().Split(delimiterChars);
                        if (cols.Length != ProjectInfo.structureMainParams.numLoci)
                        {
                            inputDataError.columnsError = true;
                            inputDataError.errorRow = i;
                            inputDataError.expectedColumns = numOfCols;
                            inputDataError.actualColumns = cols.Length;

                            return;
                        }
                        
                        string[] completeRow = blank.Concat(cols).ToArray();

                        foreach (var col in completeRow)
                        {
                            structureData[i,j] = col;
                            j++;
                        }
                        
                    }
                    // checks individual data
                    else
                    {
                        string[] cols = row.Trim().Split(delimiterChars);
                        if (cols.Length != numOfCols)
                        {
                            inputDataError.columnsError = true;
                            inputDataError.errorRow = i;
                            inputDataError.expectedColumns = numOfCols;
                            inputDataError.actualColumns = cols.Length;

                            return;
                        }

                        foreach (var col in cols)
                        {
                            structureData[i, j] = col;
                            j++;
                        }
                    }
                    i++;
                }

                dataLoaded = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private int CalculateRows()
        {
            int rows = 0;

            if (ProjectInfo.structureMainParams.oneRowPerInd) rows += ProjectInfo.structureMainParams.numInds;
            else rows += (ProjectInfo.structureMainParams.numInds * ProjectInfo.structureMainParams.ploidy);

            if (ProjectInfo.structureMainParams.markerNames) rows++;
            if (ProjectInfo.structureMainParams.recessiveAlleles) rows++;
            if (ProjectInfo.structureMainParams.mapDistances) rows++;
            if (ProjectInfo.structureMainParams.phaseInfo) rows += ProjectInfo.structureMainParams.numInds;

            return rows;
        }

        private int CalculateExtraBeginningRows()
        {
            int extraRows = 0;

            if (ProjectInfo.structureMainParams.markerNames) extraRows++;
            if (ProjectInfo.structureMainParams.recessiveAlleles) extraRows++;
            if (ProjectInfo.structureMainParams.mapDistances) extraRows++;

            return extraRows;
        }

        private int CalculateCols()
        {
            int cols = 0;

            cols += ProjectInfo.structureMainParams.numLoci;

            if (ProjectInfo.structureMainParams.label) cols++;
            if (ProjectInfo.structureMainParams.popData) cols++;
            if (ProjectInfo.structureMainParams.popFlag) cols++;
            if (ProjectInfo.structureMainParams.locData) cols++;
            if (ProjectInfo.structureMainParams.phenotype) cols++;
            cols += ProjectInfo.structureMainParams.extraCols;

            //todo - single line format

            return cols;
        }

        private int CalculateBlankCols()
        {
            int blankCols = CalculateCols() - ProjectInfo.structureMainParams.numLoci;

            return blankCols;
        }

        /// <summary>
        /// Informs whether data have been loaded, or not.
        /// </summary>
        /// <returns>Bool value</returns>
        public bool DataLoadedSuccesfully()
        {
            return dataLoaded;
        }

        /// <summary>
        /// Returns 2D array containig loaded data.
        /// </summary>
        /// <returns>2D array of strings</returns>
        public string[,] GetStructureData()
        {
            return structureData;
        }

        /// <summary>
        /// Returns string, describing certain error.
        /// </summary>
        /// <returns>Error string</returns>
        public string GetErrorString()
        {
            string errorStr;

            if (inputDataError.zeroExpectedColsOrRows)
            {
                errorStr = "Wrong user input!\n Expected 0 columns or rows in data file.";
            }
            else if (inputDataError.rowsError)
            {
                errorStr = "Wrong user input!\n"
                    + "Expected " + inputDataError.expectedRows + " row(s).\n"
                    + "Data file has " + inputDataError.actualRows + " row(s).";
            }
            else
            {
                errorStr = "Wrong user input!\n"
                    + "Expected " + inputDataError.expectedColumns + " value(s) on row " + (inputDataError.errorRow + 1) + ".\n"
                    + "Data file has " + inputDataError.actualColumns + " value(s) there.";
            }

            return errorStr;
        }
    }
}
