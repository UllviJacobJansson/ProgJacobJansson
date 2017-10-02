using System;

namespace Forloops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*for (int x = -10; x < 11; x++)
            {
                int y = 3 * x + 5;
                //Console.WriteLine("x; " + x + " | f(" + x + ")=3x" + x + "+ 5 = " + y);
                Console.WriteLine("x; {0}| f({0}) = 3*{0} + 5 = {1}", x, y);
            }
           */


            Console.WriteLine("Välkommen! Vilken av funktionerna 1,2 eller 3 vill du ha svar på? \n" +
                              "1: f(x) = 2x-7 \n" +
                              "2: g(x) = x^2+10x-25 \n" +
                              "3: h(x) = 3x^5-x^4+4x^3-2x^2+10x-25");


            while (true)
            {
                try
                {
                    string choice = Console.ReadLine();
                    double funk = double.Parse(choice);

                    switch (funk)
                    {
                        case 1:
                            for (int x = -10; x < 11; x++)
                            {
                                double y = 2 * x - 7;
                                Console.WriteLine("x:{0}\t| f({0}) =\t 2*{0} -7 \t= {1}", x, y);
                            }
                            break;

                        case 2:
                            for (int x = -10; x < 11; x++)
                            {
                                double y = Math.Pow(x, 2) + 10 * x - 25;
                                Console.WriteLine("x:{0}\t| f({0}) =\t x^2+10x-25", x, y);
                            }

                            break;

                        case 3:
                            for (int x = -10; x < 11; x++)
                            {
                                double y = 3 * Math.Pow(x, 5) - Math.Pow(x, 4) + 4 * Math.Pow(x, 3) - 2 * Math.Pow(x, 2) + 10 * x - 25;
                                Console.WriteLine("x:{0}\t| f({0}) =\t 3x^5-x^4+4x^3-2x^2+10x-25", x, y);
                            }

                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Svara med 1,2 eller 3"); 
                }
            }


        }

    }
}
