using Configurator_RESTAPI_CALL.Entity;
using Configurator_RESTAPI_CALL.Requests;
using Configurator_RESTAPI_CALL.Util;
using System;
using System.Collections.Generic;

namespace Configurator_RESTAPI_CALL.Storage
{
    public class GlobalStorage : Storage<ConfiguratorParameter, Configurator>
    {
        public GlobalStorage(Configurator api) : base(api)
        {
        }
        
        public override ConfiguratorParameter Get(string url, Dictionary<string, object> parameter)
        {
            var response = new ConfiguratorRequest(url, parameter).Execute(Api.Client);

            ConfiguratorParameter param = new ConfiguratorParameter();

            return param;
        }

        public override void Save(ConfiguratorParameter entity)
        {
            throw new NotImplementedException();
        }
    }
}
