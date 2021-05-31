using System;

namespace Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            var rijen = 3;
            var kolommen = 3;

            var arr = new int[rijen, kolommen];

            int j = 0;
            int k = 0;
            int comb = 0;
            for (int i = 1; i <= (rijen * kolommen); i++)
            {
                comb += i;
                arr[j, k] = i;

                if(k == (kolommen - 1))
                {
                    j++;
                    k = 0;
                }
                else
                {
                    k++;
                }
            }
            
            foreach(int cijfer in arr)
            {
                if(cijfer % rijen == 0)
                {
                    Console.WriteLine(cijfer);
                }
                else
                {
                    Console.Write(cijfer);
                }
            }
            Console.WriteLine($"Totaal aantal is: {comb}");
            
        }
    }
}
