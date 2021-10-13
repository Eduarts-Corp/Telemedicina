using System.Collections.Generic;
using MascotasEnCasa.App.Dominio;
using System.Linq;

namespace MascotasEnCasa.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();                        
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente (int idPaciente);
        Paciente GetPaciente(int idpaciente);      
       SignoVital AddSignoVital(SignoVital signoVital); 
        
        
    } 
}