
namespace GenotypeDataProcessing
{
    partial class FormDistructParams
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
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numIndividuals = new System.Windows.Forms.NumericUpDown();
            this.numPreDefPopulations = new System.Windows.Forms.NumericUpDown();
            this.numClusters = new System.Windows.Forms.NumericUpDown();
            this.txtLblAtopFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChoosePermutationFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPermutationFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChooseLblsAtopFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnChooseLblsBelowFile = new System.Windows.Forms.Button();
            this.txtLblBelowFile = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbxPrintLblsBelow = new System.Windows.Forms.CheckBox();
            this.cbxPrintIndividuals = new System.Windows.Forms.CheckBox();
            this.cbxPrintSeparatingLines = new System.Windows.Forms.CheckBox();
            this.cbxPrintLblsAtop = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.numIndividualWidth = new System.Windows.Forms.NumericUpDown();
            this.numFigureHeight = new System.Windows.Forms.NumericUpDown();
            this.numDistanceBelow = new System.Windows.Forms.NumericUpDown();
            this.numDistanceAbove = new System.Windows.Forms.NumericUpDown();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndividuals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreDefPopulations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClusters)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndividualWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFigureHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistanceBelow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistanceAbove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(172, 338);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(76, 26);
            this.btnApply.TabIndex = 30;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 338);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(570, 322);
            this.tabControl1.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.numIndividuals);
            this.tabPage1.Controls.Add(this.numPreDefPopulations);
            this.tabPage1.Controls.Add(this.numClusters);
            this.tabPage1.Controls.Add(this.txtLblAtopFile);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnChoosePermutationFile);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtPermutationFile);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnChooseLblsAtopFile);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnChooseLblsBelowFile);
            this.tabPage1.Controls.Add(this.txtLblBelowFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(562, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data settings";
            // 
            // numIndividuals
            // 
            this.numIndividuals.Location = new System.Drawing.Point(296, 248);
            this.numIndividuals.Maximum = new decimal(new int[] {
            27000000,
            0,
            0,
            0});
            this.numIndividuals.Name = "numIndividuals";
            this.numIndividuals.Size = new System.Drawing.Size(120, 22);
            this.numIndividuals.TabIndex = 33;
            // 
            // numPreDefPopulations
            // 
            this.numPreDefPopulations.Location = new System.Drawing.Point(296, 219);
            this.numPreDefPopulations.Maximum = new decimal(new int[] {
            27000000,
            0,
            0,
            0});
            this.numPreDefPopulations.Name = "numPreDefPopulations";
            this.numPreDefPopulations.Size = new System.Drawing.Size(120, 22);
            this.numPreDefPopulations.TabIndex = 32;
            // 
            // numClusters
            // 
            this.numClusters.Enabled = false;
            this.numClusters.Location = new System.Drawing.Point(296, 189);
            this.numClusters.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numClusters.Name = "numClusters";
            this.numClusters.Size = new System.Drawing.Size(120, 22);
            this.numClusters.TabIndex = 31;
            this.numClusters.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtLblAtopFile
            // 
            this.txtLblAtopFile.Location = new System.Drawing.Point(78, 100);
            this.txtLblAtopFile.Name = "txtLblAtopFile";
            this.txtLblAtopFile.ReadOnly = true;
            this.txtLblAtopFile.Size = new System.Drawing.Size(273, 22);
            this.txtLblAtopFile.TabIndex = 27;
            this.txtLblAtopFile.Text = "choose file ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Input file of labels for below figure (optional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Input file of labels for atop figure (optional)";
            // 
            // btnChoosePermutationFile
            // 
            this.btnChoosePermutationFile.Location = new System.Drawing.Point(367, 155);
            this.btnChoosePermutationFile.Name = "btnChoosePermutationFile";
            this.btnChoosePermutationFile.Size = new System.Drawing.Size(107, 23);
            this.btnChoosePermutationFile.TabIndex = 30;
            this.btnChoosePermutationFile.Text = "Choose File";
            this.btnChoosePermutationFile.UseVisualStyleBackColor = true;
            this.btnChoosePermutationFile.Click += new System.EventHandler(this.btnChoosePermutationFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Input file of permutation of clusters to print (optional)";
            // 
            // txtPermutationFile
            // 
            this.txtPermutationFile.Location = new System.Drawing.Point(78, 156);
            this.txtPermutationFile.Name = "txtPermutationFile";
            this.txtPermutationFile.ReadOnly = true;
            this.txtPermutationFile.Size = new System.Drawing.Size(273, 22);
            this.txtPermutationFile.TabIndex = 29;
            this.txtPermutationFile.Text = "choose file ...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Number of clusters:";
            // 
            // btnChooseLblsAtopFile
            // 
            this.btnChooseLblsAtopFile.Location = new System.Drawing.Point(367, 99);
            this.btnChooseLblsAtopFile.Name = "btnChooseLblsAtopFile";
            this.btnChooseLblsAtopFile.Size = new System.Drawing.Size(107, 23);
            this.btnChooseLblsAtopFile.TabIndex = 28;
            this.btnChooseLblsAtopFile.Text = "Choose File";
            this.btnChooseLblsAtopFile.UseVisualStyleBackColor = true;
            this.btnChooseLblsAtopFile.Click += new System.EventHandler(this.btnChooseLblsAtopFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Number of pre-defined populations:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Number of individuals:";
            // 
            // btnChooseLblsBelowFile
            // 
            this.btnChooseLblsBelowFile.Location = new System.Drawing.Point(367, 46);
            this.btnChooseLblsBelowFile.Name = "btnChooseLblsBelowFile";
            this.btnChooseLblsBelowFile.Size = new System.Drawing.Size(107, 23);
            this.btnChooseLblsBelowFile.TabIndex = 26;
            this.btnChooseLblsBelowFile.Text = "Choose File";
            this.btnChooseLblsBelowFile.UseVisualStyleBackColor = true;
            this.btnChooseLblsBelowFile.Click += new System.EventHandler(this.btnChooseLblsBelowFile_Click);
            // 
            // txtLblBelowFile
            // 
            this.txtLblBelowFile.Location = new System.Drawing.Point(78, 47);
            this.txtLblBelowFile.Name = "txtLblBelowFile";
            this.txtLblBelowFile.ReadOnly = true;
            this.txtLblBelowFile.Size = new System.Drawing.Size(273, 22);
            this.txtLblBelowFile.TabIndex = 25;
            this.txtLblBelowFile.Text = "choose file ...";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.cbxPrintLblsBelow);
            this.tabPage2.Controls.Add(this.cbxPrintIndividuals);
            this.tabPage2.Controls.Add(this.cbxPrintSeparatingLines);
            this.tabPage2.Controls.Add(this.cbxPrintLblsAtop);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(562, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Main usage options";
            // 
            // cbxPrintLblsBelow
            // 
            this.cbxPrintLblsBelow.AutoSize = true;
            this.cbxPrintLblsBelow.Checked = true;
            this.cbxPrintLblsBelow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxPrintLblsBelow.Location = new System.Drawing.Point(159, 150);
            this.cbxPrintLblsBelow.Name = "cbxPrintLblsBelow";
            this.cbxPrintLblsBelow.Size = new System.Drawing.Size(180, 21);
            this.cbxPrintLblsBelow.TabIndex = 24;
            this.cbxPrintLblsBelow.Text = "Print labels below figure";
            this.cbxPrintLblsBelow.UseVisualStyleBackColor = true;
            // 
            // cbxPrintIndividuals
            // 
            this.cbxPrintIndividuals.AutoSize = true;
            this.cbxPrintIndividuals.Checked = true;
            this.cbxPrintIndividuals.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxPrintIndividuals.Location = new System.Drawing.Point(159, 96);
            this.cbxPrintIndividuals.Name = "cbxPrintIndividuals";
            this.cbxPrintIndividuals.Size = new System.Drawing.Size(129, 21);
            this.cbxPrintIndividuals.TabIndex = 22;
            this.cbxPrintIndividuals.Text = "Print individuals";
            this.cbxPrintIndividuals.UseVisualStyleBackColor = true;
            // 
            // cbxPrintSeparatingLines
            // 
            this.cbxPrintSeparatingLines.AutoSize = true;
            this.cbxPrintSeparatingLines.Checked = true;
            this.cbxPrintSeparatingLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxPrintSeparatingLines.Location = new System.Drawing.Point(159, 177);
            this.cbxPrintSeparatingLines.Name = "cbxPrintSeparatingLines";
            this.cbxPrintSeparatingLines.Size = new System.Drawing.Size(245, 21);
            this.cbxPrintSeparatingLines.TabIndex = 25;
            this.cbxPrintSeparatingLines.Text = "Print lines to separate populations";
            this.cbxPrintSeparatingLines.UseVisualStyleBackColor = true;
            // 
            // cbxPrintLblsAtop
            // 
            this.cbxPrintLblsAtop.AutoSize = true;
            this.cbxPrintLblsAtop.Checked = true;
            this.cbxPrintLblsAtop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxPrintLblsAtop.Location = new System.Drawing.Point(159, 123);
            this.cbxPrintLblsAtop.Name = "cbxPrintLblsAtop";
            this.cbxPrintLblsAtop.Size = new System.Drawing.Size(183, 21);
            this.cbxPrintLblsAtop.TabIndex = 23;
            this.cbxPrintLblsAtop.Text = "Print labels above figure";
            this.cbxPrintLblsAtop.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.numIndividualWidth);
            this.tabPage3.Controls.Add(this.numFigureHeight);
            this.tabPage3.Controls.Add(this.numDistanceBelow);
            this.tabPage3.Controls.Add(this.numDistanceAbove);
            this.tabPage3.Controls.Add(this.numFontSize);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(562, 293);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Figure appearance";
            // 
            // numIndividualWidth
            // 
            this.numIndividualWidth.DecimalPlaces = 1;
            this.numIndividualWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numIndividualWidth.Location = new System.Drawing.Point(296, 204);
            this.numIndividualWidth.Name = "numIndividualWidth";
            this.numIndividualWidth.Size = new System.Drawing.Size(120, 22);
            this.numIndividualWidth.TabIndex = 50;
            this.numIndividualWidth.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // numFigureHeight
            // 
            this.numFigureHeight.DecimalPlaces = 1;
            this.numFigureHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numFigureHeight.Location = new System.Drawing.Point(296, 175);
            this.numFigureHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numFigureHeight.Name = "numFigureHeight";
            this.numFigureHeight.Size = new System.Drawing.Size(120, 22);
            this.numFigureHeight.TabIndex = 49;
            this.numFigureHeight.Value = new decimal(new int[] {
            36,
            0,
            0,
            0});
            // 
            // numDistanceBelow
            // 
            this.numDistanceBelow.DecimalPlaces = 1;
            this.numDistanceBelow.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDistanceBelow.Location = new System.Drawing.Point(296, 144);
            this.numDistanceBelow.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numDistanceBelow.Name = "numDistanceBelow";
            this.numDistanceBelow.Size = new System.Drawing.Size(120, 22);
            this.numDistanceBelow.TabIndex = 48;
            this.numDistanceBelow.Value = new decimal(new int[] {
            7,
            0,
            0,
            -2147483648});
            // 
            // numDistanceAbove
            // 
            this.numDistanceAbove.DecimalPlaces = 1;
            this.numDistanceAbove.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDistanceAbove.Location = new System.Drawing.Point(296, 113);
            this.numDistanceAbove.Name = "numDistanceAbove";
            this.numDistanceAbove.Size = new System.Drawing.Size(120, 22);
            this.numDistanceAbove.TabIndex = 47;
            this.numDistanceAbove.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numFontSize
            // 
            this.numFontSize.DecimalPlaces = 1;
            this.numFontSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numFontSize.Location = new System.Drawing.Point(296, 84);
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.Size = new System.Drawing.Size(120, 22);
            this.numFontSize.TabIndex = 46;
            this.numFontSize.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Distance below plot to place text:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(209, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
            this.label14.TabIndex = 41;
            this.label14.Text = "Size of font:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(217, 17);
            this.label13.TabIndex = 42;
            this.label13.Text = "Distance above plot to place text:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(159, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 17);
            this.label12.TabIndex = 43;
            this.label12.Text = "Height of the figure:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(147, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 17);
            this.label15.TabIndex = 45;
            this.label15.Text = "Width of an individual:";
            // 
            // FormDistructParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 382);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormDistructParams";
            this.Text = "Set distruct Parameters";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndividuals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreDefPopulations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClusters)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndividualWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFigureHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistanceBelow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistanceAbove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown numIndividuals;
        private System.Windows.Forms.NumericUpDown numPreDefPopulations;
        private System.Windows.Forms.NumericUpDown numClusters;
        private System.Windows.Forms.TextBox txtLblAtopFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChoosePermutationFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPermutationFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChooseLblsAtopFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnChooseLblsBelowFile;
        private System.Windows.Forms.TextBox txtLblBelowFile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbxPrintLblsBelow;
        private System.Windows.Forms.CheckBox cbxPrintIndividuals;
        private System.Windows.Forms.CheckBox cbxPrintSeparatingLines;
        private System.Windows.Forms.CheckBox cbxPrintLblsAtop;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown numIndividualWidth;
        private System.Windows.Forms.NumericUpDown numFigureHeight;
        private System.Windows.Forms.NumericUpDown numDistanceBelow;
        private System.Windows.Forms.NumericUpDown numDistanceAbove;
        private System.Windows.Forms.NumericUpDown numFontSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
    }
}