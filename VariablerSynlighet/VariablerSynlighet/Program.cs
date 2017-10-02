using System;

namespace VariablerSynlighet
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int poang = 0;
            int val = -1;
            Console.WriteLine("Hur gammal är Jacob");

            try
            {
                val = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("svaraet måste vara i sifferform");
            }


            if (val == 17)
            {
				Console.WriteLine("rätt");
				poang++;
			}

            else
            
            {
                Console.WriteLine("Fel");  
            }

             
        }
    }
}
