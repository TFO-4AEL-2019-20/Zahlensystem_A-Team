using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinirechnerTFO_KarasaniDaniel
{
    class Program
    {


        static void Main(string[] args)
        {


            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            bool Wiederholen = true;

            while (Wiederholen/* == true*/)
            {
                Console.WriteLine("\n\n \tA)  Zu Dezimal");
                Console.WriteLine("\tB)  Zu Hexadezimal");
                Console.WriteLine("\tZ)  Beenden >> Fenster schließen");

                System.Console.Write("\nTippen Sie den Buchstaben der gewünschten Aufgabe ein und betätigen Sie die Enter-Taste: ");

                string Aufgabe;

                Aufgabe = Console.ReadLine();
                //foreach (char value in Aufgabe.ToCharArray())
                // Array speichert mehrere Variabeln

                switch (Aufgabe)
                {

                    case "A":
                    case "a":
                    case "1":
                        {
                            //Einlesen Binärzahl
                            string binärzahl = Convert.ToString(Console.ReadLine());

                            int ErgebnisDEZ = DezimalUmrechnen(binärzahl);
                            Console.WriteLine(ErgebnisDEZ);

                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Beendentext();
                            Console.ReadKey();
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Black;
                            break; //um zu den anderen Cases springen zu können

                        }

                    case "B":
                    case "b":
                    case "2":
                        {

                            //Einlesen Binärzahl
                            string binärzahl = Convert.ToString(Console.ReadLine());

                            Console.WriteLine(HexadezimalUmrechnung(binärzahl)); // Schreibt dann das Ergebnis der Methode raus
                            Console.ReadKey();  // Um Ausgabe zu überprüfen

                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Beendentext();
                            Console.ReadKey();
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        }


                    case "Z":
                    case "z":
                    case "26":
                        {
                            //string myApp = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase; //Um das Programm neu zu starten

                            // System.Diagnostics.Process.Start(myApp); //Um neues Fenster zu öffnen bzw. Programm
                            Environment.Exit(0);                     //Um das Fenster zu schließen
                            // Wiederholen = false;
                            //Environment.Exit(0);
                            break;
                        }

                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error# Fehler °*°  - Bitte geben Sie eine gültige und vorhandene Rechnungsart ein! \nWeitere Rechnungsarten sind am Entwickeln...\n");
                            Console.ForegroundColor = ConsoleColor.Black;
                            System.Threading.Thread.Sleep(750);
                            Beendentext();
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        }
                }
            }

        }

        static void Beendentext()
        {
            System.Console.WriteLine("Drücken Sie eine beliebige Taste um die Konsole zu leeren");
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

        /// <summary>
        /// Umrechnung von Binär zu Dezimal
        /// </summary>
        /// <param name="Eingabe_Binaer"> Eingegebene Binärzahl</param>
        /// <returns></returns>


        static int DezimalUmrechnen(string Bin)
        {

            string Dezimal = Convert.ToInt32(Bin, 2).ToString();

            int Dezimalzahl = Convert.ToInt32(Dezimal);

            return Dezimalzahl;
        }

    }






}
