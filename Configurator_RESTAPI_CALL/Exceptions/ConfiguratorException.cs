using System;
using System.Runtime.Serialization;

namespace Configurator_RESTAPI_CALL.Exceptions
{
    public class ConfiguratorException : ApplicationException
    {
        public ConfiguratorException() { }

        protected ConfiguratorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public ConfiguratorException(string message) : base(message)
        {
        }

        public ConfiguratorException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
