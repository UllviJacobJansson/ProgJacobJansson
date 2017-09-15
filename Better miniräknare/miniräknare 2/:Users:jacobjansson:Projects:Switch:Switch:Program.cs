using System;

namespace Switch
{
    class MainClass
    {
        public static void Main(string[] args)
        {  

            Console.WriteLine("Välkommen!! Skriv två olika tal:");
			string inm1 = Console.ReadLine();
			double tal1 = double.Parse(inm1);

			string inm2 = Console.ReadLine();
			double tal2 = double.Parse(inm2);
			Console.WriteLine("Dina tal är alltså:" + tal1 + " och " + tal2 + "\n");

            while (true)
            {   
                Console.WriteLine("Välj ett alternativ nedan:");
                Console.WriteLine("1: Addera dina två tal \n" +
                                  "2: Subtrahera dina två tal \n" +
                                  "3: Dividera dina två tal\n" +
                                  "4: Multiplirera dina två tal");
                

                double summa = tal1 + tal2;
                double diff = tal1 - tal2;
                double kvot = tal1 / tal2;
                double produkt = tal1 * tal2;

                string valInm = Console.ReadLine();
                int val = int.Parse(valInm); 

                switch (val)
                {
                    case 1:
                        Console.WriteLine("Om vi adderar dina två tal blir summan: " + summa);
                        break;

                    case 2:
                        Console.WriteLine("Om vi subtraherar dina tal blir differensen: " + diff);
                        break;

                    case 3:
                        Console.WriteLine("Om vi dividerar dina två tal blir kvoten: " + kvot);
                        break;

                    case 4:
                        Console.WriteLine("Om vi multiplicerar dina två tal blir produkten: " + produkt);
                        break;

                }


                Console.WriteLine("\n");
            }
            /*flerradig kommentering*/
            //Enkelradig kommentering 

        
        
        
        
        }
        }
    }

