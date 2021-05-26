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
                CopyInputFiles(currK);
                StartProcess(currK);
            };
            backgroundWorker.RunWorkerCompleted += (sender, args) =>
            {
                DeleteFromBaseDirectory(currK);

                string fileName = "K" + currK + ".ps";
                string movedFilePath = Path.Combine(distructOutputPath, paramsetName, fileName);

                try
                {
                    if (File.Exists(movedFilePath))
                        File.Delete(movedFilePath);

                    File.Move(
                        Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, fileName),
                        movedFilePath
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

        private void CopyInputFiles(int currK)
        {
            string drawparamsFilePath = distructOutputPath + "\\" + paramsetName + "\\" + "drawparams" + currK;
            CopyToBaseDir(drawparamsFilePath, "drawparams" + currK);

            string clumppPopqPath = clumppInputPath + "K" + currK + ".popq";
            CopyToBaseDir(clumppPopqPath, "K" + currK + ".popq");

            string clumppIndivqPath = clumppInputPath + "K" + currK + ".indivq";
            CopyToBaseDir(clumppIndivqPath, "K" + currK + ".indivq");

            string labelsAtopPath = ProjectInfo.distructParamSets[paramsetName].infileLabelAtopCopy;
            CopyToBaseDir(labelsAtopPath, ProjectInfo.distructParamSets[paramsetName].infileLabelAtop);

            string labelsBelowPath = ProjectInfo.distructParamSets[paramsetName].infileLabelBelowCopy;
            CopyToBaseDir(labelsBelowPath, ProjectInfo.distructParamSets[paramsetName].infileLabelBelow);

            string clustPermPath = ProjectInfo.distructParamSets[paramsetName].infileClustPermCopy;
            CopyToBaseDir(clustPermPath, ProjectInfo.distructParamSets[paramsetName].infileClustPerm);
        }

        private void CopyToBaseDir(string filePath, string copiedFileName)
        {
            try
            {
                File.Copy(
                   filePath,
                   Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, copiedFileName),
                   true
                   );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }    
        }

        private void DeleteFromBaseDirectory(int currK)
        {
            try
            {
                File.Delete(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "drawparams" + currK));
                File.Delete(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "K" + currK + ".popq"));
                File.Delete(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "K" + currK + ".indivq"));
                File.Delete(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, ProjectInfo.distructParamSets[paramsetName].infileLabelAtop));
                File.Delete(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, ProjectInfo.distructParamSets[paramsetName].infileLabelBelow));
                File.Delete(Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, ProjectInfo.distructParamSets[paramsetName].infileClustPerm));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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

                //distructRun.StandardInput.WriteLine(
                //    "distructWindows1.1.exe -d " + distructOutputPath + "\\" + paramsetName + "\\" + "drawparams" + currK +
                //    " -p " + clumppInputPath + "K" + currK + ".popq" +
                //    " -i " + clumppInputPath + "K" + currK + ".indivq" +
                //    " -o " + Path.Combine(distructOutputPath, "K" + currK + ".ps")
                //    );

                distructRun.StandardInput.WriteLine(
                    "distructWindows1.1.exe -d " + "drawparams" + currK + " -o K" + currK + ".ps"
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
