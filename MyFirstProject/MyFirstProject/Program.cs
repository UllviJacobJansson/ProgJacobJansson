using System;

namespace MyFirstProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Skriv ditt namn");
            String namn = Console.ReadLine();

            Console.WriteLine("Ditt namn är alltså: " + namn);

            Console.WriteLine("Hur gammal är du?");
            String ålder = Console.ReadLine();

            Console.WriteLine("Så du är " + ålder + " år");
            
            Console.WriteLine("vad är din adress?");
            String adress = Console.ReadLine();

            Console.WriteLine("Du bor alltså på " + adress);

            Console.WriteLine("Vad är dina fritidsintressen? ");
            String intressen = Console.ReadLine();

            Console.WriteLine("Du heter alltså: " + namn
                             + " och du bor på " + adress
                              + " och du gillar att " + intressen + " på din fritid");

        }
    }
}
