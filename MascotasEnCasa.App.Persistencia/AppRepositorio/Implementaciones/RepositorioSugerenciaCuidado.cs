using System.Collections.Generic;
using MascotasEnCasa.App.Dominio;
using System.Linq;

namespace MascotasEnCasa.App.Persistencia
{
    public class RepositorioSugerenciaCuidado: IRepositorioSugerenciaCuidado
    {

        private readonly AppContext _appContext= new AppContext();
                
        
        SugerenciaCuidado IRepositorioSugerenciaCuidado.AddSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado)
        {
          var SugerenciaCuidadoAdicionada = _appContext.SugerenciasCuidados.Add(sugerenciaCuidado);
          _appContext.SaveChanges();
          return SugerenciaCuidadoAdicionada.Entity;

        }   
         void IRepositorioSugerenciaCuidado.DeleteSugerenciaCuidado(int idSugerenciaCuidado)
        {
            var sugerenciaCuidadoEncontrada= _appContext.SugerenciasCuidados.Find(idSugerenciaCuidado);
           if (sugerenciaCuidadoEncontrada==null)
              return;
            _appContext.SugerenciasCuidados.Remove(sugerenciaCuidadoEncontrada);
             _appContext.SaveChanges();
        }
         IEnumerable<SugerenciaCuidado> IRepositorioSugerenciaCuidado.GetAllSugerenciaCuidado()
        {
            return _appContext.SugerenciasCuidados;
        }
         SugerenciaCuidado IRepositorioSugerenciaCuidado.GetSugerenciaCuidado(int idSugerenciaCuidado)
        {
             return _appContext.SugerenciasCuidados.Find(idSugerenciaCuidado);
          
        }
        SugerenciaCuidado IRepositorioSugerenciaCuidado.UpdateSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado)
        {
           var sugerenciaCuidadoEncontrada= _appContext.SugerenciasCuidados.Find(sugerenciaCuidado.Id);
           if (sugerenciaCuidadoEncontrada!=null)
           {
               sugerenciaCuidadoEncontrada.FechaHora=sugerenciaCuidado.FechaHora;
               sugerenciaCuidadoEncontrada.Descripcion=sugerenciaCuidado.Descripcion;
               
               
               _appContext.SaveChanges();
           }

           return sugerenciaCuidadoEncontrada;
        }

    }
}
