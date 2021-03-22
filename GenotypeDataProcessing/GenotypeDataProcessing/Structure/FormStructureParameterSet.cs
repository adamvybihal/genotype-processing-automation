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
        public FormStructureParameterSet()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // todo - save parameters
            // todo - generate files
            // todo - refresh treeview in project screen
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
