using Aspose.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenotypeDataProcessing.StructureHarvester
{
    /// <summary>
    /// Class managing Structure Harvester's data
    /// </summary>
    public class StructureHarvesterDataHandle
    {

        private ProjectScreen callerProjectScreen;
        private string inputPath;
        private string harvesteResultsDirectoryPath;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="projectScreen">ProjectScreen form, calling this class</param>
        /// <param name="inputDataPath">Path of folder with structure resulsts</param>
        /// <param name="resultsPath">Path where Structure Harvester results are to be stored</param>
        public StructureHarvesterDataHandle(ProjectScreen projectScreen, string inputDataPath, string resultsPath)
        {
            callerProjectScreen = projectScreen;
            inputPath = inputDataPath;
            harvesteResultsDirectoryPath = resultsPath;

            CreateDirectory();
        }

        private void CreateDirectory()
        {
            try
            {
                if (Directory.Exists(harvesteResultsDirectoryPath))
                {
                    return;
                }

                Directory.CreateDirectory(harvesteResultsDirectoryPath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Async run of Structure Harvester via Python
        /// </summary>
        public void AsyncRun()
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (sender, args) =>
            {
                StartJob();
            };
            backgroundWorker.RunWorkerCompleted += (sender, args) =>
            {
                bool isDirEmpty = IsDirectoryEmpty();

                callerProjectScreen.ExecuteAfterStructureHarvesterJobDone(isDirEmpty);
                if (isDirEmpty)
                {
                    MessageBox.Show("Structure Harvester could not be executed!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                }
                else
                {
                    MessageBox.Show("Structure Harvester job done!",
                    "Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                }
            };
            backgroundWorker.RunWorkerAsync();
        }

        /// <summary>
        /// Structure Harvester's job execution
        /// </summary>
        private void StartJob()
        {
            Process structureHarvesterRun = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "python27/python.exe",
                Arguments = string.Format("{0} {1} {2} {3} {4}", 
                                          "structureHarvester.py", 
                                          "--dir=" + inputPath + "\\", 
                                          "--out=" + harvesteResultsDirectoryPath + "\\", 
                                          "--evanno", 
                                          "--clumpp"),
                WindowStyle = ProcessWindowStyle.Normal,
                CreateNoWindow = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };

            try
            {
                structureHarvesterRun.StartInfo = startInfo;
                structureHarvesterRun.Start();

                var _ = ConsumeReader(structureHarvesterRun.StandardOutput);
                _ = ConsumeReader(structureHarvesterRun.StandardError);

                structureHarvesterRun.StandardInput.Flush();
                structureHarvesterRun.StandardInput.Close();

                structureHarvesterRun.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            finally
            {
                structureHarvesterRun.Close();
            }
        }

        async static Task ConsumeReader(TextReader reader)
        {
            string text;

            while ((text = await reader.ReadLineAsync()) != null)
            {
                Console.WriteLine(text);
            }
        }

        /// <summary>
        /// Checks if result directory is empty after current run
        /// </summary>
        /// <returns>bool value</returns>
        public bool IsDirectoryEmpty()
        {
            return !Directory.EnumerateFileSystemEntries(harvesteResultsDirectoryPath).Any();
        }
    }
}
