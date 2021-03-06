﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenotypeDataProcessing.Programs
{
    /// <summary>
    /// Class for running distruct
    /// </summary>
    public class Distruct
    {

        private string c_drawparamsPath;
        private string c_indivqPath;
        private string c_popqPath;
        private string c_outuputName;
        private string c_dataPath;

        /// <summary>
        /// Constructor with two parameters
        /// </summary>
        /// <param name="drawparamsPath">A string path to distruct's parameter file</param>
        /// <param name="indivqPath">A string path to input file of individual q's</param>
        /// <param name="popqPath">A string path to input file of population q's</param>
        /// <param name="outputName">A name of distruct's output file</param>
        /// <param name="dataPath">A path to a folder where output will be generated</param>
        public Distruct(string drawparamsPath, string indivqPath, string popqPath, string outputName, string dataPath)
        {
            c_drawparamsPath = drawparamsPath;
            c_indivqPath = indivqPath;
            c_popqPath = popqPath;
            c_outuputName = outputName;
            c_dataPath = dataPath;
        }

        /// <summary>
        /// Method gets you the whole name of distruct's output file
        /// </summary>
        /// <returns>Returns string containing the whole name of distruct's output file</returns>
        public string GetOutputFile()
        {
            return c_outuputName + ".ps";
        }

        /// <summary>
        /// Method that launches distruct.
        /// Runs when there have been two succesful structure runs, which created necessary files to run distruct.
        /// </summary>
        public void RunDistruct()
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

                distructRun.StandardInput.WriteLine("distructWindows1.1 -d " + c_drawparamsPath + " -p " + c_popqPath + " -i " + c_indivqPath + " -o " + c_dataPath + c_outuputName + ".ps");
                distructRun.StandardInput.Flush();
                distructRun.StandardInput.Close();

                distructRun.WaitForExit();
                Console.WriteLine(distructRun.StandardOutput.ReadToEnd());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                distructRun.Close();

            }
        }
    }
}
