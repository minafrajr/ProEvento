using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using ProEvento.API.Models;

namespace ProEvento.API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Evento> Eventos { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Evento>(e => e.Property(o => o.EventoId).HasColumnType("int(1)"));
        }
        */
    }
}