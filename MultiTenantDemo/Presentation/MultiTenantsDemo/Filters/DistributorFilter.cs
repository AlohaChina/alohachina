using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.Routing;
using Me.Sample.Common.Resource;

namespace Me.Sample.Web.Presentation.MultiTenantsDemo.Filters
{
    public class DistributorFilter : ActionFilterAttribute
    {
        private const string WhiteLabelDistributor = "common";
        private const string RouteFieldDistributor = "distributor";
        private const string ResourceManagerCacheKeyFormat = "RM-{0}";
        private const string AppSettingResourceAssemblyName = "ResourceAssembly";
        private const string TenantsReplacementString = "{tenants}";
        private const string PageLevelResourceManager = "RM";
        private const string CaptionResource = "Caption";
        private const string MessageResource = "Message";

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string distributor = filterContext.RequestContext.RouteData.Values[RouteFieldDistributor] as string;

            if (string.IsNullOrEmpty(distributor))
            {
                RedirectDistributor(filterContext, WhiteLabelDistributor);
                return;
            }

            string existingDistributor = (string)filterContext.HttpContext.Session[RouteFieldDistributor] as string;

            if (string.IsNullOrEmpty(existingDistributor))
            {
                filterContext.HttpContext.Session[RouteFieldDistributor] = distributor;
            }
            else if (!string.Equals(distributor, existingDistributor))
            {
                RedirectDistributor(filterContext, distributor);
                return;
            }

            string resourceKey = string.Format(ResourceManagerCacheKeyFormat, distributor);

            ResourceManager[] resourceManagers = HttpRuntime.Cache[resourceKey] as ResourceManager[];
            if (resourceManagers == null)
            {
                resourceManagers = null;
                try
                {
                    resourceManagers = LoadResourceForDistributor(distributor);
                }
                catch
                {
                    resourceManagers = LoadResourceForDistributor(WhiteLabelDistributor);
                }

                HttpRuntime.Cache[resourceKey] = resourceManagers;
            }

            Caption.ResourceManager = resourceManagers[0];
            Message.ResourceManager = resourceManagers[1];

            base.OnActionExecuting(filterContext);
        }

        private ResourceManager[] LoadResourceForDistributor(string distributor)
        {
            ResourceManager[] resourceManagers = new ResourceManager[2];

            Assembly assembly = Assembly.LoadFrom(WebConfigurationManager.AppSettings[AppSettingResourceAssemblyName].Replace(TenantsReplacementString, distributor));

            IEnumerable<string> resources = GetEmbededResourceNamesWithoutExtension(assembly);

            resourceManagers[0] = new ResourceManager(resources.First(s => s.EndsWith(CaptionResource)), assembly);
            resourceManagers[1] = new ResourceManager(resources.First(s => s.EndsWith(MessageResource)), assembly);

            return resourceManagers;
        }

        private static IEnumerable<string> GetEmbededResourceNamesWithoutExtension(Assembly assembly)
        {
            IEnumerable<string> resources = from res in assembly.GetManifestResourceNames() select res.Substring(0, res.Length - 10);
            return resources;
        }

        private static void RedirectDistributor(ActionExecutingContext filterContext, string distributor)
        {
            filterContext.HttpContext.Session.Clear();
            filterContext.HttpContext.Session.Abandon();
            filterContext.Result = new RedirectToRouteResult("Default", new RouteValueDictionary(new
            {
                controller = "Security",
                action = "Login",
                distributor = distributor,
                culture = Thread.CurrentThread.CurrentUICulture.Name
            }));
        }
    }
}