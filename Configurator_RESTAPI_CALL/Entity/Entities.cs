using System;
using System.Collections.Generic;
using System.Text;

namespace Configurator_RESTAPI_CALL.Entity
{
    public class ConfiguratorParameter : Entity
    {
        public Int32 REGN { get => _regn.Value; set => _regn.Value = value; }
        public Int32 AREA { get => _area.Value; set => _area.Value = value; }
        public Int32 SECTION { get => _section.Value; set => _section.Value = value; }
        public Int32 PART { get => _part.Value; set => _part.Value = value; }
        public string CNTRY { get => _cntry.Value; set => _cntry.Value = value; }
        public string CUSTMOER { get => _customer.Value; set => _customer.Value = value; }

        private readonly EntityField<Int32> _regn;
        private readonly EntityField<Int32> _area;
        private readonly EntityField<Int32> _section;
        private readonly EntityField<Int32> _part;
        private readonly EntityField<string> _cntry;
        private readonly EntityField<string> _customer;

        public ConfiguratorParameter()
        {
            BuildField(ref _regn, "REGN");
            BuildField(ref _area, "AREA");
            BuildField(ref _section, "SECTION");
            BuildField(ref _part, "PART");
            BuildField(ref _cntry, "CNTRY");
            BuildField(ref _customer, "CUSTMOER");
        }
    }
}

