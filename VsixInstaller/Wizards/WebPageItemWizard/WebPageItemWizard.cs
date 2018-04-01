using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageCRMDotNetTemplatesVSIX.Wizards.WebPageItemWizard
{
    public class WebPageItemWizard : IWizard
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

            replacementsDictionary.Add("$overridebuildcontents$", "false");

            WebPageItemForm frmWebPageItem = new WebPageItemForm();

            if (frmWebPageItem.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                replacementsDictionary["$overridebuildcontents$"] = frmWebPageItem.OverrideBuildContents ? "true" : "false";
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
