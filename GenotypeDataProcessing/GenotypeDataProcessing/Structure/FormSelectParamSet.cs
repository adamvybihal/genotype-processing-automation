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
    /// Form for selecting Structure's parameter set
    /// </summary>
    public partial class FormSelectParamSet : Form
    {

        private ProjectScreen callerProjectScreen;
        private FormSelectParamSetState selectParamSetState;

        /// <summary>
        /// FormSelectParamSet constructor
        /// </summary>
        /// <param name="projectScreen">ProjectScreen form calling this class</param>
        /// <param name="state">Current form state</param>
        public FormSelectParamSet(ProjectScreen projectScreen, FormSelectParamSetState state)
        {
            InitializeComponent();

            callerProjectScreen = projectScreen;
            selectParamSetState = state;

            PopulateListView();
        }

        private void PopulateListView()
        {
            lsvParamSets.Columns.Clear();
            lsvParamSets.View = View.Details;

            lsvParamSets.Columns.Add("parameter set");
            lsvParamSets.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            switch (selectParamSetState)
            {
                case FormSelectParamSetState.UPDATE_SET:
                    PopulateWithParamSetsNames<StructureParamSetStruct>(ProjectInfo.structureParamSets);
                    break;
                case FormSelectParamSetState.SELECT_COMPLETED_SET_FOR_HARVESTER:
                    PopulateWithParamSetsNames<StructureJobInfoStruct>(ProjectInfo.structureJobInfo);
                    break;
            }
        }

        private void PopulateWithParamSetsNames<TValue>(Dictionary<string,TValue> paramSets)
        {
            foreach (KeyValuePair<string, TValue> kvp in paramSets)
            {
                lsvParamSets.Items.Add(kvp.Key);
            }
        }

        private void btnSelectParamSet_Click(object sender, EventArgs e)
        {
            if (lsvParamSets.SelectedItems.Count > 0)
            {
                ListViewItem itm = lsvParamSets.SelectedItems[0];

                switch (selectParamSetState)
                {
                    case FormSelectParamSetState.UPDATE_SET:
                        GoToParameterSetUpdate(itm.Text);
                        break;
                    case FormSelectParamSetState.SELECT_COMPLETED_SET_FOR_HARVESTER:
                        SelectSetForStructureHarvester(itm.Text);
                        break;
                }
            }
            else
            {
                MessageBox.Show(
                    "Nothing was selected.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }

        private void GoToParameterSetUpdate(string paramSet)
        {
            FormStructureParameterSet formStructureParameterSet = new FormStructureParameterSet(callerProjectScreen, FormStructureParameterSetState.UPDATE, paramSet);
            formStructureParameterSet.ShowDialog();

            this.Close();
        }

        private void SelectSetForStructureHarvester(string paramSet)
        {
            callerProjectScreen.SetSelectedStructureResults(paramSet);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
