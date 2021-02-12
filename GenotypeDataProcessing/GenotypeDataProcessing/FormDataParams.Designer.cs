
namespace GenotypeDataProcessing
{
    partial class FormDataParams
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxSingleLine = new System.Windows.Forms.CheckBox();
            this.numMissingDataValue = new System.Windows.Forms.NumericUpDown();
            this.numPloidy = new System.Windows.Forms.NumericUpDown();
            this.numLoci = new System.Windows.Forms.NumericUpDown();
            this.numIndividuals = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numExtraCols = new System.Windows.Forms.NumericUpDown();
            this.cbxExtraCols = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxPhenotypeCol = new System.Windows.Forms.CheckBox();
            this.cbxSampleInfoCol = new System.Windows.Forms.CheckBox();
            this.cbxPopInfoFlagCol = new System.Windows.Forms.CheckBox();
            this.cbxPopOriginCol = new System.Windows.Forms.CheckBox();
            this.cbxIdCol = new System.Windows.Forms.CheckBox();
            this.cbxLociDistancesRow = new System.Windows.Forms.CheckBox();
            this.cbxAlelesRow = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMarkerRow = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numRepsAfterBurnin = new System.Windows.Forms.NumericUpDown();
            this.numBurninPeriod = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMissingDataValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPloidy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndividuals)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExtraCols)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRepsAfterBurnin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBurninPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxSingleLine);
            this.groupBox1.Controls.Add(this.numMissingDataValue);
            this.groupBox1.Controls.Add(this.numPloidy);
            this.groupBox1.Controls.Add(this.numLoci);
            this.groupBox1.Controls.Add(this.numIndividuals);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(409, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Information";
            // 
            // cbxSingleLine
            // 
            this.cbxSingleLine.AutoSize = true;
            this.cbxSingleLine.Location = new System.Drawing.Point(39, 157);
            this.cbxSingleLine.Name = "cbxSingleLine";
            this.cbxSingleLine.Size = new System.Drawing.Size(268, 21);
            this.cbxSingleLine.TabIndex = 8;
            this.cbxSingleLine.Text = "data for individuals are in a single line";
            this.cbxSingleLine.UseVisualStyleBackColor = true;
            // 
            // numMissingDataValue
            // 
            this.numMissingDataValue.Location = new System.Drawing.Point(189, 123);
            this.numMissingDataValue.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numMissingDataValue.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.numMissingDataValue.Name = "numMissingDataValue";
            this.numMissingDataValue.Size = new System.Drawing.Size(99, 22);
            this.numMissingDataValue.TabIndex = 7;
            // 
            // numPloidy
            // 
            this.numPloidy.Location = new System.Drawing.Point(189, 95);
            this.numPloidy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPloidy.Name = "numPloidy";
            this.numPloidy.Size = new System.Drawing.Size(99, 22);
            this.numPloidy.TabIndex = 6;
            this.numPloidy.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numLoci
            // 
            this.numLoci.Location = new System.Drawing.Point(189, 67);
            this.numLoci.Name = "numLoci";
            this.numLoci.Size = new System.Drawing.Size(99, 22);
            this.numLoci.TabIndex = 5;
            // 
            // numIndividuals
            // 
            this.numIndividuals.Location = new System.Drawing.Point(189, 40);
            this.numIndividuals.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numIndividuals.Name = "numIndividuals";
            this.numIndividuals.Size = new System.Drawing.Size(99, 22);
            this.numIndividuals.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "missing data value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "number of loci:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ploidy of data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "number of individuals:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numExtraCols);
            this.groupBox2.Controls.Add(this.cbxExtraCols);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbxPhenotypeCol);
            this.groupBox2.Controls.Add(this.cbxSampleInfoCol);
            this.groupBox2.Controls.Add(this.cbxPopInfoFlagCol);
            this.groupBox2.Controls.Add(this.cbxPopOriginCol);
            this.groupBox2.Controls.Add(this.cbxIdCol);
            this.groupBox2.Controls.Add(this.cbxLociDistancesRow);
            this.groupBox2.Controls.Add(this.cbxAlelesRow);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbxMarkerRow);
            this.groupBox2.Location = new System.Drawing.Point(0, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 361);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Format";
            // 
            // numExtraCols
            // 
            this.numExtraCols.Enabled = false;
            this.numExtraCols.Location = new System.Drawing.Point(315, 323);
            this.numExtraCols.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numExtraCols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numExtraCols.Name = "numExtraCols";
            this.numExtraCols.Size = new System.Drawing.Size(65, 22);
            this.numExtraCols.TabIndex = 11;
            this.numExtraCols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxExtraCols
            // 
            this.cbxExtraCols.AutoSize = true;
            this.cbxExtraCols.Location = new System.Drawing.Point(29, 324);
            this.cbxExtraCols.Name = "cbxExtraCols";
            this.cbxExtraCols.Size = new System.Drawing.Size(283, 21);
            this.cbxExtraCols.TabIndex = 10;
            this.cbxExtraCols.Text = "other extra columns => if so, how many?";
            this.cbxExtraCols.UseVisualStyleBackColor = true;
            this.cbxExtraCols.CheckedChanged += new System.EventHandler(this.cbxExtraCols_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Check if data file contains following columns:";
            // 
            // cbxPhenotypeCol
            // 
            this.cbxPhenotypeCol.AutoSize = true;
            this.cbxPhenotypeCol.Location = new System.Drawing.Point(29, 297);
            this.cbxPhenotypeCol.Name = "cbxPhenotypeCol";
            this.cbxPhenotypeCol.Size = new System.Drawing.Size(171, 21);
            this.cbxPhenotypeCol.TabIndex = 8;
            this.cbxPhenotypeCol.Text = "phenotype information";
            this.cbxPhenotypeCol.UseVisualStyleBackColor = true;
            // 
            // cbxSampleInfoCol
            // 
            this.cbxSampleInfoCol.AutoSize = true;
            this.cbxSampleInfoCol.Location = new System.Drawing.Point(29, 270);
            this.cbxSampleInfoCol.Name = "cbxSampleInfoCol";
            this.cbxSampleInfoCol.Size = new System.Drawing.Size(213, 21);
            this.cbxSampleInfoCol.TabIndex = 7;
            this.cbxSampleInfoCol.Text = "sampling location information";
            this.cbxSampleInfoCol.UseVisualStyleBackColor = true;
            // 
            // cbxPopInfoFlagCol
            // 
            this.cbxPopInfoFlagCol.AutoSize = true;
            this.cbxPopInfoFlagCol.Location = new System.Drawing.Point(29, 243);
            this.cbxPopInfoFlagCol.Name = "cbxPopInfoFlagCol";
            this.cbxPopInfoFlagCol.Size = new System.Drawing.Size(146, 21);
            this.cbxPopInfoFlagCol.TabIndex = 6;
            this.cbxPopInfoFlagCol.Text = "USEPOPINFO flag";
            this.cbxPopInfoFlagCol.UseVisualStyleBackColor = true;
            // 
            // cbxPopOriginCol
            // 
            this.cbxPopOriginCol.AutoSize = true;
            this.cbxPopOriginCol.Location = new System.Drawing.Point(29, 216);
            this.cbxPopOriginCol.Name = "cbxPopOriginCol";
            this.cbxPopOriginCol.Size = new System.Drawing.Size(299, 21);
            this.cbxPopOriginCol.TabIndex = 5;
            this.cbxPopOriginCol.Text = "alleged population origin of each individual";
            this.cbxPopOriginCol.UseVisualStyleBackColor = true;
            // 
            // cbxIdCol
            // 
            this.cbxIdCol.AutoSize = true;
            this.cbxIdCol.Location = new System.Drawing.Point(29, 189);
            this.cbxIdCol.Name = "cbxIdCol";
            this.cbxIdCol.Size = new System.Drawing.Size(162, 21);
            this.cbxIdCol.TabIndex = 4;
            this.cbxIdCol.Text = "ID for each individual";
            this.cbxIdCol.UseVisualStyleBackColor = true;
            // 
            // cbxLociDistancesRow
            // 
            this.cbxLociDistancesRow.AutoSize = true;
            this.cbxLociDistancesRow.Location = new System.Drawing.Point(29, 121);
            this.cbxLociDistancesRow.Name = "cbxLociDistancesRow";
            this.cbxLociDistancesRow.Size = new System.Drawing.Size(229, 21);
            this.cbxLociDistancesRow.TabIndex = 3;
            this.cbxLociDistancesRow.Text = "map distances between loci row";
            this.cbxLociDistancesRow.UseVisualStyleBackColor = true;
            // 
            // cbxAlelesRow
            // 
            this.cbxAlelesRow.AutoSize = true;
            this.cbxAlelesRow.Location = new System.Drawing.Point(29, 94);
            this.cbxAlelesRow.Name = "cbxAlelesRow";
            this.cbxAlelesRow.Size = new System.Drawing.Size(157, 21);
            this.cbxAlelesRow.TabIndex = 2;
            this.cbxAlelesRow.Text = "recessive aleles row";
            this.cbxAlelesRow.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Check if data file contains following rows:";
            // 
            // cbxMarkerRow
            // 
            this.cbxMarkerRow.AutoSize = true;
            this.cbxMarkerRow.Location = new System.Drawing.Point(29, 67);
            this.cbxMarkerRow.Name = "cbxMarkerRow";
            this.cbxMarkerRow.Size = new System.Drawing.Size(146, 21);
            this.cbxMarkerRow.TabIndex = 0;
            this.cbxMarkerRow.Text = "marker names row";
            this.cbxMarkerRow.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numRepsAfterBurnin);
            this.groupBox4.Controls.Add(this.numBurninPeriod);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(742, 100);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Program Parameters";
            // 
            // numRepsAfterBurnin
            // 
            this.numRepsAfterBurnin.Location = new System.Drawing.Point(577, 43);
            this.numRepsAfterBurnin.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numRepsAfterBurnin.Name = "numRepsAfterBurnin";
            this.numRepsAfterBurnin.Size = new System.Drawing.Size(99, 22);
            this.numRepsAfterBurnin.TabIndex = 10;
            // 
            // numBurninPeriod
            // 
            this.numBurninPeriod.Location = new System.Drawing.Point(188, 43);
            this.numBurninPeriod.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numBurninPeriod.Name = "numBurninPeriod";
            this.numBurninPeriod.Size = new System.Drawing.Size(99, 22);
            this.numBurninPeriod.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "number of MCMC reps after burnin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "length of burnin period:";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(525, 404);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(96, 47);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Location = new System.Drawing.Point(493, 335);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(163, 47);
            this.btnAdvanced.TabIndex = 4;
            this.btnAdvanced.Text = "Advanced Options";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            // 
            // FormDataParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 480);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDataParams";
            this.Text = "Parameter Set";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMissingDataValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPloidy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndividuals)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExtraCols)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRepsAfterBurnin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBurninPeriod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numMissingDataValue;
        private System.Windows.Forms.NumericUpDown numPloidy;
        private System.Windows.Forms.NumericUpDown numLoci;
        private System.Windows.Forms.NumericUpDown numIndividuals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxSingleLine;
        private System.Windows.Forms.CheckBox cbxPhenotypeCol;
        private System.Windows.Forms.CheckBox cbxSampleInfoCol;
        private System.Windows.Forms.CheckBox cbxPopInfoFlagCol;
        private System.Windows.Forms.CheckBox cbxPopOriginCol;
        private System.Windows.Forms.CheckBox cbxIdCol;
        private System.Windows.Forms.CheckBox cbxLociDistancesRow;
        private System.Windows.Forms.CheckBox cbxAlelesRow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxMarkerRow;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.CheckBox cbxExtraCols;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numExtraCols;
        private System.Windows.Forms.NumericUpDown numRepsAfterBurnin;
        private System.Windows.Forms.NumericUpDown numBurninPeriod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdvanced;
    }
}