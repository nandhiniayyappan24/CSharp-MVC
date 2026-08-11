using System;
using System.Web.Mvc;
using System.Web.Routing;
using CSharpMvc.Extensions;
using Microsoft.Owin.Hosting;
using Owin;

[assembly: Microsoft.Owin.OwinStartup(typeof(CSharpMvc.Startup))]

namespace CSharpMvc
{
    public static class Program
    {
        public static void Main()
        {
            OpenTelemetryBootstrap.Initialize();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            using (WebApp.Start<Startup>("http://localhost:5080/"))
            {
                Console.WriteLine("CSharp MVC running on http://localhost:5080/ (net48)");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
            }
        }
    }

    public sealed class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new {};
            app.Use((context, next) => next());
        }
    }

    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }
    }
}
