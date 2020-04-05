using Volo.Abp.Modularity;

namespace Abp.Module.Inventory
{
    [DependsOn(
        typeof(InventoryApplicationModule),
        typeof(InventoryDomainTestModule)
        )]
    public class InventoryApplicationTestModule : AbpModule
    {

    }
}
