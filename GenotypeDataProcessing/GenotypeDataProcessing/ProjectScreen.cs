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
using GenotypeDataProcessing.Programs;
using GenotypeDataProcessing.Structure;

namespace GenotypeDataProcessing
{
    /// <summary>
    /// Form containing main info and visualising data of project
    /// </summary>
    public partial class ProjectScreen : Form
    {
        /// <summary>
        /// Indicates whether Structure input data were loaded succesfully
        /// </summary>
        public static bool canShowStructureData = false;

        private const bool lbl = true;
        private const bool location = true;
        private const int individuals = 200;
        private const int ploidy = 2;
        private const int loci = 6;

        /// <summary>
        /// Default constructor of ProjectScreen
        /// </summary>
        public ProjectScreen()
        {
            InitializeComponent();
            
            this.WindowState = FormWindowState.Maximized;

            lsvStructureInputData.Width = tabControl1.Width;
            lsvStructureInputData.Visible = false;

            CreateProjectDirectory();
        }

        private void CreateProjectDirectory()
        {
            try
            {
                string structureDirectoryPath = ProjectInfo.projectName;

                if (Directory.Exists(structureDirectoryPath))
                {
                    return;
                }

                Directory.CreateDirectory(structureDirectoryPath);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // ******* main menu ******* //

        private void closeProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // todo
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ******* Structure TAB ******* //

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoadStructureData formLoadStructureData = new FormLoadStructureData();
            formLoadStructureData.ShowDialog();
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

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (canShowStructureData)
            {
                lsvStructureInputData.Visible = true;
                lsvStructureInputData.View = View.Details;

                // populate - listview (todo-later make a function!)
                if (ProjectInfo.structureMainParams.label) lsvStructureInputData.Columns.Add("Label");
                if (ProjectInfo.structureMainParams.popData) lsvStructureInputData.Columns.Add("Pop");
                if (ProjectInfo.structureMainParams.popFlag) lsvStructureInputData.Columns.Add("Flag");
                if (ProjectInfo.structureMainParams.locData) lsvStructureInputData.Columns.Add("Sample Location");
                if (ProjectInfo.structureMainParams.phenotype) lsvStructureInputData.Columns.Add("Phenotype");

                for (int i = 1; i <= ProjectInfo.structureMainParams.extraCols; i++)
                {
                    lsvStructureInputData.Columns.Add("Extra " + i);
                }

                for (int i = 1; i <= ProjectInfo.structureMainParams.numLoci; i++)
                {
                    lsvStructureInputData.Columns.Add("Locus " + i);
                }

                string[,] data = ProjectInfo.structureInputData.GetStructureData();

                int maxRow = data.GetUpperBound(0);
                int maxCol = data.GetUpperBound(1);
                for (int row = 0; row <= maxRow; row++)
                {
                    ListViewItem newItem = lsvStructureInputData.Items.Add(data[row, 0]);
                    for (int col = 1; col <= maxCol; col++)
                    {
                        newItem.SubItems.Add(data[row, col]);
                    }
                }
            }
            else
            {
                MessageBox.Show("No valid data loaded");
            }
        }

        private void btnStartAnalysisStr_Click(object sender, EventArgs e)
        {
            // todo - ask user for K range + iterations over one K
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
