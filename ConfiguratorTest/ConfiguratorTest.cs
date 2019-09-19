using Configurator_RESTAPI_CALL;
using Configurator_RESTAPI_CALL.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ConfiguratorTest
{
    [TestClass]
    public class ConfiguratorTest
    {
        private Configurator configurator;

        [TestInitialize]
        public void Initialize()
        {
            if (configurator == null)
            {
                configurator = new Configurator();
                Console.WriteLine("Authenticating...");
                //configurator.Authenticate("username", "password");
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            CallMethodParameter param = new CallMethodParameter()
            {
                REGN = 22,
                AREA = 1,
                SECTION = 77,
                PART = 67123,
                CNTRY = "USA",
                CUSTMOER = "7800000012"
            };
            
            var response = configurator._globalStorage.Get("/api-rest/execute/svcapi/callmethod", param.ToDict());
        }

        [TestMethod]
        public void TestMethod2()
        {
            LstSupplyAltParameter param = new LstSupplyAltParameter()
            {
                CONO = 1,
                ORQT = 1,
                DIVI = "010",
                FACI = "060",
                ORTP = "USA",
                CUNO = "US00000072",
                ITNO = "TB9SX4C-0",
                DWDT = "20190918"
            };
            var response = configurator._lstSupplyAltStorage.Get("/m3api-rest/execute/CTZ100MI/LstSupplyAlt", param.ToDict());
        }
    }
}
