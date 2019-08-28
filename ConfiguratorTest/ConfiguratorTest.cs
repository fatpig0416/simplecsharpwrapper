using Configurator_RESTAPI_CALL;
using Configurator_RESTAPI_CALL.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            ConfiguratorParameter param = new ConfiguratorParameter()
            {
                REGN = 22,
                AREA = 1,
                SECTION = 77,
                PART = 67123,
                CNTRY = "USA",
                CUSTMOER = "7800000012"
            };

            var response = configurator._globalStorage.Get(param);
        }
    }
}
