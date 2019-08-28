using Newtonsoft.Json;
using RestSharp;

namespace Configurator_RESTAPI_CALL.Requests
{
    public class AuthenticateRequest : BaseRequest
    {
        public AuthenticateRequest(string username, string password) : base($"auth", Method.POST)
        {
            AddJsonBody(new Request
            {
                Username = username,

                Password = password
            });
        }

        public new Response Execute(IRestClient client)
        {
            return Execute<Response>(client);
        }

        public class Request
        {
            [JsonProperty("username")]
            public string Username;

            [JsonProperty("password")]
            public string Password;
        }

        public class Response
        {
            [JsonProperty("token")]
            public string Token { get; set; }
        }
    }
}
