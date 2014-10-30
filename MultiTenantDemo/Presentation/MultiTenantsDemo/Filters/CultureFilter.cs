using System.Globalization;
using System.Threading;
using System.Web.Mvc;

namespace Me.Sample.Web.Presentation.MultiTenantsDemo.Filters
{
    public class CultureFilter : ActionFilterAttribute
    {
        private const string DefaultCulture = "en-GB";
        private const string RouteFieldCulture = "culture";

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string culture = filterContext.RequestContext.RouteData.Values[RouteFieldCulture] as string;

            if (string.IsNullOrEmpty(culture))
            {
                culture = DefaultCulture;
            }

            CultureInfo cultureInfo = CultureInfo.GetCultureInfo(DefaultCulture);
            try
            {
                cultureInfo = CultureInfo.GetCultureInfo(culture);
            }
            catch
            {
                //TODO:log the exception
                //ignore the exception
            }

            Thread.CurrentThread.CurrentUICulture = cultureInfo;
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            base.OnActionExecuting(filterContext);
        }
    }
}