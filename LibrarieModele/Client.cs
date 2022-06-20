using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Client
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int CNP = 3;
        private const int TELEFON = 4;
        private const int GEN = 5;
        //proprietati auto-implemented

        public int idClient { get; set; }//identificator unic 
        public string nume { get; set; }
        public string prenume { get; set; }
        public string cnp { get; set; } //client-cod numeric personal
        public string telefon { get; set; }
        public Gen GenClient { get; set; }

        //enum Gen
        public enum Gen
        {
            masculin=0,
            feminin=1,
            neutru=2
        }
        //constructor implicit
        public Client()
        {
            nume = prenume = cnp = telefon = string.Empty;
        }

        //constructor cu parametri
        public Client(int idClient, string nume, string prenume, string cnp, string telefon)
        {
            this.idClient = idClient;
            this.nume = nume;
            this.prenume = prenume;
            this.cnp = cnp;
            this.telefon = telefon;
        }

        public Client(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            idClient = Convert.ToInt32(dateFisier[ID]);
            nume = dateFisier[NUME];
            prenume = dateFisier[PRENUME];
            cnp = dateFisier[CNP];
            telefon = dateFisier[TELEFON];
            GenClient = (Gen)Enum.Parse(typeof(Gen), dateFisier[GEN]);
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectClientPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                idClient.ToString(),
                nume ?? " NECUNOSCUT ",
                prenume ?? " NECUNOSCUT ",
                cnp ?? " NECUNOSCUT ",
                telefon ?? "NECUNOSCUT",
                GenClient);
            return obiectClientPentruFisier;
        }
/*
        public int GetIdClient
        {
            get
            {
                return idClient;
            }
        }
        public string GetCNP
        {
            get
            {
                return cnp;
            }
        }
        public string GetNume
        {
            get
            {
                return nume;
            }
        }
        public string GetPrenume
        {
            get
            {
                return prenume;
            }
        }
        public string GetTelefon
        {
            get
            {
                return telefon;
            }
        }
*/
    }
}
