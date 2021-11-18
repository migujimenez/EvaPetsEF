using EvaPets.Domain;
using Microsoft.EntityFrameworkCore;

namespace EvaPets.Data
{
    public class StoreContext :DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Cities> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Store;User Id=sa;Password=Apto201.");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Store>()
                .HasMany(c => c.Cities)
                .WithMany(s => s.Store)
                .UsingEntity<CitiesStore>
                (sc => sc.HasOne<Cities>().WithMany(),
                sc => sc.HasOne<Store>().WithMany())
                .Property(sc => sc.DateOpened)
                .HasDefaultValueSql("getdate()");
        }
    }
}
