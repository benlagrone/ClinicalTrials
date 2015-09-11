using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ClinicalTrials
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name:"MyMessages",
                url:"MyMessages",
                defaults: new {Controller="Home", action="MyMessages"}
                );

            routes.MapRoute(
                name: "ShowProtocols",
                url: "Trials/{ProtocolId}",
                defaults: new { Controller = "Trials", action = "Index", ProtocolId = UrlParameter.Optional },
                constraints: new { ProtocolId = "[0-9]+" }
                );
            routes.MapRoute(
                name: "ShowProtocol2",
                url: "Trials/Details/{ProtocolId}",
                defaults: new { Controller = "Trials", action = "GetDetails"},
                constraints: new { ProtocolId = "[0-9]+" }
                );

            routes.MapRoute(
                name: "ListProtocols",
                url: "Trials/{start}/{count}",
                defaults: new { Controller = "Trials", action = "GetList"},
                constraints: new { start = "[0-9]+", count = "[0-9]+"}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}