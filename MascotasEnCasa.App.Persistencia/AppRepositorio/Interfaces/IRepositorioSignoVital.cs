using System.Collections.Generic;
using MascotasEnCasa.App.Dominio;
using System.Linq;


namespace MascotasEnCasa.App.Persistencia
{
    public interface IRepositorioSignoVital
    {
        IEnumerable<SignoVital> GetAllSignoVital();        
        SignoVital AddSignoVital(SignoVital signoVital);
        SignoVital UpdateSignoVital(SignoVital signoVital);        
        void DeleteSignoVital(int idSignoVital);
        SignoVital GetSignoVital(int idSignoVital);
    }
}