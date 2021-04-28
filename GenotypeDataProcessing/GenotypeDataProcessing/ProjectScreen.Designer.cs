
namespace GenotypeDataProcessing
{
    partial class ProjectScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartAnalysisStr = new System.Windows.Forms.Button();
            this.mnsMainMenu = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStructure = new System.Windows.Forms.TabPage();
            this.lblStructureJobLabel = new System.Windows.Forms.Label();
            this.prbJobProgressBar = new System.Windows.Forms.ProgressBar();
            this.rtxStructureText = new System.Windows.Forms.RichTextBox();
            this.treeStructureFolder = new System.Windows.Forms.TreeView();
            this.lsvStructureInputData = new System.Windows.Forms.ListView();
            this.mnsStructure = new System.Windows.Forms.MenuStrip();
            this.dataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parameterSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabStructureHarvester = new System.Windows.Forms.TabPage();
            this.rtxStructureHarvesterText = new System.Windows.Forms.RichTextBox();
            this.treeStructureHarvesterFolder = new System.Windows.Forms.TreeView();
            this.llblStructureHarvesterWeb = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartAnalysisStrHv = new System.Windows.Forms.Button();
            this.btnChooseArchive = new System.Windows.Forms.Button();
            this.txtStructureHarvesterArchive = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabCLUMPP = new System.Windows.Forms.TabPage();
            this.treeClumppFolder = new System.Windows.Forms.TreeView();
            this.rtxClumpp = new System.Windows.Forms.RichTextBox();
            this.btnStartAnalysisCLUMPP = new System.Windows.Forms.Button();
            this.lblClumppRun = new System.Windows.Forms.Label();
            this.mnsClumpp = new System.Windows.Forms.MenuStrip();
            this.paramfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabDistruct = new System.Windows.Forms.TabPage();
            this.lblDistructRun = new System.Windows.Forms.Label();
            this.treeDistructFolder = new System.Windows.Forms.TreeView();
            this.rtxDistruct = new System.Windows.Forms.RichTextBox();
            this.btnStartAnalysisDistruct = new System.Windows.Forms.Button();
            this.mnsDistruct = new System.Windows.Forms.MenuStrip();
            this.drawparamsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.createeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConvert = new System.Windows.Forms.Button();
            this.mnsMainMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabStructure.SuspendLayout();
            this.mnsStructure.SuspendLayout();
            this.tabStructureHarvester.SuspendLayout();
            this.tabCLUMPP.SuspendLayout();
            this.mnsClumpp.SuspendLayout();
            this.tabDistruct.SuspendLayout();
            this.mnsDistruct.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartAnalysisStr
            // 
            this.btnStartAnalysisStr.Enabled = false;
            this.btnStartAnalysisStr.Location = new System.Drawing.Point(71, 291);
            this.btnStartAnalysisStr.Name = "btnStartAnalysisStr";
            this.btnStartAnalysisStr.Size = new System.Drawing.Size(160, 38);
            this.btnStartAnalysisStr.TabIndex = 2;
            this.btnStartAnalysisStr.Text = "Start a Job";
            this.btnStartAnalysisStr.UseVisualStyleBackColor = true;
            this.btnStartAnalysisStr.Click += new System.EventHandler(this.btnStartAnalysisStr_Click);
            // 
            // mnsMainMenu
            // 
            this.mnsMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem});
            this.mnsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMainMenu.Name = "mnsMainMenu";
            this.mnsMainMenu.Size = new System.Drawing.Size(1037, 28);
            this.mnsMainMenu.TabIndex = 3;
            this.mnsMainMenu.Text = "menuStrip1";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeProjectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.closeProjectToolStripMenuItem.Text = "Close Project";
            this.closeProjectToolStripMenuItem.Click += new System.EventHandler(this.closeProjectToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStructure);
            this.tabControl1.Controls.Add(this.tabStructureHarvester);
            this.tabControl1.Controls.Add(this.tabCLUMPP);
            this.tabControl1.Controls.Add(this.tabDistruct);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1037, 598);
            this.tabControl1.TabIndex = 9;
            // 
            // tabStructure
            // 
            this.tabStructure.AutoScroll = true;
            this.tabStructure.BackColor = System.Drawing.SystemColors.Control;
            this.tabStructure.Controls.Add(this.lblStructureJobLabel);
            this.tabStructure.Controls.Add(this.prbJobProgressBar);
            this.tabStructure.Controls.Add(this.rtxStructureText);
            this.tabStructure.Controls.Add(this.treeStructureFolder);
            this.tabStructure.Controls.Add(this.lsvStructureInputData);
            this.tabStructure.Controls.Add(this.btnStartAnalysisStr);
            this.tabStructure.Controls.Add(this.mnsStructure);
            this.tabStructure.Location = new System.Drawing.Point(4, 25);
            this.tabStructure.Name = "tabStructure";
            this.tabStructure.Padding = new System.Windows.Forms.Padding(3);
            this.tabStructure.Size = new System.Drawing.Size(1029, 569);
            this.tabStructure.TabIndex = 0;
            this.tabStructure.Text = "Structure";
            // 
            // lblStructureJobLabel
            // 
            this.lblStructureJobLabel.AutoSize = true;
            this.lblStructureJobLabel.Location = new System.Drawing.Point(71, 366);
            this.lblStructureJobLabel.Name = "lblStructureJobLabel";
            this.lblStructureJobLabel.Size = new System.Drawing.Size(146, 17);
            this.lblStructureJobLabel.TabIndex = 20;
            this.lblStructureJobLabel.Text = "structure is running ...";
            this.lblStructureJobLabel.Visible = false;
            // 
            // prbJobProgressBar
            // 
            this.prbJobProgressBar.Location = new System.Drawing.Point(71, 336);
            this.prbJobProgressBar.Name = "prbJobProgressBar";
            this.prbJobProgressBar.Size = new System.Drawing.Size(160, 23);
            this.prbJobProgressBar.TabIndex = 19;
            this.prbJobProgressBar.Visible = false;
            // 
            // rtxStructureText
            // 
            this.rtxStructureText.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtxStructureText.Location = new System.Drawing.Point(370, 31);
            this.rtxStructureText.Name = "rtxStructureText";
            this.rtxStructureText.ReadOnly = true;
            this.rtxStructureText.Size = new System.Drawing.Size(335, 535);
            this.rtxStructureText.TabIndex = 18;
            this.rtxStructureText.Text = "";
            // 
            // treeStructureFolder
            // 
            this.treeStructureFolder.Location = new System.Drawing.Point(39, 45);
            this.treeStructureFolder.Name = "treeStructureFolder";
            this.treeStructureFolder.Size = new System.Drawing.Size(234, 230);
            this.treeStructureFolder.TabIndex = 17;
            this.treeStructureFolder.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeStructureFolder_NodeMouseDoubleClick);
            // 
            // lsvStructureInputData
            // 
            this.lsvStructureInputData.Dock = System.Windows.Forms.DockStyle.Right;
            this.lsvStructureInputData.HideSelection = false;
            this.lsvStructureInputData.Location = new System.Drawing.Point(705, 31);
            this.lsvStructureInputData.Name = "lsvStructureInputData";
            this.lsvStructureInputData.Size = new System.Drawing.Size(321, 535);
            this.lsvStructureInputData.TabIndex = 14;
            this.lsvStructureInputData.UseCompatibleStateImageBehavior = false;
            // 
            // mnsStructure
            // 
            this.mnsStructure.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsStructure.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataFileToolStripMenuItem,
            this.parameterSetToolStripMenuItem});
            this.mnsStructure.Location = new System.Drawing.Point(3, 3);
            this.mnsStructure.Name = "mnsStructure";
            this.mnsStructure.Size = new System.Drawing.Size(1023, 28);
            this.mnsStructure.TabIndex = 13;
            this.mnsStructure.Text = "menuStrip2";
            // 
            // dataFileToolStripMenuItem
            // 
            this.dataFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.dataFileToolStripMenuItem.Name = "dataFileToolStripMenuItem";
            this.dataFileToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.dataFileToolStripMenuItem.Text = "Data File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.loadToolStripMenuItem.Text = "Load ...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // parameterSetToolStripMenuItem
            // 
            this.parameterSetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.parameterSetToolStripMenuItem.Name = "parameterSetToolStripMenuItem";
            this.parameterSetToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.parameterSetToolStripMenuItem.Text = "Parameter Set";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Enabled = false;
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.createToolStripMenuItem1.Text = "Create ...";
            this.createToolStripMenuItem1.Click += new System.EventHandler(this.createToolStripMenuItem1_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Enabled = false;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.updateToolStripMenuItem.Text = "Update ...";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.deleteToolStripMenuItem.Text = "Delete ...";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tabStructureHarvester
            // 
            this.tabStructureHarvester.BackColor = System.Drawing.SystemColors.Control;
            this.tabStructureHarvester.Controls.Add(this.rtxStructureHarvesterText);
            this.tabStructureHarvester.Controls.Add(this.treeStructureHarvesterFolder);
            this.tabStructureHarvester.Controls.Add(this.llblStructureHarvesterWeb);
            this.tabStructureHarvester.Controls.Add(this.label4);
            this.tabStructureHarvester.Controls.Add(this.label3);
            this.tabStructureHarvester.Controls.Add(this.btnStartAnalysisStrHv);
            this.tabStructureHarvester.Controls.Add(this.btnChooseArchive);
            this.tabStructureHarvester.Controls.Add(this.txtStructureHarvesterArchive);
            this.tabStructureHarvester.Controls.Add(this.label2);
            this.tabStructureHarvester.Location = new System.Drawing.Point(4, 25);
            this.tabStructureHarvester.Name = "tabStructureHarvester";
            this.tabStructureHarvester.Padding = new System.Windows.Forms.Padding(3);
            this.tabStructureHarvester.Size = new System.Drawing.Size(1029, 569);
            this.tabStructureHarvester.TabIndex = 1;
            this.tabStructureHarvester.Text = "Structure Harvester";
            // 
            // rtxStructureHarvesterText
            // 
            this.rtxStructureHarvesterText.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtxStructureHarvesterText.Location = new System.Drawing.Point(567, 3);
            this.rtxStructureHarvesterText.Name = "rtxStructureHarvesterText";
            this.rtxStructureHarvesterText.ReadOnly = true;
            this.rtxStructureHarvesterText.Size = new System.Drawing.Size(459, 563);
            this.rtxStructureHarvesterText.TabIndex = 18;
            this.rtxStructureHarvesterText.Text = "";
            // 
            // treeStructureHarvesterFolder
            // 
            this.treeStructureHarvesterFolder.Location = new System.Drawing.Point(347, 6);
            this.treeStructureHarvesterFolder.Name = "treeStructureHarvesterFolder";
            this.treeStructureHarvesterFolder.Size = new System.Drawing.Size(214, 251);
            this.treeStructureHarvesterFolder.TabIndex = 17;
            this.treeStructureHarvesterFolder.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeStructureHarvesterFolder_NodeMouseDoubleClick);
            // 
            // llblStructureHarvesterWeb
            // 
            this.llblStructureHarvesterWeb.AutoSize = true;
            this.llblStructureHarvesterWeb.Location = new System.Drawing.Point(384, 491);
            this.llblStructureHarvesterWeb.Name = "llblStructureHarvesterWeb";
            this.llblStructureHarvesterWeb.Size = new System.Drawing.Size(132, 17);
            this.llblStructureHarvesterWeb.TabIndex = 16;
            this.llblStructureHarvesterWeb.TabStop = true;
            this.llblStructureHarvesterWeb.Text = "Structure Harvester";
            this.llblStructureHarvesterWeb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblStructureHarvesterWeb_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "In case you don\'t have Python, use web version via link:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Analysis with Structure Harvester requires Python installed on your PC.";
            // 
            // btnStartAnalysisStrHv
            // 
            this.btnStartAnalysisStrHv.Enabled = false;
            this.btnStartAnalysisStrHv.Location = new System.Drawing.Point(104, 132);
            this.btnStartAnalysisStrHv.Name = "btnStartAnalysisStrHv";
            this.btnStartAnalysisStrHv.Size = new System.Drawing.Size(160, 38);
            this.btnStartAnalysisStrHv.TabIndex = 13;
            this.btnStartAnalysisStrHv.Text = "Start a Job";
            this.btnStartAnalysisStrHv.UseVisualStyleBackColor = true;
            this.btnStartAnalysisStrHv.Click += new System.EventHandler(this.btnStartAnalysisStrHv_Click);
            // 
            // btnChooseArchive
            // 
            this.btnChooseArchive.Location = new System.Drawing.Point(130, 88);
            this.btnChooseArchive.Name = "btnChooseArchive";
            this.btnChooseArchive.Size = new System.Drawing.Size(107, 23);
            this.btnChooseArchive.TabIndex = 12;
            this.btnChooseArchive.Text = "Choose";
            this.btnChooseArchive.UseVisualStyleBackColor = true;
            this.btnChooseArchive.Click += new System.EventHandler(this.btnChooseArchive_Click);
            // 
            // txtStructureHarvesterArchive
            // 
            this.txtStructureHarvesterArchive.Location = new System.Drawing.Point(40, 60);
            this.txtStructureHarvesterArchive.Name = "txtStructureHarvesterArchive";
            this.txtStructureHarvesterArchive.ReadOnly = true;
            this.txtStructureHarvesterArchive.Size = new System.Drawing.Size(288, 22);
            this.txtStructureHarvesterArchive.TabIndex = 11;
            this.txtStructureHarvesterArchive.Text = "choose results ...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select a Structure parameter set with results:";
            // 
            // tabCLUMPP
            // 
            this.tabCLUMPP.BackColor = System.Drawing.SystemColors.Control;
            this.tabCLUMPP.Controls.Add(this.treeClumppFolder);
            this.tabCLUMPP.Controls.Add(this.rtxClumpp);
            this.tabCLUMPP.Controls.Add(this.btnStartAnalysisCLUMPP);
            this.tabCLUMPP.Controls.Add(this.lblClumppRun);
            this.tabCLUMPP.Controls.Add(this.mnsClumpp);
            this.tabCLUMPP.Location = new System.Drawing.Point(4, 25);
            this.tabCLUMPP.Name = "tabCLUMPP";
            this.tabCLUMPP.Padding = new System.Windows.Forms.Padding(3);
            this.tabCLUMPP.Size = new System.Drawing.Size(1029, 569);
            this.tabCLUMPP.TabIndex = 2;
            this.tabCLUMPP.Text = "CLUMPP";
            // 
            // treeClumppFolder
            // 
            this.treeClumppFolder.Location = new System.Drawing.Point(200, 46);
            this.treeClumppFolder.Name = "treeClumppFolder";
            this.treeClumppFolder.Size = new System.Drawing.Size(188, 223);
            this.treeClumppFolder.TabIndex = 23;
            this.treeClumppFolder.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeClumppFolder_NodeMouseDoubleClick);
            // 
            // rtxClumpp
            // 
            this.rtxClumpp.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtxClumpp.Location = new System.Drawing.Point(558, 31);
            this.rtxClumpp.Name = "rtxClumpp";
            this.rtxClumpp.ReadOnly = true;
            this.rtxClumpp.Size = new System.Drawing.Size(468, 535);
            this.rtxClumpp.TabIndex = 22;
            this.rtxClumpp.Text = "";
            // 
            // btnStartAnalysisCLUMPP
            // 
            this.btnStartAnalysisCLUMPP.Location = new System.Drawing.Point(168, 295);
            this.btnStartAnalysisCLUMPP.Name = "btnStartAnalysisCLUMPP";
            this.btnStartAnalysisCLUMPP.Size = new System.Drawing.Size(160, 38);
            this.btnStartAnalysisCLUMPP.TabIndex = 20;
            this.btnStartAnalysisCLUMPP.Text = "Start a Job";
            this.btnStartAnalysisCLUMPP.UseVisualStyleBackColor = true;
            this.btnStartAnalysisCLUMPP.Click += new System.EventHandler(this.btnStartAnalysisCLUMPP_Click);
            // 
            // lblClumppRun
            // 
            this.lblClumppRun.AutoSize = true;
            this.lblClumppRun.Location = new System.Drawing.Point(184, 347);
            this.lblClumppRun.Name = "lblClumppRun";
            this.lblClumppRun.Size = new System.Drawing.Size(135, 17);
            this.lblClumppRun.TabIndex = 19;
            this.lblClumppRun.Text = "clumpp is running ...";
            this.lblClumppRun.Visible = false;
            // 
            // mnsClumpp
            // 
            this.mnsClumpp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsClumpp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramfilesToolStripMenuItem});
            this.mnsClumpp.Location = new System.Drawing.Point(3, 3);
            this.mnsClumpp.Name = "mnsClumpp";
            this.mnsClumpp.Size = new System.Drawing.Size(1023, 28);
            this.mnsClumpp.TabIndex = 21;
            this.mnsClumpp.Text = "menuStrip1";
            // 
            // paramfilesToolStripMenuItem
            // 
            this.paramfilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creToolStripMenuItem,
            this.updateToolStripMenuItem1});
            this.paramfilesToolStripMenuItem.Name = "paramfilesToolStripMenuItem";
            this.paramfilesToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.paramfilesToolStripMenuItem.Text = "Paramfiles";
            // 
            // creToolStripMenuItem
            // 
            this.creToolStripMenuItem.Name = "creToolStripMenuItem";
            this.creToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.creToolStripMenuItem.Text = "Create ...";
            this.creToolStripMenuItem.Click += new System.EventHandler(this.paramfilesToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(148, 26);
            this.updateToolStripMenuItem1.Text = "Update";
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.updateToolStripMenuItem1_Click);
            // 
            // tabDistruct
            // 
            this.tabDistruct.BackColor = System.Drawing.SystemColors.Control;
            this.tabDistruct.Controls.Add(this.btnConvert);
            this.tabDistruct.Controls.Add(this.lblDistructRun);
            this.tabDistruct.Controls.Add(this.treeDistructFolder);
            this.tabDistruct.Controls.Add(this.rtxDistruct);
            this.tabDistruct.Controls.Add(this.btnStartAnalysisDistruct);
            this.tabDistruct.Controls.Add(this.mnsDistruct);
            this.tabDistruct.Location = new System.Drawing.Point(4, 25);
            this.tabDistruct.Name = "tabDistruct";
            this.tabDistruct.Padding = new System.Windows.Forms.Padding(3);
            this.tabDistruct.Size = new System.Drawing.Size(1029, 569);
            this.tabDistruct.TabIndex = 3;
            this.tabDistruct.Text = "distruct";
            // 
            // lblDistructRun
            // 
            this.lblDistructRun.AutoSize = true;
            this.lblDistructRun.Location = new System.Drawing.Point(203, 320);
            this.lblDistructRun.Name = "lblDistructRun";
            this.lblDistructRun.Size = new System.Drawing.Size(136, 17);
            this.lblDistructRun.TabIndex = 28;
            this.lblDistructRun.Text = "distruct is running ...";
            this.lblDistructRun.Visible = false;
            // 
            // treeDistructFolder
            // 
            this.treeDistructFolder.Location = new System.Drawing.Point(206, 44);
            this.treeDistructFolder.Name = "treeDistructFolder";
            this.treeDistructFolder.Size = new System.Drawing.Size(180, 187);
            this.treeDistructFolder.TabIndex = 27;
            this.treeDistructFolder.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeDistructFolder_NodeMouseDoubleClick);
            // 
            // rtxDistruct
            // 
            this.rtxDistruct.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtxDistruct.Location = new System.Drawing.Point(563, 31);
            this.rtxDistruct.Name = "rtxDistruct";
            this.rtxDistruct.ReadOnly = true;
            this.rtxDistruct.Size = new System.Drawing.Size(463, 535);
            this.rtxDistruct.TabIndex = 26;
            this.rtxDistruct.Text = "";
            // 
            // btnStartAnalysisDistruct
            // 
            this.btnStartAnalysisDistruct.Location = new System.Drawing.Point(173, 262);
            this.btnStartAnalysisDistruct.Name = "btnStartAnalysisDistruct";
            this.btnStartAnalysisDistruct.Size = new System.Drawing.Size(160, 38);
            this.btnStartAnalysisDistruct.TabIndex = 24;
            this.btnStartAnalysisDistruct.Text = "Start a Job";
            this.btnStartAnalysisDistruct.UseVisualStyleBackColor = true;
            this.btnStartAnalysisDistruct.Click += new System.EventHandler(this.btnStartAnalysisDistruct_Click);
            // 
            // mnsDistruct
            // 
            this.mnsDistruct.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsDistruct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawparamsToolStripMenuItem2});
            this.mnsDistruct.Location = new System.Drawing.Point(3, 3);
            this.mnsDistruct.Name = "mnsDistruct";
            this.mnsDistruct.Size = new System.Drawing.Size(1023, 28);
            this.mnsDistruct.TabIndex = 25;
            this.mnsDistruct.Text = "menuStrip1";
            // 
            // drawparamsToolStripMenuItem2
            // 
            this.drawparamsToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createeToolStripMenuItem,
            this.updateToolStripMenuItem2});
            this.drawparamsToolStripMenuItem2.Name = "drawparamsToolStripMenuItem2";
            this.drawparamsToolStripMenuItem2.Size = new System.Drawing.Size(107, 24);
            this.drawparamsToolStripMenuItem2.Text = "Drawparams";
            // 
            // createeToolStripMenuItem
            // 
            this.createeToolStripMenuItem.Name = "createeToolStripMenuItem";
            this.createeToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.createeToolStripMenuItem.Text = "Create ...";
            this.createeToolStripMenuItem.Click += new System.EventHandler(this.drawparamsToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem2
            // 
            this.updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
            this.updateToolStripMenuItem2.Size = new System.Drawing.Size(148, 26);
            this.updateToolStripMenuItem2.Text = "Update";
            this.updateToolStripMenuItem2.Click += new System.EventHandler(this.updateToolStripMenuItem2_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(229, 460);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(141, 23);
            this.btnConvert.TabIndex = 29;
            this.btnConvert.Text = "Convert .ps to .pdf";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // ProjectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1037, 626);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mnsMainMenu);
            this.MainMenuStrip = this.mnsMainMenu;
            this.Name = "ProjectScreen";
            this.Text = "Genotype Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectScreen_FormClosing);
            this.mnsMainMenu.ResumeLayout(false);
            this.mnsMainMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabStructure.ResumeLayout(false);
            this.tabStructure.PerformLayout();
            this.mnsStructure.ResumeLayout(false);
            this.mnsStructure.PerformLayout();
            this.tabStructureHarvester.ResumeLayout(false);
            this.tabStructureHarvester.PerformLayout();
            this.tabCLUMPP.ResumeLayout(false);
            this.tabCLUMPP.PerformLayout();
            this.mnsClumpp.ResumeLayout(false);
            this.mnsClumpp.PerformLayout();
            this.tabDistruct.ResumeLayout(false);
            this.tabDistruct.PerformLayout();
            this.mnsDistruct.ResumeLayout(false);
            this.mnsDistruct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStartAnalysisStr;
        private System.Windows.Forms.MenuStrip mnsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStructure;
        private System.Windows.Forms.TabPage tabStructureHarvester;
        private System.Windows.Forms.TabPage tabCLUMPP;
        private System.Windows.Forms.TabPage tabDistruct;
        private System.Windows.Forms.Button btnChooseArchive;
        private System.Windows.Forms.TextBox txtStructureHarvesterArchive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartAnalysisStrHv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llblStructureHarvesterWeb;
        private System.Windows.Forms.Label lblClumppRun;
        private System.Windows.Forms.Button btnStartAnalysisCLUMPP;
        private System.Windows.Forms.Button btnStartAnalysisDistruct;
        private System.Windows.Forms.MenuStrip mnsStructure;
        private System.Windows.Forms.ListView lsvStructureInputData;
        private System.Windows.Forms.ToolStripMenuItem dataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parameterSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TreeView treeStructureFolder;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtxStructureText;
        private System.Windows.Forms.MenuStrip mnsClumpp;
        private System.Windows.Forms.ToolStripMenuItem paramfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnsDistruct;
        private System.Windows.Forms.ToolStripMenuItem drawparamsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem createeToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtxClumpp;
        private System.Windows.Forms.RichTextBox rtxDistruct;
        private System.Windows.Forms.TreeView treeClumppFolder;
        private System.Windows.Forms.TreeView treeDistructFolder;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ProgressBar prbJobProgressBar;
        private System.Windows.Forms.Label lblStructureJobLabel;
        private System.Windows.Forms.RichTextBox rtxStructureHarvesterText;
        private System.Windows.Forms.TreeView treeStructureHarvesterFolder;
        private System.Windows.Forms.Label lblDistructRun;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem2;
        private System.Windows.Forms.Button btnConvert;
    }
}

