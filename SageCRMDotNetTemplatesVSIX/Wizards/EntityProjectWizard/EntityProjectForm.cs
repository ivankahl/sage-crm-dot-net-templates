using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SageCRMDotNetTemplatesVSIX.Wizards.EntityProjectWizard
{
    public partial class EntityProjectForm : Form
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

        public string EntityListName
        {
            get { return txtListName.Text; }
            set { txtListName.Text = value; }
        }

        public string EntityDetailScreen
        {
            get { return txtDetailScreen.Text; }
            set { txtDetailScreen.Text = value; }
        }

        public string EntitySearchScreen
        {
            get { return txtSearchScreen.Text; }
            set { txtSearchScreen.Text = value; }
        }

        public string EntityFilterBoxScreen
        {
            get { return txtFilterBoxScreen.Text; }
            set { txtFilterBoxScreen.Text = value; }
        }

        public EntityProjectForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
