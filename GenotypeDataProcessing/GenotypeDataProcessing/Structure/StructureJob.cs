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

        public void BatchRunExecute()
        {
            for (int k = initK; k <= endingK; k++)
            {
                Parallel.For(1, iterations + 1, i =>
                {
                    AsyncRun(k, i);
                });
            }
        }

        private void AsyncRun(int currentK, int currentIteration)
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (sender, args) =>
            {
                StartProcess(currentK, currentIteration);
            };
            backgroundWorker.RunWorkerCompleted += (sender, args) =>
            {
                callerProjectScreen.ChangeStructureJobProgress((int)progressChangeRate);
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
