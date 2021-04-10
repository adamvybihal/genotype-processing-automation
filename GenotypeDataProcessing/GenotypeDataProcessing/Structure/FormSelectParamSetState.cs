using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenotypeDataProcessing.Structure
{
    /// <summary>
    /// Form SelectParamSet state
    /// </summary>
    public enum FormSelectParamSetState
    {
        /// <summary>
        /// select set to update
        /// </summary>
        UPDATE_SET,
        /// <summary>
        /// select set, with completed job, for structure harvester process
        /// </summary>
        SELECT_COMPLETED_SET_FOR_HARVESTER
    }
}
