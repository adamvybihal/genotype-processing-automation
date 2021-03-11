
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
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.structureParameterFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLUMPPParameterFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distructParameterFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStructureDataFile = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxPerformDistructStr = new System.Windows.Forms.CheckBox();
            this.cbxPerformCLUMPPStr = new System.Windows.Forms.CheckBox();
            this.cbxPerformStructureHarvesterStr = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStructure = new System.Windows.Forms.TabPage();
            this.lsvStructureInputData = new System.Windows.Forms.ListView();
            this.lblStructureParamfileStatus = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnChooseStructureFile = new System.Windows.Forms.Button();
            this.mnsStructure = new System.Windows.Forms.MenuStrip();
            this.tabStructureHarvester = new System.Windows.Forms.TabPage();
            this.llblStructureHarvesterWeb = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartAnalysisStrHv = new System.Windows.Forms.Button();
            this.btnChooseArchive = new System.Windows.Forms.Button();
            this.txtStructureHarvesterArchive = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxDistructStrHv = new System.Windows.Forms.CheckBox();
            this.cbxCLUMPPStrHv = new System.Windows.Forms.CheckBox();
            this.tabCLUMPP = new System.Windows.Forms.TabPage();
            this.lblCLUMPPParamfileStatus = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnStartAnalysisCLUMPP = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChoosePopulationsFile = new System.Windows.Forms.Button();
            this.txtPopulationsFile = new System.Windows.Forms.TextBox();
            this.btnChooseIndividualsFile = new System.Windows.Forms.Button();
            this.txtIndividualsFile = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxDistructClmp = new System.Windows.Forms.CheckBox();
            this.tabDistruct = new System.Windows.Forms.TabPage();
            this.lblDistructParamfileStatus = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnStartAnalysisDistruct = new System.Windows.Forms.Button();
            this.btnChooseIndivFile = new System.Windows.Forms.Button();
            this.txtIndivFile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChoosePopFile = new System.Windows.Forms.Button();
            this.txtPopFile = new System.Windows.Forms.TextBox();
            this.dataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parameterSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMainMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabStructure.SuspendLayout();
            this.mnsStructure.SuspendLayout();
            this.tabStructureHarvester.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabCLUMPP.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabDistruct.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartAnalysisStr
            // 
            this.btnStartAnalysisStr.Enabled = false;
            this.btnStartAnalysisStr.Location = new System.Drawing.Point(194, 240);
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
            this.projectToolStripMenuItem,
            this.createToolStripMenuItem,
            this.helpToolStripMenuItem});
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
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.structureParameterFileToolStripMenuItem,
            this.cLUMPPParameterFileToolStripMenuItem,
            this.distructParameterFileToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // structureParameterFileToolStripMenuItem
            // 
            this.structureParameterFileToolStripMenuItem.Name = "structureParameterFileToolStripMenuItem";
            this.structureParameterFileToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.structureParameterFileToolStripMenuItem.Text = "Structure Parameter File(s)";
            this.structureParameterFileToolStripMenuItem.Click += new System.EventHandler(this.structureParameterFileToolStripMenuItem_Click);
            // 
            // cLUMPPParameterFileToolStripMenuItem
            // 
            this.cLUMPPParameterFileToolStripMenuItem.Name = "cLUMPPParameterFileToolStripMenuItem";
            this.cLUMPPParameterFileToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.cLUMPPParameterFileToolStripMenuItem.Text = "CLUMPP Parameter File";
            // 
            // distructParameterFileToolStripMenuItem
            // 
            this.distructParameterFileToolStripMenuItem.Name = "distructParameterFileToolStripMenuItem";
            this.distructParameterFileToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.distructParameterFileToolStripMenuItem.Text = "distruct Parameter File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Input Data File";
            // 
            // txtStructureDataFile
            // 
            this.txtStructureDataFile.Location = new System.Drawing.Point(81, 53);
            this.txtStructureDataFile.Name = "txtStructureDataFile";
            this.txtStructureDataFile.ReadOnly = true;
            this.txtStructureDataFile.Size = new System.Drawing.Size(273, 22);
            this.txtStructureDataFile.TabIndex = 5;
            this.txtStructureDataFile.Text = "choose file ...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxPerformDistructStr);
            this.groupBox1.Controls.Add(this.cbxPerformCLUMPPStr);
            this.groupBox1.Controls.Add(this.cbxPerformStructureHarvesterStr);
            this.groupBox1.Location = new System.Drawing.Point(59, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 136);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Continue with:";
            // 
            // cbxPerformDistructStr
            // 
            this.cbxPerformDistructStr.AutoSize = true;
            this.cbxPerformDistructStr.Enabled = false;
            this.cbxPerformDistructStr.Location = new System.Drawing.Point(141, 86);
            this.cbxPerformDistructStr.Name = "cbxPerformDistructStr";
            this.cbxPerformDistructStr.Size = new System.Drawing.Size(76, 21);
            this.cbxPerformDistructStr.TabIndex = 3;
            this.cbxPerformDistructStr.Text = "distruct";
            this.cbxPerformDistructStr.UseVisualStyleBackColor = true;
            // 
            // cbxPerformCLUMPPStr
            // 
            this.cbxPerformCLUMPPStr.AutoSize = true;
            this.cbxPerformCLUMPPStr.Enabled = false;
            this.cbxPerformCLUMPPStr.Location = new System.Drawing.Point(141, 59);
            this.cbxPerformCLUMPPStr.Name = "cbxPerformCLUMPPStr";
            this.cbxPerformCLUMPPStr.Size = new System.Drawing.Size(86, 21);
            this.cbxPerformCLUMPPStr.TabIndex = 2;
            this.cbxPerformCLUMPPStr.Text = "CLUMPP";
            this.cbxPerformCLUMPPStr.UseVisualStyleBackColor = true;
            this.cbxPerformCLUMPPStr.CheckedChanged += new System.EventHandler(this.cbxPerformCLUMPPStr_CheckedChanged);
            // 
            // cbxPerformStructureHarvesterStr
            // 
            this.cbxPerformStructureHarvesterStr.AutoSize = true;
            this.cbxPerformStructureHarvesterStr.Enabled = false;
            this.cbxPerformStructureHarvesterStr.Location = new System.Drawing.Point(141, 32);
            this.cbxPerformStructureHarvesterStr.Name = "cbxPerformStructureHarvesterStr";
            this.cbxPerformStructureHarvesterStr.Size = new System.Drawing.Size(154, 21);
            this.cbxPerformStructureHarvesterStr.TabIndex = 1;
            this.cbxPerformStructureHarvesterStr.Text = "Structure Harvester";
            this.cbxPerformStructureHarvesterStr.UseVisualStyleBackColor = true;
            this.cbxPerformStructureHarvesterStr.CheckedChanged += new System.EventHandler(this.cbxPerformStructureHarvesterStr_CheckedChanged);
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
            this.tabControl1.Size = new System.Drawing.Size(1037, 491);
            this.tabControl1.TabIndex = 9;
            // 
            // tabStructure
            // 
            this.tabStructure.AutoScroll = true;
            this.tabStructure.BackColor = System.Drawing.SystemColors.Control;
            this.tabStructure.Controls.Add(this.lsvStructureInputData);
            this.tabStructure.Controls.Add(this.lblStructureParamfileStatus);
            this.tabStructure.Controls.Add(this.label11);
            this.tabStructure.Controls.Add(this.btnChooseStructureFile);
            this.tabStructure.Controls.Add(this.btnStartAnalysisStr);
            this.tabStructure.Controls.Add(this.groupBox1);
            this.tabStructure.Controls.Add(this.txtStructureDataFile);
            this.tabStructure.Controls.Add(this.label1);
            this.tabStructure.Controls.Add(this.mnsStructure);
            this.tabStructure.Location = new System.Drawing.Point(4, 25);
            this.tabStructure.Name = "tabStructure";
            this.tabStructure.Padding = new System.Windows.Forms.Padding(3);
            this.tabStructure.Size = new System.Drawing.Size(1029, 462);
            this.tabStructure.TabIndex = 0;
            this.tabStructure.Text = "Structure";
            // 
            // lsvStructureInputData
            // 
            this.lsvStructureInputData.HideSelection = false;
            this.lsvStructureInputData.Location = new System.Drawing.Point(520, 81);
            this.lsvStructureInputData.Name = "lsvStructureInputData";
            this.lsvStructureInputData.Size = new System.Drawing.Size(445, 266);
            this.lsvStructureInputData.TabIndex = 14;
            this.lsvStructureInputData.UseCompatibleStateImageBehavior = false;
            // 
            // lblStructureParamfileStatus
            // 
            this.lblStructureParamfileStatus.AutoSize = true;
            this.lblStructureParamfileStatus.Location = new System.Drawing.Point(312, 220);
            this.lblStructureParamfileStatus.Name = "lblStructureParamfileStatus";
            this.lblStructureParamfileStatus.Size = new System.Drawing.Size(54, 17);
            this.lblStructureParamfileStatus.TabIndex = 11;
            this.lblStructureParamfileStatus.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(157, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Parameter File Status:";
            // 
            // btnChooseStructureFile
            // 
            this.btnChooseStructureFile.Location = new System.Drawing.Point(370, 52);
            this.btnChooseStructureFile.Name = "btnChooseStructureFile";
            this.btnChooseStructureFile.Size = new System.Drawing.Size(107, 23);
            this.btnChooseStructureFile.TabIndex = 9;
            this.btnChooseStructureFile.Text = "Choose File";
            this.btnChooseStructureFile.UseVisualStyleBackColor = true;
            this.btnChooseStructureFile.Click += new System.EventHandler(this.btnChooseStructureFile_Click);
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
            // tabStructureHarvester
            // 
            this.tabStructureHarvester.BackColor = System.Drawing.SystemColors.Control;
            this.tabStructureHarvester.Controls.Add(this.llblStructureHarvesterWeb);
            this.tabStructureHarvester.Controls.Add(this.label4);
            this.tabStructureHarvester.Controls.Add(this.label3);
            this.tabStructureHarvester.Controls.Add(this.btnStartAnalysisStrHv);
            this.tabStructureHarvester.Controls.Add(this.btnChooseArchive);
            this.tabStructureHarvester.Controls.Add(this.txtStructureHarvesterArchive);
            this.tabStructureHarvester.Controls.Add(this.label2);
            this.tabStructureHarvester.Controls.Add(this.groupBox2);
            this.tabStructureHarvester.Location = new System.Drawing.Point(4, 25);
            this.tabStructureHarvester.Name = "tabStructureHarvester";
            this.tabStructureHarvester.Padding = new System.Windows.Forms.Padding(3);
            this.tabStructureHarvester.Size = new System.Drawing.Size(1029, 462);
            this.tabStructureHarvester.TabIndex = 1;
            this.tabStructureHarvester.Text = "Structure Harvester";
            // 
            // llblStructureHarvesterWeb
            // 
            this.llblStructureHarvesterWeb.AutoSize = true;
            this.llblStructureHarvesterWeb.Location = new System.Drawing.Point(387, 315);
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
            this.label4.Location = new System.Drawing.Point(22, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "In case you don\'t have Python, use web version via link:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(454, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Analysis with Structure Harvester requires Python installed on your PC.";
            // 
            // btnStartAnalysisStrHv
            // 
            this.btnStartAnalysisStrHv.Enabled = false;
            this.btnStartAnalysisStrHv.Location = new System.Drawing.Point(185, 211);
            this.btnStartAnalysisStrHv.Name = "btnStartAnalysisStrHv";
            this.btnStartAnalysisStrHv.Size = new System.Drawing.Size(160, 38);
            this.btnStartAnalysisStrHv.TabIndex = 13;
            this.btnStartAnalysisStrHv.Text = "Start Analysis";
            this.btnStartAnalysisStrHv.UseVisualStyleBackColor = true;
            // 
            // btnChooseArchive
            // 
            this.btnChooseArchive.Location = new System.Drawing.Point(375, 53);
            this.btnChooseArchive.Name = "btnChooseArchive";
            this.btnChooseArchive.Size = new System.Drawing.Size(107, 23);
            this.btnChooseArchive.TabIndex = 12;
            this.btnChooseArchive.Text = "Choose File";
            this.btnChooseArchive.UseVisualStyleBackColor = true;
            // 
            // txtStructureHarvesterArchive
            // 
            this.txtStructureHarvesterArchive.Location = new System.Drawing.Point(86, 53);
            this.txtStructureHarvesterArchive.Name = "txtStructureHarvesterArchive";
            this.txtStructureHarvesterArchive.ReadOnly = true;
            this.txtStructureHarvesterArchive.Size = new System.Drawing.Size(273, 22);
            this.txtStructureHarvesterArchive.TabIndex = 11;
            this.txtStructureHarvesterArchive.Text = "choose file ...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select .zip Archive";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxDistructStrHv);
            this.groupBox2.Controls.Add(this.cbxCLUMPPStrHv);
            this.groupBox2.Location = new System.Drawing.Point(64, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 107);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Continue analysis with:";
            // 
            // cbxDistructStrHv
            // 
            this.cbxDistructStrHv.AutoSize = true;
            this.cbxDistructStrHv.Enabled = false;
            this.cbxDistructStrHv.Location = new System.Drawing.Point(143, 61);
            this.cbxDistructStrHv.Name = "cbxDistructStrHv";
            this.cbxDistructStrHv.Size = new System.Drawing.Size(76, 21);
            this.cbxDistructStrHv.TabIndex = 3;
            this.cbxDistructStrHv.Text = "distruct";
            this.cbxDistructStrHv.UseVisualStyleBackColor = true;
            // 
            // cbxCLUMPPStrHv
            // 
            this.cbxCLUMPPStrHv.AutoSize = true;
            this.cbxCLUMPPStrHv.Enabled = false;
            this.cbxCLUMPPStrHv.Location = new System.Drawing.Point(143, 34);
            this.cbxCLUMPPStrHv.Name = "cbxCLUMPPStrHv";
            this.cbxCLUMPPStrHv.Size = new System.Drawing.Size(86, 21);
            this.cbxCLUMPPStrHv.TabIndex = 2;
            this.cbxCLUMPPStrHv.Text = "CLUMPP";
            this.cbxCLUMPPStrHv.UseVisualStyleBackColor = true;
            this.cbxCLUMPPStrHv.CheckedChanged += new System.EventHandler(this.cbxCLUMPPStrHv_CheckedChanged);
            // 
            // tabCLUMPP
            // 
            this.tabCLUMPP.BackColor = System.Drawing.SystemColors.Control;
            this.tabCLUMPP.Controls.Add(this.lblCLUMPPParamfileStatus);
            this.tabCLUMPP.Controls.Add(this.label16);
            this.tabCLUMPP.Controls.Add(this.btnStartAnalysisCLUMPP);
            this.tabCLUMPP.Controls.Add(this.label7);
            this.tabCLUMPP.Controls.Add(this.label6);
            this.tabCLUMPP.Controls.Add(this.label5);
            this.tabCLUMPP.Controls.Add(this.btnChoosePopulationsFile);
            this.tabCLUMPP.Controls.Add(this.txtPopulationsFile);
            this.tabCLUMPP.Controls.Add(this.btnChooseIndividualsFile);
            this.tabCLUMPP.Controls.Add(this.txtIndividualsFile);
            this.tabCLUMPP.Controls.Add(this.groupBox3);
            this.tabCLUMPP.Location = new System.Drawing.Point(4, 25);
            this.tabCLUMPP.Name = "tabCLUMPP";
            this.tabCLUMPP.Padding = new System.Windows.Forms.Padding(3);
            this.tabCLUMPP.Size = new System.Drawing.Size(1029, 462);
            this.tabCLUMPP.TabIndex = 2;
            this.tabCLUMPP.Text = "CLUMPP";
            // 
            // lblCLUMPPParamfileStatus
            // 
            this.lblCLUMPPParamfileStatus.AutoSize = true;
            this.lblCLUMPPParamfileStatus.Location = new System.Drawing.Point(311, 253);
            this.lblCLUMPPParamfileStatus.Name = "lblCLUMPPParamfileStatus";
            this.lblCLUMPPParamfileStatus.Size = new System.Drawing.Size(54, 17);
            this.lblCLUMPPParamfileStatus.TabIndex = 22;
            this.lblCLUMPPParamfileStatus.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(156, 253);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "Parameter File Status:";
            // 
            // btnStartAnalysisCLUMPP
            // 
            this.btnStartAnalysisCLUMPP.Enabled = false;
            this.btnStartAnalysisCLUMPP.Location = new System.Drawing.Point(186, 273);
            this.btnStartAnalysisCLUMPP.Name = "btnStartAnalysisCLUMPP";
            this.btnStartAnalysisCLUMPP.Size = new System.Drawing.Size(160, 38);
            this.btnStartAnalysisCLUMPP.TabIndex = 20;
            this.btnStartAnalysisCLUMPP.Text = "Start Analysis";
            this.btnStartAnalysisCLUMPP.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "* select at least one data file";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Select Population Data File* ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Select Individual Data File* ";
            // 
            // btnChoosePopulationsFile
            // 
            this.btnChoosePopulationsFile.Location = new System.Drawing.Point(364, 115);
            this.btnChoosePopulationsFile.Name = "btnChoosePopulationsFile";
            this.btnChoosePopulationsFile.Size = new System.Drawing.Size(107, 23);
            this.btnChoosePopulationsFile.TabIndex = 16;
            this.btnChoosePopulationsFile.Text = "Choose File";
            this.btnChoosePopulationsFile.UseVisualStyleBackColor = true;
            // 
            // txtPopulationsFile
            // 
            this.txtPopulationsFile.Location = new System.Drawing.Point(75, 115);
            this.txtPopulationsFile.Name = "txtPopulationsFile";
            this.txtPopulationsFile.ReadOnly = true;
            this.txtPopulationsFile.Size = new System.Drawing.Size(273, 22);
            this.txtPopulationsFile.TabIndex = 15;
            this.txtPopulationsFile.Text = "choose file ...";
            // 
            // btnChooseIndividualsFile
            // 
            this.btnChooseIndividualsFile.Location = new System.Drawing.Point(364, 53);
            this.btnChooseIndividualsFile.Name = "btnChooseIndividualsFile";
            this.btnChooseIndividualsFile.Size = new System.Drawing.Size(107, 23);
            this.btnChooseIndividualsFile.TabIndex = 14;
            this.btnChooseIndividualsFile.Text = "Choose File";
            this.btnChooseIndividualsFile.UseVisualStyleBackColor = true;
            // 
            // txtIndividualsFile
            // 
            this.txtIndividualsFile.Location = new System.Drawing.Point(75, 53);
            this.txtIndividualsFile.Name = "txtIndividualsFile";
            this.txtIndividualsFile.ReadOnly = true;
            this.txtIndividualsFile.Size = new System.Drawing.Size(273, 22);
            this.txtIndividualsFile.TabIndex = 13;
            this.txtIndividualsFile.Text = "choose file ...";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbxDistructClmp);
            this.groupBox3.Location = new System.Drawing.Point(64, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 107);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Continue analysis with:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 61);
            this.label10.MaximumSize = new System.Drawing.Size(300, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(293, 34);
            this.label10.TabIndex = 21;
            this.label10.Text = "subsequent distruct run available, only if you run CLUMPP analysis of population " +
    "data file";
            // 
            // cbxDistructClmp
            // 
            this.cbxDistructClmp.AutoSize = true;
            this.cbxDistructClmp.Enabled = false;
            this.cbxDistructClmp.Location = new System.Drawing.Point(155, 37);
            this.cbxDistructClmp.Name = "cbxDistructClmp";
            this.cbxDistructClmp.Size = new System.Drawing.Size(76, 21);
            this.cbxDistructClmp.TabIndex = 3;
            this.cbxDistructClmp.Text = "distruct";
            this.cbxDistructClmp.UseVisualStyleBackColor = true;
            // 
            // tabDistruct
            // 
            this.tabDistruct.BackColor = System.Drawing.SystemColors.Control;
            this.tabDistruct.Controls.Add(this.lblDistructParamfileStatus);
            this.tabDistruct.Controls.Add(this.label18);
            this.tabDistruct.Controls.Add(this.btnStartAnalysisDistruct);
            this.tabDistruct.Controls.Add(this.btnChooseIndivFile);
            this.tabDistruct.Controls.Add(this.txtIndivFile);
            this.tabDistruct.Controls.Add(this.label9);
            this.tabDistruct.Controls.Add(this.label8);
            this.tabDistruct.Controls.Add(this.btnChoosePopFile);
            this.tabDistruct.Controls.Add(this.txtPopFile);
            this.tabDistruct.Location = new System.Drawing.Point(4, 25);
            this.tabDistruct.Name = "tabDistruct";
            this.tabDistruct.Padding = new System.Windows.Forms.Padding(3);
            this.tabDistruct.Size = new System.Drawing.Size(1029, 462);
            this.tabDistruct.TabIndex = 3;
            this.tabDistruct.Text = "distruct";
            // 
            // lblDistructParamfileStatus
            // 
            this.lblDistructParamfileStatus.AutoSize = true;
            this.lblDistructParamfileStatus.Location = new System.Drawing.Point(323, 161);
            this.lblDistructParamfileStatus.Name = "lblDistructParamfileStatus";
            this.lblDistructParamfileStatus.Size = new System.Drawing.Size(54, 17);
            this.lblDistructParamfileStatus.TabIndex = 26;
            this.lblDistructParamfileStatus.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(168, 161);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(148, 17);
            this.label18.TabIndex = 25;
            this.label18.Text = "Parameter File Status:";
            // 
            // btnStartAnalysisDistruct
            // 
            this.btnStartAnalysisDistruct.Enabled = false;
            this.btnStartAnalysisDistruct.Location = new System.Drawing.Point(195, 192);
            this.btnStartAnalysisDistruct.Name = "btnStartAnalysisDistruct";
            this.btnStartAnalysisDistruct.Size = new System.Drawing.Size(160, 38);
            this.btnStartAnalysisDistruct.TabIndex = 24;
            this.btnStartAnalysisDistruct.Text = "Start Analysis";
            this.btnStartAnalysisDistruct.UseVisualStyleBackColor = true;
            // 
            // btnChooseIndivFile
            // 
            this.btnChooseIndivFile.Location = new System.Drawing.Point(361, 115);
            this.btnChooseIndivFile.Name = "btnChooseIndivFile";
            this.btnChooseIndivFile.Size = new System.Drawing.Size(107, 23);
            this.btnChooseIndivFile.TabIndex = 23;
            this.btnChooseIndivFile.Text = "Choose File";
            this.btnChooseIndivFile.UseVisualStyleBackColor = true;
            // 
            // txtIndivFile
            // 
            this.txtIndivFile.Location = new System.Drawing.Point(72, 115);
            this.txtIndivFile.Name = "txtIndivFile";
            this.txtIndivFile.ReadOnly = true;
            this.txtIndivFile.Size = new System.Drawing.Size(273, 22);
            this.txtIndivFile.TabIndex = 22;
            this.txtIndivFile.Text = "choose file ...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(323, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Select Input File of Population Q-Matrix (required) ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(308, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Select Input File of Individual Q-Matrix (optional)";
            // 
            // btnChoosePopFile
            // 
            this.btnChoosePopFile.Location = new System.Drawing.Point(361, 53);
            this.btnChoosePopFile.Name = "btnChoosePopFile";
            this.btnChoosePopFile.Size = new System.Drawing.Size(107, 23);
            this.btnChoosePopFile.TabIndex = 19;
            this.btnChoosePopFile.Text = "Choose File";
            this.btnChoosePopFile.UseVisualStyleBackColor = true;
            // 
            // txtPopFile
            // 
            this.txtPopFile.Location = new System.Drawing.Point(72, 53);
            this.txtPopFile.Name = "txtPopFile";
            this.txtPopFile.ReadOnly = true;
            this.txtPopFile.Size = new System.Drawing.Size(273, 22);
            this.txtPopFile.TabIndex = 18;
            this.txtPopFile.Text = "choose file ...";
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
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadToolStripMenuItem.Text = "Load ...";
            // 
            // parameterSetToolStripMenuItem
            // 
            this.parameterSetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1});
            this.parameterSetToolStripMenuItem.Name = "parameterSetToolStripMenuItem";
            this.parameterSetToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.parameterSetToolStripMenuItem.Text = "Parameter Set";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.createToolStripMenuItem1.Text = "Create ...";
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeProjectToolStripMenuItem.Text = "Close Project";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // ProjectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1037, 519);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.mnsMainMenu);
            this.MainMenuStrip = this.mnsMainMenu;
            this.Name = "ProjectScreen";
            this.Text = "Genotype Data";
            this.mnsMainMenu.ResumeLayout(false);
            this.mnsMainMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabStructure.ResumeLayout(false);
            this.tabStructure.PerformLayout();
            this.mnsStructure.ResumeLayout(false);
            this.mnsStructure.PerformLayout();
            this.tabStructureHarvester.ResumeLayout(false);
            this.tabStructureHarvester.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabCLUMPP.ResumeLayout(false);
            this.tabCLUMPP.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabDistruct.ResumeLayout(false);
            this.tabDistruct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStartAnalysisStr;
        private System.Windows.Forms.MenuStrip mnsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem structureParameterFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLUMPPParameterFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distructParameterFileToolStripMenuItem;
        private System.Windows.Forms.TextBox txtStructureDataFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxPerformDistructStr;
        private System.Windows.Forms.CheckBox cbxPerformCLUMPPStr;
        private System.Windows.Forms.CheckBox cbxPerformStructureHarvesterStr;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStructure;
        private System.Windows.Forms.TabPage tabStructureHarvester;
        private System.Windows.Forms.Button btnChooseStructureFile;
        private System.Windows.Forms.TabPage tabCLUMPP;
        private System.Windows.Forms.TabPage tabDistruct;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbxDistructStrHv;
        private System.Windows.Forms.CheckBox cbxCLUMPPStrHv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbxDistructClmp;
        private System.Windows.Forms.Button btnChooseArchive;
        private System.Windows.Forms.TextBox txtStructureHarvesterArchive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartAnalysisStrHv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel llblStructureHarvesterWeb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChoosePopulationsFile;
        private System.Windows.Forms.TextBox txtPopulationsFile;
        private System.Windows.Forms.Button btnChooseIndividualsFile;
        private System.Windows.Forms.TextBox txtIndividualsFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStartAnalysisCLUMPP;
        private System.Windows.Forms.Button btnChooseIndivFile;
        private System.Windows.Forms.TextBox txtIndivFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChoosePopFile;
        private System.Windows.Forms.TextBox txtPopFile;
        private System.Windows.Forms.Button btnStartAnalysisDistruct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblStructureParamfileStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCLUMPPParamfileStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblDistructParamfileStatus;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MenuStrip mnsStructure;
        private System.Windows.Forms.ListView lsvStructureInputData;
        private System.Windows.Forms.ToolStripMenuItem dataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parameterSetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

