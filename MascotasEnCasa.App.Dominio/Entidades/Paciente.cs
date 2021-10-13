using System;
using System.Collections.Generic;


namespace MascotasEnCasa.App.Dominio
{
    public class Paciente
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Raza {get;set;}
        public int Peso {get;set;}
        public string Color {get;set;}
        public int Edad {get;set;}
        public Sexo Sexo {get;set;}           
        public string Direccion{get;set;}
        public string Latitud {get;set;}
        public string Longitud {get;set;}
        public string Ciudad {get;set;}
        public Veterinario Veterinario { get; set; }         
        public AuxVeterinario AuxVeterinario { get; set; }       
        public Propietario Propietario {get;set;}
        public Historia Historia {get;set;}
        public List<SignoVital> SignosVitales {get;set;}

        
    }
}