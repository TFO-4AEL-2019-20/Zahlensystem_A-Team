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
            // des sich a kommentar
            string Binärzahl = "10010011";


            int ErgebnisDEZ = DezimalUmrechnen(Binärzahl);

            Console.WriteLine(ErgebnisDEZ);
            Console.ReadKey();
        }

        static int DezimalUmrechnen(string Bin)
        {

            string Dezimal = Convert.ToInt32(Bin, 2).ToString();

            int Dezimalzahl = Convert.ToInt32(Dezimal);

            return Dezimalzahl;
        }

    }
}
