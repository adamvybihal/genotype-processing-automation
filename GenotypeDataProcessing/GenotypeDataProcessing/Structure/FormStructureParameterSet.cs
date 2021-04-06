using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenotypeDataProcessing.Structure
{
    /// <summary>
    /// Form for creating or updating Structure parameter set
    /// </summary>
    public partial class FormStructureParameterSet : Form
    {
        private StructureParamSetStruct structureParamSetStruct;
        private ProjectScreen callerProjectScreen;
        private FormStructureParameterSetState state;

        /// <summary>
        /// FormStructureParameterSet constructor for creating new parameter set
        /// </summary>
        /// <param name="projectScreen">ProjectScreen class calling this form</param>
        /// <param name="parameterSetState">State of this form, update existing set or create new set</param>
        public FormStructureParameterSet(ProjectScreen projectScreen, FormStructureParameterSetState parameterSetState)
        {
            InitializeComponent();

            callerProjectScreen = projectScreen;
            state = parameterSetState;
        }

        /// <summary>
        /// FormStructureParameterSet constructor for updating existing parameter set
        /// </summary>
        /// <param name="projectScreen">ProjectScreen class calling this form</param>
        /// <param name="parameterSetState">State of this form, update existing set or create new set</param>
        /// <param name="paramSet">Selected parameter set, which is to be updated</param>
        public FormStructureParameterSet(ProjectScreen projectScreen, FormStructureParameterSetState parameterSetState, string paramSet)
        {
            InitializeComponent();

            callerProjectScreen = projectScreen;
            state = parameterSetState;

            UpdateFormSetup(paramSet);
        }

        private void UpdateFormSetup(string paramSet)
        {
            if (ProjectInfo.structureParamSets.ContainsKey(paramSet))
            {
                SetComponentsValues(paramSet, ProjectInfo.structureParamSets[paramSet]);
            }
            else
            {
                MessageBox.Show(
                    "Error - Parameter set not found!",
                    "Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void SetComponentsValues(string paramSet, StructureParamSetStruct structureParamSetStruct)
        {
            txtSetName.Text = paramSet;
            txtSetName.Enabled = false;

            numBurninPeriod.Value = structureParamSetStruct.burnin;
            numRepsAfterBurnin.Value = structureParamSetStruct.numReps;
            cbxPhased.Checked = structureParamSetStruct.phased;
            cbxMarkovPhase.Checked = structureParamSetStruct.markovPhase;

            cbxNoAdmix.Checked = structureParamSetStruct.noAdmix;
            cbxLocPrior.Checked = structureParamSetStruct.locPrior;

            cbxLinkage.Checked = structureParamSetStruct.linkage;
            numLogRMax.Value = (decimal)structureParamSetStruct.logRMax;
            numLogRMin.Value = (decimal)structureParamSetStruct.logRMin;
            numLogRProPSD.Value = (decimal)structureParamSetStruct.logRPropSD;
            numLogRStart.Value = (decimal)structureParamSetStruct.logRStart;

            cbxUsePopInfo.Checked = structureParamSetStruct.usePopInfo;
            numGensback.Value = structureParamSetStruct.gensBack;
            numMigprior.Value = (decimal)structureParamSetStruct.migPrior;

            if (structureParamSetStruct.inferAlpha) numInitAlpha.Value = (decimal)structureParamSetStruct.alpha;
            else numSetAlpha.Value = (decimal)structureParamSetStruct.alpha;
            rdbInferAlpha.Checked = structureParamSetStruct.inferAlpha;
            cbxPopAlphas.Checked = structureParamSetStruct.popAlphas;
            cbxUnifPriorAlpha.Checked = structureParamSetStruct.unifPriorAlphas;
            numAlphaMax.Value = (decimal)structureParamSetStruct.alphaMax;
            numAlphaProPsd.Value = (decimal)structureParamSetStruct.alphaPropSD;
            numAlphaPriorA.Value = (decimal)structureParamSetStruct.alphaPriorA;
            numAlphaPriorB.Value = (decimal)structureParamSetStruct.alphaPriorB;

            cbxFreqsCorr.Checked = structureParamSetStruct.freqsCorr;
            cbxOneFst.Checked = structureParamSetStruct.oneFst;
            numPriorMean.Value = (decimal)structureParamSetStruct.priorMean;
            numPriorSD.Value = (decimal)structureParamSetStruct.priorSD;

            if (structureParamSetStruct.inferLambda) numInitLambda.Value = (decimal)structureParamSetStruct.lambda;
            else numSetLambda.Value = (decimal)structureParamSetStruct.lambda;
            rdbInferLambda.Checked = structureParamSetStruct.inferLambda;
            cbxPopAlphas.Checked = structureParamSetStruct.popSpecifiLambda;

            cbxComputeProb.Checked = structureParamSetStruct.computePorb;
            cbxAncestdist.Checked = structureParamSetStruct.ancestDist;
            numNumboxes.Value = structureParamSetStruct.numboxes;
            numAncestpint.Value = (decimal)structureParamSetStruct.ancestPint;
            cbxStartPopInfo.Checked = structureParamSetStruct.startPopInfo;
            numMetroFreq.Value = structureParamSetStruct.metroFreq;
            cbxPrintQHat.Checked = structureParamSetStruct.printQHat;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string paramSetName = txtSetName.Text;

            if (paramSetName != "")
            {
                switch (state)
                {
                    case FormStructureParameterSetState.NEW:
                        CreateNewParameterSet(paramSetName);
                        break;
                    case FormStructureParameterSetState.UPDATE:
                        UpdateParameterSet(paramSetName);
                        break;
                }

                callerProjectScreen.UpdateStructureTreeView();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a name of parameter set!", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private void CreateNewParameterSet(string paramSetName)
        {
            SetStrucutreParamSet();

            try
            {
                ProjectInfo.structureParamSets.Add(paramSetName, structureParamSetStruct);
            }
            catch (ArgumentException)
            {
                MessageBox.Show(
                    "Parameter set with this name already exists!",
                    "Invalid Name",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            StructureParamSet structureParamSet = new StructureParamSet(paramSetName, structureParamSetStruct, ProjectInfo.structureInputInfo);
            structureParamSet.CreateMainparamsFile();
            structureParamSet.CreateExtraparamsFile();
        }

        private void UpdateParameterSet(string paramSetName)
        {
            if (ProjectInfo.structureParamSets.ContainsKey(paramSetName))
            {
                SetStrucutreParamSet();

                ProjectInfo.structureParamSets[paramSetName] = structureParamSetStruct;

                StructureParamSet structureParamSet = new StructureParamSet(paramSetName, structureParamSetStruct, ProjectInfo.structureInputInfo);
                structureParamSet.CreateMainparamsFile();
                structureParamSet.CreateExtraparamsFile();
            }
            else
            {
                CreateNewParameterSet(paramSetName);
            }
        }

        private void SetStrucutreParamSet()
        {
            structureParamSetStruct.burnin = (int)numBurninPeriod.Value;
            structureParamSetStruct.numReps = (int)numRepsAfterBurnin.Value;
            structureParamSetStruct.phased = cbxPhased.Checked;
            structureParamSetStruct.markovPhase = cbxMarkovPhase.Checked;

            structureParamSetStruct.noAdmix = cbxNoAdmix.Checked;
            structureParamSetStruct.locPrior = cbxLocPrior.Checked;

            structureParamSetStruct.linkage = cbxLinkage.Checked;
            structureParamSetStruct.logRMax = (double)numLogRMax.Value;
            structureParamSetStruct.logRMin = (double)numLogRMin.Value;
            structureParamSetStruct.logRPropSD = (double)numLogRProPSD.Value;
            structureParamSetStruct.logRStart = (double)numLogRStart.Value;

            structureParamSetStruct.usePopInfo = cbxUsePopInfo.Checked;
            structureParamSetStruct.gensBack = (int)numGensback.Value;
            structureParamSetStruct.migPrior = (double)numMigprior.Value;

            if (rdbInferAlpha.Checked) structureParamSetStruct.alpha = (double)numInitAlpha.Value;
            else structureParamSetStruct.alpha = (double)numSetAlpha.Value;
            structureParamSetStruct.inferAlpha = rdbInferAlpha.Checked;
            structureParamSetStruct.popAlphas = cbxPopAlphas.Checked;
            structureParamSetStruct.unifPriorAlphas = cbxUnifPriorAlpha.Checked;
            structureParamSetStruct.alphaMax = (double)numAlphaMax.Value;
            structureParamSetStruct.alphaPropSD = (double)numAlphaProPsd.Value;
            structureParamSetStruct.alphaPriorA = (double)numAlphaPriorA.Value;
            structureParamSetStruct.alphaPriorB = (double)numAlphaPriorB.Value;

            structureParamSetStruct.freqsCorr = cbxFreqsCorr.Checked;
            structureParamSetStruct.oneFst = cbxOneFst.Checked;
            structureParamSetStruct.priorMean = (double)numPriorMean.Value;
            structureParamSetStruct.priorSD = (double)numPriorSD.Value;

            if (rdbInferLambda.Checked) structureParamSetStruct.lambda = (double)numInitLambda.Value;
            else structureParamSetStruct.lambda = (double)numSetLambda.Value;
            structureParamSetStruct.inferLambda = rdbInferLambda.Checked;
            structureParamSetStruct.popSpecifiLambda = cbxPopAlphas.Checked;

            structureParamSetStruct.computePorb = cbxComputeProb.Checked;
            structureParamSetStruct.ancestDist = cbxAncestdist.Checked;
            structureParamSetStruct.numboxes = (int)numNumboxes.Value;
            structureParamSetStruct.ancestPint = (double)numAncestpint.Value;
            structureParamSetStruct.startPopInfo = cbxStartPopInfo.Checked;
            structureParamSetStruct.metroFreq = (int)numMetroFreq.Value;
            structureParamSetStruct.printQHat = cbxPrintQHat.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Ancestry model TAB

        private void cbxLinkage_CheckedChanged(object sender, EventArgs e)
        {
            numLogRMin.Enabled = cbxLinkage.Checked;
            numLogRMax.Enabled = cbxLinkage.Checked;
            numLogRProPSD.Enabled = cbxLinkage.Checked;
            numLogRStart.Enabled = cbxLinkage.Checked;
            cbxPhased.Enabled = cbxLinkage.Checked;
            cbxMarkovPhase.Enabled = cbxLinkage.Checked;
        }

        private void cbxUsePopInfo_CheckedChanged(object sender, EventArgs e)
        {
            numGensback.Enabled = cbxUsePopInfo.Checked;
            numMigprior.Enabled = cbxUsePopInfo.Checked;
        }

        private void rdbSetAlpha_CheckedChanged(object sender, EventArgs e)
        {
            numSetAlpha.Enabled = rdbSetAlpha.Checked;
        }

        private void rdbInferAlpha_CheckedChanged(object sender, EventArgs e)
        {
            numInitAlpha.Enabled = rdbInferAlpha.Checked;
            cbxPopAlphas.Enabled = rdbInferAlpha.Checked;
            cbxUnifPriorAlpha.Enabled = rdbInferAlpha.Checked;
            numAlphaMax.Enabled = rdbInferAlpha.Checked & cbxUnifPriorAlpha.Checked;
            numAlphaProPsd.Enabled = rdbInferAlpha.Checked & cbxUnifPriorAlpha.Checked;
            numAlphaPriorA.Enabled = rdbInferAlpha.Checked & !(cbxUnifPriorAlpha.Checked);
            numAlphaPriorB.Enabled = rdbInferAlpha.Checked & !(cbxUnifPriorAlpha.Checked);
        }

        private void cbxUnifPriorAlpha_CheckedChanged(object sender, EventArgs e)
        {
            numAlphaMax.Enabled = cbxUnifPriorAlpha.Checked;
            numAlphaProPsd.Enabled = cbxUnifPriorAlpha.Checked;

            numAlphaPriorA.Enabled = !(cbxUnifPriorAlpha.Checked);
            numAlphaPriorB.Enabled = !(cbxUnifPriorAlpha.Checked);
        }

        // Allele frequencies TAB

        private void cbxFreqsCorr_CheckedChanged(object sender, EventArgs e)
        {
            cbxOneFst.Enabled = cbxFreqsCorr.Checked;
            numPriorMean.Enabled = cbxFreqsCorr.Checked;
            numPriorSD.Enabled = cbxFreqsCorr.Checked;
        }

        private void rdbSetLambda_CheckedChanged(object sender, EventArgs e)
        {
            numSetLambda.Enabled = rdbSetLambda.Checked;
        }

        private void rdbInferLambda_CheckedChanged(object sender, EventArgs e)
        {
            numInitLambda.Enabled = rdbInferLambda.Checked;
            cbxPopSpecifiLambda.Enabled = rdbInferLambda.Checked;
        }

        // Advanced TAB

        private void cbxAncestdist_CheckedChanged(object sender, EventArgs e)
        {
            numAncestpint.Enabled = cbxAncestdist.Checked;
            numNumboxes.Enabled = cbxAncestdist.Checked;
        }

    }
}
