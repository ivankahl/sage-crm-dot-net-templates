using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageCRMDotNetTemplatesVSIX.Wizards.DataPageItemWizard
{
    public class DataPageItemWizard : IWizard
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
            replacementsDictionary.Add("$entityidfield$", "Enti_EntityId");
            replacementsDictionary.Add("$entityboxlong$", "EntityBoxLong");
            replacementsDictionary.Add("$includedetailscreen$", "true");
            replacementsDictionary.Add("$overridebuildcontents$", "false");

            DataPageItemForm frmDataPageItem = new DataPageItemForm();

            if (frmDataPageItem.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!String.IsNullOrWhiteSpace(frmDataPageItem.EntityName))
                    replacementsDictionary["$entityname$"] = frmDataPageItem.EntityName;

                if (!String.IsNullOrWhiteSpace(frmDataPageItem.EntityIDField))
                    replacementsDictionary["$entityidfield$"] = frmDataPageItem.EntityIDField;

                if (!String.IsNullOrWhiteSpace(frmDataPageItem.EntityDetailScreen))
                    replacementsDictionary["$entityboxlong$"] = frmDataPageItem.EntityDetailScreen;

                replacementsDictionary["$includedetailscreen$"] = frmDataPageItem.IncludeDetailScreen ? "true" : "false";
                replacementsDictionary["$overridebuildcontents$"] = frmDataPageItem.OverrideBuildContents ? "true" : "false";
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
