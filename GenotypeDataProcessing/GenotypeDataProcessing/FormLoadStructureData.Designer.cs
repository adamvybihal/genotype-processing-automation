
namespace GenotypeDataProcessing
{
    partial class FormLoadStructureData
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
            this.gbxStep1 = new System.Windows.Forms.GroupBox();
            this.btnChooseStructureFile = new System.Windows.Forms.Button();
            this.txtStructureDataFile = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext1to2 = new System.Windows.Forms.Button();
            this.gbxStep2 = new System.Windows.Forms.GroupBox();
            this.btnShowDataFormat2 = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.numMissingDataValue = new System.Windows.Forms.NumericUpDown();
            this.btnBack2to1 = new System.Windows.Forms.Button();
            this.numPloidy = new System.Windows.Forms.NumericUpDown();
            this.btnNext2to3 = new System.Windows.Forms.Button();
            this.numLoci = new System.Windows.Forms.NumericUpDown();
            this.numIndividuals = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxStep3 = new System.Windows.Forms.GroupBox();
            this.btnShowDataFormat3 = new System.Windows.Forms.Button();
            this.btnCancel3 = new System.Windows.Forms.Button();
            this.btnBack3to2 = new System.Windows.Forms.Button();
            this.btnNext3to4 = new System.Windows.Forms.Button();
            this.cbxSingleLine = new System.Windows.Forms.CheckBox();
            this.cbxPhase = new System.Windows.Forms.CheckBox();
            this.cbxLociDistancesRow = new System.Windows.Forms.CheckBox();
            this.cbxAlelesRow = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMarkerRow = new System.Windows.Forms.CheckBox();
            this.gbxStep4 = new System.Windows.Forms.GroupBox();
            this.btnShowDataFormat4 = new System.Windows.Forms.Button();
            this.btnCancel4 = new System.Windows.Forms.Button();
            this.numExtraCols = new System.Windows.Forms.NumericUpDown();
            this.btnBack4to3 = new System.Windows.Forms.Button();
            this.cbxExtraCols = new System.Windows.Forms.CheckBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxPhenotypeCol = new System.Windows.Forms.CheckBox();
            this.cbxSampleInfoCol = new System.Windows.Forms.CheckBox();
            this.cbxPopInfoFlagCol = new System.Windows.Forms.CheckBox();
            this.cbxPopOriginCol = new System.Windows.Forms.CheckBox();
            this.cbxIdCol = new System.Windows.Forms.CheckBox();
            this.gbxStep1.SuspendLayout();
            this.gbxStep2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMissingDataValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPloidy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndividuals)).BeginInit();
            this.gbxStep3.SuspendLayout();
            this.gbxStep4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExtraCols)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxStep1
            // 
            this.gbxStep1.Controls.Add(this.btnChooseStructureFile);
            this.gbxStep1.Controls.Add(this.txtStructureDataFile);
            this.gbxStep1.Controls.Add(this.btnCancel);
            this.gbxStep1.Controls.Add(this.btnNext1to2);
            this.gbxStep1.Location = new System.Drawing.Point(12, 13);
            this.gbxStep1.Name = "gbxStep1";
            this.gbxStep1.Size = new System.Drawing.Size(420, 320);
            this.gbxStep1.TabIndex = 0;
            this.gbxStep1.TabStop = false;
            this.gbxStep1.Text = "Step 1 of 4: Choose Input Data File";
            // 
            // btnChooseStructureFile
            // 
            this.btnChooseStructureFile.Location = new System.Drawing.Point(258, 121);
            this.btnChooseStructureFile.Name = "btnChooseStructureFile";
            this.btnChooseStructureFile.Size = new System.Drawing.Size(107, 23);
            this.btnChooseStructureFile.TabIndex = 25;
            this.btnChooseStructureFile.Text = "Choose File";
            this.btnChooseStructureFile.UseVisualStyleBackColor = true;
            this.btnChooseStructureFile.Click += new System.EventHandler(this.btnChooseStructureFile_Click);
            // 
            // txtStructureDataFile
            // 
            this.txtStructureDataFile.Location = new System.Drawing.Point(35, 121);
            this.txtStructureDataFile.Name = "txtStructureDataFile";
            this.txtStructureDataFile.ReadOnly = true;
            this.txtStructureDataFile.Size = new System.Drawing.Size(198, 22);
            this.txtStructureDataFile.TabIndex = 24;
            this.txtStructureDataFile.Text = "choose file ...";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(207, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext1to2
            // 
            this.btnNext1to2.Enabled = false;
            this.btnNext1to2.Location = new System.Drawing.Point(109, 276);
            this.btnNext1to2.Name = "btnNext1to2";
            this.btnNext1to2.Size = new System.Drawing.Size(75, 23);
            this.btnNext1to2.TabIndex = 21;
            this.btnNext1to2.Text = "Next >>";
            this.btnNext1to2.UseVisualStyleBackColor = true;
            this.btnNext1to2.Click += new System.EventHandler(this.btnNext1to2_Click);
            // 
            // gbxStep2
            // 
            this.gbxStep2.Controls.Add(this.btnShowDataFormat2);
            this.gbxStep2.Controls.Add(this.btnCancel2);
            this.gbxStep2.Controls.Add(this.numMissingDataValue);
            this.gbxStep2.Controls.Add(this.btnBack2to1);
            this.gbxStep2.Controls.Add(this.numPloidy);
            this.gbxStep2.Controls.Add(this.btnNext2to3);
            this.gbxStep2.Controls.Add(this.numLoci);
            this.gbxStep2.Controls.Add(this.numIndividuals);
            this.gbxStep2.Controls.Add(this.label4);
            this.gbxStep2.Controls.Add(this.label3);
            this.gbxStep2.Controls.Add(this.label2);
            this.gbxStep2.Controls.Add(this.label1);
            this.gbxStep2.Location = new System.Drawing.Point(12, 12);
            this.gbxStep2.Name = "gbxStep2";
            this.gbxStep2.Size = new System.Drawing.Size(420, 320);
            this.gbxStep2.TabIndex = 1;
            this.gbxStep2.TabStop = false;
            this.gbxStep2.Text = "Step 2 of 4: Input Data File Information";
            // 
            // btnShowDataFormat2
            // 
            this.btnShowDataFormat2.Location = new System.Drawing.Point(129, 223);
            this.btnShowDataFormat2.Name = "btnShowDataFormat2";
            this.btnShowDataFormat2.Size = new System.Drawing.Size(148, 35);
            this.btnShowDataFormat2.TabIndex = 29;
            this.btnShowDataFormat2.Text = "Show Data Format";
            this.btnShowDataFormat2.UseVisualStyleBackColor = true;
            this.btnShowDataFormat2.Click += new System.EventHandler(this.btnShowDataFormat2_Click);
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(264, 276);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 23);
            this.btnCancel2.TabIndex = 28;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numMissingDataValue
            // 
            this.numMissingDataValue.Location = new System.Drawing.Point(230, 117);
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
            this.numMissingDataValue.TabIndex = 16;
            // 
            // btnBack2to1
            // 
            this.btnBack2to1.Location = new System.Drawing.Point(70, 276);
            this.btnBack2to1.Name = "btnBack2to1";
            this.btnBack2to1.Size = new System.Drawing.Size(75, 23);
            this.btnBack2to1.TabIndex = 26;
            this.btnBack2to1.Text = "<< Back";
            this.btnBack2to1.UseVisualStyleBackColor = true;
            this.btnBack2to1.Click += new System.EventHandler(this.btnBack2to1_Click);
            // 
            // numPloidy
            // 
            this.numPloidy.Location = new System.Drawing.Point(230, 89);
            this.numPloidy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPloidy.Name = "numPloidy";
            this.numPloidy.Size = new System.Drawing.Size(99, 22);
            this.numPloidy.TabIndex = 15;
            this.numPloidy.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnNext2to3
            // 
            this.btnNext2to3.Location = new System.Drawing.Point(166, 276);
            this.btnNext2to3.Name = "btnNext2to3";
            this.btnNext2to3.Size = new System.Drawing.Size(75, 23);
            this.btnNext2to3.TabIndex = 27;
            this.btnNext2to3.Text = "Next >>";
            this.btnNext2to3.UseVisualStyleBackColor = true;
            this.btnNext2to3.Click += new System.EventHandler(this.btnNext2to3_Click);
            // 
            // numLoci
            // 
            this.numLoci.Location = new System.Drawing.Point(230, 61);
            this.numLoci.Name = "numLoci";
            this.numLoci.Size = new System.Drawing.Size(99, 22);
            this.numLoci.TabIndex = 14;
            // 
            // numIndividuals
            // 
            this.numIndividuals.Location = new System.Drawing.Point(230, 34);
            this.numIndividuals.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numIndividuals.Name = "numIndividuals";
            this.numIndividuals.Size = new System.Drawing.Size(99, 22);
            this.numIndividuals.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "missing data value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "number of loci:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "ploidy of data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "number of individuals:";
            // 
            // gbxStep3
            // 
            this.gbxStep3.Controls.Add(this.btnShowDataFormat3);
            this.gbxStep3.Controls.Add(this.btnCancel3);
            this.gbxStep3.Controls.Add(this.btnBack3to2);
            this.gbxStep3.Controls.Add(this.btnNext3to4);
            this.gbxStep3.Controls.Add(this.cbxSingleLine);
            this.gbxStep3.Controls.Add(this.cbxPhase);
            this.gbxStep3.Controls.Add(this.cbxLociDistancesRow);
            this.gbxStep3.Controls.Add(this.cbxAlelesRow);
            this.gbxStep3.Controls.Add(this.label5);
            this.gbxStep3.Controls.Add(this.cbxMarkerRow);
            this.gbxStep3.Location = new System.Drawing.Point(12, 12);
            this.gbxStep3.Name = "gbxStep3";
            this.gbxStep3.Size = new System.Drawing.Size(420, 320);
            this.gbxStep3.TabIndex = 1;
            this.gbxStep3.TabStop = false;
            this.gbxStep3.Text = "Step 3 of 4: Format of Input";
            // 
            // btnShowDataFormat3
            // 
            this.btnShowDataFormat3.Location = new System.Drawing.Point(134, 216);
            this.btnShowDataFormat3.Name = "btnShowDataFormat3";
            this.btnShowDataFormat3.Size = new System.Drawing.Size(148, 35);
            this.btnShowDataFormat3.TabIndex = 33;
            this.btnShowDataFormat3.Text = "Show Data Format";
            this.btnShowDataFormat3.UseVisualStyleBackColor = true;
            this.btnShowDataFormat3.Click += new System.EventHandler(this.btnShowDataFormat2_Click);
            // 
            // btnCancel3
            // 
            this.btnCancel3.Location = new System.Drawing.Point(269, 269);
            this.btnCancel3.Name = "btnCancel3";
            this.btnCancel3.Size = new System.Drawing.Size(75, 23);
            this.btnCancel3.TabIndex = 32;
            this.btnCancel3.Text = "Cancel";
            this.btnCancel3.UseVisualStyleBackColor = true;
            this.btnCancel3.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBack3to2
            // 
            this.btnBack3to2.Location = new System.Drawing.Point(75, 269);
            this.btnBack3to2.Name = "btnBack3to2";
            this.btnBack3to2.Size = new System.Drawing.Size(75, 23);
            this.btnBack3to2.TabIndex = 30;
            this.btnBack3to2.Text = "<< Back";
            this.btnBack3to2.UseVisualStyleBackColor = true;
            this.btnBack3to2.Click += new System.EventHandler(this.btnBack3to2_Click);
            // 
            // btnNext3to4
            // 
            this.btnNext3to4.Location = new System.Drawing.Point(171, 269);
            this.btnNext3to4.Name = "btnNext3to4";
            this.btnNext3to4.Size = new System.Drawing.Size(75, 23);
            this.btnNext3to4.TabIndex = 31;
            this.btnNext3to4.Text = "Next >>";
            this.btnNext3to4.UseVisualStyleBackColor = true;
            this.btnNext3to4.Click += new System.EventHandler(this.btnNext3to4_Click);
            // 
            // cbxSingleLine
            // 
            this.cbxSingleLine.AutoSize = true;
            this.cbxSingleLine.Location = new System.Drawing.Point(53, 177);
            this.cbxSingleLine.Name = "cbxSingleLine";
            this.cbxSingleLine.Size = new System.Drawing.Size(268, 21);
            this.cbxSingleLine.TabIndex = 17;
            this.cbxSingleLine.Text = "data for individuals are in a single line";
            this.cbxSingleLine.UseVisualStyleBackColor = true;
            // 
            // cbxPhase
            // 
            this.cbxPhase.AutoSize = true;
            this.cbxPhase.Location = new System.Drawing.Point(53, 150);
            this.cbxPhase.Name = "cbxPhase";
            this.cbxPhase.Size = new System.Drawing.Size(96, 21);
            this.cbxPhase.TabIndex = 8;
            this.cbxPhase.Text = "phase info";
            this.cbxPhase.UseVisualStyleBackColor = true;
            // 
            // cbxLociDistancesRow
            // 
            this.cbxLociDistancesRow.AutoSize = true;
            this.cbxLociDistancesRow.Location = new System.Drawing.Point(53, 123);
            this.cbxLociDistancesRow.Name = "cbxLociDistancesRow";
            this.cbxLociDistancesRow.Size = new System.Drawing.Size(229, 21);
            this.cbxLociDistancesRow.TabIndex = 7;
            this.cbxLociDistancesRow.Text = "map distances between loci row";
            this.cbxLociDistancesRow.UseVisualStyleBackColor = true;
            // 
            // cbxAlelesRow
            // 
            this.cbxAlelesRow.AutoSize = true;
            this.cbxAlelesRow.Location = new System.Drawing.Point(53, 96);
            this.cbxAlelesRow.Name = "cbxAlelesRow";
            this.cbxAlelesRow.Size = new System.Drawing.Size(157, 21);
            this.cbxAlelesRow.TabIndex = 6;
            this.cbxAlelesRow.Text = "recessive aleles row";
            this.cbxAlelesRow.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Check if data file contains following rows:";
            // 
            // cbxMarkerRow
            // 
            this.cbxMarkerRow.AutoSize = true;
            this.cbxMarkerRow.Location = new System.Drawing.Point(53, 69);
            this.cbxMarkerRow.Name = "cbxMarkerRow";
            this.cbxMarkerRow.Size = new System.Drawing.Size(146, 21);
            this.cbxMarkerRow.TabIndex = 4;
            this.cbxMarkerRow.Text = "marker names row";
            this.cbxMarkerRow.UseVisualStyleBackColor = true;
            // 
            // gbxStep4
            // 
            this.gbxStep4.Controls.Add(this.btnShowDataFormat4);
            this.gbxStep4.Controls.Add(this.btnCancel4);
            this.gbxStep4.Controls.Add(this.numExtraCols);
            this.gbxStep4.Controls.Add(this.btnBack4to3);
            this.gbxStep4.Controls.Add(this.cbxExtraCols);
            this.gbxStep4.Controls.Add(this.btnFinish);
            this.gbxStep4.Controls.Add(this.label6);
            this.gbxStep4.Controls.Add(this.cbxPhenotypeCol);
            this.gbxStep4.Controls.Add(this.cbxSampleInfoCol);
            this.gbxStep4.Controls.Add(this.cbxPopInfoFlagCol);
            this.gbxStep4.Controls.Add(this.cbxPopOriginCol);
            this.gbxStep4.Controls.Add(this.cbxIdCol);
            this.gbxStep4.Location = new System.Drawing.Point(12, 12);
            this.gbxStep4.Name = "gbxStep4";
            this.gbxStep4.Size = new System.Drawing.Size(420, 320);
            this.gbxStep4.TabIndex = 1;
            this.gbxStep4.TabStop = false;
            this.gbxStep4.Text = "Step 4 of 4: Format of Input";
            // 
            // btnShowDataFormat4
            // 
            this.btnShowDataFormat4.Location = new System.Drawing.Point(130, 225);
            this.btnShowDataFormat4.Name = "btnShowDataFormat4";
            this.btnShowDataFormat4.Size = new System.Drawing.Size(148, 35);
            this.btnShowDataFormat4.TabIndex = 37;
            this.btnShowDataFormat4.Text = "Show Data Format";
            this.btnShowDataFormat4.UseVisualStyleBackColor = true;
            this.btnShowDataFormat4.Click += new System.EventHandler(this.btnShowDataFormat2_Click);
            // 
            // btnCancel4
            // 
            this.btnCancel4.Location = new System.Drawing.Point(265, 278);
            this.btnCancel4.Name = "btnCancel4";
            this.btnCancel4.Size = new System.Drawing.Size(75, 23);
            this.btnCancel4.TabIndex = 36;
            this.btnCancel4.Text = "Cancel";
            this.btnCancel4.UseVisualStyleBackColor = true;
            this.btnCancel4.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numExtraCols
            // 
            this.numExtraCols.Enabled = false;
            this.numExtraCols.Location = new System.Drawing.Point(308, 197);
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
            this.numExtraCols.TabIndex = 19;
            this.numExtraCols.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBack4to3
            // 
            this.btnBack4to3.Location = new System.Drawing.Point(71, 278);
            this.btnBack4to3.Name = "btnBack4to3";
            this.btnBack4to3.Size = new System.Drawing.Size(75, 23);
            this.btnBack4to3.TabIndex = 34;
            this.btnBack4to3.Text = "<< Back";
            this.btnBack4to3.UseVisualStyleBackColor = true;
            this.btnBack4to3.Click += new System.EventHandler(this.btnBack4to3_Click);
            // 
            // cbxExtraCols
            // 
            this.cbxExtraCols.AutoSize = true;
            this.cbxExtraCols.Location = new System.Drawing.Point(22, 198);
            this.cbxExtraCols.Name = "cbxExtraCols";
            this.cbxExtraCols.Size = new System.Drawing.Size(283, 21);
            this.cbxExtraCols.TabIndex = 18;
            this.cbxExtraCols.Text = "other extra columns => if so, how many?";
            this.cbxExtraCols.UseVisualStyleBackColor = true;
            this.cbxExtraCols.CheckedChanged += new System.EventHandler(this.cbxExtraCols_CheckedChanged);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(167, 278);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 35;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Check if data file contains following columns:";
            // 
            // cbxPhenotypeCol
            // 
            this.cbxPhenotypeCol.AutoSize = true;
            this.cbxPhenotypeCol.Location = new System.Drawing.Point(22, 171);
            this.cbxPhenotypeCol.Name = "cbxPhenotypeCol";
            this.cbxPhenotypeCol.Size = new System.Drawing.Size(171, 21);
            this.cbxPhenotypeCol.TabIndex = 16;
            this.cbxPhenotypeCol.Text = "phenotype information";
            this.cbxPhenotypeCol.UseVisualStyleBackColor = true;
            // 
            // cbxSampleInfoCol
            // 
            this.cbxSampleInfoCol.AutoSize = true;
            this.cbxSampleInfoCol.Location = new System.Drawing.Point(22, 144);
            this.cbxSampleInfoCol.Name = "cbxSampleInfoCol";
            this.cbxSampleInfoCol.Size = new System.Drawing.Size(213, 21);
            this.cbxSampleInfoCol.TabIndex = 15;
            this.cbxSampleInfoCol.Text = "sampling location information";
            this.cbxSampleInfoCol.UseVisualStyleBackColor = true;
            // 
            // cbxPopInfoFlagCol
            // 
            this.cbxPopInfoFlagCol.AutoSize = true;
            this.cbxPopInfoFlagCol.Location = new System.Drawing.Point(22, 117);
            this.cbxPopInfoFlagCol.Name = "cbxPopInfoFlagCol";
            this.cbxPopInfoFlagCol.Size = new System.Drawing.Size(146, 21);
            this.cbxPopInfoFlagCol.TabIndex = 14;
            this.cbxPopInfoFlagCol.Text = "USEPOPINFO flag";
            this.cbxPopInfoFlagCol.UseVisualStyleBackColor = true;
            // 
            // cbxPopOriginCol
            // 
            this.cbxPopOriginCol.AutoSize = true;
            this.cbxPopOriginCol.Location = new System.Drawing.Point(22, 90);
            this.cbxPopOriginCol.Name = "cbxPopOriginCol";
            this.cbxPopOriginCol.Size = new System.Drawing.Size(299, 21);
            this.cbxPopOriginCol.TabIndex = 13;
            this.cbxPopOriginCol.Text = "alleged population origin of each individual";
            this.cbxPopOriginCol.UseVisualStyleBackColor = true;
            // 
            // cbxIdCol
            // 
            this.cbxIdCol.AutoSize = true;
            this.cbxIdCol.Location = new System.Drawing.Point(22, 63);
            this.cbxIdCol.Name = "cbxIdCol";
            this.cbxIdCol.Size = new System.Drawing.Size(162, 21);
            this.cbxIdCol.TabIndex = 12;
            this.cbxIdCol.Text = "ID for each individual";
            this.cbxIdCol.UseVisualStyleBackColor = true;
            // 
            // FormLoadStructureData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 343);
            this.Controls.Add(this.gbxStep4);
            this.Controls.Add(this.gbxStep3);
            this.Controls.Add(this.gbxStep2);
            this.Controls.Add(this.gbxStep1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormLoadStructureData";
            this.Text = "Load Structure Data";
            this.gbxStep1.ResumeLayout(false);
            this.gbxStep1.PerformLayout();
            this.gbxStep2.ResumeLayout(false);
            this.gbxStep2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMissingDataValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPloidy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndividuals)).EndInit();
            this.gbxStep3.ResumeLayout(false);
            this.gbxStep3.PerformLayout();
            this.gbxStep4.ResumeLayout(false);
            this.gbxStep4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExtraCols)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStep1;
        private System.Windows.Forms.GroupBox gbxStep2;
        private System.Windows.Forms.GroupBox gbxStep3;
        private System.Windows.Forms.GroupBox gbxStep4;
        private System.Windows.Forms.CheckBox cbxLociDistancesRow;
        private System.Windows.Forms.CheckBox cbxAlelesRow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxMarkerRow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext1to2;
        private System.Windows.Forms.NumericUpDown numExtraCols;
        private System.Windows.Forms.CheckBox cbxExtraCols;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbxPhenotypeCol;
        private System.Windows.Forms.CheckBox cbxSampleInfoCol;
        private System.Windows.Forms.CheckBox cbxPopInfoFlagCol;
        private System.Windows.Forms.CheckBox cbxPopOriginCol;
        private System.Windows.Forms.CheckBox cbxIdCol;
        private System.Windows.Forms.CheckBox cbxSingleLine;
        private System.Windows.Forms.NumericUpDown numMissingDataValue;
        private System.Windows.Forms.NumericUpDown numPloidy;
        private System.Windows.Forms.NumericUpDown numLoci;
        private System.Windows.Forms.NumericUpDown numIndividuals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxPhase;
        private System.Windows.Forms.Button btnChooseStructureFile;
        private System.Windows.Forms.TextBox txtStructureDataFile;
        private System.Windows.Forms.Button btnShowDataFormat2;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnBack2to1;
        private System.Windows.Forms.Button btnNext2to3;
        private System.Windows.Forms.Button btnShowDataFormat3;
        private System.Windows.Forms.Button btnCancel3;
        private System.Windows.Forms.Button btnBack3to2;
        private System.Windows.Forms.Button btnNext3to4;
        private System.Windows.Forms.Button btnShowDataFormat4;
        private System.Windows.Forms.Button btnCancel4;
        private System.Windows.Forms.Button btnBack4to3;
        private System.Windows.Forms.Button btnFinish;
    }
}