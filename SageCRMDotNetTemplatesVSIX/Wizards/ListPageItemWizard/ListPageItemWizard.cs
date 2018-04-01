using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageCRMDotNetTemplatesVSIX.Wizards.ListPageItemWizard
{
    public class ListPageItemWizard : IWizard
    {
        private DTE _dte;

        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            _dte = (DTE)automationObject;

            replacementsDictionary.Add("$entityname$", "Entity");
            replacementsDictionary.Add("$listname$", "EntityList");
            replacementsDictionary.Add("$filterboxname$", "EntityFilterBox");
            replacementsDictionary.Add("$overridebuildcontents$", "false");

            ListPageItemForm frmListPageItem = new ListPageItemForm();

            if (frmListPageItem.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!String.IsNullOrWhiteSpace(frmListPageItem.EntityName))
                    replacementsDictionary["$entityname$"] = frmListPageItem.EntityName;

                if (!String.IsNullOrWhiteSpace(frmListPageItem.ListName))
                    replacementsDictionary["$listname$"] = frmListPageItem.ListName;

                if (!String.IsNullOrWhiteSpace(frmListPageItem.FilterBoxName))
                    replacementsDictionary["$filterboxname$"] = frmListPageItem.FilterBoxName;

                replacementsDictionary["$overridebuildcontents$"] = frmListPageItem.OverrideBuildContents ? "true" : "false";
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
