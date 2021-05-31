using System;

namespace Opdracht_2
{
    class Program
    {
        private static string Endchoice;
        private static int MPchoice;

        static void Main(string[] args)
        {
            Chooser();
            Console.WriteLine($"U heeft {MPchoice} gekozen. Dat is {Endchoice}");
        }

        private static void Chooser()
        {
            Console.WriteLine("vul een getal in");
            var choice = Console.ReadLine();
            try
            {
                int Pchoice = int.Parse(choice);
                if(Pchoice <= 4 && Pchoice > 0)
                {
                    MPchoice = Pchoice;
                    GeefKaart(Pchoice);
                }
                else
                {
                    Console.WriteLine("Vul aub een getal in van 1 tm 4");
                    Chooser();
                }
            }
            catch
            {
                Console.WriteLine("Vul aub een getal in van 1 tm 4");
                Chooser();
            }
        }
        private static void GeefKaart(int keuze)
        {
            switch (keuze) {
                case 1:
                    Endchoice = "ruiten";
                    break;
                case 2:
                    Endchoice = "harten";
                    break;
                case 3:
                    Endchoice = "klaveren";
                    break;
                case 4:
                    Endchoice = "schoppen";
                    break;
            }
        }
    }
}
