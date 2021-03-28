using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenotypeDataProcessing.CLUMPP
{
    /// <summary>
    /// DataType defines the type of data to be read in to CLUMPP
    /// </summary>
    public enum DataTypeClumppEn
    {
        /// <summary>
        /// 0 = individual data in the file specified by INDFILE
        /// </summary>
        ZERO,

        /// <summary>
        /// 1 = population data in the file specified by POPFILE
        /// </summary>
        ONE
    }
}
