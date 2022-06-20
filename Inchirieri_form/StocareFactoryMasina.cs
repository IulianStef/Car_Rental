using StocareDate;
using System.Configuration;
using System.IO;

namespace Inchirieri_form
{
    public static class StocareFactoryMasina
    {
        private const string FORMAT_SALVARE = "FormatSalvare1";
        private const string NUME_FISIER = "NumeFisier1";
        public static IStocareDataMasini GetAdministratorStocare()
        {
            string formatSalvare1 = ConfigurationManager.AppSettings[FORMAT_SALVARE];

            string numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            if (formatSalvare1 != null)
            {
                switch (formatSalvare1)
                {
                    default:
                    case "bin":
                        return new AdministrareMasini_FisierBinar(caleCompletaFisier + "." + formatSalvare1);
                    case "txt":
                        return new AdministrareMasini_FisierText(caleCompletaFisier + "." + formatSalvare1);
                }
            }
            return null;
        }
    }
}
