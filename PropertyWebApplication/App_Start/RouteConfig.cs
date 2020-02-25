using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PropertyWebApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Mapping 1 - Check if our extension has the .axd - in this case, ignore the request
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Mapping 2 - Check if the url slug matches the one here
            // Custom route, use to direct urls as in the url property below
            routes.MapRoute(
                name: "Administrator",
                url: "Admin/Localities/{action}/{id}",
                defaults: new { Controller = "Localities", action = "Index", id = UrlParameter.Optional }
            );

            // Custom route, use to direct urls as in the url property below
            routes.MapRoute(
                name: "LocalitiesIndex",
                url: "Localities/{action}/{id}",
                defaults: new { Controller = "Localities", action = "Index", id = UrlParameter.Optional }
            );

            // Custom route, use to direct urls as in the url property below
            routes.MapRoute(
                name: "PropertyIndex",
                url: "Property/{action}/{id}",
                defaults: new { Controller = "Properties", action = "Index", id = UrlParameter.Optional }
            );

            // Mapping 3 - Check if the url slug matches the one here
            routes.MapRoute(
                name: "Default",
                // website.com/ Localities / Create / --
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            // No mapping found, we can't route this!
        }
    }
}
