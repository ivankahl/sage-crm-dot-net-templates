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
        public static void $entityname$DataPage(ref Web AretVal)
        {
            AretVal = new $entityname$DataPage();
        }

        public static void $entityname$DataPageDelete(ref Web AretVal)
        {
            AretVal = new $entityname$DataPageDelete();
        }

        public static void $entityname$DataPageEdit(ref Web AretVal)
        {
            AretVal = new $entityname$DataPageEdit();
        }

        public static void $entityname$DataPageNew(ref Web AretVal)
        {
            AretVal = new $entityname$DataPageNew();
        }

        public static void $entityname$ListPage(ref Web AretVal)
        {
            AretVal = new $entityname$ListPage();
        }

        public static void $entityname$SearchPage(ref Web AretVal)
        {
            AretVal = new $entityname$SearchPage();
        }
}
}
