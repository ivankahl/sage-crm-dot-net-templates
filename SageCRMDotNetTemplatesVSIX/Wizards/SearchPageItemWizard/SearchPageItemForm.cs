using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SageCRMDotNetTemplatesVSIX.Wizards.SearchPageItemWizard
{
    public partial class SearchPageItemForm : Form
    {
        public string ListName
        {
            get { return txtListName.Text; }
            set { txtListName.Text = value; }
        }

        public string SearchBoxName
        {
            get { return txtSearchBoxName.Text; }
            set { txtSearchBoxName.Text = value; }
        }

        public bool OverrideBuildContents
        {
            get { return cbxOverrideBuildContents.Checked; }
            set { cbxOverrideBuildContents.Checked = value; }
        }

        public SearchPageItemForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
