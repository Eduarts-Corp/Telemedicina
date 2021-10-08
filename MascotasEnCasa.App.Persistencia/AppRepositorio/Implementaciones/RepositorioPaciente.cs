using System;
using System.Collections.Generic;
using MascotasEnCasa.App.Dominio;
using System.Linq;

namespace MascotasEnCasa.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly MascotasEnCasa.App.Persistencia.AppContext _appContext;

        public RepositorioPaciente(MascotasEnCasa.App.Persistencia.AppContext appContext)
        {
            _appContext = appContext;
        }                  
        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
          var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
          _appContext.SaveChanges();
          return pacienteAdicionado.Entity;

        }   
         void IRepositorioPaciente.DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault( p => p.Id==idPaciente);
            if (pacienteEncontrado==null)
               return;
               _appContext.Pacientes.Remove(pacienteEncontrado);
               _appContext.SaveChanges();
        }
         IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Pacientes;
        }
         Paciente IRepositorioPaciente.GetPaciente(int idPaciente)
        {
             return _appContext.Pacientes.FirstOrDefault( p => p.Id==idPaciente);
          
        }
         Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
           var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault( p => p.Id==paciente.Id);
           if (pacienteEncontrado!=null)
           {
               pacienteEncontrado.Nombre=paciente.Nombre;
               pacienteEncontrado.Raza=paciente.Raza;
               pacienteEncontrado.Peso=paciente.Peso;
               pacienteEncontrado.Color=paciente.Color;
               pacienteEncontrado.Edad=paciente.Edad;
               pacienteEncontrado.Genero=paciente.Genero;   
               pacienteEncontrado.Direccion=paciente.Direccion;
               pacienteEncontrado.Latitud=paciente.Latitud;
               pacienteEncontrado.Longitud=paciente.Longitud;
               pacienteEncontrado.Ciudad=paciente.Ciudad;
                              
               _appContext.SaveChanges();
           }

           return pacienteEncontrado;

        }
    

    }
}    