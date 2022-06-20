using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace StocareDate
{
    public class AdministrareMasini_FisierText:IStocareDataMasini
    {
        private const int ID_PRIMA_MASINA = 1;
        private const int INCREMENT = 1;
        private const int NR_MAX_MASINI = 50;
        private string numeFisier1;

        public AdministrareMasini_FisierText(string numeFisier1)
        {
            this.numeFisier1 = numeFisier1;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier1, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddMasina(Masina masina)
        {
            masina.idMasina = GetId();

            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier1, true))
            {
                streamWriterFisierText.WriteLine(masina.ConversieLaSir_PentruFisier());
            }
        }

       /* public Masina[] GetMasini(out int nrMasini)
        {
            Masina[] masini = new Masina[NR_MAX_MASINI];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier1))
            {
                string linieFisier;
                nrMasini = 0;
                // citeste cate o linie si creaza un obiect de tip Masina
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    masini[nrMasini++] = new Masina(linieFisier);
                }
            }
            Array.Resize(ref masini, nrMasini);
            return masini;
        }*/

        public List<Masina> GetMasini()
        {
            ArrayList masini = new ArrayList();

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier1))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Masina
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Masina masina = new Masina(linieFisier);
                    masini.Add(masina);
                }
            }
            return masini.Cast<Masina>().ToList();
        }
        public Masina GetMasina(string firma, string model)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier1))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Masina masina = new Masina(linieFisier);
                    if (masina.GetFirma == firma && masina.GetModel == model)
                        return masina;
                }
            }
            return null;
        }
        public Masina GetMasina(int IdMasina)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier1))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Masina
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Masina masina = new Masina(linieFisier);
                    if (masina.idMasina == IdMasina)
                        return masina;
                }
            }
            return null;
        }
        public bool UpdateMasina(Masina masinaActualizata)
        {
            List<Masina> masini = GetMasini();
            bool actualizareCuSucces = false;

            //instructiunea 'using' va apela la final swFisierText.Close();
            //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier1, false))
            {
                foreach (Masina masina in masini)
                {
                    Masina masinaPentruScrisInFisier = masina;
                    //informatiile despre masina actualizat vor fi preluate din parametrul "masinaActualizata"
                    if (masina.idMasina == masinaActualizata.idMasina)
                    {
                        masinaPentruScrisInFisier = masinaActualizata;
                    }
                    streamWriterFisierText.WriteLine(masinaPentruScrisInFisier.ConversieLaSir_PentruFisier());
                }
                actualizareCuSucces = true;
            }
            return actualizareCuSucces;
        }
        private int GetId()
        {
            int IdMasina = ID_PRIMA_MASINA;
            // instructiunea 'using' va apela sr.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier1))
            {
                string linieFisier;

                //citeste cate o linie si creaza un obiect de tip Masina pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Masina masina = new Masina(linieFisier);
                    IdMasina = masina.idMasina + INCREMENT;
                }
            }
            return IdMasina;
        }
    }
}
