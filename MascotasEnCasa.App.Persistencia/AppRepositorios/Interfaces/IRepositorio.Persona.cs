using System.Collections.Generic;
using MascotasEnCasa.App.Dominio;

namespace MascotasEnCasa.App.Persistencia
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();

        Persona AddPersona(Persona persona);

        Persona UpdatePersona(Persona persona);
        
        void DeletePersona(int idPersona);
        
        Persona GetPersona(int idPersona);
    }   
}
