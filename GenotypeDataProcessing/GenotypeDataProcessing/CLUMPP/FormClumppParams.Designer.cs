
namespace GenotypeDataProcessing
{
    /// <summary>
    /// Form for setting CLUMPP parameters
    /// </summary>
    partial class FormClumppParams
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbMethodToBeUsed = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numClusters = new System.Windows.Forms.NumericUpDown();
            this.numRuns = new System.Windows.Forms.NumericUpDown();
            this.numPopulations = new System.Windows.Forms.NumericUpDown();
            this.numIndividuals = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnChoosePermutationFile = new System.Windows.Forms.Button();
            this.txtPermutationFile = new System.Windows.Forms.TextBox();
            this.cmbGreedyOption = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numRepeats = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbxPrintRandomInputOrder = new System.Windows.Forms.CheckBox();
            this.cbxPrintEveryPerm = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPrintPermutedData = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cbxOrderByRun = new System.Windows.Forms.CheckBox();
            this.cbxOverrideWarnings = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClusters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRuns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndividuals)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeats)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(160, 271);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 31;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(263, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 256);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.cmbMethodToBeUsed);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.numClusters);
            this.tabPage1.Controls.Add(this.numRuns);
            this.tabPage1.Controls.Add(this.numPopulations);
            this.tabPage1.Controls.Add(this.numIndividuals);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(509, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main parameters";
            // 
            // cmbMethodToBeUsed
            // 
            this.cmbMethodToBeUsed.FormattingEnabled = true;
            this.cmbMethodToBeUsed.Items.AddRange(new object[] {
            "FullSearch",
            "Greedy",
            "LargeKGreedy"});
            this.cmbMethodToBeUsed.Location = new System.Drawing.Point(254, 168);
            this.cmbMethodToBeUsed.Name = "cmbMethodToBeUsed";
            this.cmbMethodToBeUsed.Size = new System.Drawing.Size(121, 24);
            this.cmbMethodToBeUsed.TabIndex = 28;
            this.cmbMethodToBeUsed.Text = "FullSearch";
            this.cmbMethodToBeUsed.SelectedIndexChanged += new System.EventHandler(this.cmbMethodToBeUsed_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Method to be used:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Number K:";
            // 
            // numClusters
            // 
            this.numClusters.Location = new System.Drawing.Point(255, 39);
            this.numClusters.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numClusters.Name = "numClusters";
            this.numClusters.Size = new System.Drawing.Size(120, 22);
            this.numClusters.TabIndex = 22;
            // 
            // numRuns
            // 
            this.numRuns.Location = new System.Drawing.Point(255, 69);
            this.numRuns.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRuns.Name = "numRuns";
            this.numRuns.Size = new System.Drawing.Size(120, 22);
            this.numRuns.TabIndex = 23;
            // 
            // numPopulations
            // 
            this.numPopulations.Location = new System.Drawing.Point(255, 126);
            this.numPopulations.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPopulations.Name = "numPopulations";
            this.numPopulations.Size = new System.Drawing.Size(120, 22);
            this.numPopulations.TabIndex = 26;
            // 
            // numIndividuals
            // 
            this.numIndividuals.Location = new System.Drawing.Point(255, 98);
            this.numIndividuals.Maximum = new decimal(new int[] {
            27000000,
            0,
            0,
            0});
            this.numIndividuals.Name = "numIndividuals";
            this.numIndividuals.Size = new System.Drawing.Size(120, 22);
            this.numIndividuals.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Number of individuals:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Number of iterations over K:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Number of populations:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.btnChoosePermutationFile);
            this.tabPage2.Controls.Add(this.txtPermutationFile);
            this.tabPage2.Controls.Add(this.cmbGreedyOption);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.numRepeats);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(509, 227);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options for algorithms";
            // 
            // btnChoosePermutationFile
            // 
            this.btnChoosePermutationFile.Enabled = false;
            this.btnChoosePermutationFile.Location = new System.Drawing.Point(291, 178);
            this.btnChoosePermutationFile.Name = "btnChoosePermutationFile";
            this.btnChoosePermutationFile.Size = new System.Drawing.Size(75, 23);
            this.btnChoosePermutationFile.TabIndex = 13;
            this.btnChoosePermutationFile.Text = "choose";
            this.btnChoosePermutationFile.UseVisualStyleBackColor = true;
            // 
            // txtPermutationFile
            // 
            this.txtPermutationFile.Location = new System.Drawing.Point(125, 178);
            this.txtPermutationFile.Name = "txtPermutationFile";
            this.txtPermutationFile.ReadOnly = true;
            this.txtPermutationFile.Size = new System.Drawing.Size(143, 22);
            this.txtPermutationFile.TabIndex = 12;
            // 
            // cmbGreedyOption
            // 
            this.cmbGreedyOption.Enabled = false;
            this.cmbGreedyOption.FormattingEnabled = true;
            this.cmbGreedyOption.Items.AddRange(new object[] {
            "all possible input orders",
            "random input orders",
            "pre-specified input orders"});
            this.cmbGreedyOption.Location = new System.Drawing.Point(144, 45);
            this.cmbGreedyOption.Name = "cmbGreedyOption";
            this.cmbGreedyOption.Size = new System.Drawing.Size(191, 24);
            this.cmbGreedyOption.TabIndex = 0;
            this.cmbGreedyOption.Text = "random input orders";
            this.cmbGreedyOption.SelectedIndexChanged += new System.EventHandler(this.cmbGreedyOption_SelectedIndexChanged);
            this.cmbGreedyOption.EnabledChanged += new System.EventHandler(this.cmbGreedyOption_EnabledChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(162, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "Choose permutation file:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(192, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Greedy option:";
            // 
            // numRepeats
            // 
            this.numRepeats.Enabled = false;
            this.numRepeats.Location = new System.Drawing.Point(214, 98);
            this.numRepeats.Maximum = new decimal(new int[] {
            27000000,
            0,
            0,
            0});
            this.numRepeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRepeats.Name = "numRepeats";
            this.numRepeats.Size = new System.Drawing.Size(120, 22);
            this.numRepeats.TabIndex = 10;
            this.numRepeats.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(146, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Repeats:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.cbxPrintRandomInputOrder);
            this.tabPage3.Controls.Add(this.cbxPrintEveryPerm);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.cmbPrintPermutedData);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(509, 227);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Optional outputs";
            // 
            // cbxPrintRandomInputOrder
            // 
            this.cbxPrintRandomInputOrder.AutoSize = true;
            this.cbxPrintRandomInputOrder.Enabled = false;
            this.cbxPrintRandomInputOrder.Location = new System.Drawing.Point(155, 158);
            this.cbxPrintRandomInputOrder.Name = "cbxPrintRandomInputOrder";
            this.cbxPrintRandomInputOrder.Size = new System.Drawing.Size(184, 21);
            this.cbxPrintRandomInputOrder.TabIndex = 3;
            this.cbxPrintRandomInputOrder.Text = "Print random input order";
            this.cbxPrintRandomInputOrder.UseVisualStyleBackColor = true;
            // 
            // cbxPrintEveryPerm
            // 
            this.cbxPrintEveryPerm.AutoSize = true;
            this.cbxPrintEveryPerm.Location = new System.Drawing.Point(176, 131);
            this.cbxPrintEveryPerm.Name = "cbxPrintEveryPerm";
            this.cbxPrintEveryPerm.Size = new System.Drawing.Size(134, 21);
            this.cbxPrintEveryPerm.TabIndex = 2;
            this.cbxPrintEveryPerm.Text = "Print every perm";
            this.cbxPrintEveryPerm.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Print permuted data:";
            // 
            // cmbPrintPermutedData
            // 
            this.cmbPrintPermutedData.FormattingEnabled = true;
            this.cmbPrintPermutedData.Items.AddRange(new object[] {
            "don\'t print",
            "print into one file",
            "print each run into separate files"});
            this.cmbPrintPermutedData.Location = new System.Drawing.Point(155, 72);
            this.cmbPrintPermutedData.Name = "cmbPrintPermutedData";
            this.cmbPrintPermutedData.Size = new System.Drawing.Size(183, 24);
            this.cmbPrintPermutedData.TabIndex = 1;
            this.cmbPrintPermutedData.Text = "don\'t print";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.cbxOrderByRun);
            this.tabPage4.Controls.Add(this.cbxOverrideWarnings);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(509, 227);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Advanced options";
            // 
            // cbxOrderByRun
            // 
            this.cbxOrderByRun.AutoSize = true;
            this.cbxOrderByRun.Checked = true;
            this.cbxOrderByRun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxOrderByRun.Location = new System.Drawing.Point(171, 100);
            this.cbxOrderByRun.Name = "cbxOrderByRun";
            this.cbxOrderByRun.Size = new System.Drawing.Size(111, 21);
            this.cbxOrderByRun.TabIndex = 1;
            this.cbxOrderByRun.Text = "Order by run";
            this.cbxOrderByRun.UseVisualStyleBackColor = true;
            // 
            // cbxOverrideWarnings
            // 
            this.cbxOverrideWarnings.AutoSize = true;
            this.cbxOverrideWarnings.Location = new System.Drawing.Point(171, 72);
            this.cbxOverrideWarnings.Name = "cbxOverrideWarnings";
            this.cbxOverrideWarnings.Size = new System.Drawing.Size(145, 21);
            this.cbxOverrideWarnings.TabIndex = 0;
            this.cbxOverrideWarnings.Text = "Override warnings";
            this.cbxOverrideWarnings.UseVisualStyleBackColor = true;
            // 
            // FormClumppParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 304);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormClumppParams";
            this.Text = "Set CLUMPP Parameters";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClusters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRuns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndividuals)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeats)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbMethodToBeUsed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numClusters;
        private System.Windows.Forms.NumericUpDown numPopulations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numIndividuals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numRuns;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnChoosePermutationFile;
        private System.Windows.Forms.TextBox txtPermutationFile;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numRepeats;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbGreedyOption;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox cbxPrintRandomInputOrder;
        private System.Windows.Forms.CheckBox cbxPrintEveryPerm;
        private System.Windows.Forms.ComboBox cmbPrintPermutedData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox cbxOrderByRun;
        private System.Windows.Forms.CheckBox cbxOverrideWarnings;
    }
}