
namespace GenotypeDataProcessing.Structure
{
    partial class FormSelectParamSet
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelectParamSet = new System.Windows.Forms.Button();
            this.lsvParamSets = new System.Windows.Forms.ListView();
            this.lblSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(226, 263);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelectParamSet
            // 
            this.btnSelectParamSet.Location = new System.Drawing.Point(145, 263);
            this.btnSelectParamSet.Name = "btnSelectParamSet";
            this.btnSelectParamSet.Size = new System.Drawing.Size(75, 23);
            this.btnSelectParamSet.TabIndex = 4;
            this.btnSelectParamSet.Text = "Select";
            this.btnSelectParamSet.UseVisualStyleBackColor = true;
            this.btnSelectParamSet.Click += new System.EventHandler(this.btnSelectParamSet_Click);
            // 
            // lsvParamSets
            // 
            this.lsvParamSets.HideSelection = false;
            this.lsvParamSets.Location = new System.Drawing.Point(40, 61);
            this.lsvParamSets.MultiSelect = false;
            this.lsvParamSets.Name = "lsvParamSets";
            this.lsvParamSets.Size = new System.Drawing.Size(261, 196);
            this.lsvParamSets.TabIndex = 3;
            this.lsvParamSets.UseCompatibleStateImageBehavior = false;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(37, 19);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(46, 17);
            this.lblSelect.TabIndex = 6;
            this.lblSelect.Text = "label1";
            // 
            // FormSelectParamSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 303);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelectParamSet);
            this.Controls.Add(this.lsvParamSets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSelectParamSet";
            this.Text = "Select Parameter Set";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelectParamSet;
        private System.Windows.Forms.ListView lsvParamSets;
        private System.Windows.Forms.Label lblSelect;
    }
}