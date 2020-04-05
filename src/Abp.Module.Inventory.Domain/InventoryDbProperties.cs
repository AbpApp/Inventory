namespace Abp.Module.Inventory
{
    public static class InventoryDbProperties
    {
        public static string DbTablePrefix { get; set; } = "Inventory";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "Inventory";
    }
}
