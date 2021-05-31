using System;

namespace opdracht1
{
    class Program
    {
        // Global variables
        public static int permget1;
        public static int permget2;
        public static int permcount;

        static void Main(string[] args)
        {
            // PLAATS HIER MAIN CODE:

            Getaller();
            Getaller();
            Console.WriteLine($"De som van {permget1} en {permget2} is {Som(permget1, permget2)}");
            Console.WriteLine($"Het verschil tussen {permget1} en {permget2} is {Verschil(permget1, permget2)}");
            Console.WriteLine($"Het product van {permget1} en {permget2} is {Product(permget1, permget2)}");

        }

        // methods-functions:
        private static void Getaller()
        {
            Console.WriteLine("Kies een getal:");
            var getal = Console.ReadLine();
            try
            {
                if (permcount == 0)
                {
                    permget1 = Leesgeheelgetal(getal);
                    permcount++;
                }
                else if (permcount == 1)
                {
                    permget2 = Leesgeheelgetal(getal);
                    permcount++;
                }
            }
            catch
            {
                Console.WriteLine("vul alstublieft een geheel getal in");
                Getaller();
            }
        }

        private static int Leesgeheelgetal(string getal1)
        {
            int Pgetal1 = int.Parse(getal1);
            return Pgetal1;
        }

        private static int Som(int getal1, int getal2)
        {
            return getal1 + getal2;
        }

        private static int Verschil(int getal1, int getal2)
        {
            if (getal1 > getal2)
            {
                return getal1 - getal2;
            }
            else
            {
                return getal2 - getal1;
            }
        }

        private static int Product(int getal1, int getal2)
        {
            return getal1 * getal2;
        }
    }
}

