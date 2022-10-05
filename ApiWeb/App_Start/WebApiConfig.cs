using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ApiWeb
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {///para que la url acepte todos los atributos como: get post,etc
            ((Newtonsoft.Json.Serialization.DefaultContractResolver)config.Formatters.JsonFormatter.SerializerSettings.ContractResolver).IgnoreSerializableAttribute = true;
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            ////////////////

            // Configuración y servicios de API web

            // Rutas de API web
          //  config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            ///Codigo para transformar la url xml a json
               GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings
               .Add(new System.Net.Http.Formatting.RequestHeaderMapping("Accept", "text/html",
               StringComparison.InvariantCultureIgnoreCase, true, "application/json"));










        }
    }
}
