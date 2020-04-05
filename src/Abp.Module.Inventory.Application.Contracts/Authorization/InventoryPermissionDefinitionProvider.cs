using Abp.Module.Inventory.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.Module.Inventory.Authorization
{
    public class InventoryPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(InventoryPermissions.GroupName, L("Permission:Inventory"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<InventoryResource>(name);
        }
    }
}