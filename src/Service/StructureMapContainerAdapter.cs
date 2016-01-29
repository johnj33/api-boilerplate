using api.boilerplate.Service.Behaviours;
using ServiceStack.Configuration;
using StructureMap;

namespace api.boilerplate.Service
{
    public class StructureMapContainerAdapter : IContainerAdapter
    {
        public StructureMapContainerAdapter()
        {
            if (StructureMapInstanceProvider.Container == null)
            {
                StructureMapInstanceProvider.Container = new Container();
            }

            StructureMapInstanceProvider.Container.Configure(expression => expression.AddRegistry<ApiRegistry>());
        }

        public T TryResolve<T>()
        {
            return StructureMapInstanceProvider.Container.TryGetInstance<T>();
        }

        public T Resolve<T>()
        {
            return StructureMapInstanceProvider.Container.TryGetInstance<T>();
        }
    }
}
