using System;
using System.Collections.Generic;
using System.Text;

namespace Configurator_RESTAPI_CALL.Exceptions
{
    public class AuthorizationException : ConfiguratorException
    {
        public AuthorizationException(Exception innerError) : base("Unauthorized -- Your Bearer Token is invalid.",
            innerError)
        {
        }

        public AuthorizationException(string message, Exception innerError) : base(message, innerError)
        {
        }
    }
}
