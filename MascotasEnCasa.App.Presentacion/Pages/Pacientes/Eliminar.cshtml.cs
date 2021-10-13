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
    public class EliminarModel : PageModel
    {

        private readonly IRepositorioPaciente _repoPaciente;
        public Paciente paciente {get;set;}

        public EliminarModel (IRepositorioPaciente _repoPaciente)
        {
            this._repoPaciente=_repoPaciente;
        }

        public IActionResult OnGet(int id)
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

        public IActionResult OnPost(int id)
        {
            _repoPaciente.DeletePaciente(id);
            return RedirectToPage("Index");
        }

    }
}
