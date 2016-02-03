using System.Configuration;
using ServiceStack;

namespace api.boilerplate.Core.ApiClient
{
    public interface IRestClientFactory
    {
        IRestClient CreateApiClient();
    }
    
    public  class RestClientFactory : IRestClientFactory
    {
        public IRestClient CreateApiClient()
        {
            return new JsonServiceClient(ConfigurationManager.AppSettings["ApiUrl"]);
        }
    }
}
