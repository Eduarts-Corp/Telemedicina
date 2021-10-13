using System.Collections.Generic;
using MascotasEnCasa.App.Dominio;
using System.Linq;


namespace MascotasEnCasa.App.Persistencia 
{
    public class RepositorioHistoria:IRepositorioHistoria
    {

         private readonly AppContext _appContext = new AppContext();

        
        
        Historia IRepositorioHistoria.AddHistoria(Historia historia)
        {
          var historiaAdicionada = _appContext.Historias.Add(historia);
          _appContext.SaveChanges();
          return historiaAdicionada.Entity;

        }   
         void IRepositorioHistoria.DeleteHistoria(int idHistoria)
        {
            var historiaEncontrada = _appContext.Historias.Find(idHistoria);
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
             return _appContext.Historias.Find(idHistoria);          
        }
        Historia IRepositorioHistoria.UpdateHistoria(Historia historia)
        {
           var historiaEncontrada = _appContext.Historias.Find(historia.Id);
           if (historiaEncontrada!=null)
           {
               historiaEncontrada.Diagnostico=historia.Diagnostico;
               historiaEncontrada.SugerenciasCuidados = historia.SugerenciasCuidados;   
                       
                               
               _appContext.SaveChanges();
           }

           return historiaEncontrada;
        }
    }
}