using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1.MVC.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("favicon.ico");
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.aspx/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "Mvc/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                new[] { "WebApplication1.Controllers" }
                );
        }
    }
}