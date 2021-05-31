using System;

namespace Opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = { "Peter", "is", "de", "broer", "van", "Hans" };
            foreach(string woord in sentence)
            {
                Console.Write($"{woord} ");
            }
            int strlen = sentence.Length - 1;
            string buffer = sentence[0];
            sentence[0] = sentence[strlen];
            sentence[strlen] = buffer;

            Console.WriteLine();

            foreach(string woord in sentence)
            {
                Console.Write($"{woord} ");
            }
        }
    }
}
