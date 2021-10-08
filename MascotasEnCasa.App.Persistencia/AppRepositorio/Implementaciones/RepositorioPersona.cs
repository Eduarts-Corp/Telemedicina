using System;
using System.Collections.Generic;
using MascotasEnCasa.App.Dominio;
using System.Linq;


namespace MascotasEnCasa.App.Persistencia
{
    public class RepositorioPersona : IRepositorioPersona
    {
      private readonly MascotasEnCasa.App.Persistencia.AppContext _appContext;

        public RepositorioPersona(MascotasEnCasa.App.Persistencia.AppContext appContext)
        {
            _appContext = appContext;
        }   
        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
          var personaAdicionada = _appContext.Personas.Add(persona);
          _appContext.SaveChanges();
          return personaAdicionada.Entity;

        }   
         void IRepositorioPersona.DeletePersona(int idPersona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault( p => p.Id==idPersona);
           if (personaEncontrada==null)
              return;
            _appContext.Personas.Remove(personaEncontrada);
            _appContext.SaveChanges();
        }
         IEnumerable<Persona> IRepositorioPersona.GetAllPersona()
        {
            return _appContext.Personas;
        }

          IEnumerable<Propietario> IRepositorioPersona.GetAllPropietario()
        {
            return _appContext.Propietarios;
        }

          IEnumerable<Veterinario> IRepositorioPersona.GetAllVeterinario()
        {
            return _appContext.Veterianarios;            
        }

          IEnumerable<AuxVeterinario> IRepositorioPersona.GetAllAuxVeterinario()
        {
            return _appContext.AuxVeterinarios;            
        }  
         Persona IRepositorioPersona.GetPersona(int idPersona)
        {
            return _appContext.Personas.FirstOrDefault( p => p.Id==idPersona);
          
        }
        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
           var personaEncontrada = _appContext.Personas.FirstOrDefault( p => p.Id==persona.Id);
           if (personaEncontrada!=null)
           {
               personaEncontrada.Nombre=persona.Nombre;
               personaEncontrada.Apellidos=persona.Apellidos;
               personaEncontrada.NumeroTelefono=persona.NumeroTelefono;
               personaEncontrada.Genero=persona.Genero;

               _appContext.SaveChanges();
           }

           return personaEncontrada;

        }

       Propietario IRepositorioPersona.UpdatePropietario(Propietario propietario)
       {
        var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault( p => p.Id==propietario.Id);
           if (propietarioEncontrado!=null)
           {
               propietarioEncontrado.Correo=propietario.Correo;               

               _appContext.SaveChanges();
           }

           return propietarioEncontrado;
       }
       
        Veterinario IRepositorioPersona.UpdateVeterinario(Veterinario veterinario)
        {
          var veterinarioEncontrado = _appContext.Veterianarios.FirstOrDefault( p => p.Id==veterinario.Id);
           if (veterinarioEncontrado!=null)
           {
               veterinarioEncontrado.Licencia=veterinario.Licencia;
               veterinarioEncontrado.Especialidad=veterinario.Especialidad;
               
               _appContext.SaveChanges();
           }

           return veterinarioEncontrado;
        }

        AuxVeterinario IRepositorioPersona.UpdateAuxVeterinario(AuxVeterinario auxVeterinario)
        {
         var auxVeterinarioEncontrado = _appContext.AuxVeterinarios.FirstOrDefault( p => p.Id==auxVeterinario.Id);
         
           if (auxVeterinarioEncontrado!=null)
           {
              auxVeterinarioEncontrado.Licencia=auxVeterinario.Licencia;
              auxVeterinarioEncontrado.HorasLaborales=auxVeterinario.HorasLaborales;
              
               _appContext.SaveChanges();
           }
           return auxVeterinarioEncontrado;

        }
    }
}   



