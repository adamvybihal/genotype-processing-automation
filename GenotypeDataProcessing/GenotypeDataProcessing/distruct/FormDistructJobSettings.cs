using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenotypeDataProcessing.distruct
{
    public partial class FormDistructJobSettings : Form
    {
        private string chosenParamset = "";
        private int startingK;
        private int endingK;

        /// <summary>
        /// Form for setting info about distruct job
        /// </summary>
        public FormDistructJobSettings()
        {
            InitializeComponent();

            PopulateListView();

            cbxRange.Checked = false;
            numToK.Enabled = false;
        }

        private void PopulateListView()
        {
            lsvParamSets.Columns.Clear();
            lsvParamSets.View = View.Details;

            lsvParamSets.Columns.Add("parameter set");
            lsvParamSets.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (KeyValuePair<string, DistructParamStruct> kvp in ProjectInfo.distructParamSets)
            {
                lsvParamSets.Items.Add(kvp.Key);
            }
        }

        private void cbxRange_CheckedChanged(object sender, EventArgs e)
        {
            numToK.Enabled = cbxRange.Checked;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (lsvParamSets.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "No parameter set was selected!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            if (cbxRange.Checked && (numFromK.Value > numToK.Value))
            {
                MessageBox.Show(
                    "Ending K is smaller than starting K!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            chosenParamset = lsvParamSets.SelectedItems[0].Text;

            if (cbxRange.Checked)
            {
                startingK = (int)numFromK.Value;
                endingK = (int)numToK.Value;
            }
            else
            {
                startingK = (int)numFromK.Value;
                endingK = (int)numFromK.Value;
            }

            this.Close();
        }

        private void lsvParamSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvParamSets.SelectedItems.Count != 0)
            {
                string paramset = lsvParamSets.SelectedItems[0].Text;
                try
                {
                    int minK = ProjectInfo.clumppJobInfo[paramset].startK;
                    int maxK = ProjectInfo.clumppJobInfo[paramset].endK;

                    numFromK.Minimum = minK;
                    numFromK.Maximum = maxK;
                    numFromK.Value = minK;

                    numToK.Minimum = minK;
                    numToK.Maximum = maxK;
                    numToK.Value = maxK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Returns chosen parameter set
        /// </summary>
        /// <returns>string value of parameter set name</returns>
        public string GetChosenParamset()
        {
            return chosenParamset;
        }

        /// <summary>
        /// Returns starting K for analysis
        /// </summary>
        /// <returns>integer value of K</returns>
        public int GetStartingK()
        {
            return startingK;
        }

        /// <summary>
        /// Returns ending K for analysis
        /// </summary>
        /// <returns>integer value of K</returns>
        public int GetEndingK()
        {
            return endingK;
        }
    }
}
