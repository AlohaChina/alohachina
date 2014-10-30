using System.Web.Mvc;
using Me.Sample.Web.Presentation.MultiTenantsDemo.Filters;

namespace Me.Sample.Web.Presentation.MultiTenantsDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CultureFilter());
            filters.Add(new DistributorFilter());
            filters.Add(new HandleErrorAttribute());
        }
    }
}