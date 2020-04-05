using Abp.Module.Inventory.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Module.Inventory
{
    public abstract class InventoryController : AbpController
    {
        protected InventoryController()
        {
            LocalizationResource = typeof(InventoryResource);
        }
    }
}
