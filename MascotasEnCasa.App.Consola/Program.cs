using System.Net.Security;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System;
using MascotasEnCasa.App.Dominio;
using MascotasEnCasa.App.Persistencia;

namespace MascotasEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente(new Persistencia.AppContext());
        

        static void Main(string[] args)
        {
            Console.WriteLine("Prueba de Tester");
           // AddPaciente();
            BuscarPaciente(2);
                                         
        }
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre="Guantes Sandoval",
                Raza="Pincher",                                
                Peso = 4,  
                Edad = 2,              
                Color= "Negro-amarillo",         
                Genero= Genero.Masculino,
                Direccion= "Cra 10 bis 14-46",
                Ciudad= "Chia-Cundinamarca"



            };
            _repoPaciente.AddPaciente(paciente);  
            Console.WriteLine("se ha guardado el registro");  
        }
 
        
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre+" "+ paciente.Color);
        }
                 
            

        
        }
        
}   
   