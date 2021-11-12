using System;
using EvaPets.Domain;
using Microsoft.EntityFrameworkCore;

namespace EvaPets.Data
{
    public class StoreContext :DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Employees> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Store;User Id=sa;Password=Apto201.");
        }
    }
}
