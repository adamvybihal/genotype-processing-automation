
namespace GenotypeDataProcessing.distruct
{
    partial class FormDistructJobSettings
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
            this.cbxRange = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lsvParamSets = new System.Windows.Forms.ListView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numToK = new System.Windows.Forms.NumericUpDown();
            this.numFromK = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numToK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromK)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxRange
            // 
            this.cbxRange.AutoSize = true;
            this.cbxRange.Location = new System.Drawing.Point(191, 232);
            this.cbxRange.Name = "cbxRange";
            this.cbxRange.Size = new System.Drawing.Size(46, 21);
            this.cbxRange.TabIndex = 28;
            this.cbxRange.Text = "to:";
            this.cbxRange.UseVisualStyleBackColor = true;
            this.cbxRange.CheckedChanged += new System.EventHandler(this.cbxRange_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Choose parameter set";
            // 
            // lsvParamSets
            // 
            this.lsvParamSets.HideSelection = false;
            this.lsvParamSets.Location = new System.Drawing.Point(94, 50);
            this.lsvParamSets.Name = "lsvParamSets";
            this.lsvParamSets.Size = new System.Drawing.Size(214, 123);
            this.lsvParamSets.TabIndex = 26;
            this.lsvParamSets.UseCompatibleStateImageBehavior = false;
            this.lsvParamSets.SelectedIndexChanged += new System.EventHandler(this.lsvParamSets_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(222, 285);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(112, 285);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 24;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Run distruct for K:";
            // 
            // numToK
            // 
            this.numToK.Location = new System.Drawing.Point(243, 231);
            this.numToK.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numToK.Name = "numToK";
            this.numToK.Size = new System.Drawing.Size(65, 22);
            this.numToK.TabIndex = 22;
            this.numToK.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numFromK
            // 
            this.numFromK.Location = new System.Drawing.Point(94, 231);
            this.numFromK.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFromK.Name = "numFromK";
            this.numFromK.Size = new System.Drawing.Size(65, 22);
            this.numFromK.TabIndex = 21;
            this.numFromK.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormDistructJobSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 335);
            this.Controls.Add(this.cbxRange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lsvParamSets);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numToK);
            this.Controls.Add(this.numFromK);
            this.Name = "FormDistructJobSettings";
            this.Text = "Distruct Job Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numToK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lsvParamSets;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numToK;
        private System.Windows.Forms.NumericUpDown numFromK;
    }
}