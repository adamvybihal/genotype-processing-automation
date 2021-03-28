
namespace GenotypeDataProcessing
{
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
            this.numIndividuals = new System.Windows.Forms.NumericUpDown();
            this.numRuns = new System.Windows.Forms.NumericUpDown();
            this.numClusters = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numPopulations = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMethodToBeUsed = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPrintPermutedData = new System.Windows.Forms.ComboBox();
            this.cbxPrintEveryPerm = new System.Windows.Forms.CheckBox();
            this.cbxPrintRandomInputOrder = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbxOverrideWarnings = new System.Windows.Forms.CheckBox();
            this.cbxOrderByRun = new System.Windows.Forms.CheckBox();
            this.cmbGreedyOption = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numRepeats = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPermutationFile = new System.Windows.Forms.TextBox();
            this.btnChoosePermutationFile = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numIndividuals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRuns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClusters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulations)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeats)).BeginInit();
            this.SuspendLayout();
            // 
            // numIndividuals
            // 
            this.numIndividuals.Location = new System.Drawing.Point(170, 90);
            this.numIndividuals.Name = "numIndividuals";
            this.numIndividuals.Size = new System.Drawing.Size(120, 22);
            this.numIndividuals.TabIndex = 24;
            // 
            // numRuns
            // 
            this.numRuns.Location = new System.Drawing.Point(170, 61);
            this.numRuns.Name = "numRuns";
            this.numRuns.Size = new System.Drawing.Size(120, 22);
            this.numRuns.TabIndex = 23;
            // 
            // numClusters
            // 
            this.numClusters.Location = new System.Drawing.Point(170, 31);
            this.numClusters.Name = "numClusters";
            this.numClusters.Size = new System.Drawing.Size(120, 22);
            this.numClusters.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "number of clusters:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "number of runs:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "number of individuals:";
            // 
            // numPopulations
            // 
            this.numPopulations.Location = new System.Drawing.Point(170, 118);
            this.numPopulations.Name = "numPopulations";
            this.numPopulations.Size = new System.Drawing.Size(120, 22);
            this.numPopulations.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "number of populations:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMethodToBeUsed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numClusters);
            this.groupBox1.Controls.Add(this.numPopulations);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numIndividuals);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numRuns);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 203);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "main Parameters";
            // 
            // cmbMethodToBeUsed
            // 
            this.cmbMethodToBeUsed.FormattingEnabled = true;
            this.cmbMethodToBeUsed.Items.AddRange(new object[] {
            "FullSearch",
            "Greedy",
            "LargeKGreedy"});
            this.cmbMethodToBeUsed.Location = new System.Drawing.Point(169, 160);
            this.cmbMethodToBeUsed.Name = "cmbMethodToBeUsed";
            this.cmbMethodToBeUsed.Size = new System.Drawing.Size(121, 24);
            this.cmbMethodToBeUsed.TabIndex = 28;
            this.cmbMethodToBeUsed.Text = "FullSearch";
            this.cmbMethodToBeUsed.SelectedIndexChanged += new System.EventHandler(this.cmbMethodToBeUsed_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "method to be used:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbxPrintRandomInputOrder);
            this.groupBox2.Controls.Add(this.cbxPrintEveryPerm);
            this.groupBox2.Controls.Add(this.cmbPrintPermutedData);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 215);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "optional outputs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "print permuted data:";
            // 
            // cmbPrintPermutedData
            // 
            this.cmbPrintPermutedData.FormattingEnabled = true;
            this.cmbPrintPermutedData.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cmbPrintPermutedData.Location = new System.Drawing.Point(169, 31);
            this.cmbPrintPermutedData.Name = "cmbPrintPermutedData";
            this.cmbPrintPermutedData.Size = new System.Drawing.Size(121, 24);
            this.cmbPrintPermutedData.TabIndex = 1;
            this.cmbPrintPermutedData.Text = "0";
            // 
            // cbxPrintEveryPerm
            // 
            this.cbxPrintEveryPerm.AutoSize = true;
            this.cbxPrintEveryPerm.Location = new System.Drawing.Point(90, 140);
            this.cbxPrintEveryPerm.Name = "cbxPrintEveryPerm";
            this.cbxPrintEveryPerm.Size = new System.Drawing.Size(133, 21);
            this.cbxPrintEveryPerm.TabIndex = 2;
            this.cbxPrintEveryPerm.Text = "print every perm";
            this.cbxPrintEveryPerm.UseVisualStyleBackColor = true;
            // 
            // cbxPrintRandomInputOrder
            // 
            this.cbxPrintRandomInputOrder.AutoSize = true;
            this.cbxPrintRandomInputOrder.Enabled = false;
            this.cbxPrintRandomInputOrder.Location = new System.Drawing.Point(69, 167);
            this.cbxPrintRandomInputOrder.Name = "cbxPrintRandomInputOrder";
            this.cbxPrintRandomInputOrder.Size = new System.Drawing.Size(183, 21);
            this.cbxPrintRandomInputOrder.TabIndex = 3;
            this.cbxPrintRandomInputOrder.Text = "print random input order";
            this.cbxPrintRandomInputOrder.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "0 = don\'t print";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "1 = print into one file";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(236, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "2 = print each run into separate files";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnChoosePermutationFile);
            this.groupBox3.Controls.Add(this.txtPermutationFile);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.numRepeats);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cmbGreedyOption);
            this.groupBox3.Location = new System.Drawing.Point(331, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 285);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "aditional options for Greedy and LargeKGreedy algorithms";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbxOrderByRun);
            this.groupBox4.Controls.Add(this.cbxOverrideWarnings);
            this.groupBox4.Location = new System.Drawing.Point(330, 304);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 134);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "advanced options";
            // 
            // cbxOverrideWarnings
            // 
            this.cbxOverrideWarnings.AutoSize = true;
            this.cbxOverrideWarnings.Location = new System.Drawing.Point(84, 44);
            this.cbxOverrideWarnings.Name = "cbxOverrideWarnings";
            this.cbxOverrideWarnings.Size = new System.Drawing.Size(142, 21);
            this.cbxOverrideWarnings.TabIndex = 0;
            this.cbxOverrideWarnings.Text = "override warnings";
            this.cbxOverrideWarnings.UseVisualStyleBackColor = true;
            // 
            // cbxOrderByRun
            // 
            this.cbxOrderByRun.AutoSize = true;
            this.cbxOrderByRun.Checked = true;
            this.cbxOrderByRun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxOrderByRun.Location = new System.Drawing.Point(84, 72);
            this.cbxOrderByRun.Name = "cbxOrderByRun";
            this.cbxOrderByRun.Size = new System.Drawing.Size(108, 21);
            this.cbxOrderByRun.TabIndex = 1;
            this.cbxOrderByRun.Text = "order by run";
            this.cbxOrderByRun.UseVisualStyleBackColor = true;
            // 
            // cmbGreedyOption
            // 
            this.cmbGreedyOption.Enabled = false;
            this.cmbGreedyOption.FormattingEnabled = true;
            this.cmbGreedyOption.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbGreedyOption.Location = new System.Drawing.Point(148, 56);
            this.cmbGreedyOption.Name = "cmbGreedyOption";
            this.cmbGreedyOption.Size = new System.Drawing.Size(121, 24);
            this.cmbGreedyOption.TabIndex = 0;
            this.cmbGreedyOption.Text = "2";
            this.cmbGreedyOption.SelectedIndexChanged += new System.EventHandler(this.cmbGreedyOption_SelectedIndexChanged);
            this.cmbGreedyOption.EnabledChanged += new System.EventHandler(this.cmbGreedyOption_EnabledChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "greedy option:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(80, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "repeats:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "3 = pre-specified input orders";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "2 = random input orders";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(41, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "1 = all possible input orders";
            // 
            // numRepeats
            // 
            this.numRepeats.Enabled = false;
            this.numRepeats.Location = new System.Drawing.Point(148, 158);
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(64, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "choose permutation file:";
            // 
            // txtPermutationFile
            // 
            this.txtPermutationFile.Location = new System.Drawing.Point(27, 229);
            this.txtPermutationFile.Name = "txtPermutationFile";
            this.txtPermutationFile.ReadOnly = true;
            this.txtPermutationFile.Size = new System.Drawing.Size(143, 22);
            this.txtPermutationFile.TabIndex = 12;
            // 
            // btnChoosePermutationFile
            // 
            this.btnChoosePermutationFile.Enabled = false;
            this.btnChoosePermutationFile.Location = new System.Drawing.Point(193, 229);
            this.btnChoosePermutationFile.Name = "btnChoosePermutationFile";
            this.btnChoosePermutationFile.Size = new System.Drawing.Size(75, 23);
            this.btnChoosePermutationFile.TabIndex = 13;
            this.btnChoosePermutationFile.Text = "choose";
            this.btnChoosePermutationFile.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(228, 451);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 31;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(331, 451);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormClumppParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 486);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormClumppParams";
            this.Text = "Set CLUMPP Parameters";
            ((System.ComponentModel.ISupportInitialize)(this.numIndividuals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRuns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClusters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPopulations)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRepeats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numIndividuals;
        private System.Windows.Forms.NumericUpDown numRuns;
        private System.Windows.Forms.NumericUpDown numClusters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numPopulations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMethodToBeUsed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbxPrintRandomInputOrder;
        private System.Windows.Forms.CheckBox cbxPrintEveryPerm;
        private System.Windows.Forms.ComboBox cmbPrintPermutedData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbxOrderByRun;
        private System.Windows.Forms.CheckBox cbxOverrideWarnings;
        private System.Windows.Forms.Button btnChoosePermutationFile;
        private System.Windows.Forms.TextBox txtPermutationFile;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numRepeats;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbGreedyOption;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}