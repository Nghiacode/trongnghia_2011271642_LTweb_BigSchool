using System.Web;
using System.Web.Mvc;

namespace trongnghia_2011271642_LTweb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
