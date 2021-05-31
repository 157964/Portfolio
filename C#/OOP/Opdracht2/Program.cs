using System;
using System.Collections.Generic;
using Personen;

namespace Opdracht2
{
    class Program
    {
        private static List<Persoon> _personen = new List<Persoon>();

        static void Main(string[] args)
        {
            Invullen();

            PersonenWeergeven();
        }

        private static void PersonenWeergeven()
        {
            foreach(var ding in _personen)
            {
                Console.WriteLine(ding.WieBenIk());
            }
            Console.WriteLine();
        }
        
        private static void Invullen()
        {

            Console.WriteLine("1: Persoon, 2: Medewerker, 3: manager");
            var choice = int.Parse(Console.ReadLine());
            var ppl1 = new Persoon();
            var ppl2 = new Medewerker();
            var ppl3 = new Manager();

            Console.WriteLine("Voornaam: ");
            string voorNaam = Console.ReadLine();

            Console.WriteLine("Achternaam: ");
            string achterNaam = Console.ReadLine();

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Hoe lang bent u in M?");
                    ppl1.Lengte = double.Parse(Console.ReadLine());
                    ppl1.Voornaam = voorNaam;
                    ppl1.Achternaam = achterNaam;
                    _personen.Add(ppl1);
                    break;
                case 2:
                    Console.WriteLine("Wat is jou rol:");
                    ppl2.Rol = Console.ReadLine();
                    ppl2.Voornaam = voorNaam;
                    ppl2.Achternaam = achterNaam;
                    _personen.Add(ppl2);
                    break;
                case 3:
                    Console.WriteLine("Wat is jou afdeling:");
                    ppl3.Afdeling = Console.ReadLine();
                    ppl3.Voornaam = voorNaam;
                    ppl3.Achternaam = achterNaam;
                    _personen.Add(ppl3);
                    break;
            }
        }
    }
}
