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
        private string c_paramfilePath;
        private string c_outuputName;
        private E_DataTypeCLUMPP c_dataType;
        private string c_outputType;
        private string c_dataPath;

        /// <summary>
        /// Constructor with three parameters
        /// </summary>
        /// <param name="paramfilePath">A string path to CLUMPP's parameter file</param>
        /// <param name="outputName">A name of CLUMPP's output file</param>
        /// <param name="dataType">dataType defines the type of data to be read in to CLUMPP</param>
        /// <param name="dataPath">A path to a folder where output will be generated</param>
        public CLUMPP(string paramfilePath, E_DataTypeCLUMPP dataType, string outputName, string dataPath)
        {
            c_paramfilePath = paramfilePath;
            c_outuputName = outputName;
            c_dataType = dataType;
            SetOutputType();
            c_dataPath = dataPath;
        }

        /// <summary>
        /// Method sets the type of CLUMPP's output file deppending on type of data being read in.
        /// </summary>
        private void SetOutputType()
        {
            if (c_dataType == E_DataTypeCLUMPP.ONE) c_outputType = ".popq";
            else c_outputType = ".indivq";
        }

        /// <summary>
        /// Method gets you the whole name of CLUMPP's output file
        /// </summary>
        /// <returns>Returns string containing the whole name of CLUMPP's output file</returns>
        public string GetOutputFile()
        {
            return c_outuputName + c_outputType;
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

                clumppRun.StandardInput.WriteLine("CLUMPP " + c_paramfilePath + " -o " + c_dataPath + c_outuputName + c_outputType);

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
