using System.Web;
using System.Web.Mvc;

namespace OWASP_Top10_TampaDay
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
