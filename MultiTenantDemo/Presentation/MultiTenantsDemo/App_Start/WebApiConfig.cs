using System.Web.Http;

namespace Me.Sample.Web.Presentation.MultiTenantsDemo
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "MissingCultureApi",
                routeTemplate: "{distributor}/api/{controller}/{id}",
                defaults: new { culture = "en-GB", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "MissingAllApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { distributor = "common", culture = "en-GB", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{distributor}/{culture}/api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
