using System;
using System.Collections.Generic;
using MascotasEnCasa.App.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MascotasEnCasa.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext = new AppContext();

          
        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
          var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
          _appContext.SaveChanges();
          return pacienteAdicionado.Entity;

        }   
         void IRepositorioPaciente.DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.Find(idPaciente);
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
             return _appContext.Pacientes.Find(idPaciente);
          
        }
         Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
           var pacienteEncontrado = _appContext.Pacientes.Find(paciente.Id);
           if (pacienteEncontrado!=null)
           {
               pacienteEncontrado.Nombre=paciente.Nombre;
               pacienteEncontrado.Raza=paciente.Raza;
               pacienteEncontrado.Peso=paciente.Peso;
               pacienteEncontrado.Color=paciente.Color;
               pacienteEncontrado.Edad=paciente.Edad;
               pacienteEncontrado.Sexo=paciente.Sexo;   
               pacienteEncontrado.Direccion=paciente.Direccion;
               pacienteEncontrado.Latitud=paciente.Latitud;
               pacienteEncontrado.Longitud=paciente.Longitud;
               pacienteEncontrado.Ciudad=paciente.Ciudad;
                              
               _appContext.SaveChanges();
           }

           return pacienteEncontrado;

        }
        
        SignoVital IRepositorioPaciente.AddSignoVital(SignoVital signoVital)
        {
            var SignoVitalAdicionado= _appContext.SignosVitales.Add(signoVital);
            _appContext.SaveChanges();
            return SignoVitalAdicionado.Entity;
        }
       

    }
}    