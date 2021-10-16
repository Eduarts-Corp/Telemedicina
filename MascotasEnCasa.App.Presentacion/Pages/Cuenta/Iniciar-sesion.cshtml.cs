using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Task;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MascotasEnCasa.App.Presentacion.Pages.Cuenta
{
    public class Iniciar_sesionModel : PageModel
    {
        [BindProperty]
        public Credential Credential{get; set;}
        
        public void OnGet()
        {
        }

        public void OnPost()
        {

        }
    }
{
    
}
    public class Credential
    {
        [Required]
        [Display(Name="Email")]
        public string Email{get; set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password{get; set;}
    }
}