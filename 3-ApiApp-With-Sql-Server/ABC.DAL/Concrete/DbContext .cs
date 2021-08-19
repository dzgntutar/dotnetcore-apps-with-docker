using System;
using System.Collections.Generic;
using System.Text;
using ABC.DAL.Concrete.Mapping;
using ABC.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Ttar.DAL.Concrete
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Company> Companies { get; set; }

        public DbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=db-sql-server;Database=Kariyer;User Id=sa;Password=Aa123456");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
