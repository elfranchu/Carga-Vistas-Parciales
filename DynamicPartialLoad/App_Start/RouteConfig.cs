using System.Web.Mvc;
using System.Web.Routing;

namespace DynamicPartialLoad
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // Rutas que permiten hacer F5 en la carga con javascript
            routes.MapRoute(
                name: "AllInOneIndex",
                url: "AllInOne/Index/{id}",
                defaults: new { controller = "AllInOne", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "AllInOneContact",
                url: "AllInOne/Contact/{id}",
                defaults: new { controller = "AllInOne", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "AllInOneInfo",
                url: "AllInOne/Info/{id}",
                defaults: new { controller = "AllInOne", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}