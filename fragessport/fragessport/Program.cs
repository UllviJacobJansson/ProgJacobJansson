using System;

namespace fragessport
{
    class MainClass
    {
        public static void Main(string[] args)
        {     //Fråga 1
            Console.WriteLine("Välkommen! Vad heter huvudstaden?");
            string svar = Console.ReadLine();


            if(svar.ToLower() =="stockholm")
            {
                Console.WriteLine("Rätt!");
            }
            else
            {
                Console.WriteLine("Fel!");
            }
            //fråga 2
            Console.WriteLine("\nVad startade 1939?");

            svar = Console.ReadLine();

            if (svar.ToLower() == "andra världskriget" || svar.ToLower()== "ww2")
            {
                Console.WriteLine("Rätt!");
            }

            else
            {
                Console.WriteLine("Fel!");
            }
            //fråga 3
            Console.WriteLine("\nVilket år kom första Star Wars filmen ut?");

            int talsvar = int.Parse(Console.ReadLine());

            if(talsvar == 1977)
            {
                Console.WriteLine("Rätt!");
            }
            else
            {
                Console.WriteLine("Fel!");
            }
            //Fråga 4
            Console.WriteLine("\n Vilken är den största staten i USA?");

            Console.WriteLine("1: Texas\n" +
                              "2: Kalifornien\n" +
                              "3: Alaska");

            string Inm = Console.ReadLine();
            int val = int.parse(Inm);
            {
                case 1: Console.WriteLine("Fel!");
            }





                

                
                       
        }
    }
}
