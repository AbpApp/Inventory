using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Abp.Module.Inventory.MongoDB
{
    public class InventoryMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public InventoryMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}