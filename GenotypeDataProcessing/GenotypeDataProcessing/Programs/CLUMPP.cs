using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenotypeDataProcessing.DUTs;

namespace GenotypeDataProcessing.Programs
{
    /// <summary>
    /// Class for running CLUMPP
    /// </summary>
    public class CLUMPP
    {
        private string paramFilePath;
        private string outuputFileName;
        private E_DataTypeCLUMPP inputDataType;
        private string outputFileType;
        private string outputDataPath;

        /// <summary>
        /// Constructor with three parameters
        /// </summary>
        /// <param name="paramfilePath">A string path to CLUMPP's parameter file</param>
        /// <param name="outputName">A name of CLUMPP's output file</param>
        /// <param name="dataType">dataType defines the type of data to be read in to CLUMPP</param>
        /// <param name="outputPath">A path to a folder where output will be generated</param>
        public CLUMPP(string paramfilePath, E_DataTypeCLUMPP dataType, string outputName, string outputPath)
        {
            paramFilePath = paramfilePath;
            outuputFileName = outputName;
            inputDataType = dataType;
            SetOutputType();
            outputDataPath = outputPath;
        }

        /// <summary>
        /// Method sets the type of CLUMPP's output file deppending on type of data being read in.
        /// </summary>
        private void SetOutputType()
        {
            if (inputDataType == E_DataTypeCLUMPP.ONE) outputFileType = ".popq";
            else outputFileType = ".indivq";
        }

        /// <summary>
        /// Method gets you the whole name of CLUMPP's output file
        /// </summary>
        /// <returns>Returns string containing the whole name of CLUMPP's output file</returns>
        public string GetOutputFile()
        {
            return outuputFileName + outputFileType;
        }

        /// <summary>
        /// Run CLUMPP software.
        /// </summary>
        public void StartProcess()
        {
            Process clumppRun = new Process();
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
                clumppRun.StartInfo = startInfo;
                clumppRun.Start();

                clumppRun.StandardInput.WriteLine("CLUMPP " + paramFilePath + " -o " + outputDataPath + outuputFileName + outputFileType);

                clumppRun.StandardInput.Flush();
                clumppRun.StandardInput.Close();

                clumppRun.WaitForExit();

                Console.WriteLine(clumppRun.StandardOutput.ReadToEnd());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                clumppRun.Close();
            }
        }
    }
}
