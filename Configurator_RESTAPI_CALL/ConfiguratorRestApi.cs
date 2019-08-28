using Configurator_RESTAPI_CALL.Exceptions;
using System;
using System.Net;

namespace Configurator_RESTAPI_CALL
{
    public class ConfiguratorRestApi
    {
        public const string BaseUrl = "http://servtst:1502/api-rest/execute/svcapi/";

        public static Configurator Configurator(string username, string password)
        {
            return new Configurator().Authenticate(username, password);
        }

        public static ConfiguratorException RaiseRequestErrorToException(HttpStatusCode code, Exception innerError)
        {
            switch (code)
            {
                case HttpStatusCode.BadRequest:
                    return new BadRequestException(innerError);
                case HttpStatusCode.Unauthorized:
                    return new AuthorizationException(innerError);
                case HttpStatusCode.Forbidden:
                    return new InvalidParameterException(innerError);
                case HttpStatusCode.NotFound:
                    return new NotFoundException(innerError);
                case HttpStatusCode.InternalServerError:
                    return new InternalServerErrorException(innerError);
            }

            return new ConfiguratorException("Error executing request.", innerError);
        }
    }
}
