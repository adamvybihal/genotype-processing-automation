using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenotypeDataProcessing.Structure
{
    /// <summary>
    /// Enum of two states for FormStructureParameterSet class
    /// </summary>
    public enum FormStructureParameterSetState
    {
        /// <summary>
        /// Form should load existing parameters, and update them
        /// </summary>
        UPDATE,
        /// <summary>
        /// Form should create completely new parameter set
        /// </summary>
        NEW
    }
}
