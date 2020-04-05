using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.Module.Inventory.EntityFrameworkCore
{
    public class InventoryHttpApiHostMigrationsDbContext : AbpDbContext<InventoryHttpApiHostMigrationsDbContext>
    {
        public InventoryHttpApiHostMigrationsDbContext(DbContextOptions<InventoryHttpApiHostMigrationsDbContext> options)
            : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureInventory();
        }
    }
}
