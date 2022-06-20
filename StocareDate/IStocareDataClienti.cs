using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace StocareDate
{
    //definitia interfetei
    public interface IStocareDataClienti
    {
        void AddClient(Client c);
        List<Client> GetClienti();
        Client GetClient(string nume, string prenume);
        Client GetClient(int idClient);
        bool UpdateClient(Client c);
    }
}
