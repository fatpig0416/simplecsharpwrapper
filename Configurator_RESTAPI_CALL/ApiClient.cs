using RestSharp;

namespace Configurator_RESTAPI_CALL
{
    public abstract class ApiClient<T>
    {
        public readonly IRestClient Client;

        public ApiClient()
        {
            Client = new RestClient(ConfiguratorRestApi.BaseUrl);
        }

        public abstract T Authenticate(string email, string password);
    }
}
