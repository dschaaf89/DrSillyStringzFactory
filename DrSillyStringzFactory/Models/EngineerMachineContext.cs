using Microsoft.EntityFrameworkCore;
namespace DrSillyStringzFactory.Models
{
    public class EngineerMachineContext : DbContext
    {
         public  DbSet<Engineer> Engineers { get; set; }
         public  DbSet<Machine> Machines { get; set; }
         public  DbSet<EngineerMachine> EngineerMachines { get; set; }
        

        public EngineerMachineContext(DbContextOptions options) : base(options) {}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}