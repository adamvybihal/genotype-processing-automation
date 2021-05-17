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
        /// FormDistructParams constructor for updating existing parameter sets
        /// </summary>
        /// <param name="projectScreen">ProjectScreen Form which is calling this Form</param>
        /// <param name="paramset">Name of parameter set</param>
        /// <param name="paramStruct">Parameters to be updated</param>
        public FormDistructParams(ProjectScreen projectScreen, string paramset, DistructParamStruct paramStruct)
        {
            InitializeComponent();

            callerProjectScreen = projectScreen;
            paramsetName = paramset;
            SetComponents(paramStruct);

            numPreDefPopulations.Enabled = false;
            numIndividuals.Enabled = false;

            SetRangeOfK();
        }

        /// <summary>
        /// FormDistructParams Constructor
        /// </summary>
        /// <param name="projectScreen">ProjectScreen Form which is calling this Form</param>
        /// <param name="paramset">Name of parameter set</param>
        /// <param name="pops">Number of pre-defined populations in the parameter set</param>
        /// <param name="indivs">Number of individuals in the parameter set</param>
        public FormDistructParams(ProjectScreen projectScreen, string paramset, int pops, int indivs)
        {
            InitializeComponent();

            callerProjectScreen = projectScreen;
            paramsetName = paramset;

            numPreDefPopulations.Value = pops;
            numIndividuals.Value = indivs;

            numPreDefPopulations.Enabled = false;
            numIndividuals.Enabled = false;

            cbxRange.Checked = false;
            numEndK.Enabled = false;

            SetRangeOfK();
        }

        private void SetRangeOfK()
        {
            int minK = ProjectInfo.clumppJobInfo[paramsetName].startK;
            int maxK = ProjectInfo.clumppJobInfo[paramsetName].endK;

            numStartK.Minimum = minK;
            numStartK.Maximum = maxK;

            numEndK.Minimum = minK;
            numEndK.Maximum = maxK;
        }

        private void SetComponents(DistructParamStruct paramStruct)
        {
            numStartK.Value = paramStruct.kStart;

            if (numStartK.Value == numEndK.Value)
                cbxRange.Checked = false;

            numEndK.Value = paramStruct.kEnd;
            cbxRange.Checked = true;

            txtLblAtopFile.Text = paramStruct.infileLabelAtop;
            txtLblBelowFile.Text = paramStruct.infileLabelBelow;
            txtPermutationFile.Text = paramStruct.infileClustPerm;

            numStartK.Value = paramStruct.k;
            numIndividuals.Value = paramStruct.numInds;
            numPreDefPopulations.Value = paramStruct.numPops;

            cbxPrintIndividuals.Checked = paramStruct.printIndivs;
            cbxPrintLblsAtop.Checked = paramStruct.printLabelAtop;
            cbxPrintLblsBelow.Checked = paramStruct.printLabelBelow;
            cbxPrintSeparatingLines.Checked = paramStruct.printSep;

            numFontSize.Value = (decimal)paramStruct.fontHeight;
            numDistanceAbove.Value = (decimal)paramStruct.distAbove;
            numDistanceBelow.Value = (decimal)paramStruct.distBelow;
            numFigureHeight.Value = (decimal)paramStruct.boxHeight;
            numIndividualWidth.Value = (decimal)paramStruct.indivWidth;

            switch (paramStruct.orientation)
            {
                case 0:
                    cmbOrientation.Text = "horizontal";
                    break;
                case 1:
                    cmbOrientation.Text = "vertical";
                    break;
                case 2:
                    cmbOrientation.Text = "reverse horizontal";
                    break;
                case 3:
                    cmbOrientation.Text = "reverse vertical";
                    break;
            }
            cbxPrintInfileName.Enabled = (cmbOrientation.Text == "horizontal");

            numXOrigin.Value = (decimal)paramStruct.xOrigin;
            numYOrigin.Value = (decimal)paramStruct.yOrigin;
            numXScale.Value = (decimal)paramStruct.xScale;
            numYScale.Value = (decimal)paramStruct.yScale;
            numAngleLabelAtop.Value = (decimal)paramStruct.angleLabelAtop;
            numAngleLabelBelow.Value = (decimal)paramStruct.angleLabelBelow;

            numLineWidthRim.Value = (decimal)paramStruct.lineWidthRim;
            numLineWidthSep.Value = (decimal)paramStruct.lineWidthSep;
            numLineWidthInd.Value = (decimal)paramStruct.lineWidthInd;

            cbxGrayscale.Checked = paramStruct.grayscale;
            cbxEchoData.Checked = paramStruct.echoData;
            cbxReprintData.Checked = paramStruct.reprintData;
            cbxPrintInfileName.Checked = paramStruct.printInfileName;
            cbxPrintColorBrewer.Checked = paramStruct.printColorBrewer;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (cbxRange.Checked && (numStartK.Value > numEndK.Value))
            {
                MessageBox.Show(
                    "Starting K is greater than ending K!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return; 
            }

            SetDistructParams();

            string path = Path.Combine(ProjectInfo.projectNamePath, ProjectInfo.distructFolder, paramsetName);

            DistructParameterSet distructParameterSet = new DistructParameterSet(
                                                                distructParamStruct,
                                                                path,
                                                                distructParamStruct.kStart,
                                                                distructParamStruct.kEnd
                                                                );

            distructParameterSet.CreateParameterFiles();

            if (distructParameterSet.AreParamFilesCreated())
            {
                if (ProjectInfo.distructParamSets.ContainsKey(paramsetName))
                    ProjectInfo.distructParamSets.Remove(paramsetName);

                ProjectInfo.distructParamSets.Add(paramsetName, distructParamStruct);

                callerProjectScreen.UpdateDistructTreeView();
                this.Close();
            }
        }

        private void SetDistructParams()
        {
            distructParamStruct.kStart = (int)numStartK.Value;

            if (cbxRange.Checked) distructParamStruct.kEnd = (int)numEndK.Value;
            else distructParamStruct.kEnd = distructParamStruct.kStart;


            if (txtLblAtopFile.Text != chooseFileString) distructParamStruct.infileLabelAtop = txtLblAtopFile.Text;
            else distructParamStruct.infileLabelAtop = "";

            if (txtLblBelowFile.Text != chooseFileString) distructParamStruct.infileLabelBelow = txtLblBelowFile.Text;
            else distructParamStruct.infileLabelBelow = "";

            if (txtPermutationFile.Text != chooseFileString) distructParamStruct.infileClustPerm = txtPermutationFile.Text;
            else distructParamStruct.infileClustPerm = "";

            distructParamStruct.k = (int)numStartK.Value;
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

            switch (cmbOrientation.Text)
            {
                case "horizontal":
                    distructParamStruct.orientation = 0;
                    break;
                case "vertical":
                    distructParamStruct.orientation = 1;
                    break;
                case "reverse horizontal":
                    distructParamStruct.orientation = 2;
                    break;
                case "reverse vertical":
                    distructParamStruct.orientation = 3;
                    break;
            }

            distructParamStruct.xOrigin = (double)numXOrigin.Value;
            distructParamStruct.yOrigin = (double)numYOrigin.Value;
            distructParamStruct.xScale = (double)numXScale.Value;
            distructParamStruct.yScale = (double)numYScale.Value;
            distructParamStruct.angleLabelAtop = (double)numAngleLabelAtop.Value;
            distructParamStruct.angleLabelBelow = (double)numAngleLabelBelow.Value;

            distructParamStruct.lineWidthRim = (double)numLineWidthRim.Value;
            distructParamStruct.lineWidthSep = (double)numLineWidthSep.Value;
            distructParamStruct.lineWidthInd = (double)numLineWidthInd.Value;

            distructParamStruct.grayscale = cbxGrayscale.Checked;
            distructParamStruct.echoData = cbxEchoData.Checked;
            distructParamStruct.reprintData = cbxReprintData.Checked;
            distructParamStruct.printInfileName = cbxPrintInfileName.Checked;
            distructParamStruct.printColorBrewer = cbxPrintColorBrewer.Checked;
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

        private void cbxRange_CheckedChanged(object sender, EventArgs e)
        {
            numEndK.Enabled = cbxRange.Checked;
        }

        private void cmbOrientation_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxPrintInfileName.Enabled = (cmbOrientation.Text == "horizontal");
        }
    }
}
