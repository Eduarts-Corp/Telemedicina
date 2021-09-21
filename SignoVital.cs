using System;

namespace HospiEnCasaMascotas.App.Dominio
{
    public class SignoVital
    {
        public int Id { get; set; }

        public DateTime FechaHora { get; set; }

        public int Valor { get; set; }

        public System.Collections.Generic.List<SignoVital> SignosVitales { get; set; }

    }



}
