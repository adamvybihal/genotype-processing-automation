using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenotypeDataProcessing.Structure;

namespace GenotypeDataProcessing
{
    /// <summary>
    /// Static class containing information about current project
    /// </summary>
    public static class ProjectInfo
    {
        /// <summary>
        /// Name of current project
        /// </summary>
        public static string projectName;
        /// <summary>
        /// Path to current project
        /// </summary>
        public static string projectNamePath;

        /// <summary>
        /// Name of folder, containing Structure data for current project
        /// </summary>
        public const string structureFolder = "structure";
        /// <summary>
        /// Name of copied input data file for Structure
        /// </summary>
        public const string structureDataCopyName = "structureData.";
        /// <summary>
        /// Name of folder, containing Structure Harvester data for current project
        /// </summary>
        public const string structureHarvesterFolder = "structureHarvester";
        /// <summary>
        /// Name of folder, containing CLUMPP data for current project
        /// </summary>
        public const string clumppFolder = "clumpp";
        /// <summary>
        /// Name of folder, containing distruct data for current project
        /// </summary>
        public const string distructFolder = "distruct";

        /// <summary>
        /// Name of file, where to save input info of Structure
        /// </summary>
        public const string structureInputInfoFile = "structureinputdata.bin";
        /// <summary>
        /// Name of file, where to save parameter sets for Structure
        /// </summary>
        public const string structureParamSetsFile = "structureparamsets.bin";
        /// <summary>
        /// Name of file, where to save info about jobs of Structure
        /// </summary>
        public const string structureJobInfoFile = "structurejobinfo.bin";
        /// <summary>
        /// Name of file, where to save info about jobs of Structure Harvester
        /// </summary>
        public const string harvesterJobDoneFile = "harvesterjobdone.bin";

        /// <summary>
        /// Class holding Structure's input data
        /// </summary>
        public static StructureInputData structureInputData = new StructureInputData();
        /// <summary>
        /// Structure holding info about Structure's input data
        /// </summary>
        public static StructureInputInfoStruct structureInputInfo;
        /// <summary>
        /// Dicitionary containing KeyValuePairs of name of Structure's parameter set, and structure which holds Structure's parameters
        /// </summary>
        public static Dictionary<string, StructureParamSetStruct> structureParamSets = new Dictionary<string, StructureParamSetStruct>();
        /// <summary>
        /// Dicitionary containing KeyValuePairs of name of Structure's parameter set, and info about job with that parameter set
        /// </summary>
        public static Dictionary<string, StructureJobInfoStruct> structureJobInfo = new Dictionary<string, StructureJobInfoStruct>();
        /// <summary>
        /// Dicitionary containing key of initial Structure' parameter set, and bool value.
        /// Bool value is true, if Structure Harvester job is done for key parameter set.
        /// </summary>
        public static Dictionary<string, bool> harvesterJobDone = new Dictionary<string, bool>();
    }
}
