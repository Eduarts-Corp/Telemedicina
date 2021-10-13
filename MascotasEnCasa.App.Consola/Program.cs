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
                Nombre="Canela Sandoval",
                Raza=" Buldog Terrier",                                
                Peso = 12,  
                Edad = 2,              
                Color= "Gris",         
                Sexo= Sexo.Hembra,
                Direccion= "Cra 4 bis 13-49",
                Ciudad= "Bogota-Cundinamarca",
                Latitud= "0,002345F",
                Longitud= "0.455277W"



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
   