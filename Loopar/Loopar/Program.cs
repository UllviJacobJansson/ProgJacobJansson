using System;

namespace Loopar
{
    class MainClass
    {
        public static void Main(string[] args)
        /*
        {  
            char forsokigen = 'y';

            while(forsokigen == 'y')
            {
                Console.WriteLine("Hälsa snällt!");
                string svar = Console.ReadLine();

                if(svar.ToLower() == "hej")
                {
                    Console.WriteLine("RÄTT!");
                    break;
                }
                else
                {
                    Console.WriteLine("Vill du försöka igen");
                    forsokigen = Console.ReadLine()[0];
                }
            }
            Console.WriteLine("Nämen tjena fan!");
           
        }
        */
        /*
        random =randomizer = new Random();
        int random = 0;
        int svar = -1;
        while (svar !=random)
        {
            random = randomizer.Next(1,11);
            Console.Writeline("gissa på rätt tal")
                   svar = int.Parse(Console.readline);
        }
        */
        int talet = -1; 

        while(true)
        {
            console.Writeline("skriv in ett tal")

                   try
            {
                talet = int.Parse(consle.Readline());
                break;
            }
            catch
            {
                console.Writeline("Måste skrivas i heltal");
            }
}
