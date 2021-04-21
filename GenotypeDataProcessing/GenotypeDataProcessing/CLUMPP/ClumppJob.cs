using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenotypeDataProcessing.CLUMPP
{
    /// <summary>
    /// Class for managing CLUMPP sw job
    /// </summary>
    public class ClumppJob
    {
        private ProjectScreen callerProjectScreen;
        private string harvesterInputPath;
        private string outputDataPath;
        private int initK;
        private int endK;

        private bool individualsDone = false;
        private bool populationsDone = false;

        /// <summary>
        /// ClumppJob constructor
        /// </summary>
        /// <param name="projectScreen">ProjectScreen calling this class</param>
        /// <param name="folderWithInputsPath">A string path to Structure Harvester's results (CLUMPP's inputs)</param>
        /// <param name="outputPath">A path to a folder where output will be generated</param>
        /// <param name="fromK">starting K</param>
        /// <param name="toK">ending K</param>
        public ClumppJob(ProjectScreen projectScreen, string folderWithInputsPath, string outputPath, int fromK, int toK)
        {
            callerProjectScreen = projectScreen;
            harvesterInputPath = folderWithInputsPath;
            outputDataPath = outputPath;
            initK = fromK;
            endK = toK;
        }

        /// <summary>
        /// Execute batch run of CLUMPP
        /// </summary>
        public void BatchRun()
        {
            AsyncRun(DataTypeClumppEn.ZERO, initK);
            AsyncRun(DataTypeClumppEn.ONE, initK);
        }

        private void AsyncRun(DataTypeClumppEn dataType, int currK)
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (sender, args) =>
            {
                StartProcess(dataType, currK);
            };
            backgroundWorker.RunWorkerCompleted += (sender, args) =>
            {
                if (currK < endK)
                {
                    AsyncRun(dataType, currK + 1);
                }
                else
                {
                    switch (dataType)
                    {
                        case DataTypeClumppEn.ZERO:
                            individualsDone = true;
                            break;
                        case DataTypeClumppEn.ONE:
                            populationsDone = true;
                            break;
                    }

                    if (individualsDone && populationsDone)
                    {
                        callerProjectScreen.UpdateClumppTreeView();

                        MessageBox.Show(
                                    "CLUMPP job is done!",
                                    "Information",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information
                                    );
                    }
                }
            };
            backgroundWorker.RunWorkerAsync();
        }

        private void StartProcess(DataTypeClumppEn dataType, int currK)
        {
            ClumppRunInfoStruct runInfo = GetCurrentRunInfo(dataType, currK);

            Process clumppRun = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "CLUMPP.exe",
                Arguments = string.Format("{0} {1} {2} {3} {4}",
                                          Path.Combine(outputDataPath, runInfo.paramfile),
                                          runInfo.inputArgument + Path.Combine(harvesterInputPath, runInfo.inputFile),
                                          "-o " + Path.Combine(outputDataPath, runInfo.outputFile),
                                          "-j " + Path.Combine(outputDataPath, runInfo.miscFile),
                                          "-k " + currK),
                WindowStyle = ProcessWindowStyle.Normal,
                CreateNoWindow = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };

            try
            {
                clumppRun.StartInfo = startInfo;
                clumppRun.Start();

                var _ = ConsumeReader(clumppRun.StandardOutput);
                _ = ConsumeReader(clumppRun.StandardError);

                clumppRun.StandardInput.Flush();
                clumppRun.StandardInput.Close();

                clumppRun.WaitForExit();
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
                clumppRun.Close();
            }
        }

        private ClumppRunInfoStruct GetCurrentRunInfo(DataTypeClumppEn dataType, int currK)
        {
            ClumppRunInfoStruct infoToReturn = default;
            const string paramfile0 = "paramfile0";
            const string paramfile1 = "paramfile1";

            switch (dataType)
            {
                case DataTypeClumppEn.ZERO:
                    infoToReturn.paramfile = paramfile0;
                    infoToReturn.inputArgument = "-i ";
                    infoToReturn.inputFile = "K" + currK + ".indfile";
                    infoToReturn.outputFile = "K" + currK + ".indivq";
                    infoToReturn.miscFile = "K" + currK + "indiv.miscfile";
                    break;
                case DataTypeClumppEn.ONE:
                    infoToReturn.paramfile = paramfile1;
                    infoToReturn.inputArgument = "-p ";
                    infoToReturn.inputFile = "K" + currK + ".popfile";
                    infoToReturn.outputFile = "K" + currK + ".popq";
                    infoToReturn.miscFile = "K" + currK + "indiv.miscfile";
                    break;
                default:
                    break;
            }

            return infoToReturn;
        }

        async static Task ConsumeReader(TextReader reader)
        {
            string text;

            while ((text = await reader.ReadLineAsync()) != null)
            {
                Console.WriteLine(text);
            }
        }
    }
}
