using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace DrSillyStringzFactory.Models
{
  public class DesignTimeDbContextFactory
  {
    public class EngineerMachineContextFactory : IDesignTimeDbContextFactory<EngineerMachineContext>
    {

      EngineerMachineContext IDesignTimeDbContextFactory<EngineerMachineContext>.CreateDbContext(string[] args)
      {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<EngineerMachineContext>();
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        builder.UseMySql(connectionString);

        return new EngineerMachineContext(builder.Options);
      }
    }
  }
}