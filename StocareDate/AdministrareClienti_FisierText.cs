using LibrarieModele;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StocareDate
{
    public class AdministrareClienti_FisierText:IStocareDataClienti
    {
        private const int ID_PRIMUL_CLIENT = 1;
        private const int INCREMENT = 1;
        private const int NR_MAX_CLIENTI = 50;
        private string numeFisier;

        public AdministrareClienti_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddClient(Client client)
        {
            client.idClient = GetId();
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(client.ConversieLaSir_PentruFisier());
            }
        }

        public List<Client> GetClienti()
        {
            ArrayList clienti = new ArrayList();

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Client
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Client client = new Client(linieFisier);
                    clienti.Add(client);
                }
            }

            return clienti.Cast<Client>().ToList();
        }

        public Client GetClient(string nume, string prenume)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Client
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Client client = new Client(linieFisier);
                    if (client.nume.Equals(nume) && client.prenume.Equals(prenume))
                        return client;
                }
            }
            return null;
        }
        public Client[] GetClienti(out int nrClienti)
        {
            Client[] clienti = new Client[NR_MAX_CLIENTI];
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrClienti = 0;

                // citeste cate o linie si creaza un obiect de tip Client
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    clienti[nrClienti++] = new Client(linieFisier);
                }
            }
            Array.Resize(ref clienti, nrClienti);
            return clienti;
        }
        /*public Client GetClient(string nume, string prenume)
        {
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string lin;
                while ((lin = streamReader.ReadLine()) != null)
                {
                    Client client = new Client(lin);
                    if (client.GetNume == nume && client.GetPrenume == prenume)
                        return client;
                }
            }
            Client c = new Client();
            return c;
        }
        */
        public Client GetClient(int idClient)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Client
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Client client = new Client(linieFisier);
                    if (client.idClient == idClient)
                        return client;
                }
            }

            return null;
        }
        public bool UpdateClient(Client clientActualizat)
        {
            List<Client> clienti = GetClienti();
            bool actualizareCuSucces = false;

            //instructiunea 'using' va apela la final swFisierText.Close();
            //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, false))
            {
                foreach (Client client in clienti)
                {
                    Client clientPentruScrisInFisier = client;
                    //informatiile despre clientul actualizat vor fi preluate din parametrul "clientActualizat"
                    if (client.idClient == clientActualizat.idClient)
                    {
                        clientPentruScrisInFisier = clientActualizat;
                    }
                    streamWriterFisierText.WriteLine(clientPentruScrisInFisier.ConversieLaSir_PentruFisier());
                }
                actualizareCuSucces = true;
            }

            return actualizareCuSucces;
        }
        private int GetId()
        {
            int IdClient = ID_PRIMUL_CLIENT;

            // instructiunea 'using' va apela sr.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                //citeste cate o linie si creaza un obiect de tip Client pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Client client = new Client(linieFisier);
                    IdClient = client.idClient + INCREMENT;
                }
            }
            return IdClient;
        }
    }
}
