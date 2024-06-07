using System;

namespace itforall4
{
    class Program
    {
        static void Main(string[] args)
        {

            int A = 2;
            int B = 5;
            int sum = 0;
            int C = 20;

            for (int i = A; i <= B; i++) // i 1 ====> 5
            {
                Console.WriteLine("Vor    Ausgabe -- Sum: " + sum + "| A: " + A + "| B: " + B + "| i: " + i);
                sum = sum + i;//inkrementieren
                Console.WriteLine("Danach Ausgabe -- Sum: " + sum +"| A: "+ A + "| B: "+ B + "| i: "+ i);
            }

            for (int x = 0; x < 5; x++) 
            {
                int Wert = 200034 - 2234;
                Console.WriteLine("Wert von Variabel Wert: "+Wert);
                Console.WriteLine("C von For Schleife: " + C);
            }
            Console.WriteLine("Ausgabe: "+sum);
        }
    }
}
