using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }
        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           if (!optionsBuilder.IsConfigured)
           {
             // Essa string de conexão depende de SUA máquina
             optionsBuilder.UseSqlServer("User ID=sa;Password=admin;Server=localhost;Database=ExoApi;Trusted_Connection=False;");
           }
           // base.OnConfiguring(optionsBuilder);a
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
}