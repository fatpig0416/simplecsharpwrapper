using Configurator_RESTAPI_CALL.Entity;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using RestRequest = RestSharp.RestRequest;

namespace Configurator_RESTAPI_CALL.Requests
{
    public class ConfiguratorRequest : BaseRequest
    {
        public ConfiguratorRequest(string url, Dictionary<string, object> param) : base(url, Method.GET)
        {
            foreach (var p in param)
            {
                AddParameter(p.Key, p.Value, ParameterType.QueryString);
            }
            
        }

    }
}
