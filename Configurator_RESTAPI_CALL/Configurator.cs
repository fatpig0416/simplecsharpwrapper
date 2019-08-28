using Configurator_RESTAPI_CALL.Authentication;
using Configurator_RESTAPI_CALL.Requests;
using Configurator_RESTAPI_CALL.Storage;
using System;

namespace Configurator_RESTAPI_CALL
{
    public class Configurator : ApiClient<Configurator>
    {
        public readonly GlobalStorage _globalStorage;

        public Configurator() : base()
        {
            _globalStorage = new GlobalStorage(this);
        }

        public override Configurator Authenticate(string email, string password)
        {
            var response = new AuthenticateRequest(email, password).Execute(Client);
            Client.Authenticator = new JwtAuthenticator(response.Token);

            return this;
        }
    }
}
