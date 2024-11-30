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
            optionsBuilder.UseSqlServer("User ID=sa;Password=194510;Server=localhost\\SQLEXPRESS;Database=ExoApi1;Trusted_Connection=False;");
           // optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ExoApi1;Trusted_Connection=True;TrustServerCertificate=True;");
           }
        }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
