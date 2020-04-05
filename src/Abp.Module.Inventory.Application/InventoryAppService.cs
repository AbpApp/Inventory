using Abp.Module.Inventory.Localization;
using Volo.Abp.Application.Services;

namespace Abp.Module.Inventory
{
    public abstract class InventoryAppService : ApplicationService
    {
        protected InventoryAppService()
        {
            LocalizationResource = typeof(InventoryResource);
            ObjectMapperContext = typeof(InventoryApplicationModule);
        }
    }
}
