using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VolvoCaminhoes.Models;

namespace VolvoCaminhoes
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Caminhao> Caminhoes { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Caminhao>().HasKey(t => t.Id);
        }

        public DbSet<VolvoCaminhoes.Models.Caminhao> Caminhao { get; set; }

    }
}
