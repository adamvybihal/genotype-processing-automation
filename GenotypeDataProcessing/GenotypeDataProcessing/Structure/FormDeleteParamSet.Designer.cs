
namespace GenotypeDataProcessing.Structure
{
    partial class FormDeleteParamSet
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
            this.lsvParamSets = new System.Windows.Forms.ListView();
            this.btnDeleteParamSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvParamSets
            // 
            this.lsvParamSets.HideSelection = false;
            this.lsvParamSets.Location = new System.Drawing.Point(69, 21);
            this.lsvParamSets.Name = "lsvParamSets";
            this.lsvParamSets.Size = new System.Drawing.Size(261, 196);
            this.lsvParamSets.TabIndex = 0;
            this.lsvParamSets.UseCompatibleStateImageBehavior = false;
            // 
            // btnDeleteParamSet
            // 
            this.btnDeleteParamSet.Location = new System.Drawing.Point(255, 223);
            this.btnDeleteParamSet.Name = "btnDeleteParamSet";
            this.btnDeleteParamSet.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteParamSet.TabIndex = 1;
            this.btnDeleteParamSet.Text = "Delete";
            this.btnDeleteParamSet.UseVisualStyleBackColor = true;
            this.btnDeleteParamSet.Click += new System.EventHandler(this.btnDeleteParamSet_Click);
            // 
            // FormDeleteParamSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 270);
            this.Controls.Add(this.btnDeleteParamSet);
            this.Controls.Add(this.lsvParamSets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormDeleteParamSet";
            this.Text = "FormDeleteParamSet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvParamSets;
        private System.Windows.Forms.Button btnDeleteParamSet;
    }
}