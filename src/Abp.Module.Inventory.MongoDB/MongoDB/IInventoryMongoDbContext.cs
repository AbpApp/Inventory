using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Abp.Module.Inventory.MongoDB
{
    [ConnectionStringName(InventoryDbProperties.ConnectionStringName)]
    public interface IInventoryMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
