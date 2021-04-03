
namespace GenotypeDataProcessing.Structure
{
    partial class FormStructureJobSettings
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
            this.numFromK = new System.Windows.Forms.NumericUpDown();
            this.numToK = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numIterations = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lsvParamSets = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numFromK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numToK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIterations)).BeginInit();
            this.SuspendLayout();
            // 
            // numFromK
            // 
            this.numFromK.Location = new System.Drawing.Point(129, 202);
            this.numFromK.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFromK.Name = "numFromK";
            this.numFromK.Size = new System.Drawing.Size(65, 22);
            this.numFromK.TabIndex = 0;
            this.numFromK.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numToK
            // 
            this.numToK.Location = new System.Drawing.Point(250, 202);
            this.numToK.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numToK.Name = "numToK";
            this.numToK.Size = new System.Drawing.Size(65, 22);
            this.numToK.TabIndex = 1;
            this.numToK.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set K from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "to";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of iterations:";
            // 
            // numIterations
            // 
            this.numIterations.Location = new System.Drawing.Point(212, 251);
            this.numIterations.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numIterations.Name = "numIterations";
            this.numIterations.Size = new System.Drawing.Size(65, 22);
            this.numIterations.TabIndex = 5;
            this.numIterations.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(90, 300);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(200, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lsvParamSets
            // 
            this.lsvParamSets.HideSelection = false;
            this.lsvParamSets.Location = new System.Drawing.Point(73, 49);
            this.lsvParamSets.Name = "lsvParamSets";
            this.lsvParamSets.Size = new System.Drawing.Size(214, 123);
            this.lsvParamSets.TabIndex = 8;
            this.lsvParamSets.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Choose parameter set";
            // 
            // FormStructureJobSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 357);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lsvParamSets);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numIterations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numToK);
            this.Controls.Add(this.numFromK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormStructureJobSettings";
            this.Text = "FormStructureJobSettings";
            ((System.ComponentModel.ISupportInitialize)(this.numFromK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numToK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIterations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numFromK;
        private System.Windows.Forms.NumericUpDown numToK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numIterations;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lsvParamSets;
        private System.Windows.Forms.Label label4;
    }
}