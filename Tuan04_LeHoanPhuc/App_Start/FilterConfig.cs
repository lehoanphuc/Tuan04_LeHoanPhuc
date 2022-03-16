using System.Web;
using System.Web.Mvc;

namespace Tuan04_LeHoanPhuc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
