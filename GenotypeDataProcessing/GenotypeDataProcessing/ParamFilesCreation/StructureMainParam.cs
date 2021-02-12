using System;
using System.Collections.Generic;
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
            return "#define MAXPOPS   1" +
                "#define BURNIN    10000" +
                "#define NUMREPS   10000" +

                "#define INFILE   structure-testData\\testdata1" +
                "#define OUTFILE  structure-results\\outfile" +

                "#define NUMINDS    	200" +
                "#define NUMLOCI    	5" +
                "#define PLOIDY       	2" +
                "#define MISSING     	-999" +
                "#define ONEROWPERIND 	0" +

                "#define LABEL     1" +
                "#define POPDATA   1" +
                "#define POPFLAG   1" +
                "#define LOCDATA   0" +
                "#define PHENOTYPE 0" +
                "#define EXTRACOLS 0" +
                "#define MARKERNAMES      0" +
                "#define RECESSIVEALLELES 0" +
                "#define MAPDISTANCES     0" +

                "#define PHASED           0" +
                "#define PHASEINFO        0" +
                "#define MARKOVPHASE      0" +
                "#define NOTAMBIGUOUS  -999";
        }

        public void createParamFile()
        {

        }
    }
}
