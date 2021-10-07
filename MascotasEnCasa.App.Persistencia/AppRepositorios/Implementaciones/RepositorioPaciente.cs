using System.Collections.Generic;
using HospiEnCasaMascotas.App.Dominio;
using System.Linq;


namespace MascotasEnCasa.App.Persistencia
{
    public interface IRepositorioPaciente    
    {

        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);
        IEnumerable<Paciente> GetAllPacientes();
        
        
        
        
        

    }   
}

