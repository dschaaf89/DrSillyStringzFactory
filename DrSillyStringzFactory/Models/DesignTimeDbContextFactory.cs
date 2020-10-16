using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace DrSillyStringzFactory.Models
{
  public class DesignTimeDbContextFactory
  {
    public class EngineerMachineContextFactory : IDesignTimeDbContextFactory<FactoryContext>
    {

      FactoryContext IDesignTimeDbContextFactory<FactoryContext>.CreateDbContext(string[] args)
      {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<FactoryContext>();
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        builder.UseMySql(connectionString);

        return new FactoryContext(builder.Options);
      }
    }
  }
}