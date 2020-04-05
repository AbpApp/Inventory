using Volo.Abp.Modularity;

namespace Abp.Module.Inventory
{
    [DependsOn(
        typeof(InventoryDomainSharedModule)
        )]
    public class InventoryDomainModule : AbpModule
    {

    }
}
