﻿using System;
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
using GenotypeDataProcessing.StructureHarvester;
using GenotypeDataProcessing.CLUMPP;

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
        public static bool structureDataLoaded = false;

        /// <summary>
        /// Default constructor of ProjectScreen
        /// </summary>
        public ProjectScreen()
        {
            InitializeComponent();
            
            this.WindowState = FormWindowState.Maximized;

            lsvStructureInputData.Width = tabControl1.Width;
            rtxStructureText.Width = tabControl1.Width / 2;

            prbJobProgressBar.Minimum = 0;
            prbJobProgressBar.Maximum = 100;

            CreateProjectDirectory();

            UpdateStructureTreeView();
            UpdateClumppTreeView();
            UpdateDistructTreeView();
        }

        /// <summary>
        /// Loads data, enables buttons, when data are loaded
        /// </summary>
        public void ExecuteWhenStructureDataLoaded()
        {
            createToolStripMenuItem1.Enabled = true;
            PopulateStructureListView();
        }

        private void PopulateStructureListView()
        {
            if (structureDataLoaded)
            {
                lsvStructureInputData.Visible = true;
                lsvStructureInputData.View = View.Details;

                lsvStructureInputData.Columns.Clear();

                if (ProjectInfo.structureInputInfo.label) lsvStructureInputData.Columns.Add("Label");
                if (ProjectInfo.structureInputInfo.popData) lsvStructureInputData.Columns.Add("Pop");
                if (ProjectInfo.structureInputInfo.popFlag) lsvStructureInputData.Columns.Add("Flag");
                if (ProjectInfo.structureInputInfo.locData) lsvStructureInputData.Columns.Add("Sample Location");
                if (ProjectInfo.structureInputInfo.phenotype) lsvStructureInputData.Columns.Add("Phenotype");

                for (int i = 1; i <= ProjectInfo.structureInputInfo.extraCols; i++)
                {
                    lsvStructureInputData.Columns.Add("Extra " + i);
                }

                for (int i = 1; i <= ProjectInfo.structureInputInfo.numLoci; i++)
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

        private void CreateProjectDirectory()
        {
            // main dir
            try
            {
                string projectDirectoryPath = ProjectInfo.projectName;

                if (!Directory.Exists(projectDirectoryPath))
                {
                    Directory.CreateDirectory(projectDirectoryPath);
                }                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //structure dir
            try
            {
                string structureDirectoryPath = Path.Combine(ProjectInfo.projectName, ProjectInfo.structureFolder);

                if (!Directory.Exists(structureDirectoryPath))
                {
                    Directory.CreateDirectory(structureDirectoryPath);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            // structure harvester dir
            try
            {
                string strucHarvesterDirectoryPath = Path.Combine(ProjectInfo.projectName, ProjectInfo.structureHarvesterFolder);

                if (!Directory.Exists(strucHarvesterDirectoryPath))
                {
                    Directory.CreateDirectory(strucHarvesterDirectoryPath);
                }     
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            // clumpp dir
            try
            {
                string clumppDirectoryPath = Path.Combine(ProjectInfo.projectName, ProjectInfo.clumppFolder);


                if (!Directory.Exists(clumppDirectoryPath))
                {
                    Directory.CreateDirectory(clumppDirectoryPath);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            // distruct dir
            try
            {
                string distructDirectoryPath = Path.Combine(ProjectInfo.projectName, ProjectInfo.distructFolder);

                if (!Directory.Exists(distructDirectoryPath))
                {
                    Directory.CreateDirectory(distructDirectoryPath);
                }          
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Updates TreeView of Structure folder
        /// </summary>
        public void UpdateStructureTreeView()
        {
            string structureFolder = Path.Combine(ProjectInfo.projectName, ProjectInfo.structureFolder);

            treeStructureFolder.Nodes.Clear();

            DirectoryInfo rootDirectoryInfo = new DirectoryInfo(structureFolder);
            treeStructureFolder.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));

            rtxStructureText.Text = "";
        }

        /// <summary>
        /// Updates TreeView of CLUMPP folder
        /// </summary>
        public void UpdateClumppTreeView()
        {
            string clumppFolder = Path.Combine(ProjectInfo.projectName, ProjectInfo.clumppFolder);

            treeClumppFolder.Nodes.Clear();

            DirectoryInfo rootDirectoryInfo = new DirectoryInfo(clumppFolder);
            treeClumppFolder.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));

            rtxClumpp.Text = "";
        }

        /// <summary>
        /// Updates TreeView of Distruct folder
        /// </summary>
        public void UpdateDistructTreeView()
        {
            string distructFolder = Path.Combine(ProjectInfo.projectName, ProjectInfo.distructFolder);

            treeDistructFolder.Nodes.Clear();

            DirectoryInfo rootDirectoryInfo = new DirectoryInfo(distructFolder);
            treeDistructFolder.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));

            rtxDistruct.Text = "";
        }
        
        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            return directoryNode;
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
            FormLoadStructureData formLoadStructureData = new FormLoadStructureData(this);
            formLoadStructureData.ShowDialog();
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormStructureParameterSet formStructureParameterSet = new FormStructureParameterSet(this, FormStructureParameterSetState.NEW);
            formStructureParameterSet.ShowDialog();

            if (ProjectInfo.structureParamSets.Count > 0)
            {
                deleteToolStripMenuItem.Enabled = true;
                updateToolStripMenuItem.Enabled = true;
                btnStartAnalysisStr.Enabled = true;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectParamSet formSelectParamSet = new FormSelectParamSet(this);
            formSelectParamSet.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeleteParamSet formDeleteParamSet = new FormDeleteParamSet(this);
            formDeleteParamSet.ShowDialog();

            if (ProjectInfo.structureParamSets.Count == 0)
            {
                deleteToolStripMenuItem.Enabled = false;
                updateToolStripMenuItem.Enabled = false;
            }
        }

        private void treeStructureFolder_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = Path.Combine(ProjectInfo.projectName, e.Node.FullPath);

            try
            {
                if ((e.Node.Nodes.Count == 0) && ((e.Node.Text + ".") != ProjectInfo.structureDataCopyName))
                    rtxStructureText.Text = File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string path = Path.Combine(ProjectInfo.projectName, ProjectInfo.structureFolder);

            FormStructureJobSettings formStructureJobSettings = new FormStructureJobSettings();
            formStructureJobSettings.ShowDialog();

            string selectedParamSet = formStructureJobSettings.GetSelectedParamSet();

            if (selectedParamSet != "")
            {
                btnStartAnalysisStr.Enabled = false;

                prbJobProgressBar.Visible = true;
                prbJobProgressBar.Value = 0;

                lblStructureJobLabel.Visible = true;

                StructureJob structureJob = new StructureJob(this, 
                                                            selectedParamSet, 
                                                            path, 
                                                            ProjectInfo.structureJobInfo[selectedParamSet].startingK,
                                                            ProjectInfo.structureJobInfo[selectedParamSet].endingK,
                                                            ProjectInfo.structureJobInfo[selectedParamSet].iterations);
                structureJob.BatchRunExecute();
            }
        }

        /// <summary>
        /// Method to change Project Screen's progress bar for Structure job
        /// </summary>
        /// <param name="add">integer to add to progress bar</param>
        public void ChangeStructureJobProgress(int add)
        {
            StructureProgressBarAdd(add);

            IsStructureJobDone();
        }

        private void StructureProgressBarAdd(int add)
        {
            int newProgressValue = prbJobProgressBar.Value + add;
            if (newProgressValue > prbJobProgressBar.Maximum)
                SafeChangeStructureProgressBar(prbJobProgressBar.Maximum);
            else
                SafeChangeStructureProgressBar(newProgressValue);
        }

        private delegate void SafeCallDelegate(int newValue);

        private void SafeChangeStructureProgressBar(int newValue)
        {
            if (prbJobProgressBar.InvokeRequired)
            {
                var d = new SafeCallDelegate(SafeChangeStructureProgressBar);
                prbJobProgressBar.Invoke(d, new object[] { newValue });
            }
            else
            {
                prbJobProgressBar.Value = newValue;
            }
        }

        private void IsStructureJobDone()
        {
            if (prbJobProgressBar.Value == prbJobProgressBar.Maximum)
            {
                btnStartAnalysisStr.Enabled = true;
                lblStructureJobLabel.Visible = false;

                MessageBox.Show(
                    "Structure job done!",
                    "Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                UpdateStructureTreeView();
            }
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

        private void btnChooseArchive_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();

            if (fbd.SelectedPath != "")
            {
                txtStructureHarvesterArchive.Text = fbd.SelectedPath;

                btnStartAnalysisStrHv.Enabled = true;
            }
        }

        private void btnStartAnalysisStrHv_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(ProjectInfo.projectName, ProjectInfo.structureHarvesterFolder);

            StructureHarvesterDataHandle structureHarvesterDataHandle = new StructureHarvesterDataHandle(txtStructureHarvesterArchive.Text, path);

            structureHarvesterDataHandle.StartJob();

            if (structureHarvesterDataHandle.IsStructureHarvesterJobDone())
            {

            }
        }

        // ******* CLUMPP TAB ******* //

        private void paramfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClumppParams formClumppParams = new FormClumppParams(this);
            formClumppParams.ShowDialog();

        }

        private void treeClumppFolder_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = Path.Combine(ProjectInfo.projectName, e.Node.FullPath);

            try
            {
                if (e.Node.Nodes.Count == 0)
                    rtxClumpp.Text = File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ******* distruct ******* //

        private void drawparamsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDistructParams formDistructParams = new FormDistructParams(this);
            formDistructParams.ShowDialog();
        }

        private void treeDistructFolder_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = Path.Combine(ProjectInfo.projectName, e.Node.FullPath);

            try
            {
                if (e.Node.Nodes.Count == 0)
                    rtxDistruct.Text = File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
