using Sage.CRM.WebObject;

namespace $rootnamespace$
{
	public class $safeitemname$ : SearchPage
	{
        public $safeitemname$() : base("$searchboxname$", "$listname$")
        {

        }$if$ ($overridebuildcontents$ == true)
    
        public override void BuildContents()
        {
            base.BuildContents();
        }$endif$
	}
}
