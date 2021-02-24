using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenotypeDataProcessing.DUTs;
using GenotypeDataProcessing.ParamFilesCreation;

namespace GenotypeDataProcessing
{
    public partial class FormStructureMainParams : Form
    {
        public FormStructureMainParams()
        {
            InitializeComponent();
        }

        private void cbxExtraCols_CheckedChanged(object sender, EventArgs e)
        {
            numExtraCols.Enabled = cbxExtraCols.Checked;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ST_StructureMainParams stStructureMainParams;

            stStructureMainParams.burin = (int)numBurninPeriod.Value;
            stStructureMainParams.numReps = (int)numRepsAfterBurnin.Value;

            stStructureMainParams.numInds = (int)numIndividuals.Value;
            stStructureMainParams.numLoci = (int)numLoci.Value;
            stStructureMainParams.ploidy = (int)numPloidy.Value;
            stStructureMainParams.missing = (int)numMissingDataValue.Value;
            stStructureMainParams.oneRowPerInd = cbxSingleLine.Checked;

            stStructureMainParams.label = cbxIdCol.Checked;
            stStructureMainParams.popData = cbxPopOriginCol.Checked;
            stStructureMainParams.popFlag = cbxPopInfoFlagCol.Checked;
            stStructureMainParams.locData = cbxSampleInfoCol.Checked;
            stStructureMainParams.phenotype = cbxPhenotypeCol.Checked;
            stStructureMainParams.extraCols = (int)numExtraCols.Value;
            stStructureMainParams.markerNames = cbxMarkerRow.Checked;
            stStructureMainParams.recessiveAlleles = cbxAlelesRow.Checked;
            stStructureMainParams.mapDistances = cbxLociDistancesRow.Checked;

            stStructureMainParams.phased = false;
            stStructureMainParams.phaseInfo = false;
            stStructureMainParams.markovPhase = false;
            stStructureMainParams.notAmbiguous = -999;

            StructureMainParam structureMainParam = new StructureMainParam(stStructureMainParams);

            structureMainParam.createParamFile();
    }
    }
}
