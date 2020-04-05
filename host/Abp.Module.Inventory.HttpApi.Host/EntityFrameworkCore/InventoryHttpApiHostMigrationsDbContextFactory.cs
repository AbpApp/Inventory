using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Abp.Module.Inventory.EntityFrameworkCore
{
    public class InventoryHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<InventoryHttpApiHostMigrationsDbContext>
    {
        public InventoryHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<InventoryHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Inventory"));

            return new InventoryHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
