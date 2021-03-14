using System.Web;
using System.Web.Mvc;

namespace Demo.ASP.MultipleForms
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
