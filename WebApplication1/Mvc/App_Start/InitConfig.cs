using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1.MVC.App_Start
{
    public class InitConfig
    {
        public static void RegisterMvc()
        {
            AreaRegistration.RegisterAllAreas();

            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new CustomViewEngine());
        }
    }

    public class CustomViewEngine : RazorViewEngine
    {
        private const string MasterLocationPrefix = "~/MVC/";
        private const string AreaLocationPrefix = MasterLocationPrefix + "Areas/";

        public CustomViewEngine()
            : this(null)
        {
        }

        public CustomViewEngine(IViewPageActivator viewPageActivator)
            : base(viewPageActivator)
        {
            AreaViewLocationFormats = new[]
            {
                AreaLocationPrefix + "{2}/Views/{1}/{0}.cshtml",
                AreaLocationPrefix + "{2}/Views/Shared/{0}.cshtml",
            };
            AreaMasterLocationFormats = new[]
            {
                AreaLocationPrefix + "{2}/Views/{1}/{0}.cshtml",
                AreaLocationPrefix + "{2}/Views/Shared/{0}.cshtml",
            };
            AreaPartialViewLocationFormats = new[]
            {
                AreaLocationPrefix + "{2}/Views/{1}/{0}.cshtml",
                AreaLocationPrefix + "{2}/Views/Shared/{0}.cshtml",
            };

            ViewLocationFormats = new[]
            {
                MasterLocationPrefix + "Views/{1}/{0}.cshtml",
                MasterLocationPrefix + "Views/Shared/{0}.cshtml",
            };
            MasterLocationFormats = new[]
            {
                MasterLocationPrefix + "Views/{1}/{0}.cshtml",
                MasterLocationPrefix + "Views/Shared/{0}.cshtml",
            };
            PartialViewLocationFormats = new[]
            {
                MasterLocationPrefix + "Views/{1}/{0}.cshtml",
                MasterLocationPrefix + "Views/Shared/{0}.cshtml",
            };

            FileExtensions = new[]
            {
                "cshtml",
            };
        }
    }
}