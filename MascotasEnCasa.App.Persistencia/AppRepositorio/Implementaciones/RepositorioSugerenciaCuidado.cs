using System.Collections.Generic;
using MascotasEnCasa.App.Dominio;
using System.Linq;

namespace MascotasEnCasa.App.Persistencia
{
    public class RepositorioSugerenciaCuidado: IRepositorioSugerenciaCuidado
    {

        private readonly MascotasEnCasa.App.Persistencia.AppContext _appContext;

        public RepositorioSugerenciaCuidado(MascotasEnCasa.App.Persistencia.AppContext appContext)
        {
            _appContext = appContext;
        }
        
        SugerenciaCuidado IRepositorioSugerenciaCuidado.AddSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado)
        {
          var SugerenciaCuidadoAdicionada = _appContext.SugerenciasCuidados.Add(sugerenciaCuidado);
          _appContext.SaveChanges();
          return SugerenciaCuidadoAdicionada.Entity;

        }   
         void IRepositorioSugerenciaCuidado.DeleteSugerenciaCuidado(int idSugerenciaCuidado)
        {
            var sugerenciaCuidadoEncontrada= _appContext.SugerenciasCuidados.FirstOrDefault( p => p.Id==idSugerenciaCuidado);
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
             return _appContext.SugerenciasCuidados.FirstOrDefault( p => p.Id==idSugerenciaCuidado);
          
        }
        SugerenciaCuidado IRepositorioSugerenciaCuidado.UpdateSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado)
        {
           var sugerenciaCuidadoEncontrada= _appContext.SugerenciasCuidados.FirstOrDefault( p => p.Id==sugerenciaCuidado.Id);
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
