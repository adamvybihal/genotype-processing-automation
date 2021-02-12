using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenotypeDataProcessing.Structures;

namespace GenotypeDataProcessing.ParamFilesCreation
{
    class StructureMainParam
    {
        ST_StructureMainParams cParams;
        string strParamString;

        public StructureMainParam(ST_StructureMainParams iMainParams)
        {
            cParams = iMainParams;
            strParamString = setString(iMainParams);
        }

        private string setString(ST_StructureMainParams iParams)
        {
            return "#define MAXPOPS   1" + "\n" +
                "#define BURNIN    10000" + "\n" +
                "#define NUMREPS   10000" + "\n" +

                "#define INFILE   structure-testData\\testdata1" + "\n" +
                "#define OUTFILE  structure-results\\outfile" + "\n" +

                "#define NUMINDS    	200" + "\n" +
                "#define NUMLOCI    	5" + "\n" +
                "#define PLOIDY       	2" + "\n" +
                "#define MISSING     	-999" + "\n" +
                "#define ONEROWPERIND 	0" + "\n" +

                "#define LABEL     1" + "\n" +
                "#define POPDATA   1" + "\n" +
                "#define POPFLAG   1" + "\n" +
                "#define LOCDATA   0" + "\n" +
                "#define PHENOTYPE 0" + "\n" +
                "#define EXTRACOLS 0" + "\n" +
                "#define MARKERNAMES      0" + "\n" +
                "#define RECESSIVEALLELES 0" + "\n" +
                "#define MAPDISTANCES     0" + "\n" +

                "#define PHASED           0" + "\n" +
                "#define PHASEINFO        0" + "\n" +
                "#define MARKOVPHASE      0" + "\n" +
                "#define NOTAMBIGUOUS  -999";
        }

        public void createParamFile()
        {
            string path = "paramfile-test/MyParamFile.";

            try
            {
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(strParamString);
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
