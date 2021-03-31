using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenotypeDataProcessing.Structure
{
    public class StructureParamSet
    {

        private string parameterSetName;
        private StructureParamSetStruct stStructureParamSet;
        private StructureInputInfoStruct stStructureInputInfo;
        private string directoryPath;

        public StructureParamSet(string nameOfSet, StructureParamSetStruct structureParamSetStruct, StructureInputInfoStruct structureInputInfoStruct)
        {
            parameterSetName = nameOfSet;
            stStructureParamSet = structureParamSetStruct;
            stStructureInputInfo = structureInputInfoStruct;

            CreateDirectory();
        }

        private void CreateDirectory()
        {
            try
            {
                directoryPath = Path.Combine(ProjectInfo.projectName, ProjectInfo.structureFolder, parameterSetName);

                if (Directory.Exists(directoryPath))
                {
                    return;
                }

                Directory.CreateDirectory(directoryPath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Creates mainparams file for current parameter set
        /// </summary>
        public void CreateMainparamsFile()
        {
            string mainparamsString = MainparamsString();

            string mainparamsPath = Path.Combine(directoryPath, "mainparams.");

            try
            {
                using (FileStream fs = File.Create(mainparamsPath))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(mainparamsString);
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private string MainparamsString()
        {
            string inputDataFilePath = Path.Combine(ProjectInfo.projectName, ProjectInfo.structureFolder, ProjectInfo.structureDataCopyName);
            const string outFile = "outfile";

            return "#define MAXPOPS   1" + "\n" +                               // value will change via command line
                "#define BURNIN    " + stStructureParamSet.burnin + "\n" +
                "#define NUMREPS   " + stStructureParamSet.numReps + "\n" +

                "#define INFILE   " + inputDataFilePath + "\n" +
                "#define OUTFILE  " + outFile + "\n" +                          // value will change via command line

                "#define NUMINDS    	" + stStructureInputInfo.numInds + "\n" +
                "#define NUMLOCI    	" + stStructureInputInfo.numLoci + "\n" +
                "#define PLOIDY       	" + stStructureInputInfo.ploidy + "\n" +
                "#define MISSING     	" + stStructureInputInfo.missingDataValue + "\n" +
                "#define ONEROWPERIND 	" + ReturnLogical(stStructureInputInfo.oneRowPerInd) + "\n" +

                "#define LABEL     " + ReturnLogical(stStructureInputInfo.label) + "\n" +
                "#define POPDATA   " + ReturnLogical(stStructureInputInfo.popData) + "\n" +
                "#define POPFLAG   " + ReturnLogical(stStructureInputInfo.popFlag) + "\n" +
                "#define LOCDATA   " + ReturnLogical(stStructureInputInfo.locData) + "\n" +
                "#define PHENOTYPE " + ReturnLogical(stStructureInputInfo.phenotype) + "\n" +
                "#define EXTRACOLS " + stStructureInputInfo.extraCols + "\n" +
                "#define MARKERNAMES      " + ReturnLogical(stStructureInputInfo.markerNames) + "\n" +
                "#define RECESSIVEALLELES " + ReturnLogical(stStructureInputInfo.recessiveAlleles) + "\n" +
                "#define MAPDISTANCES     " + ReturnLogical(stStructureInputInfo.mapDistances) + "\n" +

                "#define PHASED           " + ReturnLogical(stStructureParamSet.phased) + "\n" +
                "#define PHASEINFO        " + ReturnLogical(stStructureInputInfo.phaseInfo) + "\n" +
                "#define MARKOVPHASE      " + ReturnLogical(stStructureParamSet.markovPhase) + "\n" +
                "#define NOTAMBIGUOUS   -999";
        }

        /// <summary>
        /// Creates extraparams file for current parameter set
        /// </summary>
        public void CreateExtraparamsFile()
        {
            string extraparamsString = ExtraparamsString();

            string extraparamsPath = Path.Combine(directoryPath, "extraparams.");

            try
            {
                using (FileStream fs = File.Create(extraparamsPath))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(extraparamsString);
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private string ExtraparamsString()
        {
            return "#define NOADMIX     " + ReturnLogical(stStructureParamSet.noAdmix) + "\n" +
                "#define LINKAGE     " + ReturnLogical(stStructureParamSet.linkage) + "\n" +
                "#define USEPOPINFO  " + ReturnLogical(stStructureParamSet.usePopInfo) + "\n" +
                "#define LOCPRIOR    " + ReturnLogical(stStructureParamSet.locPrior) + "\n" +

                "#define FREQSCORR   " + ReturnLogical(stStructureParamSet.freqsCorr) + "\n" +
                "#define ONEFST      " + ReturnLogical(stStructureParamSet.oneFst) + "\n" +

                "#define INFERALPHA  " + ReturnLogical(stStructureParamSet.inferAlpha) + "\n" +
                "#define POPALPHAS   " + ReturnLogical(stStructureParamSet.popAlphas) + "\n" +
                "#define ALPHA     " + stStructureParamSet.alpha.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +

                "#define INFERLAMBDA " + ReturnLogical(stStructureParamSet.inferLambda) + "\n" +
                "#define POPSPECIFICLAMBDA " + ReturnLogical(stStructureParamSet.popSpecifiLambda) + "\n" +
                "#define LAMBDA    " + stStructureParamSet.lambda.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +

                "#define FPRIORMEAN 0.01 // (d) Prior mean and SD of Fst for pops." + "\n" +
                "#define FPRIORSD   0.05" + "\n" +

                "#define UNIFPRIORALPHA " + ReturnLogical(stStructureParamSet.unifPriorAlphas) + "\n" +
                "#define ALPHAMAX     " + stStructureParamSet.alphaMax.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define ALPHAPRIORA   " + stStructureParamSet.alphaPriorA.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define ALPHAPRIORB   " + stStructureParamSet.alphaPriorB.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +

                "#define LOG10RMIN     " + stStructureParamSet.logRMin.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define LOG10RMAX      " + stStructureParamSet.logRMax.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define LOG10RPROPSD   " + stStructureParamSet.logRPropSD.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define LOG10RSTART   " + stStructureParamSet.logRStart.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +

                "#define GENSBACK    " + stStructureParamSet.gensBack + "\n" +
                "#define MIGRPRIOR " + stStructureParamSet.migPrior.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +
                "#define PFROMPOPFLAGONLY 0" + "\n" +

                "#define LOCISPOP      1" + "\n" +
                "#define LOCPRIORINIT  1.0" + "\n" +
                "#define MAXLOCPRIOR  20.0" + "\n" +

                "#define PRINTNET     1" + "\n" +
                "#define PRINTLAMBDA  1" + "\n" +
                "#define PRINTQSUM    1" + "\n" +

                "#define SITEBYSITE   0" + "\n" +
                "#define PRINTQHAT    " + ReturnLogical(stStructureParamSet.printQHat) + "\n" +
                "#define UPDATEFREQ   100" + "\n" +
                "#define PRINTLIKES   0" + "\n" +
                "#define INTERMEDSAVE 0" + "\n" +

                "#define ECHODATA     1" + "\n" +
                "#define ANCESTDIST   " + ReturnLogical(stStructureParamSet.ancestDist) + "\n" +
                "#define NUMBOXES   " + stStructureParamSet.numboxes + "\n" +
                "#define ANCESTPINT " + stStructureParamSet.ancestPint.ToString(CultureInfo.InvariantCulture.NumberFormat) + "\n" +


                "#define COMPUTEPROB " + ReturnLogical(stStructureParamSet.computePorb) + "\n" +
                "#define ADMBURNIN  500    // (int) [only relevant for linkage model]" + "\n" +
                "#define ALPHAPROPSD 0.025" + "\n" +
                "#define STARTATPOPINFO " + ReturnLogical(stStructureParamSet.startPopInfo) + "\n" +
                "#define RANDOMIZE      1" + "\n" +
                "#define SEED        2245" + "\n" +
                "#define METROFREQ    " + stStructureParamSet.metroFreq + "\n" +
                "#define REPORTHITRATE 0";
        }

        /// <summary>
        /// Return 0 or 1, based on param boolValue
        /// </summary>
        /// <param name="boolValue">boolean value</param>
        /// <returns>1 if boolValue == true, else 0</returns>
        public static int ReturnLogical(bool boolValue)
        {
            if (boolValue) return 1;
            else return 0;
        }
    }
}
