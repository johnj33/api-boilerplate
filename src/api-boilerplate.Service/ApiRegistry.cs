using api.boilerplate.Endpoints;
using log4net;
using StructureMap;

namespace api.boilerplate.Service
{
    public class ApiRegistry : Registry
    {
        public ApiRegistry()
        {
            Scan(scan =>
            {
                scan.AssemblyContainingType<AppHost>();
                scan.AssemblyContainingType<ApiEndpointsAssembly>();
                scan.WithDefaultConventions();
            });

            For<ILog>().AlwaysUnique().Use(context => EvaluateLoggerCallingType(context));
        }

        private static ILog EvaluateLoggerCallingType(IContext context)
        {
            return LogManager.GetLogger(context.ParentType ?? context.RootType);
        }
    }
}
