using System.Collections.Generic;
using MascotasEnCasa.App.Dominio;
using System.Linq;

namespace MascotasEnCasa.App.Persistencia
{
    public interface IRepositorioHistoria
    {
        IEnumerable<Historia> GetAllHistoria();
        Historia AddHistoria(Historia historia);
        Historia UpdateHistoria(Historia historia);
        void DeleteHistoria (int idHistoria);
        Historia GetHistoria(int idHistoria);
    }
}