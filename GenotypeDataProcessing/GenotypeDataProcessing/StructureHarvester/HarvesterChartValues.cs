using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenotypeDataProcessing.StructureHarvester
{
    /// <summary>
    /// Class which loads data which will be read into chart
    /// </summary>
    public class HarvesterChartValues
    {

        private bool fileExists = false;
        private List<double[]> chartData = new List<double[]>();

        /// <summary>
        /// HarvesterChartValues constructor
        /// </summary>
        /// <param name="inFile">Defines which file to read data from</param>
        /// <param name="chartType">Defines which data will be read in</param>
        public HarvesterChartValues(string inFile, HarvesterChartType chartType)
        {
            ReadDataFromFile(inFile, chartType);
        }

        private void ReadDataFromFile(string inFile, HarvesterChartType chartType)
        {
            if (File.Exists(inFile))
            {
                fileExists = true;

                Regex regex = GetDataRegex(chartType);
                List<string[]> dataCollected = new List<string[]>();

                using (var fileStream = File.OpenRead(inFile))
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true))
                {
                    int i = 0;
                    string line;

                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (regex.IsMatch(line))
                        {
                            dataCollected.Add(new string[7]);
                            dataCollected[i] = line.Split('\t');
                            i++;
                        }
                    }

                    SetDataForChart(dataCollected, chartType);
                }
            }
            else
            {
                fileExists = false;

                MessageBox.Show(
                                "Data for this chart could not be read in.\n" + 
                                "File " + inFile + " does not exist.\n" +
                                "Try rerun of Structure Harvester for specified parameter set.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
            }
        }

        private Regex GetDataRegex(HarvesterChartType chartType)
        {
            Regex regex;

            switch (chartType)
            {
                case HarvesterChartType.MEAN_LnP:
                    regex = new Regex(
                        @"^\d+\t\d+\t-?\d+[.]\d+\t-?\d+[.]\d+$"
                        );
                    break;
                case HarvesterChartType.FIRST_DERIVATIVE_Ln:
                case HarvesterChartType.SECOND_DERIVATIVE_Ln:
                case HarvesterChartType.DELTA_K:
                default:
                    regex = new Regex(
                        @"^\d+\t\d+\t-?\d+[.]\d+\t-?\d+[.]\d+\t(-?\d+[.]\d+|NA)\t(-?\d+[.]\d+|NA)\t(-?\d+[.]\d+|NA)$"
                        );
                    break;
            }

            return regex;
        }

        private void SetDataForChart(List<string[]> dataCollected, HarvesterChartType chartType)
        {
            const int X = 0;
            int Y;

            switch (chartType)
            {
                case HarvesterChartType.MEAN_LnP:
                    Y = 2;
                    break;
                case HarvesterChartType.FIRST_DERIVATIVE_Ln:
                    Y = 4;
                    break;
                case HarvesterChartType.SECOND_DERIVATIVE_Ln:
                    Y = 5;
                    break;
                case HarvesterChartType.DELTA_K:
                default:
                    Y = 6;
                    break;
            }

            int i = 0;
            foreach (var currentKValues in dataCollected)
            {
                double k = double.Parse(currentKValues[X]);
                double yValue;
                if (currentKValues[Y] == "NA")
                    yValue = 0;
                else
                    yValue = double.Parse(currentKValues[Y], System.Globalization.CultureInfo.InvariantCulture);

                chartData.Add(new double[] { k, yValue });

                i++;
            }
        }

        /// <summary>
        /// Gets list of XY for Structure Harvester chart
        /// </summary>
        /// <returns>list of arrays with XY values for chart</returns>
        public List<double[]> GetDataForChart()
        {
            return chartData;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>bool value</returns>
        public bool DoesFileExist()
        {
            return fileExists;
        }
    }
}
