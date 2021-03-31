﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenotypeDataProcessing.CLUMPP
{
    public class ClumppParameterSet
    {

        private string directoryPath;

        private ClumppParamStruct clumppParamStruct;

        private bool isParamfileCreated = false;


        public ClumppParameterSet(ClumppParamStruct clumppParams, string path)
        {
            clumppParamStruct = clumppParams;
            directoryPath = path;

            CreateDirectory();
        }

        private void CreateDirectory()
        {
            try
            {
                directoryPath = Path.Combine(ProjectInfo.projectName, ProjectInfo.clumppFolder);

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
        /// Creates paramfile for CLUMPP program
        /// </summary>
        /// <param name="dataTypeClumpp">data type, based on loading individual or population data</param>
        public void CreateParamfile(DataTypeClumppEn dataTypeClumpp)
        {
            isParamfileCreated = false;
            string paramfileString = SetParamfileString(dataTypeClumpp);

            string paramfilePath;

            if (dataTypeClumpp == DataTypeClumppEn.ZERO) paramfilePath = Path.Combine(directoryPath, "paramfile0.");
            else paramfilePath = Path.Combine(directoryPath, "paramfile1.");

            try
            {
                using (FileStream fs = File.Create(paramfilePath))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(paramfileString);
                    fs.Write(info, 0, info.Length);
                }

                isParamfileCreated = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private string SetParamfileString(DataTypeClumppEn dataTypeClumpp)
        {
            string paramString;

            if (dataTypeClumpp == DataTypeClumppEn.ZERO) paramString = "DATATYPE 0\n";
            else paramString = "DATATYPE 1\n";

            paramString += "DATATYPE " + clumppParamStruct.dataType + "\n" +
                "INDFILE indiv.indfile" + "\n" +
                "POPFILE pop.popfile" + "\n" +
                "OUTFILE outf.indivq" + "\n" +
                "MISCFILE mis.miscfile" + "\n" +
                "K " + clumppParamStruct.k + "\n";

            if (dataTypeClumpp == DataTypeClumppEn.ZERO) paramString += "C " + clumppParamStruct.individuals + "\n";
            else paramString += "C " + clumppParamStruct.populations + "\n";

            paramString += "R " + clumppParamStruct.r + "\n" +
                "M " + clumppParamStruct.m + "\n" +
                "W 1" + "\n" +
                "S 2" + "\n" +

                "GREEDY_OPTION " + clumppParamStruct.greedyOption + "\n" +
                "REPEATS " + clumppParamStruct.repeats + "\n" +
                "PERMUTATIONFILE " + clumppParamStruct.permutationFile + "\n" +

                "PRINT_PERMUTED_DATA " + clumppParamStruct.printPermutedData + "\n" +
                "PERMUTED_DATAFILE " + directoryPath + "/perm.perm_datafile\n" +

                "PRINT_EVERY_PERM " + ReturnLogical(clumppParamStruct.printEveryPerm) + "\n" +
                "EVERY_PERMFILE " + directoryPath + "/everyperm.every_permfile" + "\n" +

                "PRINT_RANDOM_INPUTORDER " + ReturnLogical(clumppParamStruct.printRandomInputOrder) + "\n" +
                "RANDOM_INPUTORDERFILE " + directoryPath + "/randomorder.random_inputorderfile" + "\n" +

                "OVERRIDE_WARNINGS " + ReturnLogical(clumppParamStruct.overrideWarnings) + "\n" +
                "ORDER_BY_RUN " + ReturnLogical(clumppParamStruct.orderByRun);

            return paramString;
        }

        public bool IsParamfileCreated()
        {
            return isParamfileCreated;
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