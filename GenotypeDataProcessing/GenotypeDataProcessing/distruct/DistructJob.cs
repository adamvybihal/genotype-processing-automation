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
        private ProjectScreen callerProjectScreen;

        private string paramsetName;
        private string clumppInputPath;
        private string distructOutputPath;

        private int initK;
        private int endK;

        /// <summary>
        /// DistructJob Constructor
        /// </summary>
        /// <param name="projectScreen">Instance of ProjectScreen calling this class</param>
        /// <param name="paramset">Name of parameter set</param>
        /// <param name="inputPath">Path where inputs from CLUMPP are</param>
        /// <param name="outputPath">Path where to save distruct outputs</param>
        /// <param name="kStart">starting K</param>
        /// <param name="kEnd">ending K</param>
        public DistructJob(ProjectScreen projectScreen, string paramset, string inputPath, string outputPath, int kStart, int kEnd)
        {
            callerProjectScreen = projectScreen;
            paramsetName = paramset;
            clumppInputPath = inputPath;
            distructOutputPath = outputPath;
            initK = kStart;
            endK = kEnd;
        }

        /// <summary>
        /// Execute batch run of distruct
        /// </summary>
        public void BatchRun()
        {
            AsyncRun(initK);
        }

        private void AsyncRun(int currK)
        {
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += (sender, args) =>
            {
                StartProcess(currK);
            };
            backgroundWorker.RunWorkerCompleted += (sender, args) =>
            {
                string fileName = "K" + currK + ".ps";

                try
                {
                    File.Move(
                        Path.Combine(distructOutputPath, fileName),
                        Path.Combine(distructOutputPath, paramsetName, fileName)
                        );
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
                

                if (currK < endK)
                {
                    AsyncRun(currK + 1);
                }
                else
                {
                    callerProjectScreen.ExecuteWhenDistructDone();

                    MessageBox.Show(
                                "distruct job completed!",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                                );
                }           
            };
            backgroundWorker.RunWorkerAsync();
        }

        private void StartProcess(int currK)
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

                distructRun.StandardInput.WriteLine(
                    "distructWindows1.1.exe -d " + distructOutputPath + "\\" + paramsetName + "\\" + "drawparams" + currK +
                    " -p " + clumppInputPath + "K" + currK + ".popq" +
                    " -i " + clumppInputPath + "K" + currK + ".indivq" +
                    " -o " + Path.Combine(distructOutputPath, "K" + currK + ".ps")
                    );

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
}
