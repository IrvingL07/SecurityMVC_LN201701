using System.Web;
using System.Web.Mvc;

namespace MVCSecurityDemo_LN201701
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
