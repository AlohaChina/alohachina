using System.Web.Mvc;
using System.Web.Routing;

namespace Me.Sample.Web.Presentation.MultiTenantsDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "MissingCulture",
                url: "{distributor}/page/{controller}/{action}/{id}",
                defaults: new { controller = "Security", action = "Login", culture = "en-GB", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "MissingAll",
                url: "page/{controller}/{action}/{id}",
                defaults: new { controller = "Security", action = "Login", distributor = "common", culture = "en-GB", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{distributor}/{culture}/page/{controller}/{action}/{id}",
                defaults: new { controller = "Security", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}