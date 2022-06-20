using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Masina
    {
        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';
        private const int ID = 0;
        private const int FIRMA = 1;
        private const int MODEL = 2;
        private const int AN_FABRICATIE = 3;
        private const int CULOARE = 4;
        private const int MOTORIZARE = 5;
        private const int TRANSMISIE = 6;
        private const int OPTIUNE = 7;
        private const int DISPONIBILITATE = 8;

        //proprietati auto-implemented

        public int idMasina { get; set; }//identificator unic 
        public string firma { get; set; } //ex:Audi
        public string model { get; set; }//A4
        public string an_fabricatie { get; set; }
        public Culori CuloriDisponibile { get; set; }
        public Motorizari MotorizariDisponibile { get; set; }
        public Transmisii TransmisieDisponibila { get; set; }
        public Optiuni OptiuniDisponibile { get; set; }
        public bool disponibilitate { get; set; }
    
        //enum optiuni
        [Flags]
        public enum Optiuni
        {
            AerConditionat = 0,
            GeamuriElectrice = 1,
            Navigatie = 2,
            FaruriCeata = 4,
            ScauneIncalzite = 8,
            OglinziIncalzite = 16
        }
        //enum motorizari masina
        public enum Motorizari
        {
            Benzina = 0,
            Diesel = 1,
            Hibrid = 2,
            Electric = 3
        }
        //enum transmisie
        public enum Transmisii
        {
            CutieManuala=0,
            CutieAutomata=1
        }
        //enum culori masina
        public enum Culori
        {
            alb = 0,
            negru = 1,
            argintiu = 2,
            auriu = 3,
            albastru = 4,
            gri = 5,
            portocaliu = 6,
            verde = 7,
            turcoaz = 8
        }
        //constructor implicit
        public Masina()
        {
            disponibilitate = true;
            firma = model = an_fabricatie = string.Empty;
            CuloriDisponibile = Culori.alb;
            OptiuniDisponibile = Optiuni.AerConditionat;
        }
        //constructor cu parametri
        public Masina(int _id, string _firma, string _model, string _an_fabricatie, Culori _culoare,
            Motorizari _motorizare,Transmisii _transmisie, Optiuni _optiune)
        {
            idMasina = _id;
            firma = _firma;
            model = _model;
            an_fabricatie = _an_fabricatie;
            CuloriDisponibile = _culoare;
            MotorizariDisponibile = _motorizare;
            TransmisieDisponibila = _transmisie;
            OptiuniDisponibile = _optiune;
            disponibilitate = true;
        }
        //constructor cu mai putini parametri
        public Masina(int _id, string _firma, string _model, string _an_fabricatie)
        {
            idMasina = _id;
            firma = _firma;
            model = _model;
            an_fabricatie = _an_fabricatie;
        }
        //constructor cu un singur parametru de tip string care reprezinta o linie dintr-un fisier text
        public Masina(string linieFisier)
        {
            string[] dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier
            //prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            idMasina = Convert.ToInt32(dateFisier[ID]);
            firma = dateFisier[FIRMA];
            model = dateFisier[MODEL];
            an_fabricatie = dateFisier[AN_FABRICATIE];
            CuloriDisponibile = (Culori)Enum.Parse(typeof(Culori), dateFisier[CULOARE]);
            MotorizariDisponibile = (Motorizari)Enum.Parse(typeof(Motorizari), dateFisier[MOTORIZARE]);
            TransmisieDisponibila = (Transmisii)Enum.Parse(typeof(Transmisii), dateFisier[TRANSMISIE]);
            OptiuniDisponibile=(Optiuni)Enum.Parse(typeof(Optiuni),dateFisier[OPTIUNE]);
            disponibilitate = Convert.ToBoolean(dateFisier[DISPONIBILITATE]);
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectMasinaPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                idMasina.ToString(),
                (firma ?? " NECUNOSCUT "),
                (model ?? " NECUNOSCUT "),
                (an_fabricatie ?? " NECUNOSCUT "),
                CuloriDisponibile,
                MotorizariDisponibile,
                TransmisieDisponibila,
                (int)OptiuniDisponibile,
                disponibilitate);

            return obiectMasinaPentruFisier;
        }
        //Id masina(numar de inregistrare)
        public int GetIdMasina
        {
            get
            {
                return idMasina;
            }
        }
        //firma(marca) masina
        public string GetFirma
        {
            get
            {
                return firma;
            }
        }
        //model masina
        public string GetModel
        {
            get
            {
                return model;
            }
        }
        //an fabricatie
        public string GetAnFabricatie
        {
            get
            {
                return an_fabricatie;
            }
        }
        //verificare disponibilitate masina
        public string Disponibilitate()
        {
            Masina m = new Masina();
            if (m.disponibilitate == true)
                return "Masina disponibila";
            else
                return "Masina indisponibila";
        }
        public string GetCuloare
        {
            get
            {
                return CuloriDisponibile.ToString();
            }
        }
        public string GetOptiune
        {
            get
            {
                return OptiuniDisponibile.ToString();
            }
        }
    }
}
