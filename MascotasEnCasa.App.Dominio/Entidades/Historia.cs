using System;
using System.Collections.Generic;

namespace MascotasEnCasa.App.Dominio
{
    public class Historia
    {
        public int Id{get;set;}
        public string Diagnostico {get;set;}        
        public List<SugerenciaCuidado> SugerenciasCuidados {get;set;}
        
        
    }
}
