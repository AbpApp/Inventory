using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Abp.Module.Inventory.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace Abp.Module.Inventory
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class InventoryDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<InventoryDomainSharedModule>("Abp.Module.Inventory");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<InventoryResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/Inventory");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("Inventory", typeof(InventoryResource));
            });
        }
    }
}
