using System;
using System.Collections.Generic;
using System.Text;

namespace Configurator_RESTAPI_CALL.Exceptions
{
    public class BadRequestException : ConfiguratorException
    {
        public BadRequestException(Exception innerError) : base("Bad Request -- Your request is invalid.", innerError)
        {
        }

        public BadRequestException(string message, Exception innerError) : base(message, innerError)
        {
        }
    }
}
