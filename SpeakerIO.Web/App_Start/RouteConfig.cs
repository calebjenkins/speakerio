﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using SpeakerIO.Web.Controllers;
using NavigationRoutes;

namespace SpeakerIO.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            routes.MapRoute(name: "Calls", url: "call-for-speakers/{key}",
                            defaults: new { controller = "Home", action = "Call", },
                            namespaces: new[] { typeof(HomeController).Namespace });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Home", action = "Index" }, namespaces:new[]{typeof(HomeController).Namespace}
            );

            
        }
    }
}