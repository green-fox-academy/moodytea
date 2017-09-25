using System;

namespace Bunnies2
{
    class Program
    {
        static int Bunnies (int n)
        {
            if (n >= 0)
            {
                return 5  * n / 2;
            }
            else return 0;
        }
        static void Main(string[] args)
        {
            int n = 1;
            Console.WriteLine(Bunnies(n));
            Console.ReadKey();
        }
    }
}
