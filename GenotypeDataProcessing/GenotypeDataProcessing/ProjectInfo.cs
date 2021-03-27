using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenotypeDataProcessing.DUTs;
using GenotypeDataProcessing.Structure;

namespace GenotypeDataProcessing
{
    /// <summary>
    /// Static class containing information about current project
    /// </summary>
    public static class ProjectInfo
    {
        public const string projectName = "testProject";

        public const string structureFolder = "structure";
        public const string structureDataCopyName = "structureData.";

        public const string structureHarvesterFolder = "structureHarvester";
        public const string clumppFolder = "clumpp";
        public const string distructFolder = "distruct";

        public static StructureInputData structureInputData;
        public static StructureInputInfoStruct structureInputInfo;
    }
}
