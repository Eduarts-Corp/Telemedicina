using Microsoft.EntityFrameworkCore;
using MascotasEnCasa.App.Dominio;

namespace MascotasEnCasa.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }                
        public DbSet<Historia> Historias { get; set; }
        public DbSet<Persona>  Personas { get; set; }
        public DbSet<Veterinario> Veterianarios { get; set; }
        public DbSet<AuxVeterinario> AuxVeterinarios { get; set; }
        public DbSet<SugerenciaCuidado> SugerenciasCuidados { get; set; }
        public DbSet<SignoVital> SignosVitales { get; set; }
        public DbSet<Propietario> Propietarios { get; set; }
          
        
        
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
         if (!optionsBuilder.IsConfigured)
         {
             optionsBuilder.UseSqlServer
             ("Server=tcp:databasegarous.database.windows.net,1433;Initial Catalog=Garous;Persist Security Info=False;User ID=eduarts;Password=Garous1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
         }   
        }
    }
}