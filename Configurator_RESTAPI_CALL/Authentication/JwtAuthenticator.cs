using RestSharp;
using RestSharp.Authenticators;

namespace Configurator_RESTAPI_CALL.Authentication
{
    public class JwtAuthenticator : IAuthenticator
    {
        private readonly string _authToken;

        public JwtAuthenticator(string authToken)
        {
            _authToken = authToken;
        }

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            request.AddParameter("Authorization", $"Bearer {_authToken}", ParameterType.HttpHeader);
        }
    }
}
