using System.Web;
using System.Web.Mvc;

namespace WEP_API_CRUD_EXAMPLE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
