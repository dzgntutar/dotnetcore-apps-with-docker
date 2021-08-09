// using System;
// using System.Collections.Generic;
// using System.Text;
// using Microsoft.EntityFrameworkCore;

// namespace Ttar.DAL.Concrete
// {
//     public class EfContext : DbContext
//     {
//         public DbSet<Category> Categories { get; set; }

//         protected override void OnConfiguring(
//             DbContextOptionsBuilder optionsBuilder
//         )
//         {
//             //optionsBuilder.UseSqlite("Data Source=test.db");
//             base.OnConfiguring(optionsBuilder);
//         }

//         protected override void OnModelCreating(ModelBuilder modelBuilder)
//         {
//             modelBuilder.ApplyConfiguration(new CategoryMap());
//             base.OnModelCreating(modelBuilder);
//         }
//     }
// }
