using System;

namespace Miniräknare
{
    class MainClass
    {
        public static void Main(string[] args)
        {   //Hälsar användaren välkommen och ber hen skriva in ett tal
            Console.WriteLine("Välkommen! \nSkriv in ett heltal.");
            String inm1 = Console.ReadLine();
            double tal1 = double.Parse(inm1);
            //Ber användaren att skriva in ett till tal
            Console.WriteLine("Skriv in ett till tal.");
            String inm2 = Console.ReadLine();
            double tal2 = double.Parse(inm2);
            //adderar, subtraherar, multiplicerar och dividerar tal1 + tal2
            double summa = tal1 + tal2;
            double diff = tal1 - tal2;
            double produkt = tal1 * tal2;
            double kvot = tal1 / tal2;
            int rest = (int)(tal1 % tal2); 
            Console.WriteLine("Summan av dina tal är: " + summa);
            Console.WriteLine("Differensen av dina tal är: " + diff);
            Console.WriteLine("Produten av dina tal är: " + produkt);
            Console.WriteLine("Kvoten av dina tal är:  " + kvot);
            Console.WriteLine("Rsesten av dina tal är: " + rest);
        }
    }
}
