using System.Web.Mvc;
using System.Web.Routing;

namespace ShoppingWEBTraining
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "api",
                url: "api/{controller}/{action}/{id}",
                defaults: new { action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.LowercaseUrls = true;
        }
    }
}