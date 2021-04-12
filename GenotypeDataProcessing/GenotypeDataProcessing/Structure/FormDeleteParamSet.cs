using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenotypeDataProcessing.Structure
{
    /// <summary>
    /// Form for deleting Structure's parameter sets
    /// </summary>
    public partial class FormDeleteParamSet : Form
    {

        private ProjectScreen callerProjectScreen;

        /// <summary>
        /// FormDeleteParamSet constructor
        /// </summary>
        /// <param name="projectScreen">ProjectScreen Form calling this class</param>
        public FormDeleteParamSet(ProjectScreen projectScreen)
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

        private void btnDeleteParamSet_Click(object sender, EventArgs e)
        {
            string structureFolderPath = Path.Combine(ProjectInfo.projectNamePath, ProjectInfo.structureFolder);

            if (lsvParamSets.SelectedItems.Count > 0)
            {
                var confirmation = MessageBox.Show(
                    "Are you sure, you want to delete selected parameter set(s)?",
                    "Confirmation", 
                    MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    for (int i = lsvParamSets.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem itm = lsvParamSets.SelectedItems[i];
                        lsvParamSets.Items[itm.Index].Remove();

                        string fullParamSetPath = Path.Combine(structureFolderPath, itm.Text);
                        DeleteParamsetDirectory(fullParamSetPath);

                        DeleteFromDictionary<StructureParamSetStruct>(ProjectInfo.structureParamSets, itm.Text);
                        DeleteFromDictionary<StructureJobInfoStruct>(ProjectInfo.structureJobInfo, itm.Text);                        
                    }

                    callerProjectScreen.UpdateStructureTreeView();
                }
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

        private void DeleteParamsetDirectory(string directoryPath)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(directoryPath);
                dir.Attributes = dir.Attributes & ~FileAttributes.ReadOnly;
                dir.Delete(true);
            }
            catch (IOException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DeleteFromDictionary<TValue>(Dictionary<string, TValue> keyValuePairs, string paramset)
        {
            if (keyValuePairs.ContainsKey(paramset))
            {
                keyValuePairs.Remove(paramset);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}