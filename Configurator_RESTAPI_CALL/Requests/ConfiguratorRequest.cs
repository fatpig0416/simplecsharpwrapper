using Configurator_RESTAPI_CALL.Entity;
using RestSharp;
using RestRequest = RestSharp.RestRequest;

namespace Configurator_RESTAPI_CALL.Requests
{
    public class ConfiguratorRequest : BaseRequest
    {
        public ConfiguratorRequest(ConfiguratorParameter param) : base("callmehtod", Method.GET)
        {
            AddParameter("REGN", param.REGN, ParameterType.QueryString);
            AddParameter("AREA", param.AREA, ParameterType.QueryString);
            AddParameter("SECTION", param.SECTION, ParameterType.QueryString);
            AddParameter("PART", param.PART, ParameterType.QueryString);
            AddParameter("CNTRY", param.CNTRY, ParameterType.QueryString);
            AddParameter("CUSTMOER", param.CUSTMOER, ParameterType.QueryString);
        }

    }
}
