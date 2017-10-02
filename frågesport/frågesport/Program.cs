
using System;
using System.Threading;


namespace frågesport
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int poang = 0;

			{     //Fråga 1
				Console.WriteLine("Välkommen! Vad heter Sveriges huvudstad?");
				string svar = Console.ReadLine();


				if (svar.ToLower() == "stockholm")
				{
					Console.WriteLine("Rätt!\n");
                    poang++;

				}
				else
				{
					Console.WriteLine("Fel!");

				}
				//fråga 2
				Console.WriteLine("\nVad startade 1939?");

				svar = Console.ReadLine();

				if (svar.ToLower() == "andra världskriget" || svar.ToLower() == "ww2")
				{
					Console.WriteLine("Rätt!");
                    poang++;
				}

				else
				{
					Console.WriteLine("Fel!");
				}
				//fråga 3 nummerfråga
				Console.WriteLine("\nVilket år kom första Star Wars filmen ut?");

                int talsvar = -1;
                while(true)

                try
                {

                    talsvar = int.Parse(Console.ReadLine());
						if (talsvar == 1977)
						{
							Console.WriteLine("Rätt!");
							poang++;
                            break; 
						}
						else
						{
							Console.WriteLine("Fel!");
                            poang--;
						}
                }
                catch
                {
                    Console.WriteLine("Fel format");
                        poang--;
                        
                }


				
				//Fråga 4 flervals fråga 
				Console.WriteLine("\n Vilken är den största staten i USA?");
                int talsvar2 = -1;

				Console.WriteLine("1: Texas\n" +
								  "2: Kalifornien\n" +
								  "3: Alaska");
                while(true)
                    
                try
                {
                    talsvar2 = int.Parse(Console.ReadLine());
					if (talsvar2 == 3)
					{
						Console.WriteLine("Rätt!");
						poang++;
                            break;
					}
					else
					{
						Console.WriteLine("Fel");
                        poang--;
					}
                }
                catch
                {
                    Console.WriteLine("Välj 1,2 eller 3!");
                    poang--;
                }


                //Fråga 5
                Console.WriteLine("\n Vad är en katt?");

                svar = Console.ReadLine();

                if (svar.ToLower() == "ett djur" || svar.ToLower() == "djur" || svar.ToLower() == "en fisk")

                {
                    Console.WriteLine("Rätt!");
                    poang++;
                }

                else
                {
                    Console.WriteLine("Fel!");
                }
                // Fråga 6 Talfråga
                int talsvar3 = -1;
                Console.WriteLine("\n Vad är meningen med livet?");
                try
                {
                    talsvar3 = int.Parse(Console.ReadLine());
                }
                catch
                {
                    
                }
                if (talsvar3 == 7)
                {
                    Console.WriteLine("Rätt!");
                    poang++;
                }
                else 
                {
                    Console.WriteLine("Fel!");
                }
                // Fråga 7 Flervalsfråga
                int talsvar4 = -1;
                Console.WriteLine("\n Vem var Adolf Hitler? ");
                Console.WriteLine("1: Han var en katt\n" +
                                  "2: Tysklands ledare i WW2\n" +
                                  "3: Han var Leonardo DeCaprios pappa");
                try
                {
                    talsvar4 = int.Parse(Console.ReadLine());
                }
                catch
                {
                    
                }



                if (talsvar4 == 2)
                {
                    Console.WriteLine("Rätt!");
                    poang++;
                }
                else
                {
                    Console.WriteLine("Fel!!");
                }
                //Fråga 8
                Console.WriteLine("Vem är bäst i Världen?");

                  svar = Console.ReadLine();
                if (svar.ToLower() == "jacob" || svar.ToLower() == "edward blom")
                {
                    Console.WriteLine("Rätt!");
                    poang++;
                }
                else
                {
                    Console.WriteLine("Fel!");
                }
                //fråga 9
                Console.WriteLine("Vem är president i USA atm?");
                svar = Console.ReadLine();
                if (svar.ToLower() == "donald trump" || (svar.ToLower() == "trump"))
                {
                    Console.WriteLine("Rätt!");
                    poang++;
                }
                else
                {
                    Console.WriteLine("Fel!");
                }
                //FRÅGA 10
                Console.WriteLine("Vad tycker du om min frågesport?");
                svar = Console.ReadLine();
                if(svar.ToLower() == "ja" || svar.ToLower() == "den är sämst" )
                {
                    Console.WriteLine("Rätt");
                    poang++;
                }
                else
                {
                    Console.WriteLine("Fel");
                }
                Console.WriteLine("Dina poäng beräknas......");
                Thread.Sleep(3000); 
                Console.WriteLine("Du fick " +poang + " Poäng av 10");
				
				}









			}
		}
	}
        
    

