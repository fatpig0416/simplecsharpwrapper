using System;
namespace Configurator_RESTAPI_CALL.Exceptions
{
    public class NotFoundException : ConfiguratorException
    {
        public NotFoundException(Exception innerError) : base(
            "Not Found -- The endpoint or object you are looking for does not exist.", innerError)
        {
        }

        public NotFoundException(string message, Exception innerError) : base(message, innerError)
        {
        }
    }
}
