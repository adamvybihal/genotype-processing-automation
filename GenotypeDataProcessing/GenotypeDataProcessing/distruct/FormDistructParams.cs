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
    public partial class FormDistructParams : Form
    {

        private const string chooseFileString = "choose file ...";

        private DistructParamStruct distructParamStruct;
        private ProjectScreen callerProjectScreen;

        public FormDistructParams(ProjectScreen projectScreen)
        {
            InitializeComponent();

            callerProjectScreen = projectScreen;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SetDistructParams();

            string path = Path.Combine(ProjectInfo.projectName, ProjectInfo.distructFolder);

            DistructParameterSet distructParameterSet = new DistructParameterSet(distructParamStruct, path);

            distructParameterSet.CreateDrawparams();

            if (distructParameterSet.IsDrawparamsCreated())
            {
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
    }
}
