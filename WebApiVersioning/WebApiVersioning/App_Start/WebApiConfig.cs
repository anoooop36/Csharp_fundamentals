using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using WebApiVersioning.CustomController;

namespace WebApiVersioning
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "Version1",
            //    routeTemplate: "api/v1/student/{id}",
            //    defaults: new { id = RouteParameter.Optional, controller = "StudentV1" }
            //);

            config.Services.Replace(typeof(IHttpControllerSelector),new CustomControllerSelector(config));

            config.Routes.MapHttpRoute(
                name: "Deafualt",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional}
            );
        }
    }
}
