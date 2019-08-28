using Configurator_RESTAPI_CALL.Storage;
namespace Configurator_RESTAPI_CALL.Entity
{
    public class EntityManyRelationship<E, C, S>
        where E : Entity
        where C : ApiClient<C>
        where S : Storage<E, C>, new()
    {
        public readonly Storage<E, C> Known;

        public EntityManyRelationship()
        {
            Known = StorageFactory.Create<S, E, C>();
        }
    }
}
