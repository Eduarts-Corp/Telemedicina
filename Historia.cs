using System;

namespace HospiEnCasaMascotas.App.Dominio
{
    public class Historia
    {
        public SugerenciaCuidado SugerenciaCuidado {get; set;}

        public int Id {get; set;}

        public string Diagnostico { get; set;}

        public string Entorno { get; set; }

        public String Antecedentes { get; set; }

    }

}