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
        public int edad {get;set;}
        public Genero Genero {get;set;}           
        public string Direccion{get;set;}
        public string Latitud {get;set;}
        public string Longitud {get;set;}
        public string Ciudad {get;set;}
        public Propietario Propietario {get;set;}
        public Historia HistoriaClinica {get;set;}
        public List<SignoVital> SignosVitales {get;set;}

        
    }
}