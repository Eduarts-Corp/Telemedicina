using System;

namespace HospiEnCasaMascotas.App.Dominio
{
    public class Propietario:Persona
    {
        public string Correo { get; set; }

        public string Direccion { get; set; }

        public float Latitud { get; set; }

        public float Longitud { get ; set; }

    }

 }   