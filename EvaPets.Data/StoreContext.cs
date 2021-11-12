using System;
using EvaPets.Domain;
using Microsoft.EntityFrameworkCore;

namespace EvaPets.Data
{
    public class StoreContext :DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Employees> Employees { get; set; }
    }
}
