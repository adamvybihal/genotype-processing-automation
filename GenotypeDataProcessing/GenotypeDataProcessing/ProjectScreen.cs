using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenotypeDataProcessing.Programs;
using GenotypeDataProcessing.DataHandle;

namespace GenotypeDataProcessing
{
    public partial class ProjectScreen : Form
    {
        private const bool lbl = true;
        private const bool location = true;
        private const int individuals = 200;
        private const int ploidy = 2;
        private const int loci = 6;

        public ProjectScreen()
        {
            InitializeComponent();

            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            lsvStructureInputData.View = View.Details;
            lsvStructureInputData.Columns.Add("Label");
            lsvStructureInputData.Columns.Add("Location");
            lsvStructureInputData.Columns.Add("Locus");
        }

        private void structureParameterFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStructureMainParams formDataParams = new FormStructureMainParams();
            formDataParams.ShowDialog();
        }

        // ******* Structure TAB ******* //

        private void btnChooseStructureFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();

            if (fileDialog.FileName != "")
            {
                txtStructureDataFile.Text = fileDialog.FileName;

                cbxPerformStructureHarvesterStr.Enabled = true;
            }
        }

        private void cbxPerformStructureHarvesterStr_CheckedChanged(object sender, EventArgs e)
        {
            cbxPerformCLUMPPStr.Enabled = cbxPerformStructureHarvesterStr.Checked;
            if (!cbxPerformStructureHarvesterStr.Checked) cbxPerformCLUMPPStr.Checked = false;
        }

        private void cbxPerformCLUMPPStr_CheckedChanged(object sender, EventArgs e)
        {
            cbxPerformDistructStr.Enabled = cbxPerformCLUMPPStr.Checked;
            if (!cbxPerformCLUMPPStr.Checked) cbxPerformDistructStr.Checked = false;
        }

        private void btnStartAnalysisStr_Click(object sender, EventArgs e)
        {
            ; ;
        }

        // ******* Structure Harvester TAB ******* //

        private void llblStructureHarvesterWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://taylor0.biology.ucla.edu/structureHarvester/");
        }

        private void cbxCLUMPPStrHv_CheckedChanged(object sender, EventArgs e)
        {
            cbxDistructStrHv.Enabled = cbxCLUMPPStrHv.Checked;
            if (!cbxCLUMPPStrHv.Checked) cbxDistructStrHv.Checked = false;
        }

        // ******* CLUMPP TAB ******* //

        // ******* distruct ******* //
    }
}
