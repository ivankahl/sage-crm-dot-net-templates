﻿using Sage.CRM.WebObject;

namespace $rootnamespace$
{
	public class $safeitemname$ : DataPage
	{
        public $safeitemname$() : base("$entityname$", "$entityidfield$"$if$($includedetailscreen$ == true), "$entityboxlong$"$endif$)
        {

        }$if$ ($overridebuildcontents$ == true)
    
        public override void BuildContents()
        {
            base.BuildContents();
        }$endif$
	}
}
