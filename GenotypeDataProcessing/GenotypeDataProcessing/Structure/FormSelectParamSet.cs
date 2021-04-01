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
    public partial class FormSelectParamSet : Form
    {

        private ProjectScreen callerProjectScreen;

        public FormSelectParamSet(ProjectScreen projectScreen)
        {
            InitializeComponent();

            callerProjectScreen = projectScreen;

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

        private void btnSelectParamSet_Click(object sender, EventArgs e)
        {
            if (lsvParamSets.SelectedItems.Count > 0)
            {
                ListViewItem itm = lsvParamSets.SelectedItems[0];

                FormStructureParameterSet formStructureParameterSet = new FormStructureParameterSet(callerProjectScreen, FormStructureParameterSetState.UPDATE, itm.Text);
                formStructureParameterSet.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Nothing was selected.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
