using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenotypeDataProcessing.Structure
{
    /// <summary>
    /// Class for managing Structure SW job
    /// </summary>
    public class StructureJob
    {

        private int initK;
        private int endingK;
        private int iterations;
        private string mainparamsPath;
        private string extraparamsPath;
        private string outfilePath;

        private ProjectScreen callerProjectScreen;

        private double progressChangeRate;

        /// <summary>
        /// StructureJob constructor
        /// </summary>
        /// <param name="projectScreen">ProjectScreen form which is calling this class</param>
        /// <param name="paramSetName">Selected parameter set for Structure job</param>
        /// <param name="structureFolderPath">Path to projects' Structure folder</param>
        /// <param name="kFrom">Starting K</param>
        /// <param name="kTo">Ending K</param>
        /// <param name="reps">Iterations over each K</param>
        public StructureJob(ProjectScreen projectScreen, string paramSetName, string structureFolderPath, int kFrom, int kTo, int reps)
        {
            initK = kFrom;
            endingK = kTo;
            iterations = reps;

            CreateResultsDirectory(structureFolderPath, paramSetName);

            mainparamsPath = Path.Combine(structureFolderPath, paramSetName, "mainparams");
            extraparamsPath = Path.Combine(structureFolderPath, paramSetName, "extraparams");
            outfilePath = Path.Combine(structureFolderPath, paramSetName, "results", "outfile");

            callerProjectScreen = projectScreen;

            double filesToBeGenerated = (endingK - initK + 1) * iterations;
            progressChangeRate = Math.Ceiling(100 / filesToBeGenerated);
        }

        private void CreateResultsDirectory(string structureFolderPath, string paramSetName)
        {
            try
            {
                string directoryPath = Path.Combine(structureFolderPath, paramSetName, "results");

                if (Directory.Exists(directoryPath))
                {
                    return;
                }

                Directory.CreateDirectory(directoryPath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Execution of Structure runs
        /// </summary>
        public void BatchRunExecute()
        {
            AsyncRun(initK, 1);
        }

        private void AsyncRun(int currentK, int currentIteration)
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (sender, args) =>
            {
                callerProjectScreen.ShowCurrentKAndIteration(currentK, currentIteration, endingK, iterations);
                StartProcess(currentK, currentIteration);
            };
            backgroundWorker.RunWorkerCompleted += (sender, args) =>
            {
                callerProjectScreen.ChangeStructureJobProgress(Convert.ToInt32(progressChangeRate));

                if (currentIteration < iterations)
                {
                    AsyncRun(currentK, currentIteration + 1);
                }
                else if (currentK < endingK)
                {
                    AsyncRun(currentK + 1, 1);
                }
                else
                {
                    callerProjectScreen.WhenStructureIsJobDone();

                    MessageBox.Show(
                        "Structure job is done!",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
            };
            backgroundWorker.RunWorkerAsync();
        }

        private void StartProcess(int currentK, int currentIteration)
        {
            Process structureRun = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                WindowStyle = ProcessWindowStyle.Normal,
                CreateNoWindow = true,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };

            try
            {
                structureRun.StartInfo = startInfo;
                structureRun.Start();

                structureRun.StandardInput.WriteLine(
                    "structure -m " + mainparamsPath +
                    " -e " + extraparamsPath +
                    " -K " + currentK +
                    " -o " + outfilePath + currentK + "-" + currentIteration
                    );

                var _ = ConsumeReader(structureRun.StandardOutput);
                _ = ConsumeReader(structureRun.StandardError);

                structureRun.StandardInput.Flush();
                structureRun.StandardInput.Close();

                structureRun.WaitForExit();
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
                structureRun.Close();
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
    }
}
