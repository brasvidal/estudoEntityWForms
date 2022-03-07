using Microsoft.EntityFrameworkCore;
using Models;

namespace Controllers.Context
{
    internal class SistemaContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Dentista> Dentistas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseNpgsql("User ID = postgres; Password=admin;Server=localhost;Port=5432;Database=banco;Integrated Security = true; Pooling=true;");
    }
}
