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
using GenotypeDataProcessing.CLUMPP;

namespace GenotypeDataProcessing
{
    public partial class FormClumppParams : Form
    {

        private ClumppParamStruct clumppParamStruct;
        private ProjectScreen callerProjectScreen;
        private string parameterSet = "";

        /// <summary>
        /// FormClumppParams constructor to update parameter set
        /// </summary>
        /// <param name="projectScreen">ProjectScreen form calling this class</param>
        /// <param name="paramsetName">Name of parameter set</param>
        /// <param name="paramset">Parameter set to be updated</param>
        public FormClumppParams(ProjectScreen projectScreen, string paramsetName, ClumppParamStruct paramset)
        {
            InitializeComponent();

            callerProjectScreen = projectScreen;
            parameterSet = paramsetName;
            SetComponents(paramset);
        }

        /// <summary>
        /// FormClumppParams constructor for new parameter set
        /// </summary>
        /// <param name="projectScreen">ProjectScreen form calling this class</param>
        /// <param name="paramset">Name of parameter set</param>
        /// <param name="r">Iterations over each K</param>
        /// <param name="inds">Number of individuals</param>
        public FormClumppParams(ProjectScreen projectScreen, string paramset, int r, int inds)
        {
            InitializeComponent();            

            callerProjectScreen = projectScreen;

            parameterSet = paramset;
            SetComponents(r, inds);
        }

        private void SetComponents(int runs, int individuals)
        {
            numRuns.Value = runs;
            numIndividuals.Value = individuals;

            numRuns.Enabled = false;
            numIndividuals.Enabled = false;
        }

        private void SetComponents(ClumppParamStruct paramset)
        {
            numRuns.Enabled = false;
            numIndividuals.Enabled = false;

            numRuns.Value = paramset.r;
            numIndividuals.Value = paramset.individuals;
            numPopulations.Value = paramset.populations;

            switch (paramset.m)
            {
                case 1:
                    cmbMethodToBeUsed.Text = "FullSearch";
                    break;
                case 2:
                    cmbMethodToBeUsed.Text = "Greedy";
                    break;
                case 3:
                    cmbMethodToBeUsed.Text = "LargeKGreedy";
                    break;
            }

            switch (paramset.greedyOption)
            {
                case 1:
                    cmbGreedyOption.Text = "all possible input orders";
                    break;
                case 2:
                    cmbGreedyOption.Text = "random input orders";
                    break;
                case 3:
                    cmbGreedyOption.Text = "pre-specified input orders";
                    break;
            }

            numRepeats.Value = paramset.repeats;

            switch (paramset.printPermutedData)
            {
                case 0:
                    cmbPrintPermutedData.Text = "don't print";
                    break;
                case 1:
                    cmbPrintPermutedData.Text = "print into one file";
                    break;
                case 2:
                    cmbPrintPermutedData.Text = "print each run into separate files";
                    break;
            }

            cbxPrintEveryPerm.Checked = paramset.printEveryPerm;
            cbxPrintRandomInputOrder.Checked = paramset.printRandomInputOrder;

            cbxOverrideWarnings.Checked = paramset.overrideWarnings;
            cbxOrderByRun.Checked = paramset.orderByRun;
        }

        private void cmbMethodToBeUsed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMethodToBeUsed.Text == "Greedy" || cmbMethodToBeUsed.Text == "LargeKGreedy") cmbGreedyOption.Enabled = true;
            else cmbGreedyOption.Enabled = false;
        }

        private void cmbGreedyOption_EnabledChanged(object sender, EventArgs e)
        {
            if (cmbGreedyOption.Enabled)
            {
                EnableFunctionsBasedOnGreedy();
            }
            else
            {
                numRepeats.Enabled = false;
                btnChoosePermutationFile.Enabled = false;
                cbxPrintRandomInputOrder.Enabled = false;
            }
        }

        private void cmbGreedyOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableFunctionsBasedOnGreedy();
        }

        private void EnableFunctionsBasedOnGreedy()
        {
            switch (cmbGreedyOption.Text)
            {
                case "all possible input orders":
                    numRepeats.Enabled = false;
                    btnChoosePermutationFile.Enabled = false;
                    cbxPrintRandomInputOrder.Enabled = false;
                    break;
                case "random input orders":
                    numRepeats.Enabled = true;
                    btnChoosePermutationFile.Enabled = false;
                    cbxPrintRandomInputOrder.Enabled = true;
                    break;
                case "pre-specified input orders":
                    numRepeats.Enabled = true;
                    btnChoosePermutationFile.Enabled = true;
                    cbxPrintRandomInputOrder.Enabled = false;
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SetClumppParams();

            string path = Path.Combine(ProjectInfo.projectNamePath, ProjectInfo.clumppFolder, parameterSet);

            ClumppParameterSet clumppParameterSet = new ClumppParameterSet(clumppParamStruct, path);

            clumppParameterSet.CreateParamfile(DataTypeClumppEn.ZERO);
            if (clumppParameterSet.IsParamfileCreated())
            {
                clumppParameterSet.CreateParamfile(DataTypeClumppEn.ONE);
                if (clumppParameterSet.IsParamfileCreated())
                {
                    callerProjectScreen.UpdateClumppTreeView();

                    if (ProjectInfo.clumppParamSets.ContainsKey(parameterSet))
                        ProjectInfo.clumppParamSets.Remove(parameterSet);

                    ProjectInfo.clumppParamSets.Add(parameterSet, clumppParamStruct);

                    this.Close();
                }
            }
        }

        private void SetClumppParams()
        {
            clumppParamStruct.k = (int)numClusters.Value;
            clumppParamStruct.r = (int)numRuns.Value;
            clumppParamStruct.individuals = (int)numIndividuals.Value;
            clumppParamStruct.populations = (int)numPopulations.Value;

            switch (cmbMethodToBeUsed.Text)
            {
                case "FullSearch":
                    clumppParamStruct.m = 1;
                    break;
                case "Greedy":
                    clumppParamStruct.m = 2;
                    break;
                case "LargeKGreedy":
                    clumppParamStruct.m = 3;
                    break;
            }

            switch (cmbGreedyOption.Text)
            {
                case "all possible input orders":
                    clumppParamStruct.greedyOption = 1;
                    break;
                case "random input orders":
                    clumppParamStruct.greedyOption = 2;
                    break;
                case "pre-specified input orders":
                    clumppParamStruct.greedyOption = 3;
                    break;
            }

            clumppParamStruct.repeats = (int)numRepeats.Value;

            switch (cmbPrintPermutedData.Text)
            {
                case "don't print":
                    clumppParamStruct.printPermutedData = 0;
                    break;
                case "print into one file":
                    clumppParamStruct.printPermutedData = 1;
                    break;
                case "print each run into separate files":
                    clumppParamStruct.printPermutedData = 2;
                    break;
            }

            clumppParamStruct.printEveryPerm = cbxPrintEveryPerm.Checked;
            clumppParamStruct.printRandomInputOrder = cbxPrintRandomInputOrder.Checked;

            clumppParamStruct.overrideWarnings = cbxOverrideWarnings.Checked;
            clumppParamStruct.orderByRun = cbxOrderByRun.Checked;
        }
    }
}
