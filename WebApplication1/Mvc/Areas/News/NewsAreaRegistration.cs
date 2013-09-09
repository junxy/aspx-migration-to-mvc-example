using System.Web.Mvc;

namespace WebApplication1.Areas.News
{
    public class NewsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "News";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "News_default",
                "Mvc/News/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new[] { "WebApplication1.Mvc.Areas.News.Controllers" }
            );
        }
    }
}
