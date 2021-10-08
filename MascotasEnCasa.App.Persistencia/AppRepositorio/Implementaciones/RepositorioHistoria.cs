using System.Collections.Generic;
using MascotasEnCasa.App.Dominio;
using System.Linq;


namespace MascotasEnCasa.App.Persistencia 
{
    public class RepositorioHistoria:IRepositorioHistoria
    {

         private readonly MascotasEnCasa.App.Persistencia.AppContext _appContext;

        public RepositorioHistoria(MascotasEnCasa.App.Persistencia.AppContext appContext)
        {
            _appContext = appContext;
        }   
        
        Historia IRepositorioHistoria.AddHistoria(Historia historia)
        {
          var historiaAdicionada = _appContext.Historias.Add(historia);
          _appContext.SaveChanges();
          return historiaAdicionada.Entity;

        }   
         void IRepositorioHistoria.DeleteHistoria(int idHistoria)
        {
            var historiaEncontrada = _appContext.Historias.FirstOrDefault( p => p.Id==idHistoria);
           if (historiaEncontrada==null)
              return;
            _appContext.Historias.Remove(historiaEncontrada);
             _appContext.SaveChanges();
        }
         IEnumerable<Historia> IRepositorioHistoria.GetAllHistoria()
        {
            return _appContext.Historias;
        }
         Historia IRepositorioHistoria.GetHistoria(int idHistoria)
        {
             return _appContext.Historias.FirstOrDefault( p => p.Id==idHistoria);          
        }
        Historia IRepositorioHistoria.UpdateHistoria(Historia historia)
        {
           var historiaEncontrada = _appContext.Historias.FirstOrDefault( p => p.Id==historia.Id);
           if (historiaEncontrada!=null)
           {
               historiaEncontrada.Diagnostico=historia.Diagnostico;           
                               
               _appContext.SaveChanges();
           }

           return historiaEncontrada;
        }
    }
}