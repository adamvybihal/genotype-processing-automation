using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenotypeDataProcessing
{
    public partial class FormDataParams : Form
    {
        public FormDataParams()
        {
            InitializeComponent();
        }

        private void cbxExtraCols_CheckedChanged(object sender, EventArgs e)
        {
            numExtraCols.Enabled = cbxExtraCols.Checked;
        }
    }
}
