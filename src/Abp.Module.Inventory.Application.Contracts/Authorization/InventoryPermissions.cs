using Volo.Abp.Reflection;

namespace Abp.Module.Inventory.Authorization
{
    public class InventoryPermissions
    {
        public const string GroupName = "Inventory";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(InventoryPermissions));
        }
    }
}