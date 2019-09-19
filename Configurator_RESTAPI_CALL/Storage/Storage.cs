using Configurator_RESTAPI_CALL.Entity;
using Configurator_RESTAPI_CALL.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Configurator_RESTAPI_CALL.Storage
{
    public abstract class Storage<T, C> where T : Entity.Entity
    {
        public ApiClient<C> Api { get; private set; }
        public readonly IDictionary<string, T> Known;
        public bool Dirty = false;

        public Storage()
        {
            Known = new EventEmittingDictionary<string, T>(() => Dirty = true);
        }

        public Storage(ApiClient<C> api)
        {
            Known = new EventEmittingDictionary<string, T>(() => Dirty = true);
            UseClient(api);
        }

        public void UseClient(ApiClient<C> api)
        {
            Api = api;
        }

        public abstract T Get(string url, Dictionary<string, object> parameter);

        public void Sync()
        {
            foreach (var entity in Known.Values)
            {
                if (entity.Dirty())
                {
                    Save(entity);
                }
            }
        }

        public abstract void Save(T entity);


        public void Clear(string id)
        {
            Known.Remove(id);
        }

        public void Clear()
        {
            Known.Clear();
        }

        public void Clean()
        {
            Dirty = false;
        }
    }

    public class StorageFactory
    {
        public static T Create<T, E, C>()
            where E : Entity.Entity
            where T : Storage<E, C>, new()
        {
            return new T();
        }
    }
}
