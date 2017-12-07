﻿using System.Web.Mvc;
using System.Web.Routing;

namespace Hospital.Terminal
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ItemList",
                url: "Plant/ItemList/{cid}",
                defaults: new { controller = "Plant", action = "ItemList", cid = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Category",
                url: "Plant/Category/{cid}",
                defaults: new { controller = "Plant", action = "Category", cid = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Detail",
                url: "Plant/Detail/{itemNumber}",
                defaults: new { controller = "Plant", action = "Detail", itemNumber = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "HospitalDetail",
                url: "Hospital/{action}/{hospitalId}",
                defaults: new { controller = "Hospital", action = "Detail", hospitalId = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Expert",
                url: "Hospital/{action}/{expertId}",
                defaults: new { controller = "Hospital", action = "ExpertInfo", expertId = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}