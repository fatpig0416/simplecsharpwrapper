using System;
using System.Collections.Generic;
using System.Text;

namespace Configurator_RESTAPI_CALL.Entity
{

    public class LstSupplyAlt : Entity
    {
        public string PLDT { get => _pldt.Value; set => _pldt.Value = value; }
        public string DSDT { get => _dsdt.Value; set => _dsdt.Value = value; }
        public string CODT { get => _codt.Value; set => _codt.Value = value; }

        private readonly EntityField<string> _pldt;
        private readonly EntityField<string> _dsdt;
        private readonly EntityField<string> _codt;

        public LstSupplyAlt()
        {
            BuildField(ref _pldt, "PLDT");
            BuildField(ref _dsdt, "DSDT");
            BuildField(ref _codt, "CODT");
        }
    }

    public class ConfiguratorParameter : Entity
    {
        public Dictionary<string, string> Params { get => _param.Value; set => _param.Value = value; }

        private readonly EntityField<Dictionary<string, string>> _param;

        public ConfiguratorParameter()
        {
            BuildField(ref _param, "Params");
        }
    }

    public class CallMethodParameter : Entity
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

        public CallMethodParameter()
        {
            BuildField(ref _regn, "REGN");
            BuildField(ref _area, "AREA");
            BuildField(ref _section, "SECTION");
            BuildField(ref _part, "PART");
            BuildField(ref _cntry, "CNTRY");
            BuildField(ref _customer, "CUSTMOER");
        }

        public Dictionary<string, object> ToDict()
        {
            var param = new Dictionary<string, object>();
            param.Add("REGN", REGN);
            param.Add("AREA", AREA);
            param.Add("SECTION", SECTION);
            param.Add("PART", PART);
            param.Add("CNTRY", CNTRY);
            param.Add("CUSTMOER", CUSTMOER);

            return param;
        }
    }
    public class LstSupplyAltParameter : Entity
    {
        public Int32 CONO { get => _cono.Value; set => _cono.Value = value; }
        public Int32 ORQT { get => _qrqt.Value; set => _qrqt.Value = value; }
        public string DIVI { get => _divi.Value; set => _divi.Value = value; }
        public string FACI { get => _faci.Value; set => _faci.Value = value; }
        public string ORTP { get => _ortp.Value; set => _ortp.Value = value; }
        public string CUNO { get => _cuno.Value; set => _cuno.Value = value; }
        public string ITNO { get => _itno.Value; set => _itno.Value = value; }
        public string DWDT { get => _dwdt.Value; set => _dwdt.Value = value; }

        private readonly EntityField<Int32> _cono;
        private readonly EntityField<Int32> _qrqt;
        private readonly EntityField<string> _divi;
        private readonly EntityField<string> _faci;
        private readonly EntityField<string> _ortp;
        private readonly EntityField<string> _cuno;
        private readonly EntityField<string> _itno;
        private readonly EntityField<string> _dwdt;

        public LstSupplyAltParameter()
        {
            BuildField(ref _cono, "CONO");
            BuildField(ref _qrqt, "ORQT");
            BuildField(ref _divi, "DIVI");
            BuildField(ref _faci, "FACI");
            BuildField(ref _ortp, "ORTP");
            BuildField(ref _cuno, "CUNO");
            BuildField(ref _itno, "ITNO");
            BuildField(ref _dwdt, "DWDT");
        }

        public Dictionary<string, object> ToDict()
        {
            var param = new Dictionary<string, object>();
            param.Add("CONO", CONO);
            param.Add("ORQT", ORQT);
            param.Add("DIVI", DIVI);
            param.Add("FACI", FACI);
            param.Add("ORTP", ORTP);
            param.Add("CUNO", CUNO);
            param.Add("ITNO", ITNO);
            param.Add("DWDT", DWDT);

            return param;
        }
    }
}

