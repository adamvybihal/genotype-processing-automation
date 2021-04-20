using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenotypeDataProcessing.distruct
{
    /// <summary>
    /// Class for managing distruct SW job
    /// </summary>
    public class DistructJob
    {
        private string drawparamsFilePath;
        private string indivqFilePath;
        private string popqFilePath;
        private string outuputFileName;
        private string outputDataPath;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="drawparamsPath">A string path to distruct's parameter file</param>
        /// <param name="indivqPath">A string path to input file of individual q's</param>
        /// <param name="popqPath">A string path to input file of population q's</param>
        /// <param name="outputName">A name of distruct's output file</param>
        /// <param name="dataPath">A path to a folder where output will be generated</param>
        public DistructJob(string drawparamsPath, string indivqPath, string popqPath, string outputName, string dataPath)
        {
            drawparamsFilePath = drawparamsPath;
            indivqFilePath = indivqPath;
            popqFilePath = popqPath;
            outuputFileName = outputName;
            outputDataPath = dataPath;
        }

        /// <summary>
        /// Method gets you the whole name of distruct's output file
        /// </summary>
        /// <returns>Returns string containing the whole name of distruct's output file</returns>
        public string GetOutputFile()
        {
            return outuputFileName + ".ps";
        }

        public void AsyncRun()
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (sender, args) =>
            {
                StartProcess();
            };
            backgroundWorker.RunWorkerCompleted += (sender, args) =>
            {
                MessageBox.Show(
                    "Completed",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            };
            backgroundWorker.RunWorkerAsync();
        }

        private void StartProcess()
        {
            Process distructRun = new Process();
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
                distructRun.StartInfo = startInfo;
                distructRun.Start();

                distructRun.StandardInput.WriteLine("distructWindows1.1 -d " + drawparamsFilePath + " -p " + popqFilePath + " -i " + indivqFilePath + " -o " + outputDataPath + outuputFileName + ".ps");

                var _ = ConsumeReader(distructRun.StandardOutput);
                _ = ConsumeReader(distructRun.StandardError);

                distructRun.StandardInput.Flush();
                distructRun.StandardInput.Close();

                distructRun.WaitForExit();
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
                distructRun.Close();
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

        //Command line options:
        //-d drawparams
        //-K K
        //-M NUMPOPS
        //-N NUMINDS
        //-p input file(population q's)
        //-i input file (individual q's)
        //-a input file (labels atop figure)
        //-b input file(labels below figure)
        //-c input file(cluster permutation)
        //-o output file
}
