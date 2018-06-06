using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;
using Sage.CRM.WebObject;
using $safeprojectname$.$entityname$;

namespace $safeprojectname$
{
	public static class AppFactory
    {
        public static void RunDataPage(ref Web AretVal)
        {
            AretVal = new $entityname$DataPage();
        }

        public static void RunDataPageDelete(ref Web AretVal)
        {
            AretVal = new $entityname$DataPageDelete();
        }

        public static void RunDataPageEdit(ref Web AretVal)
        {
            AretVal = new $entityname$DataPageEdit();
        }

        public static void RunDataPageNew(ref Web AretVal)
        {
            AretVal = new $entityname$DataPageNew();
        }

        public static void RunListPage(ref Web AretVal)
        {
            AretVal = new $entityname$ListPage();
        }

        public static void RunSearchPage(ref Web AretVal)
        {
            AretVal = new $entityname$SearchPage();
        }
}
}
