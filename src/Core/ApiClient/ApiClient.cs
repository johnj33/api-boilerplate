namespace api.boilerplate.Core.ApiClient
{
    public interface IApiClient
    {
        T Get<T>(string endpoint);
    }

    public class ApiClient : IApiClient
    {
        private readonly IRestClientFactory _restClientFactory;

        public ApiClient() : this(new RestClientFactory())
        {
        }

        public ApiClient(IRestClientFactory restClientFactory)
        {
            _restClientFactory = restClientFactory;
        }

        public T Get<T>(string endpoint)
        {
            return _restClientFactory
                .CreateApiClient()
                .Get<T>(endpoint);
        }
    }
}
