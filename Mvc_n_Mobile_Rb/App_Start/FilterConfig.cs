using System.Web;
using System.Web.Mvc;

namespace Mvc_n_Mobile_Rb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}