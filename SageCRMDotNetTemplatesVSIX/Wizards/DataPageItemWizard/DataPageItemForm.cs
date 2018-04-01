using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SageCRMDotNetTemplatesVSIX.Wizards.DataPageItemWizard
{
    public partial class DataPageItemForm : Form
    {
        public string EntityName
        {
            get { return txtEntityName.Text; }
            set { txtEntityName.Text = value; }
        }

        public string EntityIDField
        {
            get { return txtEntityIDField.Text; }
            set { txtEntityIDField.Text = value; }
        }

        public string EntityDetailScreen
        {
            get { return txtDetailScreen.Text; }
            set { txtDetailScreen.Text = value; }
        }

        public bool IncludeDetailScreen
        {
            get { return cbxIncludeDetailScreen.Checked; }
            set { cbxIncludeDetailScreen.Checked = value; }
        }

        public bool OverrideBuildContents
        {
            get { return cbxOverrideBuildContents.Checked; }
            set { cbxOverrideBuildContents.Checked = value; }
        }

        public DataPageItemForm()
        {
            InitializeComponent();
        }

        private void cbxOverrideBuildContents_CheckedChanged(object sender, EventArgs e)
        {
            txtDetailScreen.Enabled = cbxIncludeDetailScreen.Checked;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
