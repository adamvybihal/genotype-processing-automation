using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenotypeDataProcessing.Structure
{
    /// <summary>
    /// Structure for holding info about Structure's job of certain parameter set
    /// </summary>
    [Serializable]
    public struct StructureJobInfoStruct
    {
        /// <summary>
        /// starting K
        /// </summary>
        public int startingK;
        /// <summary>
        /// ending K
        /// </summary>
        public int endingK;
        /// <summary>
        /// number of iterations over each K
        /// </summary>
        public int iterations;
    }
}
