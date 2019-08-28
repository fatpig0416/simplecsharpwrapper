using System;
using System.Collections.Generic;
using System.Text;

namespace Configurator_RESTAPI_CALL.Exceptions
{
    public class InternalServerErrorException : ConfiguratorException
    {
        public InternalServerErrorException(Exception innerError) : base(
            "Internal Server Error -- We had a problem with our server. Try again later.", innerError)
        {
        }

        public InternalServerErrorException(string message, Exception innerError) : base(message, innerError)
        {
        }
    }
}
