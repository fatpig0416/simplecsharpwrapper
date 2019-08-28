using RestSharp;
using RestSharp.Serializers.Newtonsoft.Json;
using System.Xml.Serialization;
using RestRequest = RestSharp.RestRequest;

namespace Configurator_RESTAPI_CALL.Requests
{
    public abstract class BaseRequest : RestRequest
    {
        protected BaseRequest(string resource, Method method) : base(resource, method)
        {
            RequestFormat = DataFormat.Xml;
            XmlSerializer = new RestSharp.Serializers.DotNetXmlSerializer();
        }

        protected T Execute<T>(IRestClient client) where T : new()
        {
            var response = client.Execute<T>(this);
            var fullUrl = client.BuildUri(this);
            if (response.ErrorException != null)
            {
                throw ConfiguratorRestApi.RaiseRequestErrorToException(response.StatusCode, response.ErrorException);
            }

            return response.Data;
        }


        public BasicResponse Execute(IRestClient client)
        {
            return Execute<BasicResponse>(client);
        }

        [XmlRoot("BasicResponse")]
        public class BasicResponse
        {
            [XmlElement("Element")]
            public Element Element { get; set; }
        }

        public class Element
        {
            [XmlElement("Id")]
            public int Id { get; set; }

            // Todo

        }
    }
}
