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
        private string harvesterInputPath;
        private string outputDataPath;
        private int initK;
        private int endK;

        /// <summary>
        /// ClumppJob constructor
        /// </summary>
        /// <param name="folderWithInputsPath">A string path to Structure Harvester's results (CLUMPP's inputs)</param>
        /// <param name="outputPath">A path to a folder where output will be generated</param>
        /// <param name="fromK">starting K</param>
        /// <param name="toK">ending K</param>
        public ClumppJob(string folderWithInputsPath, string outputPath, int fromK, int toK)
        {
            harvesterInputPath = folderWithInputsPath;
            outputDataPath = outputPath;
            initK = fromK;
            endK = toK;
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
                MessageBox.Show(
                    "Completed",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            };
            backgroundWorker.RunWorkerAsync();
        }

        /// <summary>
        /// Run CLUMPP software.
        /// </summary>
        private void StartProcess(DataTypeClumppEn dataType, int currK)
        {
            ClumppRunInfoStruct runInfo = GetCurrentRunInfo(dataType, currK);

            Process clumppRun = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "CLUMPP.exe",
                Arguments = string.Format("{0} {1} {2} {3}",
                                          "projects/testProject/clumpp/paramfile0",
                                          "-i projects/K3.indfile",
                                          "-o projects/K3",
                                          "-j projects/K33"),
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
                    infoToReturn.inputFile = "K" + currK + ".indfile";
                    infoToReturn.outputFile = "K" + currK + ".indivq";
                    infoToReturn.miscFile = "K" + currK + "indiv.miscfile";
                    break;
                case DataTypeClumppEn.ONE:
                    infoToReturn.paramfile = paramfile1;
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
    //Command line options:
    //# -i INDFILE
    //# -p POPFILE
    //# -o OUTFILE
    //# -j MISCFILE
    //# -k K
    //# -c C
    //# -r R
    //# -m M
    //# -w W
    //# -s S
}
