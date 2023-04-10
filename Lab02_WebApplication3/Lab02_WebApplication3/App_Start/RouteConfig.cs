using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab02_WebApplication3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "List Song",
                url: "am-nhac/danh-sach-phat",
                defaults: new { controller = "Music", action = "ListSong" }
                );
            routes.MapRoute(
                name: "Download Song",
                url: "am-nhac/tai-xuong/{id}",
                defaults: new { controller = "Music", action = "Download", id = @"\d{1,4}" }
                );
            routes.MapRoute(
                name: "Detail Song",
                url: "am-nhac/bai-hat/{id}",
                defaults: new { controller = "Music", action = "Detail", id = @"\d{1,4}" }
                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Music", action = "ListSong", id = UrlParameter.Optional }
            );
        }
    }
}
