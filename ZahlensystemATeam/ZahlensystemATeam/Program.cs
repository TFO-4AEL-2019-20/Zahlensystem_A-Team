using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZahlensystemATeam
{
    class Program
    {
        static void Main(string[] args)
        {
            string Eingabe_Binaer = "00001111"; // Eingabezahl...
            Console.WriteLine(HexadezimalUmrechnung(Eingabe_Binaer)); // Schreibt dann das Ergebnis der Methode raus
            Console.ReadKey();  // Um Ausgabe zu überprüfen
        }
        /// <summary>
        /// Umrechnung von Binär zu Hexadezimal
        /// </summary>
        /// <param name="Eingabe_Binaer"> Eingegebene Binärzahl</param>
        /// <returns></returns>
        public static string HexadezimalUmrechnung(string Eingabe_Binaer)   // Methode
        {
            string StringHex = Convert.ToInt32(Eingabe_Binaer, 2).ToString("X");
            return StringHex;
        }

    }
}
