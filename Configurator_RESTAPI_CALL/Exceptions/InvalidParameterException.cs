using System;
using System.Collections.Generic;
using System.Text;

namespace Configurator_RESTAPI_CALL.Exceptions
{
    public class InvalidParameterException : ConfiguratorException
    {
        public InvalidParameterException(Exception innerError) : base(
            "Invalid Parameter -- Either the URL parameters or the request body parameters are invalid.", innerError)
        {
        }

        public InvalidParameterException(string message, Exception innerError) : base(message, innerError)
        {
        }
    }
}
