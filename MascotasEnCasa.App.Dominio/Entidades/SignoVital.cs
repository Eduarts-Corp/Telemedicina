using System;


namespace MascotasEnCasa.App.Dominio
{
    public class SignoVital
    {
        public int Id{get;set;}                
        public DateTime FechaHora {get;set;}       
        public int Valor {get; set;}
         public Signo Signo {set;get;}
        
        
        
    }
}