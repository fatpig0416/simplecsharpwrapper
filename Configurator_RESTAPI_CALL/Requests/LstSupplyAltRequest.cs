using Configurator_RESTAPI_CALL.Entity;
using RestSharp;
using System.Collections.Generic;
using System.Xml.Serialization;
using RestRequest = RestSharp.RestRequest;

namespace Configurator_RESTAPI_CALL.Requests
{
    class LstSupplyAltRequest : BaseRequest
    {
        public LstSupplyAltRequest(string url, Dictionary<string, object> param) : base(url, Method.GET)
        {
            foreach (var p in param)
            {
                AddParameter(p.Key, p.Value, ParameterType.QueryString);
            }

        }

        public new MiResult Execute(IRestClient client)
        {
            return Execute<MiResult>(client);
        }

        [XmlRoot("miResult")]
        public class MiResult
        {
            [XmlElement("MIRecord")]
            public List<NameValue> NameValue { get; set; }
        }

        public class NameValue
        {
            [XmlElement("Name")]
            public string Name { get; set; }

            [XmlElement("Value")]
            public string Value { get; set; }
        }
        
    }
}
