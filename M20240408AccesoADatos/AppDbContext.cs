using M20240408.EntidadesDeNegocio;
using Microsoft.EntityFrameworkCore;


namespace M20240408AccesoADatos
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<PersonaM> Persona { get; set; }
    }
}
