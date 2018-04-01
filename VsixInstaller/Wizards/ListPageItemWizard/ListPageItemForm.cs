using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SageCRMDotNetTemplatesVSIX.Wizards.ListPageItemWizard
{
    public partial class ListPageItemForm : Form
    {
        public string EntityName
        {
            get { return txtEntityName.Text; }
            set { txtEntityName.Text = value; }
        }

        public string ListName
        {
            get { return txtListName.Text; }
            set { txtListName.Text = value; }
        }

        public string FilterBoxName
        {
            get { return txtFilterBoxName.Text; }
            set { txtFilterBoxName.Text = value; }
        }

        public bool OverrideBuildContents
        {
            get { return cbxOverrideBuildContents.Checked; }
            set { cbxOverrideBuildContents.Checked = value; }
        }

        public ListPageItemForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
