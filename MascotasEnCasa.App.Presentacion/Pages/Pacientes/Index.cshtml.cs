using System.Collections;
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

    public class IndexModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        public IEnumerable<Paciente> Pacientes { get; set; }


        public IndexModel (IRepositorioPaciente _repoPaciente)
        {
            this._repoPaciente=_repoPaciente;
        }
 
        public void OnGet()
        {
            Pacientes = _repoPaciente.GetAllPacientes();
        }
    }
}
