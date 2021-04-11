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
using GenotypeDataProcessing.StructureHarvester;
using GenotypeDataProcessing.CLUMPP;
using GenotypeDataProcessing.distruct;
using DansCSharpLibrary.Serialization;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace GenotypeDataProcessing
{
    /// <summary>
    /// Form containing main info and visualising data of project
    /// </summary>
    public partial class ProjectScreen : Form
    {
        /// <summary>
        /// Default constructor of ProjectScreen
        /// </summary>
        public ProjectScreen()
        {
            InitializeComponent();
            
            this.WindowState = FormWindowState.Maximized;

            lsvStructureInputData.Width = tabControl1.Width;
            rtxStructureText.Width = tabControl1.Width / 2;

            ProjectInfo.projectNamePath = "testProject"; // todo - later delete

            prbJobProgressBar.Minimum = 0;
            prbJobProgressBar.Maximum = 100;

            CreateProjectDirectory();

            UpdateStructureTreeView();
            UpdateClumppTreeView();
            UpdateDistructTreeView();
        }

        /// <summary>
        /// Constructor of ProjectScreen, when loading old project
        /// </summary>
        public ProjectScreen(string projectName)
        {
            InitializeComponent();

            CreateDirectoryForProjects();

            this.WindowState = FormWindowState.Maximized;

            lsvStructureInputData.Width = tabControl1.Width;
            rtxStructureText.Width = tabControl1.Width / 2;
            rtxStructureHarvesterText.Width = tabControl1.Width;

            ProjectInfo.projectName = projectName;
            ProjectInfo.projectNamePath = "projects\\" + projectName;
            LoadProjectData(ProjectInfo.projectNamePath);

            prbJobProgressBar.Minimum = 0;
            prbJobProgressBar.Maximum = 100;

            CreateProjectDirectory();

            UpdateStructureTreeView();
            UpdateClumppTreeView();
            UpdateDistructTreeView();
            UpdateStructureHarvesterTreeView();
        }

        private void CreateDirectoryForProjects()
        {
            try
            {
                string projectDirectoryPath = "projects";

                if (!Directory.Exists(projectDirectoryPath))
                {
                    Directory.CreateDirectory(projectDirectoryPath);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void LoadProjectData(string projectName)
        {
            string projectPath = Path.Combine(projectName);
            string structureDataInfoPath = Path.Combine(projectPath, ProjectInfo.structureInputInfoFile);
            string structureParamSetsPath = Path.Combine(projectPath, ProjectInfo.structureParamSetsFile);
            string structureJobInfoPath = Path.Combine(projectPath, ProjectInfo.structureJobInfoFile);

            // load structure data
            if (File.Exists(structureDataInfoPath))
            {
                try
                {
                    ProjectInfo.structureInputData = BinarySerialization.ReadFromBinaryFile<StructureInputData>(
                    structureDataInfoPath);
                    ProjectInfo.structureInputInfo = ProjectInfo.structureInputData.GetStructureInputInfo();
                }
                catch(Exception e)
                {
                    MessageBox.Show(
                        e.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            // load structure param sets
            if (File.Exists(structureParamSetsPath))
            {
                try
                {
                    ProjectInfo.structureParamSets = BinarySerialization.ReadFromBinaryFile<Dictionary<string,StructureParamSetStruct>>(
                    structureParamSetsPath);
                }
                catch (Exception e)
                {
                    MessageBox.Show(
                        e.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            // load structure job infos
            if (File.Exists(structureJobInfoPath))
            {
                try
                {
                    ProjectInfo.structureJobInfo = BinarySerialization.ReadFromBinaryFile<Dictionary<string, StructureJobInfoStruct>>(
                    structureJobInfoPath);
                }
                catch (Exception e)
                {
                    MessageBox.Show(
                        e.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            if (ProjectInfo.structureInputData.DataLoadedSuccesfully()) ExecuteWhenStructureDataLoaded();
            if (ProjectInfo.structureParamSets.Count > 0)
            {
                deleteToolStripMenuItem.Enabled = true;
                updateToolStripMenuItem.Enabled = true;
                btnStartAnalysisStr.Enabled = true;
            }
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

        private void CreateProjectDirectory()
        {
            // main dir
            try
            {
                string projectDirectoryPath = ProjectInfo.projectNamePath;

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
                string structureDirectoryPath = Path.Combine(ProjectInfo.projectNamePath, ProjectInfo.structureFolder);

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
                string strucHarvesterDirectoryPath = Path.Combine(ProjectInfo.projectNamePath, ProjectInfo.structureHarvesterFolder);

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
                string clumppDirectoryPath = Path.Combine(ProjectInfo.projectNamePath, ProjectInfo.clumppFolder);


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
                string distructDirectoryPath = Path.Combine(ProjectInfo.projectNamePath, ProjectInfo.distructFolder);

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
            string structureFolder = Path.Combine(ProjectInfo.projectNamePath, ProjectInfo.structureFolder);

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
            string clumppFolder = Path.Combine(ProjectInfo.projectNamePath, ProjectInfo.clumppFolder);

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
            string distructFolder = Path.Combine(ProjectInfo.projectNamePath, ProjectInfo.distructFolder);

            treeDistructFolder.Nodes.Clear();

            DirectoryInfo rootDirectoryInfo = new DirectoryInfo(distructFolder);
            treeDistructFolder.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));

            rtxDistruct.Text = "";
        }

        /// <summary>
        /// Updates TreeView of StructureHarvester folder
        /// </summary>
        public void UpdateStructureHarvesterTreeView()
        {
            string structureHarvesterFolder = Path.Combine(ProjectInfo.projectNamePath, ProjectInfo.structureHarvesterFolder);

            treeStructureHarvesterFolder.Nodes.Clear();

            DirectoryInfo rootDirectoryInfo = new DirectoryInfo(structureHarvesterFolder);
            treeStructureHarvesterFolder.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));

            rtxStructureHarvesterText.Text = "";
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
            FormSelectParamSet formSelectParamSet = new FormSelectParamSet(this, FormSelectParamSetState.UPDATE_SET);
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
            string path = Path.Combine(ProjectInfo.projectNamePath, e.Node.FullPath);

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
            string path = Path.Combine(ProjectInfo.projectNamePath, ProjectInfo.structureFolder);

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

        private delegate void SafeCallDelegateProgressBar(int newValue);

        private void SafeChangeStructureProgressBar(int newValue)
        {
            if (prbJobProgressBar.InvokeRequired)
            {
                var d = new SafeCallDelegateProgressBar(SafeChangeStructureProgressBar);
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
            //FolderBrowserDialog fbd = new FolderBrowserDialog();
            //fbd.ShowDialog();

            //if (fbd.SelectedPath != "")
            //{
            //    txtStructureHarvesterArchive.Text = fbd.SelectedPath;

            //    btnStartAnalysisStrHv.Enabled = true;
            //}
            if (ProjectInfo.structureJobInfo.Count > 0)
            {
                FormSelectParamSet formSelectParamSet = new FormSelectParamSet(this,
                                                            FormSelectParamSetState.SELECT_COMPLETED_SET_FOR_HARVESTER);
                formSelectParamSet.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are no completed Structure jobs, Structure Harvester could continue with.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }      
        }

        /// <summary>
        /// Set Text property of txtStructureHarvesterArchive to name of selected parameter set
        /// </summary>
        /// <param name="paramSet">selected Structure parameter set with job done</param>
        public void SetSelectedStructureResults(string paramSet)
        {
            SafeChangeStructureHarvesterArchiveText(paramSet);

            btnStartAnalysisStrHv.Enabled = true;
        }

        private delegate void SafeCallDelegateTextbox(string newText);

        private void SafeChangeStructureHarvesterArchiveText(string newText)
        {
            if (txtStructureHarvesterArchive.InvokeRequired)
            {
                var t = new SafeCallDelegateTextbox(SafeChangeStructureHarvesterArchiveText);
                txtStructureHarvesterArchive.Invoke(t, new object[] { newText });
            }
            else
            {
                txtStructureHarvesterArchive.Text = newText;
            }
        }

        private void btnStartAnalysisStrHv_Click(object sender, EventArgs e)
        {
            string paramSetResultsPath = Path.Combine(
                                            ProjectInfo.projectNamePath, 
                                            ProjectInfo.structureFolder,
                                            txtStructureHarvesterArchive.Text,
                                            "results"
                                            );
            string harvesterResultsPath = Path.Combine(
                                              ProjectInfo.projectNamePath,
                                              ProjectInfo.structureHarvesterFolder,
                                              txtStructureHarvesterArchive.Text
                                              );

            StructureHarvesterDataHandle structureHarvesterDataHandle = new StructureHarvesterDataHandle(
                                                                this,
                                                                Path.Combine(paramSetResultsPath),
                                                                Path.Combine(harvesterResultsPath));
            structureHarvesterDataHandle.AsyncRun();

            btnStartAnalysisStrHv.Enabled = false;
        }

        /// <summary>
        /// Refresh Structure Harvester tab after a job is done 
        /// </summary>
        public void ExecuteAfterStructureHarvesterJobDone()
        {
            btnStartAnalysisStrHv.Enabled = true;
            UpdateStructureHarvesterTreeView();
        }

        private void treeStructureHarvesterFolder_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string path = Path.Combine(ProjectInfo.projectNamePath, e.Node.FullPath);

            try
            {
                if (e.Node.Nodes.Count == 0)
                    rtxStructureHarvesterText.Text = File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string path = Path.Combine(ProjectInfo.projectNamePath, e.Node.FullPath);

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
            string path = Path.Combine(ProjectInfo.projectNamePath, e.Node.FullPath);

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

        // ******* closing project ******* //

        private void ProjectScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            string projectPath = Path.Combine(ProjectInfo.projectNamePath);

            BinarySerialization.WriteToBinaryFile<StructureInputData>(
                projectPath + "/" + ProjectInfo.structureInputInfoFile, 
                ProjectInfo.structureInputData);
            BinarySerialization.WriteToBinaryFile<Dictionary<string, StructureParamSetStruct>>(
                projectPath + "/" + ProjectInfo.structureParamSetsFile,
                ProjectInfo.structureParamSets);
            BinarySerialization.WriteToBinaryFile<Dictionary<string, StructureJobInfoStruct>>(
                projectPath + "/" + ProjectInfo.structureJobInfoFile,
                ProjectInfo.structureJobInfo);
        }

        
    }
}
