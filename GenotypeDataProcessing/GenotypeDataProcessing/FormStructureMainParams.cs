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
            ST_StructureMainParams structureMainParams;

            structureMainParams.burin = (int)numBurninPeriod.Value;
            structureMainParams.numReps = (int)numRepsAfterBurnin.Value;

            structureMainParams.numInds = (int)numIndividuals.Value;
            structureMainParams.numLoci = (int)numLoci.Value;
            structureMainParams.ploidy = (int)numPloidy.Value;
            structureMainParams.missingDataValue = (int)numMissingDataValue.Value;
            structureMainParams.oneRowPerInd = cbxSingleLine.Checked;

            structureMainParams.label = cbxIdCol.Checked;
            structureMainParams.popData = cbxPopOriginCol.Checked;
            structureMainParams.popFlag = cbxPopInfoFlagCol.Checked;
            structureMainParams.locData = cbxSampleInfoCol.Checked;
            structureMainParams.phenotype = cbxPhenotypeCol.Checked;
            structureMainParams.extraCols = (int)numExtraCols.Value;
            structureMainParams.markerNames = cbxMarkerRow.Checked;
            structureMainParams.recessiveAlleles = cbxAlelesRow.Checked;
            structureMainParams.mapDistances = cbxLociDistancesRow.Checked;

            structureMainParams.phased = false;
            structureMainParams.phaseInfo = false;
            structureMainParams.markovPhase = false;
            structureMainParams.notAmbiguous = -999;

            StructureMainParamFile structureMainParamFile = new StructureMainParamFile(structureMainParams);

            structureMainParamFile.createParamFile();
    }
    }
}
