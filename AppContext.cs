using Microsoft.EntityFrameworkCore;
using HospiEnCasaMascotas.App.Dominio;

namespace HospiEnCasaMascotas.App.Persistencia
{
    public class AppContext : DbContext 
    {
        public DbSet<Persona> Personas {get; set;}
        public DbSet<AuxiliarVeterinario> AuxiliaresVeterinarios {get; set;}        
        public DbSet<Historia> Historias {get;set;}
        public DbSet<Paciente> Pacientes {get;set;}
        public DbSet<Propietario> Propietarios {get; set;}
        public DbSet<SignoVital> SignosVitales {get; set;}
        public DbSet<SugerenciaCuidado> SugerenciasCuidados {get; set;}
        public DbSet<Veterinario> Veterinarios {get; set;}

         protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
         {
             if (!optionsBuilder.IsConfigured)
                {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HospiEnCasa.Data");
                }
         }  

  
    }


}