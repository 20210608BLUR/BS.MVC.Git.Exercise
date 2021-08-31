using System.Web;
using System.Web.Mvc;

namespace BS.MVC.Git.Exercise
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
