using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenotypeDataProcessing.StructureHarvester
{
    /// <summary>
    /// Type of Structure Harvester Chart
    /// </summary>
    public enum HarvesterChartType
    {
        /// <summary>
        /// Chart will contain est. Ln prob. of data
        /// </summary>
        MEAN_LnP,
        /// <summary>
        /// Chart will contain Ln'(K) data
        /// </summary>
        FIRST_DERIVATIVE_Ln,
        /// <summary>
        /// Chart will contain |Ln''(K)|
        /// </summary>
        SECOND_DERIVATIVE_Ln,
        /// <summary>
        /// Chart will contain Delta K
        /// </summary>
        DELTA_K
    }
}
