using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotasEnCasa.App.Persistencia;
using MascotasEnCasa.App.Dominio;

namespace MascotasEnCasa.App.Presentacion.Pages.Pacientes
{
    public class ActualizarModel : PageModel
    {
        
        private readonly IRepositorioPaciente _repoPaciente;
        public Paciente paciente{get;set;}
        
        public ActualizarModel(IRepositorioPaciente _repoPaciente)

        {
            this._repoPaciente= _repoPaciente;
        }

        public IActionResult OnGet(int id) ///me devuelve una accion (Y este Onget recibira el Id)
        {
            paciente=_repoPaciente.GetPaciente(id);                
                if (paciente==null)
                    {
                        return NotFound();
                    }    
                else
                    {   
                        return Page();
                    }       
            
        }               

            public IActionResult OnPost(Paciente paciente)
            {
                _repoPaciente.UpdatePaciente(paciente);
                return RedirectToPage("Index");
            }

               
        }
}
