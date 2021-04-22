using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenotypeDataProcessing.distruct;

namespace GenotypeDataProcessing
{
    /// <summary>
    /// Form for setting distruct params
    /// </summary>
    public partial class FormDistructParams : Form
    {

        private const string chooseFileString = "choose file ...";

        private DistructParamStruct distructParamStruct;
        private ProjectScreen callerProjectScreen;

        private string paramsetName = "";

        /// <summary>
        /// One parameter constructor
        /// </summary>
        /// <param name="projectScreen">ProjectScreen Form which is calling this Form</param>
        public FormDistructParams(ProjectScreen projectScreen)
        {
            InitializeComponent();

            callerProjectScreen = projectScreen;
        }

        /// <summary>
        /// FormDistructParamsConstructor
        /// </summary>
        /// <param name="projectScreen">ProjectScreen Form which is calling this Form</param>
        /// <param name="paramset">Name of parameter set</param>
        /// <param name="pops">Number of pre-defined populations in the parameter set</param>
        /// <param name="indivs">Number of individuals in the parameter set</param>
        public FormDistructParams(ProjectScreen projectScreen, string paramset, int pops, int indivs)
        {
            InitializeComponent();

            paramsetName = paramset;

            numPreDefPopulations.Value = pops;
            numIndividuals.Value = indivs;

            numPreDefPopulations.Enabled = false;
            numIndividuals.Enabled = false;

            callerProjectScreen = projectScreen;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SetDistructParams();

            string path = Path.Combine(ProjectInfo.projectNamePath, ProjectInfo.distructFolder, paramsetName);

            DistructParameterSet distructParameterSet = new DistructParameterSet(distructParamStruct, path);

            distructParameterSet.CreateDrawparams();

            if (distructParameterSet.IsDrawparamsCreated())
            {
                ProjectInfo.distructParamSets.Add(paramsetName, distructParamStruct);

                callerProjectScreen.UpdateDistructTreeView();
                this.Close();
            }
        }

        private void SetDistructParams()
        {
            if (txtLblAtopFile.Text != chooseFileString) distructParamStruct.infileLabelAtop = txtLblAtopFile.Text;
            else distructParamStruct.infileLabelAtop = "";

            if (txtLblBelowFile.Text != chooseFileString) distructParamStruct.infileLabelBelow = txtLblBelowFile.Text;
            else distructParamStruct.infileLabelBelow = "";

            if (txtPermutationFile.Text != chooseFileString) distructParamStruct.infileClustPerm = txtPermutationFile.Text;
            else distructParamStruct.infileClustPerm = "";

            distructParamStruct.k = (int)numClusters.Value;
            distructParamStruct.numInds = (int)numIndividuals.Value;
            distructParamStruct.numPops = (int)numPreDefPopulations.Value;

            distructParamStruct.printIndivs = cbxPrintIndividuals.Checked;
            distructParamStruct.printLabelAtop = cbxPrintLblsAtop.Checked;
            distructParamStruct.printLabelBelow = cbxPrintLblsBelow.Checked;
            distructParamStruct.printSep = cbxPrintSeparatingLines.Checked;

            distructParamStruct.fontHeight = (double)numFontSize.Value;
            distructParamStruct.distAbove = (double)numDistanceAbove.Value;
            distructParamStruct.distBelow = (double)numDistanceBelow.Value;
            distructParamStruct.boxHeight = (double)numFigureHeight.Value;
            distructParamStruct.indivWidth = (double)numIndividualWidth.Value;
        }

        private void btnChooseLblsBelowFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();

            if (fileDialog.FileName != "")
            {
                txtLblBelowFile.Text = fileDialog.FileName;
            }
        }

        private void btnChooseLblsAtopFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();

            if (fileDialog.FileName != "")
            {
                txtLblAtopFile.Text = fileDialog.FileName;
            }
        }

        private void btnChoosePermutationFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();

            if (fileDialog.FileName != "")
            {
                txtPermutationFile.Text = fileDialog.FileName;
            }
        }
    }
}
