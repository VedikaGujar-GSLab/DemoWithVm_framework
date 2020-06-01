using System.Web;
using System.Web.Mvc;

namespace CiCd_WithGit_WithVM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
