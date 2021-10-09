using System.Collections.Generic;
using MascotasEnCasa.App.Dominio;
using System.Linq;


namespace MascotasEnCasa.App.Persistencia
{
    public class RepositorioSignoVital:IRepositorioSignoVital
    {
         private readonly MascotasEnCasa.App.Persistencia.AppContext _appContext;

        public RepositorioSignoVital(MascotasEnCasa.App.Persistencia.AppContext appContext)
        {
            _appContext = appContext;
        }    
     SignoVital IRepositorioSignoVital.AddSignoVital(SignoVital signoVital)
        {
          var SignoVitalAdicionado = _appContext.SignosVitales.Add(signoVital);
          _appContext.SaveChanges();
          return SignoVitalAdicionado.Entity;

        }   
         void IRepositorioSignoVital.DeleteSignoVital(int idSignoVital)
         
        {
            var SignoVitalAdicionado= _appContext.SignosVitales.FirstOrDefault( p => p.Id==idSignoVital);
           if (SignoVitalAdicionado==null)
              return;
            _appContext.SignosVitales.Remove(SignoVitalAdicionado);
             _appContext.SaveChanges();
        }
         IEnumerable<SignoVital> IRepositorioSignoVital.GetAllSignoVital()
        {
            return _appContext.SignosVitales;
        }
         SignoVital IRepositorioSignoVital.GetSignoVital(int idSignoVital)
        {
             return _appContext.SignosVitales.FirstOrDefault( p => p.Id==idSignoVital);
          
        }
        SignoVital IRepositorioSignoVital.UpdateSignoVital(SignoVital signoVital)
        {
           var SignoVitalAdicionado= _appContext.SignosVitales.FirstOrDefault( p => p.Id==signoVital.Id);
           if (SignoVitalAdicionado!=null)
           {
               SignoVitalAdicionado.FechaHora=signoVital.FechaHora;
               SignoVitalAdicionado.Signo=signoVital.Signo;
               SignoVitalAdicionado.Valor=signoVital.Valor;

               _appContext.SaveChanges();
           }

           return SignoVitalAdicionado;
        }

    }
}