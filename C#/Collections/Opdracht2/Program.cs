using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;


namespace Opdracht2
{
    class Program
    {

        static Dictionary<string, double> voertuigen = new Dictionary<string, double>();
        static Queue<string> file = new Queue<string>();

        static void Main()
        {
            Initialiseer();
            Simuleer();
        }

        private static void Simuleer()
        {
            Console.WriteLine("1: voertuig toevoegen, 2: verwijder voertuig, 3: bekijk file, 4: stop programma");
            string keuze = Console.ReadLine();
            Keuze(keuze);
        }

        private static void Keuze(string keuze)
        {
            try
            {
                int Pkeuze = int.Parse(keuze);
                switch (Pkeuze)
                {
                    case 1:
                        Voegtoe();
                        Simuleer();
                        break;
                    case 2:
                        Verwijder();
                        Simuleer();
                        break;
                    case 3:
                        Bekijk();
                        Simuleer();
                        break;
                    case 4:
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Voer een geldig getal in");
                Simuleer();

            }
        }

        private static void Bekijk()
        {
            double elength = 0;
            Console.Write("De file bestaat uit: ");
            foreach(string item in file)
            {
                Console.Write($"{item} ");
                voertuigen.TryGetValue(item, out double length);
                elength += length;
            }
            Console.WriteLine();
            Console.WriteLine($"De file is: {elength} m lang");
        }

        private static void Verwijder()
        {
            string front = file.Peek();
            file.Dequeue();
            Console.WriteLine($"De voorste {front} is doorgereden");
        }

        private static void Voegtoe()
        {
            int TEMPchoice = 0;
            Console.WriteLine("Kies een voertuig");
            foreach (KeyValuePair<string, double> entry in voertuigen)
            {
                Console.Write($"{TEMPchoice}: {entry.Key}, ");
                TEMPchoice++;
            }
            Console.WriteLine();

            var choice = Console.ReadLine();
            try
            {
                int Pchoice = int.Parse(choice);
                string Schoice = voertuigen.ElementAt(Pchoice).Key;
                file.Enqueue(Schoice);
            }
            catch
            {
                Console.WriteLine("Hies een geldig getal");
                Voegtoe();
            }
        }

        private static void Initialiseer()
        {
            voertuigen.Add("auto", 4.00);
            voertuigen.Add("vrachtwagen", 20.50);
            voertuigen.Add("fiets", 2.50);
        }
    }
}
