using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Intranet.Enums
{
    public class HtmlLists
    {

        //Generico
        public static IEnumerable<string> GenderList = new List<string>
        {
            "Maschio",
            "Femmina"
        };

        public static IEnumerable<string> StatiCiviliList = new List<string>
        {
            "Celibe/Nubile",
            "Sposato/a",
            "Unito/a Civilmente",
            "Divorziato/a",
            "Vedovo/a"
        };

        public static IEnumerable<string> ManoDominanteList = new List<string>
        {
            "Destro",
            "Mancino",
            "Mancino Corretto",
            "Ambidestro"
        };

        public static IEnumerable<string> TipoDiNascitaList = new List<string>
        {
            "A termine",
            "Prematura",
            "Post-Termine"
        };

        public static IEnumerable<string> TipoDiAllattamentoList = new List<string>
        {
            "Materno",
            "Artificiale",
        };


        //Cartelle Cliniche

        public static IEnumerable<int> VarieScale = new List<int>
        {
            1,
            2,
            3,
            4
        };
        

        //Personale

        public static IEnumerable<string> CarichiPendentiEsitiList = new List<string>
        {
            "Negativo",
            "Positivo",
        };
    }
}