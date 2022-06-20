
using StocareDate;
using System.Configuration;
using System.IO;

namespace Inchirieri_form
{
    public static class StocareFactoryClient
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";
        public static IStocareDataClienti GetAdministratorStocare()
        {
            string formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];

            string numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "bin":
                        return new AdministrareClienti_FisierBinar(caleCompletaFisier + "." + formatSalvare);
                    case "txt":
                        return new AdministrareClienti_FisierText(caleCompletaFisier + "." + formatSalvare);
                }
            }
            return null;
        }
    }
}
