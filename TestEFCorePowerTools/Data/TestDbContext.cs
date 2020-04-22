using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestEFCorePowerTools.Data.Entities;

namespace TestEFCorePowerTools.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table1>().HasKey(x => x.Id);
        }

        public DbSet<Table1> GolfClubs { get; set; }
    }
}
