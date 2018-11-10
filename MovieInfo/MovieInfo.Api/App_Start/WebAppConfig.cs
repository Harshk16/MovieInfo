using Newtonsoft.Json;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace MovieInfo.Api.App_Start
{
    public static class WebAppConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Formatters.Remove(new XmlMediaTypeFormatter());

            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

            config.Formatters.XmlFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("multipart/form-data"));
            //config.Filters.Add(new ExceptionApiAttribute());

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new
                {
                    id = RouteParameter.Optional
                }
            );
        }
    }
}