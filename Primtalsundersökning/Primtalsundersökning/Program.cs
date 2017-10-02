using System;

namespace Primtalsundersökning
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Välkommen!\n Skriv in ett tal du vill undersöka om det är ett primtal.");
            int undersok = Math.Abs(Convert.ToInt32(Console.ReadLine()));

            int start = (int)Math.Sqrt(undersok);

            for (int i = start; i > 1; i--)
            {
                if(undersok % i == 0)
                {
                    Console.WriteLine("Inte ett primtal");
                }
                else 
                {
                    Console.WriteLine("detta är ett primtal :)"); 
                }
            }


        }
    }
}
