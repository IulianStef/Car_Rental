using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace StocareDate
{
    public class AdministrareMasini_FisierBinar:IStocareDataMasini
    {
        private const int ID_PRIMA_MASINA = 1;
        private const int INCREMENT = 1;

        string NumeFisier1 { get; set; }
        public AdministrareMasini_FisierBinar(string numeFisier1)
        {
            this.NumeFisier1 = numeFisier1;
            Stream sBinFile = File.Open(NumeFisier1, FileMode.OpenOrCreate);
            sBinFile.Close();

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sBinFile.Close();
            //using (Stream sBinFile = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }

        public void AddMasina(Masina m)
        {
            m.idMasina = GetId();

            try
            {
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier1, FileMode.Append, FileAccess.Write))
                {
                    //serializare unui obiect
                    b.Serialize(sBinFile, m);
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
        public List<Masina> GetMasini()
        {
            List<Masina> masini = new List<Masina>();
            try
            {
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier1, FileMode.Open))
                {

                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        masini.Add((Masina)b.Deserialize(sBinFile));
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
            return masini;
        }
        public Masina GetMasina(int idMasina)
        {
            throw new Exception("Optiunea GetMasina by Id nu este implementata");
        }

        public Masina GetMasina(string firma, string model)
        {
            throw new Exception("Optiunea GetMasina nu este implementata");
        }

        public bool UpdateMasina(Masina m)
        {
            throw new Exception("Optiunea UpdateMasina nu este implementata");
        }

        private int GetId()
        {
            int IdMasina = ID_PRIMA_MASINA;
            try
            {
                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier1, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();

                    //citeste cate o linie si creaza un obiect de tip Masina pe baza datelor din linia citita
                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        Masina m = (Masina)b.Deserialize(sBinFile);
                        IdMasina = m.idMasina + INCREMENT;
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
            return IdMasina;
        }
    }
}
