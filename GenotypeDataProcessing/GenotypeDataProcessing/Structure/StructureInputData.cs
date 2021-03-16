using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenotypeDataProcessing.Structure
{
    public class StructureInputData
    {

        private string structureDirectoryPath;
        private string[,] structureData;
        private bool dataLoaded = false;

        public StructureInputData(string inputPath, string projectPath)
        {
            CreateStructureDirectory();
            CopyToProjectDir(inputPath, projectPath);
            // nacist data do promenne
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
                string[] rawData = File.ReadAllLines(Path.Combine(structureDirectoryPath, "structureData."));
                int numOfRows = CalculateRows();
                int numOfCols = CalculateCols();

                if (rawData.Length != numOfRows) return;

                if (numOfRows == 0 | numOfCols == 0) return;

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
                        string[] cols = row.Trim().Split(' ');
                        if (cols.Length != ProjectInfo.structureMainParams.numLoci) return;

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
                        string[] cols = row.Trim().Split(' ');
                        if (cols.Length != numOfCols) return;

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

        public bool DataLoadedSuccesfully()
        {
            return dataLoaded;
        }

        public string[,] GetStructureData()
        {
            return structureData;
        }
    }
}
