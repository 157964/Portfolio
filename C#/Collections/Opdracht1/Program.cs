using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Opdracht1
{
    class Program
    {
        static Stack<string> stapel = new Stack<string>();

        static void Main()
        {
            Console.WriteLine("1: Add entry, 2: Read stack, 3: remove if on top, 4: exit the program");
            UserChoice(stapel);
        }

        private static void UserChoice(Stack<string> INstapel)
        {
            var choice = Console.ReadLine();
            try
            {
                int Pchoice = int.Parse(choice);
                switch (Pchoice)
                {
                    case 1:
                        Fill();
                        Console.WriteLine("OK");
                        UserChoice(stapel);
                        break;
                    case 2:
                        PrintStack(INstapel);
                        UserChoice(stapel);
                        break;
                    case 3:
                        RemoveTopIfExist(INstapel);
                        Console.WriteLine("DONE");
                        UserChoice(INstapel);
                        break;
                    case 4:
                        //ez way to close the program
                        break;
                    default:
                        Console.WriteLine("Vul een geldig getal in");
                        UserChoice(stapel);
                        break;
                }
                
            }
            catch
            {
                Console.WriteLine("Vul een geldig getal in");
                UserChoice(stapel);
            }
        }

        private static void RemoveTopIfExist(Stack<string> nstapel)
        {
            Console.Write("Zoek entry: ");
            string search = Console.ReadLine();
            if(nstapel.Contains(search))
            {
                if(nstapel.Peek() == search)
                {
                    nstapel.Pop();
                }
            }
        }

        private static void Fill()
        {
            Console.Write("Vul een nieuwe entry in: ");
            string entry = Console.ReadLine();
            stapel.Push(entry);
        }

        private static void PrintStack(Stack<string> Stapel)
        {
            Console.Write("Dit zit er in de stack: ");
            foreach (string item in Stapel)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
