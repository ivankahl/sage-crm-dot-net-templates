using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageCRMDotNetTemplatesVSIX.Wizards.SearchPageItemWizard
{
    public class SearchPageItemWizard : IWizard
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

            replacementsDictionary.Add("$listname$", "Entity");
            replacementsDictionary.Add("$searchboxname$", "EntityList");
            replacementsDictionary.Add("$overridebuildcontents$", "false");

            SearchPageItemForm frmSearchPageItem = new SearchPageItemForm();

            if (frmSearchPageItem.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!String.IsNullOrWhiteSpace(frmSearchPageItem.ListName))
                    replacementsDictionary["$listname$"] = frmSearchPageItem.ListName;

                if (!String.IsNullOrWhiteSpace(frmSearchPageItem.SearchBoxName))
                    replacementsDictionary["$searchboxname$"] = frmSearchPageItem.SearchBoxName;

                replacementsDictionary["$overridebuildcontents$"] = frmSearchPageItem.OverrideBuildContents ? "true" : "false";
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
