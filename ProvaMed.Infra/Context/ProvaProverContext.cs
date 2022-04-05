using Microsoft.EntityFrameworkCore;
using ProvaMed.DomainModel.Entity;
using ProvaMed.Infra.Mappings;

namespace ProvaMed.Infra.Context
{
    public class ProvaMedContext : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }

        public ProvaMedContext(DbContextOptions<ProvaMedContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContatoMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
