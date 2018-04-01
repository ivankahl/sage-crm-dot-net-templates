using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageCRMDotNetTemplatesVSIX.Wizards.EntityProjectWizard
{
    public class EntityProjectWizard : IWizard
    {
        private DTE _dte;

        public void BeforeOpeningFile(ProjectItem projectItem) { }

        public void ProjectFinishedGenerating(Project project) { }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem) { }

        public void RunFinished() { }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            _dte = (DTE)automationObject;

            // Set defaults
            replacementsDictionary.Add("$entityname$", "Entity");
            replacementsDictionary.Add("$entityidfield$", "Enti_EntityId");
            replacementsDictionary.Add("$entitylistname$", "EntityList");
            replacementsDictionary.Add("$entityboxlong$", "EntityBoxLong");
            replacementsDictionary.Add("$entitysearchbox$", "EntitySearchScreen");
            replacementsDictionary.Add("$entityfilterbox$", "EntityFilterBox");

            EntityProjectForm frmEntityProject = new EntityProjectForm();

            if (frmEntityProject.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!String.IsNullOrWhiteSpace(frmEntityProject.EntityName))
                    replacementsDictionary["$entityname$"] = frmEntityProject.EntityName;

                if (!String.IsNullOrWhiteSpace(frmEntityProject.EntityIDField))
                    replacementsDictionary["$entityidfield$"] = frmEntityProject.EntityIDField;

                if (!String.IsNullOrWhiteSpace(frmEntityProject.EntityListName))
                    replacementsDictionary["$entitylistname$"] = frmEntityProject.EntityListName;

                if (!String.IsNullOrWhiteSpace(frmEntityProject.EntityDetailScreen))
                    replacementsDictionary["$entityboxlong$"] = frmEntityProject.EntityDetailScreen;

                if (!String.IsNullOrWhiteSpace(frmEntityProject.EntitySearchScreen))
                    replacementsDictionary["$entitysearchbox$"] = frmEntityProject.EntitySearchScreen;

                if (!String.IsNullOrWhiteSpace(frmEntityProject.EntityFilterBoxScreen))
                    replacementsDictionary["$entityfilterbox$"] = frmEntityProject.EntityFilterBoxScreen;
            }
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
