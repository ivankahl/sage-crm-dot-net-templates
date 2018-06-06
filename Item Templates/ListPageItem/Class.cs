using Sage.CRM.WebObject;

namespace $rootnamespace$
{
	public class $safeitemname$ : ListPage
	{
        public $safeitemname$() : base("$entityname$", "$listname$", "$filterboxname$")
        {

        }$if$ ($overridebuildcontents$ == true)
    
        public override void BuildContents()
        {
            base.BuildContents();
        }$endif$
	}
}
