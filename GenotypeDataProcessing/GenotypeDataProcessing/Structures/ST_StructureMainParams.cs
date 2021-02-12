using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenotypeDataProcessing.Structures
{
    struct ST_StructureMainParams
    {
        public int burin;
        public int numReps;

        public int numInds;
        public int numLoci;
        public int ploidy;
        public int missing;
        public bool oneRowPerInd;

        public bool label;
        public bool popData;
        public bool popFlag;
        public bool locData;
        public bool phenotype;
        public int extraCols;
        public bool markerNames;
        public bool recessiveAlleles;
        public bool mapDistances;

        public bool phased;
        public bool phaseInfo;
        public bool markovPhase;
        public int notAmbiguous;
    }
}
