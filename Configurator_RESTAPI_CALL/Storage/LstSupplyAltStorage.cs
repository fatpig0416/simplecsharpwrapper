using Configurator_RESTAPI_CALL.Entity;
using Configurator_RESTAPI_CALL.Requests;
using System;
using System.Collections.Generic;

namespace Configurator_RESTAPI_CALL.Storage
{
    public class LstSupplyAltStorage : Storage<LstSupplyAlt, Configurator>
    {
        public LstSupplyAltStorage(Configurator api) : base(api)
        {
        }

        public override LstSupplyAlt Get(string url, Dictionary<string, object> parameter)
        {
            var response = new LstSupplyAltRequest(url, parameter).Execute(Api.Client);

            LstSupplyAlt param = new LstSupplyAlt();

            return param;
        }

        public override void Save(LstSupplyAlt entity)
        {
            throw new NotImplementedException();
        }
    }
}
