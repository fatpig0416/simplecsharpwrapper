using Configurator_RESTAPI_CALL.Util;
using System;
using System.Collections.Generic;

namespace Configurator_RESTAPI_CALL.Entity
{
    public delegate void ChangedCallback(string propertyName);

    public class EntityField<T>
    {
        private readonly string _name;
        private readonly string _conversionType;
        private T _value;
        private bool _set = false;
        private ChangedCallback _callback;

        public T Value
        {
            get => _value;

            set
            {
                if (_set == false || !EqualityComparer<T>.Default.Equals(_value, value))
                {
                    _set = true;
                    _callback.Invoke(_name);
                    _value = value;
                }
            }
        }

        public EntityField(string name, ChangedCallback callback)
        {
            _name = name;
            _callback = callback;
        }

        public EntityField(string name, string conversionType, ChangedCallback callback)
        {
            _name = name;
            _conversionType = conversionType;
            _callback = callback;
        }

        public dynamic ConvertIncoming(dynamic value)
        {
            if (_conversionType != null)
            {
                if (typeof(T) == typeof(DateTime) || typeof(T) == typeof(DateTime?))
                {
                    return Utils.DateTimeFromString(value);
                }
            }

            return value;
        }

        public dynamic ConvertOutgoing(dynamic value)
        {
            if (_conversionType != null)
            {
                if (typeof(T) == typeof(DateTime) || typeof(T) == typeof(DateTime?))
                {
                    return Utils.DateToString(value);
                }

            }

            return value;
        }
    }
}
