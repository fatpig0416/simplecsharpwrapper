using Configurator_RESTAPI_CALL.Authentication;
using Configurator_RESTAPI_CALL.Requests;
using Configurator_RESTAPI_CALL.Storage;

namespace Configurator_RESTAPI_CALL
{
    public class Configurator : ApiClient<Configurator>
    {
        public readonly GlobalStorage _globalStorage;
        public readonly LstSupplyAltStorage _lstSupplyAltStorage;

        public Configurator() : base()
        {
            _globalStorage = new GlobalStorage(this);
            _lstSupplyAltStorage = new LstSupplyAltStorage(this);
        }

        public override Configurator Authenticate(string email, string password)
        {
            var response = new AuthenticateRequest(email, password).Execute(Client);
            Client.Authenticator = new JwtAuthenticator(response.Token);

            return this;
        }
    }
}
