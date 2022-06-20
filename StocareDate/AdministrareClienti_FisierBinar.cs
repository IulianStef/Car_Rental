using LibrarieModele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace StocareDate
{
    //clasa AdministrareClienti_FisierBinar implementeaza interfata IStocareDataClienti
    public class AdministrareClienti_FisierBinar: IStocareDataClienti
    {
        private const int ID_PRIMUL_CLIENT = 1;
        private const int INCREMENT = 1;
        
        string NumeFisier { get; set; }
        public AdministrareClienti_FisierBinar(string NumeFisier)
        {
            this.NumeFisier = NumeFisier;
            Stream sBinFile = File.Open(NumeFisier, FileMode.OpenOrCreate);
            sBinFile.Close();

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sBinFile.Close();
            //using (Stream sBinFile = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }
        public void AddClient(Client c)
        {
            c.idClient = GetId();
            try
            {
                BinaryFormatter b = new BinaryFormatter();
                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Append, FileAccess.Write))
                {
                    //serializare unui obiect
                    b.Serialize(sBinFile, c);
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            
        }
        public List<Client> GetClienti()
        {
            List<Client> clienti = new List<Client>();
            try
            {
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {

                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        clienti.Add((Client)b.Deserialize(sBinFile));
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return clienti;
        }
        public Client GetClient(int idClient)
        {
            throw new Exception("Optiunea GetClient by Id nu este implementata");
        }
        
        public Client GetClient(string nume,string prenume)
        {
            throw new Exception("Optiunea GetClient nu este implementata");
        }
        public bool UpdateClient(Client c)
        {
            throw new Exception("Optiunea UpdateClient nu este implementata");
        }
        private int GetId()
        {
            int IdClient = ID_PRIMUL_CLIENT;
            try
            {
                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        Client s = (Client)b.Deserialize(sBinFile);
                        IdClient = s.idClient + INCREMENT;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return IdClient;
        }
    }
}
