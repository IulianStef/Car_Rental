using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace StocareDate
{
    public interface IStocareDataMasini
    {
        void AddMasina(Masina masina);
        List<Masina> GetMasini();
        Masina GetMasina(string firma, string model);
        Masina GetMasina(int idMasina);
        bool UpdateMasina(Masina m);
    }
}
