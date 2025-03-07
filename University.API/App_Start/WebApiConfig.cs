﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using University.API.Controllers;

namespace University.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de Web API

            // Rutas de Web API           
            var enableCorsAttribute = new EnableCorsAttribute("*",
                "Origin, Content-Type, Accept",
                "GET, POST, PUT, DELETE, OPTIONS"
                );
            config.EnableCors(enableCorsAttribute); 
            config.MapHttpAttributeRoutes();

            config.MessageHandlers.Add(new TokenValidationHandler());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
