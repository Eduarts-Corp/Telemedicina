using System.Collections.Generic;
using MascotasEnCasa.App.Dominio;
using System.Linq;

namespace MascotasEnCasa.App.Persistencia
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersona();                
        IEnumerable<Veterinario> GetAllVeterinario();        
        IEnumerable<AuxVeterinario> GetAllAuxVeterinario();
        IEnumerable<Propietario> GetAllPropietario();
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        Propietario UpdatePropietario(Propietario propietario);
        Veterinario UpdateVeterinario(Veterinario veterinario);
        AuxVeterinario UpdateAuxVeterinario(AuxVeterinario auxVeterinario);
        void DeletePersona (int idPersona);
        Persona GetPersona(int idPersona);
    }
}