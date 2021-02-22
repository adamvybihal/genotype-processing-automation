
namespace GenotypeDataProcessing
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnChooseStructureFile = new System.Windows.Forms.Button();
            this.tabStructureHarvester = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxDistructStrHv = new System.Windows.Forms.CheckBox();
            this.cbxCLUMPPStrHv = new System.Windows.Forms.CheckBox();
            this.tabCLUMPP = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxDistructClmp = new System.Windows.Forms.CheckBox();
            this.tabDistruct = new System.Windows.Forms.TabPage();
            this.btnChooseArchive = new System.Windows.Forms.Button();
            this.txtStructureHarvesterArchive = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartAnalysisStrHv = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.llblStructureHarvesterWeb = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStartAnalysisCLUMPP = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnStartAnalysisDistruct = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabStructure.SuspendLayout();
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
            this.btnStartAnalysisStr.Location = new System.Drawing.Point(194, 236);
            this.btnStartAnalysisStr.Name = "btnStartAnalysisStr";
            this.btnStartAnalysisStr.Size = new System.Drawing.Size(160, 38);
            this.btnStartAnalysisStr.TabIndex = 2;
            this.btnStartAnalysisStr.Text = "Start Analysis";
            this.btnStartAnalysisStr.UseVisualStyleBackColor = true;
            this.btnStartAnalysisStr.Click += new System.EventHandler(this.btnStartAnalysisStr_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.createToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
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
            this.label1.Location = new System.Drawing.Point(197, 19);
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
            this.groupBox1.Text = "Continue analysis with:";
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
            this.cbxPerformCLUMPPStr.CheckedChanged += new System.EventHandler(this.cbxPerformCLUMPP_CheckedChanged);
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
            this.cbxPerformStructureHarvesterStr.CheckedChanged += new System.EventHandler(this.cbxPerformStructureHarvester_CheckedChanged);
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
            this.tabControl1.Size = new System.Drawing.Size(554, 388);
            this.tabControl1.TabIndex = 9;
            // 
            // tabStructure
            // 
            this.tabStructure.BackColor = System.Drawing.SystemColors.Control;
            this.tabStructure.Controls.Add(this.btnChooseStructureFile);
            this.tabStructure.Controls.Add(this.btnStartAnalysisStr);
            this.tabStructure.Controls.Add(this.groupBox1);
            this.tabStructure.Controls.Add(this.txtStructureDataFile);
            this.tabStructure.Controls.Add(this.label1);
            this.tabStructure.Location = new System.Drawing.Point(4, 25);
            this.tabStructure.Name = "tabStructure";
            this.tabStructure.Padding = new System.Windows.Forms.Padding(3);
            this.tabStructure.Size = new System.Drawing.Size(546, 359);
            this.tabStructure.TabIndex = 0;
            this.tabStructure.Text = "Structure";
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
            this.tabStructureHarvester.Size = new System.Drawing.Size(546, 359);
            this.tabStructureHarvester.TabIndex = 1;
            this.tabStructureHarvester.Text = "Structure Harvester";
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
            // 
            // tabCLUMPP
            // 
            this.tabCLUMPP.BackColor = System.Drawing.SystemColors.Control;
            this.tabCLUMPP.Controls.Add(this.btnStartAnalysisCLUMPP);
            this.tabCLUMPP.Controls.Add(this.label7);
            this.tabCLUMPP.Controls.Add(this.label6);
            this.tabCLUMPP.Controls.Add(this.label5);
            this.tabCLUMPP.Controls.Add(this.button3);
            this.tabCLUMPP.Controls.Add(this.textBox2);
            this.tabCLUMPP.Controls.Add(this.button2);
            this.tabCLUMPP.Controls.Add(this.textBox1);
            this.tabCLUMPP.Controls.Add(this.groupBox3);
            this.tabCLUMPP.Location = new System.Drawing.Point(4, 25);
            this.tabCLUMPP.Name = "tabCLUMPP";
            this.tabCLUMPP.Padding = new System.Windows.Forms.Padding(3);
            this.tabCLUMPP.Size = new System.Drawing.Size(546, 359);
            this.tabCLUMPP.TabIndex = 2;
            this.tabCLUMPP.Text = "CLUMPP";
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
            this.tabDistruct.Controls.Add(this.btnStartAnalysisDistruct);
            this.tabDistruct.Controls.Add(this.button4);
            this.tabDistruct.Controls.Add(this.textBox4);
            this.tabDistruct.Controls.Add(this.label9);
            this.tabDistruct.Controls.Add(this.label8);
            this.tabDistruct.Controls.Add(this.button1);
            this.tabDistruct.Controls.Add(this.textBox3);
            this.tabDistruct.Location = new System.Drawing.Point(4, 25);
            this.tabDistruct.Name = "tabDistruct";
            this.tabDistruct.Padding = new System.Windows.Forms.Padding(3);
            this.tabDistruct.Size = new System.Drawing.Size(546, 359);
            this.tabDistruct.TabIndex = 3;
            this.tabDistruct.Text = "distruct";
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
            // btnStartAnalysisStrHv
            // 
            this.btnStartAnalysisStrHv.Enabled = false;
            this.btnStartAnalysisStrHv.Location = new System.Drawing.Point(183, 236);
            this.btnStartAnalysisStrHv.Name = "btnStartAnalysisStrHv";
            this.btnStartAnalysisStrHv.Size = new System.Drawing.Size(160, 38);
            this.btnStartAnalysisStrHv.TabIndex = 13;
            this.btnStartAnalysisStrHv.Text = "Start Analysis";
            this.btnStartAnalysisStrHv.UseVisualStyleBackColor = true;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(359, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "In case you don\'t have Python, use web version via link:";
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Choose File";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(273, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "choose file ...";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(364, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Choose File";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(273, 22);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "choose file ...";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Select Population Data File* ";
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
            // btnStartAnalysisCLUMPP
            // 
            this.btnStartAnalysisCLUMPP.Enabled = false;
            this.btnStartAnalysisCLUMPP.Location = new System.Drawing.Point(178, 265);
            this.btnStartAnalysisCLUMPP.Name = "btnStartAnalysisCLUMPP";
            this.btnStartAnalysisCLUMPP.Size = new System.Drawing.Size(160, 38);
            this.btnStartAnalysisCLUMPP.TabIndex = 20;
            this.btnStartAnalysisCLUMPP.Text = "Start Analysis";
            this.btnStartAnalysisCLUMPP.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Choose File";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(72, 53);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(273, 22);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "choose file ...";
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(361, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Choose File";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(72, 115);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(273, 22);
            this.textBox4.TabIndex = 22;
            this.textBox4.Text = "choose file ...";
            // 
            // btnStartAnalysisDistruct
            // 
            this.btnStartAnalysisDistruct.Enabled = false;
            this.btnStartAnalysisDistruct.Location = new System.Drawing.Point(193, 160);
            this.btnStartAnalysisDistruct.Name = "btnStartAnalysisDistruct";
            this.btnStartAnalysisDistruct.Size = new System.Drawing.Size(160, 38);
            this.btnStartAnalysisDistruct.TabIndex = 24;
            this.btnStartAnalysisDistruct.Text = "Start Analysis";
            this.btnStartAnalysisDistruct.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 416);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Genotype Data Analysis";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabStructure.ResumeLayout(false);
            this.tabStructure.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnStartAnalysisCLUMPP;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnStartAnalysisDistruct;
        private System.Windows.Forms.Label label10;
    }
}

