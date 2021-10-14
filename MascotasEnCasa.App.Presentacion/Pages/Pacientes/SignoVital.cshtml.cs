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
    public class SignoVitalModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        public SignoVital signoVital {set;get;}
        public Paciente paciente{get;set;}
        public SignoVitalModel(IRepositorioPaciente _repoPaciente)
        {
            this._repoPaciente=_repoPaciente;
        }
        
    
        public IActionResult OnGet(int id)
        {
            signoVital=new SignoVital();

            paciente=_repoPaciente.GetPaciente(id);
            if(paciente==null)
            {
               return NotFound();
            }
            else
            {
            return Page();
            }
        }
        public IActionResult OnPost(SignoVital signoVital)
        {
            _repoPaciente.AddSignoVital(signoVital);
            return RedirectToPage("Index");
        }

    }

}    
    

