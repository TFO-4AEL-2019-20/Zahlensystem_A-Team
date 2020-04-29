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



            string Eingabe_Binaer = "00001111"; // Eingabezahl...
            Console.WriteLine(HexadezimalUmrechnung(Eingabe_Binaer)); // Schreibt dann das Ergebnis der Methode raus
            Console.ReadKey();  // Um Ausgabe zu überprüfen



            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            bool Wiederholen = true;

            while (Wiederholen/* == true*/)
            {
                Console.WriteLine("\n\n \tA)  Addieren");
                Console.WriteLine("\tB)  Subtrahieren");
                Console.WriteLine("\tC)  Multiplizieren");
                Console.WriteLine("\tD)  Dividieren");
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
                    case "1": /* Hab es auch mit 1, 2 usw. programmiert, dass es die dementsprechenden Übungen ausführt,
                                  da ich es auch mit Zahlen verwenden möchte 
                                   HINWEIS: Somit wenn man 12 z.b. eingibt, dann wird die 1. und 2. Übung nacheinander ausgeführt, obwohl die Warnung angegeben wird- Müsste ich noch optimieren!
                                   
                                   */
                        {
                            Console.Write("\n1.Zahl: ");
                            int Zahl1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("2.Zahl: ");
                            int Zahl2 = Convert.ToInt32(Console.ReadLine());

                            System.Threading.Thread.Sleep(350);
                            Console.WriteLine("Summe: " + Addiere(Zahl1, Zahl2));

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
                            Console.Write("\n1.Zahl: ");
                            int Zahl1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("2.Zahl: ");
                            int Zahl2 = Convert.ToInt32(Console.ReadLine());

                            System.Threading.Thread.Sleep(350);

                            Console.WriteLine("Differenz: " + Subtrahiere(Zahl1, Zahl2));

                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Beendentext();
                            Console.ReadKey();
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        }

                    case "C":
                    case "c":
                    case "3":
                        {
                            Console.Write("\n1.Zahl: ");
                            int Zahl1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("2.Zahl: ");
                            int Zahl2 = Convert.ToInt32(Console.ReadLine());

                            System.Threading.Thread.Sleep(350);

                            Console.WriteLine("Produkt: " + Multipliziere(Zahl1, Zahl2));

                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            System.Console.WriteLine("Wenn Sie das Programm schließen möchten, dann drücken Sie die Taste Z, ansonsten eine beliebige Taste um die Console zu leeren");
                            Console.ReadKey();
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Black;
                            break;
                        }

                    case "D":
                    case "d":
                    case "4":
                        {
                            Console.Write("\n1.Zahl: ");
                            int Zahl1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("2.Zahl: ");
                            int Zahl2 = Convert.ToInt32(Console.ReadLine());

                            System.Threading.Thread.Sleep(350);

                            Console.WriteLine("Quotient: " + Dividiere(Zahl1, Zahl2));

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

        static int Addiere(int Zahl1, int Zahl2)
        {
            return (Zahl1 + Zahl2);
        }

        static int Subtrahiere(int Zahl1, int Zahl2)
        {
            return (Zahl1 - Zahl2);
        }

        static int Multipliziere(int Zahl1, int Zahl2)
        {
            return (Zahl1 * Zahl2);

            // des sich a kommentar
            //Einlesen Binärzahl
            string binärzahl = Convert.ToString(Console.ReadLine());

        }

        static int Dividiere(int Zahl1, int Zahl2)
        {
            return (Zahl1 / Zahl2);
        }

        static void Beendentext()
        {
            System.Console.WriteLine("Drücken Sie eine beliebige Taste um die Konsole zu leeren");
        }

        public static string HexadezimalUmrechnung(string Eingabe_Binaer)   // Methode
        {
            string StringHex = Convert.ToInt32(Eingabe_Binaer, 2).ToString("X");
            return StringHex;
        }
            
        }
        /// <summary>
        /// Umrechnung von Binär zu Hexadezimal
        /// </summary>
        /// <param name="Eingabe_Binaer"> Eingegebene Binärzahl</param>
        /// <returns></returns>
        


    }
