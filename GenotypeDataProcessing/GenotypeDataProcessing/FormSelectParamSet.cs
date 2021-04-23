using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GenotypeDataProcessing.CLUMPP;
using GenotypeDataProcessing.distruct;

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

            TellWhatToSelect();
            PopulateListView();
        }

        private void TellWhatToSelect()
        {
            switch (selectParamSetState)
            {
                case FormSelectParamSetState.UPDATE_STRUCTURE_SET:
                case FormSelectParamSetState.UPDATE_CLUMPP_SET:
                case FormSelectParamSetState.UPDATE_DISTRUCT_SET:
                    lblSelect.Text = "Select parameter set, which is to be updated.";
                    break;
                case FormSelectParamSetState.SELECT_COMPLETED_SET_FOR_HARVESTER:
                    lblSelect.Text = "Select Structure parameter set to harvest.";
                    break;
                case FormSelectParamSetState.SELECT_HARVESTER_JOB_FOR_CLUMPP:
                    lblSelect.Text = "Select completed Harvester job, to infer\n necessary CLUMPP parameters.";
                    break;
                case FormSelectParamSetState.SELECT_CLUMPP_JOB_FOR_DISTRUCT:
                    lblSelect.Text = "Select completed CLUMPP job, to infer\n necessary distruct parameters.";
                    break;
            }
        }

        private void PopulateListView()
        {
            lsvParamSets.Columns.Clear();
            lsvParamSets.View = View.Details;

            lsvParamSets.Columns.Add("parameter set");
            lsvParamSets.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            switch (selectParamSetState)
            {
                case FormSelectParamSetState.UPDATE_STRUCTURE_SET:
                    PopulateWithParamSetsNames<StructureParamSetStruct>(ProjectInfo.structureParamSets);
                    break;
                case FormSelectParamSetState.SELECT_COMPLETED_SET_FOR_HARVESTER:
                    PopulateWithParamSetsNames<StructureJobInfoStruct>(ProjectInfo.structureJobInfo);
                    break;
                case FormSelectParamSetState.SELECT_HARVESTER_JOB_FOR_CLUMPP:
                    PopulateWithParamSetsNames<bool>(ProjectInfo.harvesterJobDone);
                    break;
                case FormSelectParamSetState.UPDATE_CLUMPP_SET:
                    PopulateWithParamSetsNames<ClumppParamStruct>(ProjectInfo.clumppParamSets);
                    break;
                case FormSelectParamSetState.SELECT_CLUMPP_JOB_FOR_DISTRUCT:
                    PopulateWithParamSetsNames<ClumppJobInfoStruct>(ProjectInfo.clumppJobInfo);
                    break;
                case FormSelectParamSetState.UPDATE_DISTRUCT_SET:
                    PopulateWithParamSetsNames<DistructParamStruct>(ProjectInfo.distructParamSets);
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
                    case FormSelectParamSetState.UPDATE_STRUCTURE_SET:
                        GoToStructureParameterSetUpdate(itm.Text);
                        break;
                    case FormSelectParamSetState.SELECT_COMPLETED_SET_FOR_HARVESTER:
                        SelectSetForStructureHarvester(itm.Text);
                        break;
                    case FormSelectParamSetState.SELECT_HARVESTER_JOB_FOR_CLUMPP:
                        GoToNewClumppParametersSet(itm.Text);
                        break;
                    case FormSelectParamSetState.UPDATE_CLUMPP_SET:
                        GoToClumppParameterSetUpdate(itm.Text);
                        break;
                    case FormSelectParamSetState.SELECT_CLUMPP_JOB_FOR_DISTRUCT:
                        GoToNewDistructParameterSet(itm.Text);
                        break;
                    case FormSelectParamSetState.UPDATE_DISTRUCT_SET:
                        GoToDistructParameterSetUpdate(itm.Text);
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

        private void GoToStructureParameterSetUpdate(string paramSet)
        {
            FormStructureParameterSet formStructureParameterSet = new FormStructureParameterSet(callerProjectScreen, 
                                                                            FormStructureParameterSetState.UPDATE,
                                                                            paramSet);
            formStructureParameterSet.ShowDialog();

            this.Close();
        }

        private void SelectSetForStructureHarvester(string paramSet)
        {
            callerProjectScreen.SetSelectedStructureResults(paramSet);

            this.Close();
        }

        private void GoToNewClumppParametersSet(string paramSet)
        {
            FormClumppParams formClumppParams = new FormClumppParams(
                                                        callerProjectScreen,
                                                        paramSet,
                                                        ProjectInfo.structureJobInfo[paramSet].iterations,
                                                        ProjectInfo.structureInputInfo.numInds
                                                        );
            formClumppParams.ShowDialog();

            this.Close();
        }

        private void GoToClumppParameterSetUpdate(string paramSet)
        {
            FormClumppParams formClumppParams = new FormClumppParams(
                                                        callerProjectScreen,
                                                        paramSet,
                                                        ProjectInfo.clumppParamSets[paramSet]
                                                        );
            formClumppParams.ShowDialog();

            this.Close();
        }

        private void GoToNewDistructParameterSet(string paramSet)
        {
            FormDistructParams formDistructParams = new FormDistructParams(
                                                            callerProjectScreen,
                                                            paramSet,
                                                            ProjectInfo.clumppParamSets[paramSet].populations,
                                                            ProjectInfo.structureInputInfo.numInds
                                                            );
            formDistructParams.ShowDialog();

            this.Close();
        }

        private void GoToDistructParameterSetUpdate(string paramSet)
        {
            FormDistructParams formDistructParams = new FormDistructParams(
                                                            callerProjectScreen,
                                                            paramSet,
                                                            ProjectInfo.distructParamSets[paramSet]
                                                            );
            formDistructParams.ShowDialog();

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
