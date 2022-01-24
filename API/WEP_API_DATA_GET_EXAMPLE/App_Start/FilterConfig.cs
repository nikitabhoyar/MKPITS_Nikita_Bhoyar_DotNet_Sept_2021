using System.Web;
using System.Web.Mvc;

namespace WEPAPI_DATA_GET_EXAMPLE
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
