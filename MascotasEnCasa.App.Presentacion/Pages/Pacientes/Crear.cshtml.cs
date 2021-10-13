using System.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotasEnCasa.App.Dominio;
using MascotasEnCasa.App.Persistencia;

namespace MascotasEnCasa.App.Presentacion.Pages.Pacientes
{
    public class CrearModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        public Paciente paciente {get; set;}    ///genero un variable de tipo paciente para guardar los datos de la parte grafica
        /// Ahora necesito un metodo constructor para que me pueda crear la conexion directa con el repositorio entonces
        public CrearModel(IRepositorioPaciente _repoPaciente)/// generara unatributo de tipo repoPaciente y se llamara repoPaciente
        {
            this._repoPaciente = _repoPaciente; /// aqui le digo que el repoPaciente es igual el repoPaciente al que declare inicialmente.
        }

        public void OnGet() /// dentro de este metodo debo llamar para que me instancie un nuevo paciente asi:
        {
            paciente= new Paciente(); /// Cuando se ejecute me dira que este paciente que estoy llamando aqui me lo va a llamar creando el nuevo paciente.
        } /// para que me lo envie a la base de datos me toca crear un metodo AddPaciente que estaq en el IRepositorio 

        public IActionResult OnPost(Paciente paciente)
        {
            _repoPaciente.AddPaciente(paciente); ///Para guardar los datos se ubica en repoPaciente y llama al metodo Add Paciente y lo que adiciona es el paciente que me estan enviando
                                            
             return RedirectToPage("Index");


            /// una forma que se visualiza el paciente enviado retorna y redirecciona al index 
        }
          /* El metodo On post coge los datos que envian atraves del formulario y lo envia a la BD
        este metodo creara ese paciente en la base de datos y por eso recibe un objeto de tipo Paciente que se llama paciente*/
    }


}
