using System.Web;
using System.Web.Mvc;

namespace assignment3_AnubhavSharma
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
