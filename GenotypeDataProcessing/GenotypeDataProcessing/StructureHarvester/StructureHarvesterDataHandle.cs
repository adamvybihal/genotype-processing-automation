using Aspose.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenotypeDataProcessing.StructureHarvester
{
    public class StructureHarvesterDataHandle
    {

        private bool succesfulJob = false;

        private string directoryPath;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="inputDataPath">Path of folder with structure resulsts</param>
        /// <param name="resultsPath">Path where Structure Harvester results are to be stored</param>
        public StructureHarvesterDataHandle(string inputDataPath, string resultsPath)
        {
            directoryPath = resultsPath;

            CreateDirectory();
            ZipStructureResults(inputDataPath);
        }

        private void CreateDirectory()
        {
            try
            {
                if (Directory.Exists(directoryPath))
                {
                    return;
                }

                Directory.CreateDirectory(directoryPath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ZipStructureResults(string folderToZip)
        {
            string path = Path.Combine(directoryPath, "archive.zip");

            using (FileStream zipFile = File.Open(path, FileMode.Create))
            {
                using (Archive archive = new Archive())
                {
                    DirectoryInfo dir = new DirectoryInfo(folderToZip);
                    archive.CreateEntries(dir);
                    archive.Save(zipFile);
                }
            }
        }

        public void StartJob()
        {

        }

        /// <summary>
        /// Checks if run was succesful
        /// </summary>
        /// <returns>bool</returns>
        public bool IsStructureHarvesterJobDone()
        {
            return succesfulJob;
        }
    }
}
