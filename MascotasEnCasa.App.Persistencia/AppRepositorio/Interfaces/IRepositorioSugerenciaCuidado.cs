using System.Collections.Generic;
using MascotasEnCasa.App.Dominio;
using System.Linq;

namespace MascotasEnCasa.App.Persistencia
{
    public interface IRepositorioSugerenciaCuidado
    {
       IEnumerable<SugerenciaCuidado> GetAllSugerenciaCuidado();
        SugerenciaCuidado AddSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado);
        SugerenciaCuidado UpdateSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado);        
        void DeleteSugerenciaCuidado(int idSugerenciaCuidado);
        SugerenciaCuidado GetSugerenciaCuidado(int idSugerenciaCuidado);      


    }
}