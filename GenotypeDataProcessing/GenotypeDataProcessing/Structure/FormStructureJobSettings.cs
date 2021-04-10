using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenotypeDataProcessing.Structure
{
    /// <summary>
    /// Form for setting info about Structure job
    /// </summary>
    public partial class FormStructureJobSettings : Form
    {

        private string parameterSet = "";

        /// <summary>
        /// FormStructureJobSettings constructor
        /// </summary>
        public FormStructureJobSettings()
        {
            InitializeComponent();

            PopulateListView();
        }

        private void PopulateListView()
        {
            lsvParamSets.Columns.Clear();
            lsvParamSets.View = View.Details;

            lsvParamSets.Columns.Add("parameter set");
            lsvParamSets.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (KeyValuePair<string, StructureParamSetStruct> kvp in ProjectInfo.structureParamSets)
            {
                lsvParamSets.Items.Add(kvp.Key);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (lsvParamSets.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "No parameter set was selected!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (numFromK.Value > numToK.Value)
            {
                MessageBox.Show(
                    "Ending K is smaller than starting K!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            StructureJobInfoStruct jobInfo;
            jobInfo.startingK = (int)numFromK.Value;
            jobInfo.endingK = (int)numToK.Value;
            jobInfo.iterations = (int)numIterations.Value;

            ListViewItem itm = lsvParamSets.SelectedItems[0];
            parameterSet = itm.Text;

            SetJobInfo(parameterSet, jobInfo);
        }

        private void SetJobInfo(string paramset, StructureJobInfoStruct jobInfo)
        {
            if (ProjectInfo.structureParamSets.ContainsKey(paramset))
            {
                if (ProjectInfo.structureJobInfo.ContainsKey(paramset))
                    ProjectInfo.structureJobInfo.Remove(paramset);

                ProjectInfo.structureJobInfo.Add(paramset, jobInfo);

                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Something went wrong. Parameter set does not exist.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
        }

        /// <summary>
        /// Gets name of selected parameter set, selected by a user
        /// </summary>
        /// <returns>string name of selected parameter set</returns>
        public string GetSelectedParamSet()
        {
            return parameterSet;
        }
    }
}
