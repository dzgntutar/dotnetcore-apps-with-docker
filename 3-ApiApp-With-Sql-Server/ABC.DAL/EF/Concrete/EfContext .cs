using System;
using System.Collections.Generic;
using System.Text;
using ABC.DAL.EF.Concrete.Mapping;
using ABC.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Ttar.DAL.Concrete
{
    public class EfContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }

        public EfContext(DbContextOptions<EfContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
    }
}
