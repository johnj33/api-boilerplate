using System;
using System.Configuration;
using System.Reflection;
using api.boilerplate.Endpoints;
using Funq;
using ServiceStack;
using ServiceStack.Text;

namespace api.boilerplate.Service
{
    public class AppHost : AppHostHttpListenerBase
    {
        private const string SERVICE_NAME = "api-boilerplate";

        public AppHost()
            : base(SERVICE_NAME, GetEndpointAssembly())
        {
        }

        private static Assembly GetEndpointAssembly()
        {
            return typeof(ApiEndpointsAssembly).Assembly;
        }

        public override void Configure(Container container)
        {
            container.Adapter = new StructureMapContainerAdapter();
            
            ConfigureServiceStack();
            ConfigureCors();

            GlobalResponseFilters.Add((req, res, dto) =>
                res.AddHeader(HttpHeaders.CacheControl, "no-cache, no-store, must-revalidate"));
            GlobalResponseFilters.Add((req, res, dto) =>
                res.AddHeader("Pragma", "no-cache"));
            GlobalResponseFilters.Add((req, res, dto) =>
                res.AddHeader("Expires", "0"));
        }

        private void ConfigureCors()
        {
            var allowedOrigins = ConfigurationManager.AppSettings["AllowCORSOrigin"];
            var allowedHeaders = ConfigurationManager.AppSettings["AllowCORSHeaders"];

            Plugins.Add(new CorsFeature(allowedOrigins, allowedHeaders: allowedHeaders));
        }

        private static void ConfigureServiceStack()
        {
            JsConfig.EmitCamelCaseNames = true;
            JsConfig.ExcludeTypeInfo = true;
            JsConfig.IncludeNullValues = true;
            JsConfig<Guid>.SerializeFn = guid => guid.ToString();
            JsConfig<Guid?>.SerializeFn = guid => guid.ToString();
            JsConfig.DateHandler = DateHandler.ISO8601;
        }
    }
}
