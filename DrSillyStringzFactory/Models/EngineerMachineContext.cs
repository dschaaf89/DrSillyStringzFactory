namespace DrSillyStringzFactory.Models
{
    public class EngineerMachineContext: DbContext
    {
          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            public DbSet<Engineer> Engineer { get; set; }
            public DbSet<Machine> Machine { get; set; }
             public  DbSet<EngineerMachine> EngineerMachine { get; set; }
            public EngineerMachineContext(DbContextOptions options) : base(options) {}
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}