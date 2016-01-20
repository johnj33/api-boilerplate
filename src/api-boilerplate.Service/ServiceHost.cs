using System;
using System.Reflection;
using log4net;
using ServiceStack;

namespace api.boilerplate.Service
{
    public class ServiceHost : IDisposable
    {
        private readonly AppHostHttpListenerBase _appHost;
        private readonly ServiceConfiguration _serviceConfiguration;
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public ServiceHost(AppHostHttpListenerBase appHost, ServiceConfiguration serviceConfiguration)
        {
            _appHost = appHost;
            _serviceConfiguration = serviceConfiguration;
        }

        public void StartService()
        {
            _appHost.Init();
            var listeningAtUrlBase = _serviceConfiguration.Url();
            _appHost.Start(listeningAtUrlBase);
            Console.WriteLine("Listening on  " + listeningAtUrlBase);
            Log.InfoFormat("Application Started on {0}", listeningAtUrlBase);

            Log.Info("Application Starting");
        }

        public void StopService()
        {
            if (_appHost.HasStarted)
            {
                _appHost.Stop();
            }
            _appHost.Dispose();

            Log.Info("Application Stopping");
        }

        public void Dispose()
        {
            StopService();
        }
    }
}
