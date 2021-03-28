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
    public partial class FormStructureParameterSet : Form
    {
        StructureParamSetStruct structureParamSetStruct;
        ProjectScreen callerProjectScreen;

        public FormStructureParameterSet(ProjectScreen projectScreen)
        {
            InitializeComponent();

            callerProjectScreen = projectScreen;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string paramSetName = txtSetName.Text;

            if (paramSetName != "")
            {
                SetStrucutreParamSet();

                StructureParamSet structureParamSet = new StructureParamSet(paramSetName, structureParamSetStruct, ProjectInfo.structureInputInfo);
                if (structureParamSet.IsParamSetNameValid())
                {
                    structureParamSet.CreateMainparamsFile();
                    structureParamSet.CreateExtraparamsFile();

                    callerProjectScreen.UpdateTreeView();

                    ProjectInfo.structureParameterSets.Add(paramSetName);
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Parameter set with this name already exists!", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a name of parameter set!", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
