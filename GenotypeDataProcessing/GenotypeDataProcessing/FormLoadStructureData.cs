using GenotypeDataProcessing.Structure;
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

namespace GenotypeDataProcessing
{
    /// <summary>
    /// Form for loading Structure input data file
    /// </summary>
    public partial class FormLoadStructureData : Form
    {
        // calculated from actual input file
        private int colsInFile = 0;
        private int rowsInFile = 0;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public FormLoadStructureData()
        {
            InitializeComponent();

            gbxStep2.Visible = false;
            gbxStep3.Visible = false;
            gbxStep4.Visible = false;

            // todo - implement code, co user can use these !!
            cbxPhase.Enabled = false;
            cbxSingleLine.Enabled = false;
        }

        //STEP 1
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChooseStructureFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();

            if (fileDialog.FileName != "")
            {
                txtStructureDataFile.Text = fileDialog.FileName;

                btnNext1to2.Enabled = true;
            }
        }

        private void btnNext1to2_Click(object sender, EventArgs e)
        {
            gbxStep1.Visible = false;
            gbxStep2.Visible = true;
        }

        //STEP 2
        private void btnNext2to3_Click(object sender, EventArgs e)
        {
            gbxStep2.Visible = false;
            gbxStep3.Visible = true;
        }

        private void btnBack2to1_Click(object sender, EventArgs e)
        {
            gbxStep2.Visible = false;
            gbxStep1.Visible = true;
        }

        // STEP 3
        private void btnNext3to4_Click(object sender, EventArgs e)
        {
            gbxStep3.Visible = false;
            gbxStep4.Visible = true;
        }

        private void btnBack3to2_Click(object sender, EventArgs e)
        {
            gbxStep3.Visible = false;
            gbxStep2.Visible = true;
        }

        // STEP 4
        private void btnFinish_Click(object sender, EventArgs e)
        {
            ProjectScreen.canShowStructureData = false;
            SetProjectInputInfo();

            string projectPath = Path.Combine(ProjectInfo.projectName, ProjectInfo.structureFolder, "structureData.");
            ProjectInfo.structureInputData = new StructureInputData(txtStructureDataFile.Text, projectPath);

            if (ProjectInfo.structureInputData.DataLoadedSuccesfully())
            {
                ProjectScreen.canShowStructureData = true;
                MessageBox.Show("Data set loaded succesfully.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(ProjectInfo.structureInputData.GetErrorString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetProjectInputInfo()
        {
            ProjectInfo.structureMainParams.numInds = (int)numIndividuals.Value;
            ProjectInfo.structureMainParams.numLoci = (int)numLoci.Value;
            ProjectInfo.structureMainParams.ploidy = (int)numPloidy.Value;
            ProjectInfo.structureMainParams.missingDataValue = (int)numMissingDataValue.Value;

            ProjectInfo.structureMainParams.oneRowPerInd = cbxSingleLine.Checked;
            ProjectInfo.structureMainParams.label = cbxIdCol.Checked;
            ProjectInfo.structureMainParams.popData = cbxPopOriginCol.Checked;
            ProjectInfo.structureMainParams.popFlag = cbxPopInfoFlagCol.Checked;
            ProjectInfo.structureMainParams.locData = cbxSampleInfoCol.Checked;
            ProjectInfo.structureMainParams.phenotype = cbxPhenotypeCol.Checked;

            if (cbxExtraCols.Checked) ProjectInfo.structureMainParams.extraCols = (int)numExtraCols.Value;
            else ProjectInfo.structureMainParams.extraCols = 0;

            ProjectInfo.structureMainParams.markerNames = cbxMarkerRow.Checked;
            ProjectInfo.structureMainParams.recessiveAlleles = cbxAlelesRow.Checked;
            ProjectInfo.structureMainParams.mapDistances = cbxLociDistancesRow.Checked;
            ProjectInfo.structureMainParams.phaseInfo = cbxPhase.Checked;
        }

        private void btnBack4to3_Click(object sender, EventArgs e)
        {
            gbxStep4.Visible = false;
            gbxStep3.Visible = true;
        }

        private void cbxExtraCols_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxExtraCols.Checked) numExtraCols.Enabled = true;
            else numExtraCols.Enabled = false;
        }
    }
}
