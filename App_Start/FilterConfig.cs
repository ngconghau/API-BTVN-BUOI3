using System.Web;
using System.Web.Mvc;

namespace nguyenconghau_5951071025
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters( GlobalFilterCollection filters )
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
