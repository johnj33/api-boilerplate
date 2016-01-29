using System;
using System.Reflection;
using log4net;
using Topshelf;

namespace api.boilerplate.Service
{
    internal class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static void Main()
        {
            Log.Info("Starting api-boilerplate");

            var serviceConfiguration = new ServiceConfiguration();

            HostFactory.Run(
                ts =>
                {
                    ts.Service<ServiceHost>(service =>
                    {
                        service.ConstructUsing(s => new ServiceHost(new AppHost(), serviceConfiguration));
                        service.WhenStarted(s => s.StartService());
                        service.WhenStopped(s => s.StopService());
                    });

                    ts.RunAsLocalSystem();
                    ts.SetDisplayName("[api-boilerplate] Service");
                    ts.SetServiceName("api-boilerplate");
                    
                    ts.UseLog4Net();
                });
        }
    }
}
