using System;

namespace HospiEnCasaMascotas.App.Dominio

{
    public class Paciente


    {
        public int Id { get; set;}    
        public Propietario Propietario { set; get; }
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public float Talla { get; set;}
        public float Peso {get; set; }
        public string Color {get; set; }
        public DateTime Fechanacimineto { get; set; }
        public Sexo Sexo {get; set; }
        public AuxiliarVeterinario AuxiliarVeterinario {get; set; }
        public Veterinario Veterinario { get; set; }
        public SignoVital Signovital { set; get; }
        public Historia Historia { set; get;}
            
        
    }
}    