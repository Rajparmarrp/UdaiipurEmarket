using System.Web;
using System.Web.Mvc;

namespace Udaipur_E_Marketing
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
