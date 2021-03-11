
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
            this.numPreDefPopulations = new System.Windows.Forms.NumericUpDown();
            this.numClusters = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numIndividuals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreDefPopulations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClusters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numIndividuals
            // 
            this.numIndividuals.Location = new System.Drawing.Point(388, 176);
            this.numIndividuals.Name = "numIndividuals";
            this.numIndividuals.Size = new System.Drawing.Size(120, 22);
            this.numIndividuals.TabIndex = 24;
            // 
            // numPreDefPopulations
            // 
            this.numPreDefPopulations.Location = new System.Drawing.Point(388, 147);
            this.numPreDefPopulations.Name = "numPreDefPopulations";
            this.numPreDefPopulations.Size = new System.Drawing.Size(120, 22);
            this.numPreDefPopulations.TabIndex = 23;
            // 
            // numClusters
            // 
            this.numClusters.Location = new System.Drawing.Point(388, 117);
            this.numClusters.Name = "numClusters";
            this.numClusters.Size = new System.Drawing.Size(120, 22);
            this.numClusters.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "number of clusters:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "number of runs:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "number of individuals:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(388, 204);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "number of populations:";
            // 
            // FormClumppParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numIndividuals);
            this.Controls.Add(this.numPreDefPopulations);
            this.Controls.Add(this.numClusters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "FormClumppParams";
            this.Text = "Set CLUMPP Parameters";
            ((System.ComponentModel.ISupportInitialize)(this.numIndividuals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPreDefPopulations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numClusters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numIndividuals;
        private System.Windows.Forms.NumericUpDown numPreDefPopulations;
        private System.Windows.Forms.NumericUpDown numClusters;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}