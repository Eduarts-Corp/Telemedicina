using System;
using System.Collections.Generic;
using MascotasEnCasa.App.Persistencia;
using MascotasEnCasa.App.Dominio;
using System.Linq;

namespace MascotasEnCasa.App.Persistencia
{
    public class RepositorioPersona : IRepositorioPersona
    {

        private readonly AppContext _appContext;

        public RepositorioPersona(AppContext appContext)
        {
            _appContext=appContext;
        }

        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaAdicionado =_appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionado.Entity;
        }

        void IRepositorioPersona.DeletePersona(int idPersona)
        {
            var personaEncontrado=_appContext.Personas.FirstOrDefault(p =>p.Id==idPersona);
            if (personaEncontrado==null)
                return;
                _appContext.Personas.Remove(personaEncontrado);
                _appContext.SaveChanges();
        }

        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {
             return _appContext.Personas;
        }

        Persona IRepositorioPersona.GetPersona(int idPersona)
        {
            return _appContext.Personas.FirstOrDefault(p =>p.Id==idPersona);
        }

        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrado= _appContext.Personas.FirstOrDefault(p =>p.Id==persona.Id);
            if (personaEncontrado!= null)
            {
                personaEncontrado.Nombre=persona.Nombre;
                personaEncontrado.Apellido=persona.Apellido;
                personaEncontrado.Telefono=persona.Telefono;
                personaEncontrado.Genero= persona.Genero;

                _appContext.SaveChanges();

            }
            return personaEncontrado;
        }
    }
}