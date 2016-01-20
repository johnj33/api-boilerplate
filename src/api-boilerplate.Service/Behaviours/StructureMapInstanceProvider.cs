using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using StructureMap;

namespace api.boilerplate.Service.Behaviours
{
    public class StructureMapInstanceProvider : IInstanceProvider
    {
        private readonly Type _serviceType;
        public static IContainer Container { get; set; }

        public StructureMapInstanceProvider(Type serviceType)
        {
            _serviceType = serviceType;
        }

        public object GetInstance(InstanceContext instanceContext)
        {
            return GetInstance(instanceContext, null);
        }

        public object GetInstance(InstanceContext instanceContext, Message message)
        {
            return Container.GetInstance(_serviceType);
        }

        public void ReleaseInstance(InstanceContext instanceContext, object instance)
        {
            var disposable = instance as IDisposable;
            if (disposable != null)
                disposable.Dispose();
        }
    }
}
