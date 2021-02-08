
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
            this.btnChooseDataFile = new System.Windows.Forms.Button();
            this.lblDataFile = new System.Windows.Forms.Label();
            this.btnStartAnalysis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChooseDataFile
            // 
            this.btnChooseDataFile.Location = new System.Drawing.Point(125, 49);
            this.btnChooseDataFile.Name = "btnChooseDataFile";
            this.btnChooseDataFile.Size = new System.Drawing.Size(160, 50);
            this.btnChooseDataFile.TabIndex = 0;
            this.btnChooseDataFile.Text = "Choose Data File";
            this.btnChooseDataFile.UseVisualStyleBackColor = true;
            this.btnChooseDataFile.Click += new System.EventHandler(this.btnChooseDataFile_Click);
            // 
            // lblDataFile
            // 
            this.lblDataFile.AutoSize = true;
            this.lblDataFile.Location = new System.Drawing.Point(122, 102);
            this.lblDataFile.MaximumSize = new System.Drawing.Size(160, 0);
            this.lblDataFile.Name = "lblDataFile";
            this.lblDataFile.Size = new System.Drawing.Size(98, 17);
            this.lblDataFile.TabIndex = 1;
            this.lblDataFile.Text = "Choose File ...";
            // 
            // btnStartAnalysis
            // 
            this.btnStartAnalysis.Location = new System.Drawing.Point(125, 143);
            this.btnStartAnalysis.Name = "btnStartAnalysis";
            this.btnStartAnalysis.Size = new System.Drawing.Size(160, 38);
            this.btnStartAnalysis.TabIndex = 2;
            this.btnStartAnalysis.Text = "Start Analysis";
            this.btnStartAnalysis.UseVisualStyleBackColor = true;
            this.btnStartAnalysis.Click += new System.EventHandler(this.btnStartAnalysis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 313);
            this.Controls.Add(this.btnStartAnalysis);
            this.Controls.Add(this.lblDataFile);
            this.Controls.Add(this.btnChooseDataFile);
            this.Name = "Form1";
            this.Text = "Genotype Data Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseDataFile;
        private System.Windows.Forms.Label lblDataFile;
        private System.Windows.Forms.Button btnStartAnalysis;
    }
}

