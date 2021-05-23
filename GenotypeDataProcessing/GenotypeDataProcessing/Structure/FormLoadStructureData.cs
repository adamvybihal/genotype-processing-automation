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
        private ProjectScreen callerProjectScreen;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public FormLoadStructureData(ProjectScreen projectScreen)
        {
            InitializeComponent();

            callerProjectScreen = projectScreen;

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
            SetProjectInputInfo();

            string strucureInputCopyPath = Path.Combine(ProjectInfo.projectNamePath, ProjectInfo.structureFolder, ProjectInfo.structureDataCopyName);
            ProjectInfo.structureInputData = new StructureInputData(txtStructureDataFile.Text, strucureInputCopyPath, ProjectInfo.structureInputInfo);

            if (ProjectInfo.structureInputData.DataLoadedSuccesfully())
            {
                MessageBox.Show("Data set loaded succesfully.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //CreateProjectInfoFile();

                callerProjectScreen.ExecuteWhenStructureDataLoaded();
                callerProjectScreen.UpdateStructureTreeView();

                this.Close();
            }
            else
            {
                MessageBox.Show(ProjectInfo.structureInputData.GetErrorString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void CreateProjectInfoFile()
        //{
        //    string infoString = GetProjectInfoFileString();

        //    string filePath = Path.Combine(ProjectInfo.projectNamePath, ProjectInfo.projectName + ".myproj");

        //    try
        //    {
        //        using (FileStream fs = File.Create(filePath))
        //        {
        //            byte[] info = new UTF8Encoding(true).GetBytes(infoString);
        //            fs.Write(info, 0, info.Length);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(
        //            ex.Message,
        //            "Error",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error
        //            );
        //    }
        //}

        private string GetProjectInfoFileString()
        {
            return "NAME " + ProjectInfo.projectNamePath; // + "\n" +
                //"NUMINDS " + numIndividuals.Value + "\n" +
                //"NUMLOCI " + numLoci.Value + "\n" +
                //"PLOIDY " + numPloidy.Value + "\n" +
                //"MISSING " + numMissingDataValue.Value + "\n" +
                //"ONEROWPERIND " + StructureParamSet.ReturnLogical(cbxSingleLine.Checked) + "\n" +

                //"LABEL " + StructureParamSet.ReturnLogical(cbxIdCol.Checked) + "\n" +
                //"POPDATA " + StructureParamSet.ReturnLogical(cbxPopOriginCol.Checked) + "\n" +
                //"POPFLAG " + StructureParamSet.ReturnLogical(cbxPopInfoFlagCol.Checked) + "\n" +
                //"LOCDATA " + StructureParamSet.ReturnLogical(cbxSampleInfoCol.Checked) + "\n" +
                //"PHENOTYPE " + StructureParamSet.ReturnLogical(cbxPhenotypeCol.Checked) + "\n" +
                //"EXTRACOLS " + numExtraCols.Value + "\n" +
                //"MARKERNAMES " + StructureParamSet.ReturnLogical(cbxMarkerRow.Checked) + "\n" +
                //"RECESSIVEALLELES " + StructureParamSet.ReturnLogical(cbxAlelesRow.Checked) + "\n" +
                //"MAPDISTANCES " + StructureParamSet.ReturnLogical(cbxLociDistancesRow.Checked) + "\n" +
                //"PHASEINFO " + StructureParamSet.ReturnLogical(cbxPhase.Checked);
        }

        private void SetProjectInputInfo()
        {
            ProjectInfo.structureInputInfo.numInds = (int)numIndividuals.Value;
            ProjectInfo.structureInputInfo.numLoci = (int)numLoci.Value;
            ProjectInfo.structureInputInfo.ploidy = (int)numPloidy.Value;
            ProjectInfo.structureInputInfo.missingDataValue = (int)numMissingDataValue.Value;

            ProjectInfo.structureInputInfo.oneRowPerInd = cbxSingleLine.Checked;
            ProjectInfo.structureInputInfo.label = cbxIdCol.Checked;
            ProjectInfo.structureInputInfo.popData = cbxPopOriginCol.Checked;
            ProjectInfo.structureInputInfo.popFlag = cbxPopInfoFlagCol.Checked;
            ProjectInfo.structureInputInfo.locData = cbxSampleInfoCol.Checked;
            ProjectInfo.structureInputInfo.phenotype = cbxPhenotypeCol.Checked;

            if (cbxExtraCols.Checked) ProjectInfo.structureInputInfo.extraCols = (int)numExtraCols.Value;
            else ProjectInfo.structureInputInfo.extraCols = 0;

            ProjectInfo.structureInputInfo.markerNames = cbxMarkerRow.Checked;
            ProjectInfo.structureInputInfo.recessiveAlleles = cbxAlelesRow.Checked;
            ProjectInfo.structureInputInfo.mapDistances = cbxLociDistancesRow.Checked;
            ProjectInfo.structureInputInfo.phaseInfo = cbxPhase.Checked;
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
